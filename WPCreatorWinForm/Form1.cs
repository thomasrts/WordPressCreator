using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            fonctions.ConnexionServeur();
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
            fonctions.ConnexionServeur();
            this.pg_etat.Value = 25;
            fonctions.CreationWordpress(this.tb_nomdossier.Text, this.tb_nombdd.Text);
            this.pg_etat.Value = 64;
            fonctions.CreationApache(this.tb_nomfichier.Text, this.sw_servername.Value, this.tb_servername.Text);
            this.pg_etat.Value = 100;
        }
    }
}