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
            if (fonctions.ConnexionServeur()) lbl_status.Text = @"Connexion au serveur réussie \n Succesful connection to server";
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
            if (fonctions.ConnexionServeur()) lbl_status.Text = @"Connexion au serveur réussie \n Succesful connection to server";
            pg_etat.Value = 25;
            fonctions.CreationWordpress(tb_nomdossier.Text, tb_nombdd.Text, tb_mysql_user.Text);
            pg_etat.Value = 50;
            if (sw_apache.Value && tb_nomfichier.Text != null)
            {
                fonctions.CreationApache(tb_nomdossier.Text, tb_nomfichier.Text, sw_servername.Value, tb_servername.Text);
                pg_etat.Value = 80;
                fonctions.UploadFichiers(tb_nomfichier.Text);
                pg_etat.Value = 100;
            }

            pg_etat.Value = 100;
        }

        private void btn_saveconf_Click(object sender, EventArgs e)
        {
            if (this.tb_mysql_user.Text == "")
            {
                MessageBox.Show(@"Renseignez un user pour MySQL", @"Erreur d'enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        
    }
}