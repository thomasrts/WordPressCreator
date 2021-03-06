﻿using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Renci.SshNet;
using Renci.SshNet.Common;
using WinSCP;
using Session = WinSCP.Session;

namespace WPCreatorWinForm
{
    public class Fonctions
    {
        private readonly Form1 _form1 = new Form1();
        private readonly string[] lesCommandes = new string[12];

        private string IP;
        private string password;
        private string Path;
        private string Username;

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
            return IP;
        }

        public void SetIP(string prmIP)
        {
            IP = prmIP;
        }

        public void SetUsername(string prmUser)
        {
            Username = prmUser;
        }

        public void SetPassword(string prmPass)
        {
            password = prmPass;
        }

        /*--------------------------FIN CONSTRUCTEURS-------------------------*/
        /// <summary>
        ///     Role : test the remote server connection
        /// </summary>
        /// <returns>Type : bool; to know if connection is successed</returns>
        public bool ConnexionServeur()
        {
            using (var serveur = new SshClient(IP, 22, Username, password))
            {
                try
                {
                    serveur.Connect();
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
        ///     Function which prepare SSH commands
        /// </summary>
        public void AffecterCommandes()
        {
            lesCommandes[0] = "sudo apt update && sudo apt upgrade -y";
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
        ///     Main function which allow to implement the whole WP
        /// </summary>
        /// <param name="prmNomDossier">WP's folder name in /var/www/ root</param>
        /// <param name="prmNomBDD">DB name in MySQL</param>
        /// <param name="prmNomUserMySQL">Username to be used to log in to MySQL</param>
        /// <param name="prmMdpMySQL">Password to log on MySQL</param>
        /// <param name="stateSwLang"></param>
        public void CreationWordpress(string prmNomDossier, string prmNomBDD, string prmNomUserMySQL, string prmMdpMySQL, bool stateSwLang)
        {
            using (var serveur = new SshClient(IP, 22, Username, password))
            {
                if (serveur.IsConnected)
                    serveur.Disconnect();
                else
                {
                    try
                    {
                        if (VerifierNomBDD(prmNomBDD, stateSwLang))
                        {
                            serveur.Connect();
                            serveur.RunCommand(lesCommandes[0]);
                            //Mise à jour du serveur
                            try
                            {
                                serveur.RunCommand(lesCommandes[1]);
                                //Téléchargement de WordPress / WP downloading
                                Thread.Sleep(350);
                                try
                                {
                                    serveur.RunCommand(lesCommandes[2]);
                                    //Extraction du WP / WP extracting
                                    Thread.Sleep(350);
                                    serveur.RunCommand(lesCommandes[6]);
                                    //Suppression de l'archive WP / WP Archive deleted
                                    
                                    Thread.Sleep(350);
                                    try
                                    {
                                        lesCommandes[3] = "sudo mv wordpress/ /var/www/" + prmNomDossier;
                                        lesCommandes[4] = "sudo cd /var/www/" + prmNomDossier;
                                        lesCommandes[5] = "sudo chown -R www-data:www-data /var/www/" + prmNomDossier;
                                        lesCommandes[10] = "mysql -u " + prmNomUserMySQL + " --password=" + prmMdpMySQL + " -e 'create database " + prmNomBDD + "'";
                                        //Redéfinition des commandes utilisées avec les paramèètres renseignés / SSH functions redefinded
                                        serveur.RunCommand(lesCommandes[3]);
                                        //Déplacement du dossier WP / WP's folder moved
                                        Thread.Sleep(350);
                                        try
                                        {
                                            serveur.RunCommand(lesCommandes[4]);
                                            //Changement du PWD / PWD changed
                                            Thread.Sleep(350);
                                            try
                                            {
                                                serveur.RunCommand(lesCommandes[5]);
                                                //Change le propriétaire des fichiers & dossiers du WP en www-data / Changing owner of files & folders of WP to www-data
                                                
                                                Thread.Sleep(350);
                                                try
                                                {
                                                    MessageBox.Show(lesCommandes[10]);
                                                    serveur.RunCommand(lesCommandes[10]);
                                                    
                                                    serveur.Disconnect();
                                                    //Crée la base de données en utilisant MySQL / Creating DB into MySQL
                                                    if (!stateSwLang)
                                                        MessageBox.Show(@"Nom du dossier du WordPress : /var/www/" + prmNomDossier + @"\n Nom de la base de données : " +
                                                                        prmNomBDD, @"Récapitulatif", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    else
                                                        MessageBox.Show(@"WordPress's folder name : /var/www/" + prmNomDossier + @"\n MySQL DB name : " + prmNomBDD,
                                                            @"Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    }
                    catch (SshException sshException)
                    {
                        MessageBox.Show(sshException.ToString());
                    }
                }
            }
        }


        public void CreationApache(string prmEmplacementWP, string prmNomSite, bool prmSwitchValue, string prmServerName, bool stateSwLang)
        {
            lesCommandes[7] = "sudo a2ensite " + prmNomSite + ".conf";
            lesCommandes[8] = "sudo mv /tmp/" + prmNomSite + ".conf /etc/apache2/sites-available/" + prmNomSite +
                              ".conf";
            Path = prmEmplacementWP;
            //Redéfinition des commandes SSH avec le nom du site / SSH functions redefinded
            if (prmSwitchValue && prmNomSite != null)
                //Vérification de l'existance des dossiers du logiciel / Verifying that folders have been created 
            {
                if (Directory.Exists(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator"))
                {
                    if (Directory.Exists(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator\ApacheConfs"))
                    {
                        var lignes_conf = "<VirtualHost *:80> \n DocumentRoot /var/www/" + Path +
                                          "\n ServerName " + prmNomSite + "\n</VirtualHost>";
                        File.WriteAllText(@"C:\users\" + Environment.UserName +
                                          @"\AppData\Local\WPCreator\ApacheConfs\" +
                                          prmNomSite + ".conf", lignes_conf);
                    }
                    else
                    {
                        Directory.CreateDirectory(@"C:\users\" + Environment.UserName +
                                                  @"\AppData\Local\WPCreator\ApacheConfs");
                        var lignes_conf = "<VirtualHost *:80> \n DocumentRoot /var/www/" + Path +
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
                        var lignes_conf = "<VirtualHost *:80> \n DocumentRoot /var/www/" + Path +
                                          "\n ServerName " + prmNomSite + "\n</VirtualHost>";
                        File.WriteAllText(@"C:\users\" + Environment.UserName +
                                          @"\AppData\Local\WPCreator\ApacheConfs\" +
                                          prmNomSite + ".conf", lignes_conf);
                    }
                    else
                    {
                        Directory.CreateDirectory(@"C:\users\" + Environment.UserName +
                                                  @"\AppData\Local\WPCreator\ApacheConfs");
                        var lignes_conf = "<VirtualHost *:80> \n DocumentRoot /var/www/" + Path +
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
                        var lignes_conf = "<VirtualHost *:80> \n DocumentRoot /var/www/" + Path + "\n</VirtualHost>";
                        File.WriteAllText(
                            @"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator\ApacheConfs/" +
                            prmNomSite +
                            ".conf", lignes_conf);
                    }
                    else
                    {
                        Directory.CreateDirectory(@"C:\users\" + Environment.UserName +
                                                  @"\AppData\Local\WPCreator\ApacheConfs");
                        var lignes_conf = "<VirtualHost *:80> \n DocumentRoot /var/www/" + Path + "\n</VirtualHost>";
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
                        var lignes_conf = "<VirtualHost *:80> \n DocumentRoot /var/www/" + Path + "\n</VirtualHost>";
                        File.WriteAllText(
                            @"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator\ApacheConfs/" +
                            prmNomSite +
                            ".conf", lignes_conf);
                    }
                    else
                    {
                        Directory.CreateDirectory(@"C:\users\" + Environment.UserName +
                                                  @"\AppData\Local\WPCreator\ApacheConfs");
                        var lignes_conf = "<VirtualHost *:80> \n DocumentRoot /var/www/" + Path + "\n</VirtualHost>";
                        File.WriteAllText(
                            @"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator\ApacheConfs/" +
                            prmNomSite +
                            ".conf", lignes_conf);
                    }
                }
            }
        }

        /// <summary>
        ///     Function which upload Apache conf files to server using Sftp
        /// </summary>
        /// <param name="prmNomSite"></param>
        /// <param name="stateSwLang"></param>
        public void UploadFichiers(string prmNomSite, bool stateSwLang)
        {
            var sessionOptions = new SessionOptions
            {
                Protocol = Protocol.Sftp,
                HostName = IP,
                UserName = Username,
                Password = password
            };
            using (var session = new Session())
            {
                var fingerprint = session.ScanFingerprint(sessionOptions, "SHA-256");
                sessionOptions.SshHostKeyFingerprint = fingerprint;
                session.Open(sessionOptions);

                // Upload des fichiers 
                var transferOptions = new TransferOptions();
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

            using (var client = new SshClient(IP, 22, Username, password))
            {
                try
                {
                    client.Connect();
                    client.RunCommand(lesCommandes[8]);
                    client.Disconnect();
                    //Déplacement du fichier de configuration effectué / Apache conf file moved
                    try
                    {
                        client.Connect();
                        client.RunCommand(lesCommandes[7]);
                        client.RunCommand(lesCommandes[9]);
                        client.Disconnect();
                        if (!stateSwLang)
                            MessageBox.Show(
                                @"Activation du site effectuée ! Félicitations, votre site est disponible à partir de l'adresse suivante : " +
                                prmNomSite);
                        else
                            MessageBox.Show(
                                @"Site activation done ! Congratulations, your site is now available at this following address : " +
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

        protected internal bool VerifierNomBDD(string prmNomBDD, bool stateSwLang)
        {
            foreach(var carac in prmNomBDD)
                if (carac == '-')
                {
                    if (!stateSwLang)
                        MessageBox.Show(@"Il est interdit de créer une base de données avec un trait d'union, veuillez réessayer", @"Erreur lors de la création",
                            MessageBoxButtons
                                .OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show(@"It's forbidden to create a DB with this symbol : - . Please retry", @"Error while creating", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    return false;
                }

            return true;
        }
    }
}