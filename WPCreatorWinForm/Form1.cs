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
            Fonctions fonctions = new Fonctions(this.tb_ip.Text, this.tb_user.Text, this.tb_pass.Text);
            if (fonctions.ConnexionServeur())
            {
                lbl_status.Text = "Connexion au serveur réussie";
            }
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_reduce_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.MinimizeBox = true;
            WindowState = FormWindowState.Minimized;
        }

        private void btn_creation_Click(object sender, EventArgs e)
        {
            Fonctions fonctions = new Fonctions(this.tb_ip.Text, this.tb_user.Text, this.tb_pass.Text);
            fonctions.AffecterCommandes();
            this.pg_etat.Value = 12;
            if (fonctions.ConnexionServeur())
            {
                lbl_status.Text = "Connexion au serveur réussie";
            }
            this.pg_etat.Value = 25;
            fonctions.CreationWordpress(this.tb_nomdossier.Text, this.tb_nombdd.Text);
            this.pg_etat.Value = 64;
            if (sw_apache.Value && tb_nomfichier.Text != null)
            {
                fonctions.CreationApache(this.tb_nomfichier.Text, this.sw_servername.Value, this.tb_servername.Text);
            }
            this.pg_etat.Value = 100;
        }

        private void btn_saveconf_Click(object sender, EventArgs e)
        {
            string content = this.tb_ip.Text + ";" + this.tb_user.Text + ";" + this.tb_pass.Text;
            if(!Directory.Exists(@"C:\users\"+Environment.UserName+@"\AppData\Local\WPCreator"))
            {
                Directory.CreateDirectory(@"C:\users\"+Environment.UserName+@"\AppData\Local\WPCreator");
                if (!Directory.Exists(@"C:\users\"+Environment.UserName+@"\AppData\Local\WPCreator\config"))
                {
                    Directory.CreateDirectory(@"C:\users\"+Environment.UserName+@"\AppData\Local\WPCreator/config");
                    File.AppendAllText(@"C:\users\"+Environment.UserName+@"\AppData\Local\WPCreator/config.txt", content+"\n");
                }
                else
                {
                    File.AppendAllText(@"C:\users\"+Environment.UserName+@"\AppData\Local\WPCreator/config/config.txt", content+"\n");
                }
            }
            else
            {
                if (!Directory.Exists(@"C:\users\"+Environment.UserName+@"\AppData\Local\WPCreator/config"))
                {
                    Directory.CreateDirectory(@"C:\users\"+Environment.UserName+@"\AppData\Local\WPCreator/config");
                    File.AppendAllText(@"C:\users\"+Environment.UserName+@"\AppData\Local\WPCreator/config/config.txt", content+"\n");
                }
                else
                {
                    File.AppendAllText(@"C:\users\"+Environment.UserName+@"\AppData\Local\WPCreator/config/config.txt", content+"\n");
                }
            }
                
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(Directory.Exists(@"C:\users\"+Environment.UserName+@"\AppData\Local\WPCreator/"))
            {
                if (Directory.Exists(@"C:\users\"+Environment.UserName+@"\AppData\Local\WPCreator/config"))
                {
                    if (File.Exists(@"C:\users\"+Environment.UserName+@"\AppData\Local\WPCreator/config/config.txt"))
                    {
                        var fichier = File.ReadAllLines(@"C:\users\"+Environment.UserName+@"\AppData\Local\WPCreator/config/config.txt");

                        foreach (var config in fichier)
                        {
                            cb_conf.Items.Add(config);
                        }
                    }
                }
            }

            sw_apache.Value = true;
        }

        private void btn_loadconf_Click(object sender, EventArgs e)
        {
            string input = cb_conf.SelectedItem.ToString();
                        string[] config = new string[3];
                        config = input.Split(';');
                        tb_ip.Text = config[0];
                        tb_user.Text = config[1];
                        tb_pass.Text = config[2];
        }

        private void sw_apache_OnValueChange(object sender, EventArgs e)
        {
            if (sw_apache.Value == false)
            {
                label5.Visible = false;
                tb_nomfichier.Visible = false;
            }
            else{
                label5.Visible = true;
                tb_nomfichier.Visible = true;
            }
                
        }
    }
}