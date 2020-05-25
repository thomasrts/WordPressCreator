using System;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Renci.SshNet;
using Renci.SshNet.Common;
using WinSCP;
using Session = WinSCP.Session;

namespace WPCreatorWinForm
{
    public class Fonctions
    {
        private string[] lesCommandes = new string[12];
        private string IP;
        private string Username;
        private string password;
        private string Path;

        protected Form1 _form1 = new Form1();
        /* ------------------CONSTRUCTEURS ET AFFECTATIONS--------------------*/

        public Fonctions(string ip, string username, string password)
        {
            IP = ip;
            Username = username;
            this.password = password;
        }

        public Fonctions()
        {
        }

        public string GetIP()
        {
            return this.IP;
        }

        public void SetIP(string prmIP)
        {
            this.IP = prmIP;
        }

        public void SetUsername(string prmUser)
        {
            this.Username = prmUser;
        }

        public void SetPassword(string prmPass)
        {
            this.password = prmPass;
        }

        public void SetPath(string prmPath)
        {
            this.Path = prmPath;
        }

        /*--------------------------FIN CONSTRUCTEURS-------------------------*/
        /// <summary>
        /// Permet de tester la connexion au serveur communiqué
        /// </summary>
        /// <returns>Type : bool; afin de savoir si la connexion a réussi</returns>
        public bool ConnexionServeur()
        {
            using (var serveur = new SshClient(this.IP, 22, this.Username, this.password))
            {
                try
                {
                    serveur.Connect();
                    //MessageBox.Show(@"Connecté à l'hôte : " + this.IP);
                    serveur.Disconnect();
                    return true;
                }
                catch (SshException sshException)
                {
                    MessageBox.Show(sshException.ToString());
                    return false;
                }
            }
        }

        /// <summary>
        /// Permet d'affecter les commandes SSH à envoyer
        /// </summary>
        public void AffecterCommandes()
        {
            lesCommandes[0] = "sudo apt update && sudo apt upgrade";
            lesCommandes[1] = "sudo wget https://fr.wordpress.org/latest-fr_FR.tar.gz";
            lesCommandes[2] = "sudo tar xzf latest-fr_FR.tar.gz";
            lesCommandes[3] = "sudo mv wordpress/ /var/www/" + Path;
            lesCommandes[4] = "sudo cd /var/www/" + Path + "/";
            lesCommandes[5] = "sudo chown -R www-data:www-data " + Path;
            lesCommandes[6] = "sudo rm latest-fr_FR.tar.gz";
            lesCommandes[7] = "sudo a2ensite .conf";
            lesCommandes[9] = "sudo systemctl reload apache2";
        }

        /// <summary>
        /// Procède à l'installation d'un WordPress et à la création automatique d'une base de données MySQL
        /// </summary>
        /// <param name="prmNomDossier">Nom du dossier contenant WP</param>
        /// <param name="prmNomBDD">Nom de la base de données</param>
        public void CreationWordpress(string prmNomDossier, string prmNomBDD)
        {
            if (ConnexionServeur())
            {
                using (var serveur = new SshClient(this.IP, 22, this.Username, this.password))
                {
                    if (serveur.IsConnected)
                    {
                        serveur.Disconnect();
                    }
                    else
                    {
                        try
                        {
                            serveur.Connect();
                            //serveur.RunCommand(lesCommandes[0]);
                            //Mise à jour du serveur
                            serveur.Disconnect();
                            try
                            {
                                serveur.Connect();
                                serveur.RunCommand(lesCommandes[1]);
                                //Téléchargement de WordPress
                                serveur.Disconnect();
                                try
                                {
                                    serveur.Connect();
                                    serveur.RunCommand(lesCommandes[2]);
                                    //Extraction du WP
                                    serveur.RunCommand(lesCommandes[6]);
                                    //Suppression de l'archive WP
                                    serveur.Disconnect();
                                    try
                                    {
                                        serveur.Connect();
                                        lesCommandes[3] = "sudo mv wordpress/ /var/www/" + prmNomDossier;
                                        lesCommandes[4] = "sudo cd /var/www/" + prmNomDossier;
                                        lesCommandes[5] = "sudo chown -R www-data:www-data /var/www/" + prmNomDossier;
                                        lesCommandes[10] = "mysql -e 'create database " + prmNomBDD + "'";
                                        //Redéfinition des commandes utilisées avec les paramèètres renseignés 
                                        serveur.RunCommand(lesCommandes[3]);
                                        //Déplacement du dossier WP
                                        serveur.Disconnect();
                                        try
                                        {
                                            serveur.Connect();
                                            serveur.RunCommand(lesCommandes[4]);
                                            //Changement du PWD
                                            serveur.Disconnect();
                                            try
                                            {
                                                serveur.Connect();
                                                serveur.RunCommand(lesCommandes[5]);
                                                //Change le propriétaire des fichiers & dossiers du WP en www-data
                                                serveur.Disconnect();
                                                try
                                                {
                                                    serveur.Connect();
                                                    serveur.RunCommand((lesCommandes[10]));
                                                    serveur.Disconnect();
                                                    //Crée la base de données en utilisant MySQL
                                                }
                                                catch (SshException exception)
                                                {
                                                    MessageBox.Show(exception.ToString());
                                                }
                                            }
                                            catch (SshException sshException)
                                            {
                                                MessageBox.Show(sshException.ToString());
                                            }
                                        }
                                        catch (SshException sshException)
                                        {
                                            MessageBox.Show(sshException.ToString());
                                        }
                                    }
                                    catch (SshException sshException)
                                    {
                                        MessageBox.Show(sshException.ToString());
                                    }
                                }
                                catch (SshException sshException)
                                {
                                    MessageBox.Show(sshException.ToString());
                                }
                            }
                            catch (SshException sshException)
                            {
                                MessageBox.Show(sshException.ToString());
                            }
                        }
                        catch (SshException sshException)
                        {
                            MessageBox.Show(sshException.ToString());
                        }
                    }
                }
            }
        }

        public void CreationApache(string prmNomSite, bool prmSwitchValue, string prmServerName)
        {
            lesCommandes[7] = "sudo a2ensite " + prmNomSite + ".conf";
            lesCommandes[8] = "sudo mv /tmp/" + prmNomSite + ".conf /etc/apache2/sites-available/" + prmNomSite +
                              ".conf";
            //Redéfinition des commandes SSH avec le nom du site
            if (prmSwitchValue && prmNomSite != null)
            {
                //Vérification de l'existance des dossiers du logiciel
                if (Directory.Exists(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator"))
                {
                    if (Directory.Exists(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator\ApacheConfs"))
                    {
                        string lignes_conf = "<VirtualHost *:80> \n DocumentRoot /var/www/" + Path +
                                             "\n ServerName " + prmNomSite + "\n</VirtualHost>";
                        File.WriteAllText(@"C:\users\" + Environment.UserName +
                                          @"\AppData\Local\WPCreator\ApacheConfs\" +
                                          prmNomSite + ".conf", lignes_conf);
                    }
                    else
                    {
                        Directory.CreateDirectory(@"C:\users\" + Environment.UserName +
                                                  @"\AppData\Local\WPCreator\ApacheConfs");
                        string lignes_conf = "<VirtualHost *:80> \n DocumentRoot /var/www/" + Path +
                                             "\n ServerName " + prmNomSite + "\n</VirtualHost>";
                        File.WriteAllText(@"C:\users\" + Environment.UserName +
                                          @"\AppData\Local\WPCreator\ApacheConfs\" +
                                          prmNomSite + ".conf", lignes_conf);
                    }
                }
                else
                {
                    Directory.CreateDirectory(@"C:\users\" + Environment.UserName +
                                              @"\AppData\Local\WPCreator\");

                    if (Directory.Exists(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator\ApacheConfs"))
                    {
                        string lignes_conf = "<VirtualHost *:80> \n DocumentRoot /var/www/" + Path +
                                             "\n ServerName " + prmNomSite + "\n</VirtualHost>";
                        File.WriteAllText(@"C:\users\" + Environment.UserName +
                                          @"\AppData\Local\WPCreator\ApacheConfs\" +
                                          prmNomSite + ".conf", lignes_conf);
                    }
                    else
                    {
                        Directory.CreateDirectory(@"C:\users\" + Environment.UserName +
                                                  @"\AppData\Local\WPCreator\ApacheConfs");
                        string lignes_conf = "<VirtualHost *:80> \n DocumentRoot /var/www/" + Path +
                                             "\n ServerName " + prmNomSite + "\n</VirtualHost>";
                        File.WriteAllText(@"C:\users\" + Environment.UserName +
                                          @"\AppData\Local\WPCreator\ApacheConfs\" +
                                          prmNomSite + ".conf", lignes_conf);
                    }
                }
            }
            else
            {
                if (Directory.Exists(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator"))
                {
                    if (Directory.Exists(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator\ApacheConfs"))
                    {
                        string lignes_conf = "<VirtualHost *:80> \n DocumentRoot /var/www/" + Path + "\n</VirtualHost>";
                        File.WriteAllText(
                            @"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator\ApacheConfs/" +
                            prmNomSite +
                            ".conf", lignes_conf);
                    }
                    else
                    {
                        Directory.CreateDirectory(@"C:\users\" + Environment.UserName +
                                                  @"\AppData\Local\WPCreator\ApacheConfs");
                        string lignes_conf = "<VirtualHost *:80> \n DocumentRoot /var/www/" + Path + "\n</VirtualHost>";
                        File.WriteAllText(
                            @"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator\ApacheConfs/" +
                            prmNomSite +
                            ".conf", lignes_conf);
                    }
                }
                else
                {
                    Directory.CreateDirectory(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator");
                    if (Directory.Exists(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator\ApacheConfs"))
                    {
                        string lignes_conf = "<VirtualHost *:80> \n DocumentRoot /var/www/" + Path + "\n</VirtualHost>";
                        File.WriteAllText(
                            @"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator\ApacheConfs/" +
                            prmNomSite +
                            ".conf", lignes_conf);
                    }
                    else
                    {
                        Directory.CreateDirectory(@"C:\users\" + Environment.UserName +
                                                  @"\AppData\Local\WPCreator\ApacheConfs");
                        string lignes_conf = "<VirtualHost *:80> \n DocumentRoot /var/www/" + Path + "\n</VirtualHost>";
                        File.WriteAllText(
                            @"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator\ApacheConfs/" +
                            prmNomSite +
                            ".conf", lignes_conf);
                    }
                }
            }
        }

        
        public void UploadFichiers(string prmNomSite)
        {
            
            SessionOptions sessionOptions = new SessionOptions()
            {
                Protocol = Protocol.Sftp,
                HostName = this.IP,
                UserName = this.Username,
                Password = this.password
            };
            using (Session session = new Session())
            {
                
                    string fingerprint = session.ScanFingerprint(sessionOptions, "SHA-256");
                    sessionOptions.SshHostKeyFingerprint = fingerprint;
                    session.Open(sessionOptions);

                // Upload des fichiers
                TransferOptions transferOptions = new TransferOptions();
                transferOptions.TransferMode = TransferMode.Binary;

                TransferOperationResult transferResult;

                transferResult =
                    session.PutFiles(
                        @"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator\ApacheConfs\" + prmNomSite +
                        ".conf", "/tmp/" + prmNomSite + ".conf", false,
                        transferOptions);

                // Throw on any error
                transferResult.Check();
            }

            using (var client = new SshClient(this.IP, 22, this.Username, this.password))
            {
                try
                {
                    client.Connect();
                    client.RunCommand(lesCommandes[8]);
                    client.Disconnect();
                    //"Déplacement du fichier de configuration effectué"

                    try
                    {
                        client.Connect();
                        client.RunCommand(lesCommandes[7]);
                        client.RunCommand(lesCommandes[9]);
                        client.Disconnect();
                        MessageBox.Show(
                            @"Activation du site effectuée ! Félicitations, votre site est disponible à partir de l'adresse suivante : " +
                            prmNomSite);
                    }
                    catch (SshException sshException)
                    {
                        MessageBox.Show(sshException.ToString());
                    }
                }
                catch (SshException exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }
        }
    }
}