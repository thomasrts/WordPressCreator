using System;
using System.IO;
using System.Windows.Forms;

namespace WPCreatorWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Visible = false;
            tb_servername.Visible = false;
            AppDomain.CurrentDomain.UnhandledException += (sender, args) => { };
            Application.ThreadException += (sender, args) => { };
        }

        private void sw_servername_OnValueChange(object sender, EventArgs e)
        {
            if (sw_servername.Value == false)
            {
                label3.Visible = false;
                tb_servername.Visible = false;
            }
            else
            {
                label3.Visible = true;
                tb_servername.Visible = true;
            }
        }

        private void btn_testco_Click(object sender, EventArgs e)
        {
            var fonctions = new Fonctions(tb_ip.Text, tb_user.Text, tb_pass.Text);
            if (fonctions.ConnexionServeur())
            {
                if (sw_language.Value == false)
                    lbl_status.Text = @"Connexion au serveur réussie";
                else
                    lbl_status.Text = @"Succesful connection to the server";
            }
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_reduce_Click(object sender, EventArgs e)
        {
            var unused = new Form1 {MinimizeBox = true};
            WindowState = FormWindowState.Minimized;
        }

        private void btn_creation_Click(object sender, EventArgs e)
        {
            var fonctions = new Fonctions(tb_ip.Text, tb_user.Text, tb_pass.Text);
            fonctions.AffecterCommandes();
            pg_etat.Value = 12;
            if (tb_ip.Text == "" || tb_user.Text == "" || tb_pass.Text == "" || tb_nomdossier.Text == "" || tb_nombdd.Text == "" || tb_mysql_user.Text == "" ||
                tb_mysql_mdp.Text == "")
            {
                pg_etat.Value = 0;
                if (sw_language.Value == false)
                {
                    MessageBox.Show(@"Au moins un des champs requis est vide, veuillez vérifier l'intégralité de vos informations",@"Erreur lors de la création",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    lbl_status.Text = @"Processus avorté, au moins un champ n'est pas correctement rempli";
                }
                else
                {
                    MessageBox.Show(@"At least one field is not filled, please check all credentials",@"Error while creating",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    lbl_status.Text = @"Process aborted, at least one field is empty";
                }
            }
            else
            {
                if (fonctions.VerifierNomBDD(tb_nombdd.Text, sw_language.Value))
                {
                    if (fonctions.ConnexionServeur())
                    {
                        if (sw_language.Value == false)
                            lbl_status.Text = @"Connexion au serveur réussie";
                        else
                            lbl_status.Text = @"Succesful connection to the server";

                        pg_etat.Value = 25;
                        fonctions.CreationWordpress(tb_nomdossier.Text, tb_nombdd.Text, tb_mysql_user.Text, tb_mysql_mdp.Text, sw_language.Value);
                        if (sw_language.Value == false)
                            lbl_status.Text = @"WordPress et base de données crées";
                        else
                            lbl_status.Text = @"WP & DB created";
                        pg_etat.Value = 50;
                        if (sw_apache.Value && tb_nomfichier.Text != null)
                        {
                            fonctions.CreationApache(tb_nomdossier.Text, tb_nomfichier.Text, sw_servername.Value, tb_servername.Text, sw_language.Value);
                            if (sw_language.Value == false)
                                lbl_status.Text = @"Fichier de configuration Apache crée";
                            else
                                lbl_status.Text = @"Apache conf file created";
                            pg_etat.Value = 80;
                            fonctions.UploadFichiers(tb_nomfichier.Text, sw_language.Value);
                            if (sw_language.Value == false)
                                lbl_status.Text = @"Upload des fichiers effectué";
                            else
                                lbl_status.Text = @"Files upload done";
                            pg_etat.Value = 100;
                        }
                    }

                    pg_etat.Value = 100;
                }
                else
                {
                    if (sw_language.Value == false)
                    {
                        lbl_status.Text = @"Processus avorté, erreur dans le nom de la base de données";
                    }
                    else
                    {
                        lbl_status.Text = @"Process aborted, database name error";
                    }

                    pg_etat.Value = 0;
                }
            }
        }

        private void btn_saveconf_Click(object sender, EventArgs e)
        {
            if (tb_mysql_user.Text == "")
            {
                if (sw_language.Value == false)
                    MessageBox.Show(@"Renseignez un user pour MySQL", @"Erreur d'enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(@"Fill a MySQL username", @"Error while saving", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var content = tb_ip.Text + ";" + tb_user.Text + ";" + tb_pass.Text + ";" + tb_mysql_user;
                if (!Directory.Exists(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator"))
                {
                    Directory.CreateDirectory(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator");
                    if (!Directory.Exists(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator\config"))
                    {
                        Directory.CreateDirectory(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator/config");
                        File.AppendAllText(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator/config/config.txt", content + @"\n");
                    }
                    else
                    {
                        File.AppendAllText(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator/config/config.txt", content + @"\n");
                    }
                }
                else
                {
                    if (!Directory.Exists(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator/config"))
                    {
                        Directory.CreateDirectory(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator/config");
                        File.AppendAllText(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator/config/config.txt", content + @"\n");
                    }
                    else
                    {
                        File.AppendAllText(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator/config/config.txt", content + @"\n");
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator/"))
                if (Directory.Exists(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator/config"))
                    if (File.Exists(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator/config/config.txt"))
                    {
                        var fichier = File.ReadAllLines(@"C:\users\" + Environment.UserName + @"\AppData\Local\WPCreator/config/config.txt");
                        foreach (var config in fichier)
                            cb_conf.Items.Add(config);

                        sw_apache.Value = true;
                    }
        }

        private void btn_loadconf_Click(object sender, EventArgs e)
        {
            var input = cb_conf.SelectedItem.ToString();
            string[] config;
            config = input.Split(';');
            tb_ip.Text = config[0];
            tb_user.Text = config[1];
            tb_pass.Text = config[2];
            tb_mysql_user.Text = config[3];
        }

        private void sw_apache_OnValueChange(object sender, EventArgs e)
        {
            if (sw_apache.Value == false)
            {
                label5.Visible = false;
                tb_nomfichier.Visible = false;
            }
            else
            {
                label5.Visible = true;
                tb_nomfichier.Visible = true;
            }
        }

        private void sw_language_OnValueChange(object sender, EventArgs e)
        {
            if (sw_language.Value == false)
            {
                label10.Text = @"Adresse IP du serveur";
                label9.Text = @"Nom d'utilisateur";
                labelmdp.Text = @"Mot de passe";
                label1.Text = @"Nom du dossier du WP (après /var/www/)";
                label2.Text = @"Nom de la base de données MySQL";
                label13.Text = @"Nom d'utilisateur MySQL";
                label14.Text = @"Mot de passe MySQL";
                label12.Text = @"Fichier de conf. necessaire ?";
                label5.Text = @"Nom du fichier de configuration Apache";
                label4.Text = @"ServerName ?";
                label3.Text = @"ServerName";
                label11.Text = @"Presets de configuration";
                label8.Text = @"Assurez-vous que l'utilisateur à les droits administrateur sur le serveur cible et un pouvoir de création de bases de données";
                btn_testco.Text = @"Tester la connexion";
                btn_saveconf.Text = @"Sauvegarder la configuration";
                btn_loadconf.Text = @"Charger la configuration";
                btn_creation.Text = @"Créer le WordPress";
            }
            else
            {
                label10.Text = @"Server's IP";
                label9.Text = @"SSH Username";
                labelmdp.Text = @"SSH Password";
                label1.Text = @"WP's folder name (next /var/www/)";
                label2.Text = @"MySQL Database name";
                label13.Text = @"MySQL Username";
                label14.Text = @"MySQL Password";
                label12.Text = @"Configuration file needed?";
                label5.Text = @"Apache's conf file name";
                label4.Text = @"ServerName ?";
                label3.Text = @"ServerName";
                label11.Text = @"Configuration presets";
                label8.Text = @"Please, ensure that the user has root access on the target server and abilities to create databases";
                btn_testco.Text = @"Test connection";
                btn_saveconf.Text = @"Save configuration";
                btn_loadconf.Text = @"Load configuration";
                btn_creation.Text = @"Create WordPress";
            }
        }
    }
}