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
                            serveur.Disconnect();
                            //"Mise à jour effectuée"

                            try
                            {
                                serveur.Connect();
                                serveur.RunCommand(lesCommandes[1]);
                                serveur.Disconnect();
                                //"Wordpress téléchargé"

                                try
                                {
                                    serveur.Connect();
                                    serveur.RunCommand(lesCommandes[2]);
                                    serveur.RunCommand(lesCommandes[6]);
                                    serveur.Disconnect();
                                    //"Wordpress extrait et archive supprimée"

                                    try
                                    {
                                        serveur.Connect();
                                        lesCommandes[3] = "sudo mv wordpress/ /var/www/" + prmNomDossier;
                                        lesCommandes[4] = "sudo cd /var/www/" + prmNomDossier;
                                        lesCommandes[5] = "sudo chown -R www-data:www-data /var/www/" + prmNomDossier;
                                        lesCommandes[10] = "mysql -e 'create database " + prmNomBDD + "'";
                                        serveur.RunCommand(lesCommandes[3]);

                                        //"Wordpress déplacé"
                                        serveur.Disconnect();
                                        try
                                        {
                                            serveur.Connect();
                                            serveur.RunCommand(lesCommandes[4]);

                                            //"PWD déplacé"
                                            serveur.Disconnect();
                                            try
                                            {
                                                serveur.Connect();
                                                serveur.RunCommand(lesCommandes[5]);

                                                //"Propriétaire changé"
                                                serveur.Disconnect();
                                                try
                                                {
                                                    serveur.Connect();
                                                    serveur.RunCommand((lesCommandes[10]));
                                                    serveur.Disconnect();
                                                    //"Base de données correctement crée : " + prmNomBDD
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
            if (prmSwitchValue && prmNomSite != null)
            {
                if (Directory.Exists(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator"))
                {
                    if (Directory.Exists(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator\ApacheConfs"))
                    {
                        string lignes_conf = "<VirtualHost *:80> \n DocumentRoot /var/www/" + Path +
                                             "\n ServerName " + prmNomSite + "\n</VirtualHost>";
                        File.WriteAllText(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator\ApacheConfs\" +
                                              prmNomSite + ".conf", lignes_conf);
                        
                    }
                    else
                    {
                        Directory.CreateDirectory(@"C:\users\" + Environment.UserName +
                                                  @"\AppData\Local\WPCreator\ApacheConfs");
                        string lignes_conf = "<VirtualHost *:80> \n DocumentRoot /var/www/" + Path +
                                             "\n ServerName " + prmNomSite + "\n</VirtualHost>";
                        File.WriteAllText(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator\ApacheConfs\" +
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
                        File.WriteAllText(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator\ApacheConfs\" +
                                          prmNomSite + ".conf", lignes_conf);
                    }
                    else
                    {
                        Directory.CreateDirectory(@"C:\users\" + Environment.UserName +
                                                  @"\AppData\Local\WPCreator\ApacheConfs");
                        string lignes_conf = "<VirtualHost *:80> \n DocumentRoot /var/www/" + Path +
                                             "\n ServerName " + prmNomSite + "\n</VirtualHost>";
                        File.WriteAllText(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator\ApacheConfs\" +
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
                        File.WriteAllText(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator\ApacheConfs/" + prmNomSite + ".conf", lignes_conf);
                    }
                    else
                    {
                        Directory.CreateDirectory(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator\ApacheConfs");
                        string lignes_conf = "<VirtualHost *:80> \n DocumentRoot /var/www/" + Path + "\n</VirtualHost>";
                        File.WriteAllText(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator\ApacheConfs/" + prmNomSite + ".conf", lignes_conf);
                    }
                }
                else
                {
                    Directory.CreateDirectory(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator");
                    if (Directory.Exists(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator\ApacheConfs"))
                    {
                        string lignes_conf = "<VirtualHost *:80> \n DocumentRoot /var/www/" + Path + "\n</VirtualHost>";
                        File.WriteAllText(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator\ApacheConfs/" + prmNomSite + ".conf", lignes_conf);
                    }
                    else
                    {
                        Directory.CreateDirectory(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator\ApacheConfs");
                        string lignes_conf = "<VirtualHost *:80> \n DocumentRoot /var/www/" + Path + "\n</VirtualHost>";
                        File.WriteAllText(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator\ApacheConfs/" + prmNomSite + ".conf", lignes_conf);
                    }
                    
                }
            }


            SessionOptions sessionOptions = new SessionOptions()
            {
                Protocol = Protocol.Sftp,
                HostName = "104.40.200.125",
                UserName = "winscp",
                Password = "#*ThomasR62",
                SshHostKeyFingerprint = "ssh-rsa 2048 e2:9c:0d:ed:75:9c:c6:21:f9:fa:a7:10:a6:09:1b:f0"
            };
            using (Session session = new Session())
            {
                session.Open(sessionOptions);

                // Upload des fichiers
                TransferOptions transferOptions = new TransferOptions();
                transferOptions.TransferMode = TransferMode.Binary;

                TransferOperationResult transferResult;

                transferResult =
                    session.PutFiles(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator\ApacheConfs\" + prmNomSite + ".conf", "/tmp/" + prmNomSite + ".conf", false,
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