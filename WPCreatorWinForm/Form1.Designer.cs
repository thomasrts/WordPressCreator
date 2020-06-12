namespace WPCreatorWinForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_nomdossier = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tb_nombdd = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_nomfichier = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tb_servername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sw_servername = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.tb_pass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelmdp = new System.Windows.Forms.Label();
            this.tb_ip = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_testco = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_creation = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_quit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_reduce = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pg_etat = new Bunifu.Framework.UI.BunifuProgressBar();
            this.btn_saveconf = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_loadconf = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cb_conf = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.sw_apache = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_mysql_user = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tb_user = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tb_mysql_mdp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(489, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 31);
            this.label1.TabIndex = 46;
            this.label1.Text = "Nom du dossier du WP\r\n(après le /var/www/)\r\n";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(489, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 28);
            this.label2.TabIndex = 45;
            this.label2.Text = "Nom de la base de de données MySQL\r\n";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(489, 516);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 28);
            this.label3.TabIndex = 55;
            this.label3.Text = "ServerName";
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(539, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 66;
            this.label4.Text = "ServerName ?";
            // 
            // tb_nomdossier
            // 
            this.tb_nomdossier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_nomdossier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_nomdossier.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_nomdossier.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_nomdossier.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_nomdossier.ForeColor = System.Drawing.Color.White;
            this.tb_nomdossier.HintForeColor = System.Drawing.Color.Empty;
            this.tb_nomdossier.HintText = "";
            this.tb_nomdossier.isPassword = false;
            this.tb_nomdossier.LineFocusedColor = System.Drawing.Color.MediumSeaGreen;
            this.tb_nomdossier.LineIdleColor = System.Drawing.Color.White;
            this.tb_nomdossier.LineMouseHoverColor = System.Drawing.Color.MediumSeaGreen;
            this.tb_nomdossier.LineThickness = 3;
            this.tb_nomdossier.Location = new System.Drawing.Point(637, 150);
            this.tb_nomdossier.Margin = new System.Windows.Forms.Padding(4);
            this.tb_nomdossier.MaxLength = 32767;
            this.tb_nomdossier.Name = "tb_nomdossier";
            this.tb_nomdossier.Size = new System.Drawing.Size(94, 31);
            this.tb_nomdossier.TabIndex = 3;
            this.tb_nomdossier.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tb_nombdd
            // 
            this.tb_nombdd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_nombdd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_nombdd.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_nombdd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_nombdd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_nombdd.ForeColor = System.Drawing.Color.White;
            this.tb_nombdd.HintForeColor = System.Drawing.Color.Empty;
            this.tb_nombdd.HintText = "";
            this.tb_nombdd.isPassword = false;
            this.tb_nombdd.LineFocusedColor = System.Drawing.Color.MediumSeaGreen;
            this.tb_nombdd.LineIdleColor = System.Drawing.Color.White;
            this.tb_nombdd.LineMouseHoverColor = System.Drawing.Color.MediumSeaGreen;
            this.tb_nombdd.LineThickness = 3;
            this.tb_nombdd.Location = new System.Drawing.Point(637, 208);
            this.tb_nombdd.Margin = new System.Windows.Forms.Padding(4);
            this.tb_nombdd.MaxLength = 32767;
            this.tb_nombdd.Name = "tb_nombdd";
            this.tb_nombdd.Size = new System.Drawing.Size(94, 31);
            this.tb_nombdd.TabIndex = 4;
            this.tb_nombdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(489, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 28);
            this.label5.TabIndex = 40;
            this.label5.Text = "Nom du fichier de configuration Apache\r\n";
            // 
            // tb_nomfichier
            // 
            this.tb_nomfichier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_nomfichier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_nomfichier.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_nomfichier.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_nomfichier.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_nomfichier.ForeColor = System.Drawing.Color.White;
            this.tb_nomfichier.HintForeColor = System.Drawing.Color.Empty;
            this.tb_nomfichier.HintText = "";
            this.tb_nomfichier.isPassword = false;
            this.tb_nomfichier.LineFocusedColor = System.Drawing.Color.MediumSeaGreen;
            this.tb_nomfichier.LineIdleColor = System.Drawing.Color.White;
            this.tb_nomfichier.LineMouseHoverColor = System.Drawing.Color.MediumSeaGreen;
            this.tb_nomfichier.LineThickness = 3;
            this.tb_nomfichier.Location = new System.Drawing.Point(637, 420);
            this.tb_nomfichier.Margin = new System.Windows.Forms.Padding(4);
            this.tb_nomfichier.MaxLength = 32767;
            this.tb_nomfichier.Name = "tb_nomfichier";
            this.tb_nomfichier.Size = new System.Drawing.Size(94, 31);
            this.tb_nomfichier.TabIndex = 6;
            this.tb_nomfichier.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tb_servername
            // 
            this.tb_servername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_servername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_servername.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_servername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_servername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_servername.ForeColor = System.Drawing.Color.White;
            this.tb_servername.HintForeColor = System.Drawing.Color.Empty;
            this.tb_servername.HintText = "";
            this.tb_servername.isPassword = false;
            this.tb_servername.LineFocusedColor = System.Drawing.Color.MediumSeaGreen;
            this.tb_servername.LineIdleColor = System.Drawing.Color.White;
            this.tb_servername.LineMouseHoverColor = System.Drawing.Color.MediumSeaGreen;
            this.tb_servername.LineThickness = 3;
            this.tb_servername.Location = new System.Drawing.Point(637, 516);
            this.tb_servername.Margin = new System.Windows.Forms.Padding(4);
            this.tb_servername.MaxLength = 32767;
            this.tb_servername.Name = "tb_servername";
            this.tb_servername.Size = new System.Drawing.Size(94, 31);
            this.tb_servername.TabIndex = 7;
            this.tb_servername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Montserrat Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(183, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(437, 35);
            this.label6.TabIndex = 10;
            this.label6.Text = "WordPress Creator\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(257, 672);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(289, 30);
            this.label7.TabIndex = 11;
            this.label7.Text = "Copyright ® Thomas ROTSAERT, ouranet.com";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sw_servername
            // 
            this.sw_servername.BackColor = System.Drawing.Color.Transparent;
            this.sw_servername.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("sw_servername.BackgroundImage")));
            this.sw_servername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sw_servername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sw_servername.Location = new System.Drawing.Point(489, 477);
            this.sw_servername.Name = "sw_servername";
            this.sw_servername.OffColor = System.Drawing.Color.Gray;
            this.sw_servername.OnColor = System.Drawing.Color.FromArgb(((int) (((byte) (71)))), ((int) (((byte) (202)))), ((int) (((byte) (94)))));
            this.sw_servername.Size = new System.Drawing.Size(35, 20);
            this.sw_servername.TabIndex = 12;
            this.sw_servername.Value = false;
            this.sw_servername.OnValueChange += new System.EventHandler(this.sw_servername_OnValueChange);
            // 
            // tb_pass
            // 
            this.tb_pass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_pass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_pass.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_pass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_pass.ForeColor = System.Drawing.Color.White;
            this.tb_pass.HintForeColor = System.Drawing.Color.Empty;
            this.tb_pass.HintText = "";
            this.tb_pass.isPassword = true;
            this.tb_pass.LineFocusedColor = System.Drawing.Color.MediumSeaGreen;
            this.tb_pass.LineIdleColor = System.Drawing.Color.White;
            this.tb_pass.LineMouseHoverColor = System.Drawing.Color.MediumSeaGreen;
            this.tb_pass.LineThickness = 3;
            this.tb_pass.Location = new System.Drawing.Point(183, 271);
            this.tb_pass.Margin = new System.Windows.Forms.Padding(4);
            this.tb_pass.MaxLength = 32767;
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(157, 31);
            this.tb_pass.TabIndex = 2;
            this.tb_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelmdp
            // 
            this.labelmdp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelmdp.Location = new System.Drawing.Point(35, 260);
            this.labelmdp.Name = "labelmdp";
            this.labelmdp.Size = new System.Drawing.Size(124, 28);
            this.labelmdp.TabIndex = 17;
            this.labelmdp.Text = "Mot de passe";
            // 
            // tb_ip
            // 
            this.tb_ip.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_ip.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_ip.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_ip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_ip.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_ip.ForeColor = System.Drawing.Color.White;
            this.tb_ip.HintForeColor = System.Drawing.Color.Empty;
            this.tb_ip.HintText = "";
            this.tb_ip.isPassword = false;
            this.tb_ip.LineFocusedColor = System.Drawing.Color.MediumSeaGreen;
            this.tb_ip.LineIdleColor = System.Drawing.Color.White;
            this.tb_ip.LineMouseHoverColor = System.Drawing.Color.MediumSeaGreen;
            this.tb_ip.LineThickness = 3;
            this.tb_ip.Location = new System.Drawing.Point(183, 150);
            this.tb_ip.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ip.MaxLength = 32767;
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(157, 31);
            this.tb_ip.TabIndex = 0;
            this.tb_ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(35, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 28);
            this.label9.TabIndex = 14;
            this.label9.Text = "Nom d\'utilisateur";
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(35, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 31);
            this.label10.TabIndex = 13;
            this.label10.Text = "Adresse IP du serveur";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(183, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(437, 72);
            this.label8.TabIndex = 19;
            this.label8.Text = "Assurez-vous que l\'utilisateur à les droits administrateur sur le serveur cible e" + "t un pouvoir de création de bases de données\r\n\r\n";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btn_testco
            // 
            this.btn_testco.Active = false;
            this.btn_testco.Activecolor = System.Drawing.Color.FromArgb(((int) (((byte) (46)))), ((int) (((byte) (139)))), ((int) (((byte) (87)))));
            this.btn_testco.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (46)))), ((int) (((byte) (139)))), ((int) (((byte) (87)))));
            this.btn_testco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_testco.BorderRadius = 0;
            this.btn_testco.ButtonText = "Tester la connexion";
            this.btn_testco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_testco.DisabledColor = System.Drawing.Color.Gray;
            this.btn_testco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_testco.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_testco.Iconimage = ((System.Drawing.Image) (resources.GetObject("btn_testco.Iconimage")));
            this.btn_testco.Iconimage_right = null;
            this.btn_testco.Iconimage_right_Selected = null;
            this.btn_testco.Iconimage_Selected = null;
            this.btn_testco.IconMarginLeft = 10;
            this.btn_testco.IconMarginRight = 15;
            this.btn_testco.IconRightVisible = true;
            this.btn_testco.IconRightZoom = 0D;
            this.btn_testco.IconVisible = true;
            this.btn_testco.IconZoom = 100D;
            this.btn_testco.IsTab = false;
            this.btn_testco.Location = new System.Drawing.Point(35, 327);
            this.btn_testco.Name = "btn_testco";
            this.btn_testco.Normalcolor = System.Drawing.Color.FromArgb(((int) (((byte) (46)))), ((int) (((byte) (139)))), ((int) (((byte) (87)))));
            this.btn_testco.OnHovercolor = System.Drawing.Color.FromArgb(((int) (((byte) (36)))), ((int) (((byte) (129)))), ((int) (((byte) (77)))));
            this.btn_testco.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_testco.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_testco.selected = false;
            this.btn_testco.Size = new System.Drawing.Size(134, 48);
            this.btn_testco.TabIndex = 20;
            this.btn_testco.Text = "Tester la connexion";
            this.btn_testco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_testco.Textcolor = System.Drawing.Color.White;
            this.btn_testco.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_testco.Click += new System.EventHandler(this.btn_testco_Click);
            // 
            // btn_creation
            // 
            this.btn_creation.Active = false;
            this.btn_creation.Activecolor = System.Drawing.Color.FromArgb(((int) (((byte) (46)))), ((int) (((byte) (139)))), ((int) (((byte) (87)))));
            this.btn_creation.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (46)))), ((int) (((byte) (139)))), ((int) (((byte) (87)))));
            this.btn_creation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_creation.BorderRadius = 0;
            this.btn_creation.ButtonText = "Créer le WordPress";
            this.btn_creation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_creation.DisabledColor = System.Drawing.Color.Gray;
            this.btn_creation.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_creation.Iconimage = ((System.Drawing.Image) (resources.GetObject("btn_creation.Iconimage")));
            this.btn_creation.Iconimage_right = null;
            this.btn_creation.Iconimage_right_Selected = null;
            this.btn_creation.Iconimage_Selected = null;
            this.btn_creation.IconMarginLeft = 0;
            this.btn_creation.IconMarginRight = 0;
            this.btn_creation.IconRightVisible = true;
            this.btn_creation.IconRightZoom = 0D;
            this.btn_creation.IconVisible = true;
            this.btn_creation.IconZoom = 90D;
            this.btn_creation.IsTab = false;
            this.btn_creation.Location = new System.Drawing.Point(503, 567);
            this.btn_creation.Name = "btn_creation";
            this.btn_creation.Normalcolor = System.Drawing.Color.FromArgb(((int) (((byte) (46)))), ((int) (((byte) (139)))), ((int) (((byte) (87)))));
            this.btn_creation.OnHovercolor = System.Drawing.Color.FromArgb(((int) (((byte) (36)))), ((int) (((byte) (129)))), ((int) (((byte) (77)))));
            this.btn_creation.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_creation.selected = false;
            this.btn_creation.Size = new System.Drawing.Size(237, 34);
            this.btn_creation.TabIndex = 21;
            this.btn_creation.Text = "Créer le WordPress";
            this.btn_creation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_creation.Textcolor = System.Drawing.Color.White;
            this.btn_creation.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_creation.Click += new System.EventHandler(this.btn_creation_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btn_quit
            // 
            this.btn_quit.Active = false;
            this.btn_quit.Activecolor = System.Drawing.Color.FromArgb(((int) (((byte) (46)))), ((int) (((byte) (139)))), ((int) (((byte) (87)))));
            this.btn_quit.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (46)))), ((int) (((byte) (139)))), ((int) (((byte) (87)))));
            this.btn_quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_quit.BorderRadius = 0;
            this.btn_quit.ButtonText = "";
            this.btn_quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quit.DisabledColor = System.Drawing.Color.Gray;
            this.btn_quit.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_quit.Iconimage = ((System.Drawing.Image) (resources.GetObject("btn_quit.Iconimage")));
            this.btn_quit.Iconimage_right = null;
            this.btn_quit.Iconimage_right_Selected = null;
            this.btn_quit.Iconimage_Selected = null;
            this.btn_quit.IconMarginLeft = 0;
            this.btn_quit.IconMarginRight = 0;
            this.btn_quit.IconRightVisible = true;
            this.btn_quit.IconRightZoom = 0D;
            this.btn_quit.IconVisible = true;
            this.btn_quit.IconZoom = 100D;
            this.btn_quit.IsTab = false;
            this.btn_quit.Location = new System.Drawing.Point(749, 13);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Normalcolor = System.Drawing.Color.FromArgb(((int) (((byte) (46)))), ((int) (((byte) (139)))), ((int) (((byte) (87)))));
            this.btn_quit.OnHovercolor = System.Drawing.Color.FromArgb(((int) (((byte) (36)))), ((int) (((byte) (129)))), ((int) (((byte) (77)))));
            this.btn_quit.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_quit.selected = false;
            this.btn_quit.Size = new System.Drawing.Size(30, 31);
            this.btn_quit.TabIndex = 22;
            this.btn_quit.TabStop = false;
            this.btn_quit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_quit.Textcolor = System.Drawing.Color.White;
            this.btn_quit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // btn_reduce
            // 
            this.btn_reduce.Active = false;
            this.btn_reduce.Activecolor = System.Drawing.Color.FromArgb(((int) (((byte) (46)))), ((int) (((byte) (139)))), ((int) (((byte) (87)))));
            this.btn_reduce.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (46)))), ((int) (((byte) (139)))), ((int) (((byte) (87)))));
            this.btn_reduce.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_reduce.BorderRadius = 0;
            this.btn_reduce.ButtonText = "";
            this.btn_reduce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reduce.DisabledColor = System.Drawing.Color.Gray;
            this.btn_reduce.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_reduce.Iconimage = ((System.Drawing.Image) (resources.GetObject("btn_reduce.Iconimage")));
            this.btn_reduce.Iconimage_right = null;
            this.btn_reduce.Iconimage_right_Selected = null;
            this.btn_reduce.Iconimage_Selected = null;
            this.btn_reduce.IconMarginLeft = 0;
            this.btn_reduce.IconMarginRight = 0;
            this.btn_reduce.IconRightVisible = true;
            this.btn_reduce.IconRightZoom = 0D;
            this.btn_reduce.IconVisible = true;
            this.btn_reduce.IconZoom = 100D;
            this.btn_reduce.IsTab = false;
            this.btn_reduce.Location = new System.Drawing.Point(710, 14);
            this.btn_reduce.Name = "btn_reduce";
            this.btn_reduce.Normalcolor = System.Drawing.Color.FromArgb(((int) (((byte) (46)))), ((int) (((byte) (139)))), ((int) (((byte) (87)))));
            this.btn_reduce.OnHovercolor = System.Drawing.Color.FromArgb(((int) (((byte) (36)))), ((int) (((byte) (129)))), ((int) (((byte) (77)))));
            this.btn_reduce.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_reduce.selected = false;
            this.btn_reduce.Size = new System.Drawing.Size(30, 29);
            this.btn_reduce.TabIndex = 23;
            this.btn_reduce.TabStop = false;
            this.btn_reduce.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reduce.Textcolor = System.Drawing.Color.White;
            this.btn_reduce.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_reduce.Click += new System.EventHandler(this.btn_reduce_Click);
            // 
            // pg_etat
            // 
            this.pg_etat.BackColor = System.Drawing.Color.Silver;
            this.pg_etat.BorderRadius = 5;
            this.pg_etat.Location = new System.Drawing.Point(503, 623);
            this.pg_etat.MaximumValue = 100;
            this.pg_etat.Name = "pg_etat";
            this.pg_etat.ProgressColor = System.Drawing.Color.MediumSeaGreen;
            this.pg_etat.Size = new System.Drawing.Size(237, 26);
            this.pg_etat.TabIndex = 24;
            this.pg_etat.Value = 0;
            // 
            // btn_saveconf
            // 
            this.btn_saveconf.Active = false;
            this.btn_saveconf.Activecolor = System.Drawing.Color.FromArgb(((int) (((byte) (46)))), ((int) (((byte) (139)))), ((int) (((byte) (87)))));
            this.btn_saveconf.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (46)))), ((int) (((byte) (139)))), ((int) (((byte) (87)))));
            this.btn_saveconf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_saveconf.BorderRadius = 0;
            this.btn_saveconf.ButtonText = "Sauvegarder la configuration";
            this.btn_saveconf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_saveconf.DisabledColor = System.Drawing.Color.Gray;
            this.btn_saveconf.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_saveconf.Iconimage = ((System.Drawing.Image) (resources.GetObject("btn_saveconf.Iconimage")));
            this.btn_saveconf.Iconimage_right = null;
            this.btn_saveconf.Iconimage_right_Selected = null;
            this.btn_saveconf.Iconimage_Selected = null;
            this.btn_saveconf.IconMarginLeft = 15;
            this.btn_saveconf.IconMarginRight = 15;
            this.btn_saveconf.IconRightVisible = true;
            this.btn_saveconf.IconRightZoom = 0D;
            this.btn_saveconf.IconVisible = true;
            this.btn_saveconf.IconZoom = 50D;
            this.btn_saveconf.IsTab = false;
            this.btn_saveconf.Location = new System.Drawing.Point(202, 327);
            this.btn_saveconf.Name = "btn_saveconf";
            this.btn_saveconf.Normalcolor = System.Drawing.Color.FromArgb(((int) (((byte) (46)))), ((int) (((byte) (139)))), ((int) (((byte) (87)))));
            this.btn_saveconf.OnHovercolor = System.Drawing.Color.FromArgb(((int) (((byte) (36)))), ((int) (((byte) (129)))), ((int) (((byte) (77)))));
            this.btn_saveconf.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_saveconf.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_saveconf.selected = false;
            this.btn_saveconf.Size = new System.Drawing.Size(138, 48);
            this.btn_saveconf.TabIndex = 25;
            this.btn_saveconf.Text = "Sauvegarder la configuration";
            this.btn_saveconf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_saveconf.Textcolor = System.Drawing.Color.White;
            this.btn_saveconf.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_saveconf.Click += new System.EventHandler(this.btn_saveconf_Click);
            // 
            // btn_loadconf
            // 
            this.btn_loadconf.Active = false;
            this.btn_loadconf.Activecolor = System.Drawing.Color.FromArgb(((int) (((byte) (46)))), ((int) (((byte) (139)))), ((int) (((byte) (87)))));
            this.btn_loadconf.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (46)))), ((int) (((byte) (139)))), ((int) (((byte) (87)))));
            this.btn_loadconf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_loadconf.BorderRadius = 0;
            this.btn_loadconf.ButtonText = "Charger la configuration";
            this.btn_loadconf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_loadconf.DisabledColor = System.Drawing.Color.Gray;
            this.btn_loadconf.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_loadconf.Iconimage = ((System.Drawing.Image) (resources.GetObject("btn_loadconf.Iconimage")));
            this.btn_loadconf.Iconimage_right = null;
            this.btn_loadconf.Iconimage_right_Selected = null;
            this.btn_loadconf.Iconimage_Selected = null;
            this.btn_loadconf.IconMarginLeft = 10;
            this.btn_loadconf.IconMarginRight = 15;
            this.btn_loadconf.IconRightVisible = true;
            this.btn_loadconf.IconRightZoom = 0D;
            this.btn_loadconf.IconVisible = true;
            this.btn_loadconf.IconZoom = 90D;
            this.btn_loadconf.IsTab = false;
            this.btn_loadconf.Location = new System.Drawing.Point(202, 395);
            this.btn_loadconf.Name = "btn_loadconf";
            this.btn_loadconf.Normalcolor = System.Drawing.Color.FromArgb(((int) (((byte) (46)))), ((int) (((byte) (139)))), ((int) (((byte) (87)))));
            this.btn_loadconf.OnHovercolor = System.Drawing.Color.FromArgb(((int) (((byte) (36)))), ((int) (((byte) (129)))), ((int) (((byte) (77)))));
            this.btn_loadconf.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_loadconf.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_loadconf.selected = false;
            this.btn_loadconf.Size = new System.Drawing.Size(138, 48);
            this.btn_loadconf.TabIndex = 26;
            this.btn_loadconf.Text = "Charger la configuration";
            this.btn_loadconf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_loadconf.Textcolor = System.Drawing.Color.White;
            this.btn_loadconf.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_loadconf.Click += new System.EventHandler(this.btn_loadconf_Click);
            // 
            // cb_conf
            // 
            this.cb_conf.FormattingEnabled = true;
            this.cb_conf.Location = new System.Drawing.Point(35, 422);
            this.cb_conf.Name = "cb_conf";
            this.cb_conf.Size = new System.Drawing.Size(133, 21);
            this.cb_conf.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(36, 395);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 22);
            this.label11.TabIndex = 28;
            this.label11.Text = "Presets de configurations :";
            // 
            // lbl_status
            // 
            this.lbl_status.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_status.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_status.Location = new System.Drawing.Point(55, 465);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(285, 54);
            this.lbl_status.TabIndex = 29;
            // 
            // sw_apache
            // 
            this.sw_apache.BackColor = System.Drawing.Color.Transparent;
            this.sw_apache.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("sw_apache.BackgroundImage")));
            this.sw_apache.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sw_apache.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sw_apache.Location = new System.Drawing.Point(489, 373);
            this.sw_apache.Name = "sw_apache";
            this.sw_apache.OffColor = System.Drawing.Color.Gray;
            this.sw_apache.OnColor = System.Drawing.Color.FromArgb(((int) (((byte) (71)))), ((int) (((byte) (202)))), ((int) (((byte) (94)))));
            this.sw_apache.Size = new System.Drawing.Size(35, 20);
            this.sw_apache.TabIndex = 31;
            this.sw_apache.Value = false;
            this.sw_apache.OnValueChange += new System.EventHandler(this.sw_apache_OnValueChange);
            // 
            // label12
            // 
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(539, 373);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 20);
            this.label12.TabIndex = 30;
            this.label12.Text = "Fichier de conf. nécessaire?";
            // 
            // label13
            // 
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(489, 260);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 28);
            this.label13.TabIndex = 32;
            this.label13.Text = "Nom d\'utilisateur MySQL";
            // 
            // tb_mysql_user
            // 
            this.tb_mysql_user.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_mysql_user.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_mysql_user.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_mysql_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_mysql_user.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_mysql_user.ForeColor = System.Drawing.Color.White;
            this.tb_mysql_user.HintForeColor = System.Drawing.Color.Empty;
            this.tb_mysql_user.HintText = "";
            this.tb_mysql_user.isPassword = false;
            this.tb_mysql_user.LineFocusedColor = System.Drawing.Color.MediumSeaGreen;
            this.tb_mysql_user.LineIdleColor = System.Drawing.Color.White;
            this.tb_mysql_user.LineMouseHoverColor = System.Drawing.Color.MediumSeaGreen;
            this.tb_mysql_user.LineThickness = 3;
            this.tb_mysql_user.Location = new System.Drawing.Point(637, 260);
            this.tb_mysql_user.Margin = new System.Windows.Forms.Padding(4);
            this.tb_mysql_user.MaxLength = 32767;
            this.tb_mysql_user.Name = "tb_mysql_user";
            this.tb_mysql_user.Size = new System.Drawing.Size(94, 31);
            this.tb_mysql_user.TabIndex = 5;
            this.tb_mysql_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tb_user
            // 
            this.tb_user.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_user.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_user.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_user.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_user.ForeColor = System.Drawing.Color.White;
            this.tb_user.HintForeColor = System.Drawing.Color.Empty;
            this.tb_user.HintText = "";
            this.tb_user.isPassword = false;
            this.tb_user.LineFocusedColor = System.Drawing.Color.MediumSeaGreen;
            this.tb_user.LineIdleColor = System.Drawing.Color.White;
            this.tb_user.LineMouseHoverColor = System.Drawing.Color.MediumSeaGreen;
            this.tb_user.LineThickness = 3;
            this.tb_user.Location = new System.Drawing.Point(183, 218);
            this.tb_user.Margin = new System.Windows.Forms.Padding(4);
            this.tb_user.MaxLength = 32767;
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(157, 31);
            this.tb_user.TabIndex = 67;
            this.tb_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tb_mysql_mdp
            // 
            this.tb_mysql_mdp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_mysql_mdp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_mysql_mdp.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_mysql_mdp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_mysql_mdp.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_mysql_mdp.ForeColor = System.Drawing.Color.White;
            this.tb_mysql_mdp.HintForeColor = System.Drawing.Color.Empty;
            this.tb_mysql_mdp.HintText = "";
            this.tb_mysql_mdp.isPassword = false;
            this.tb_mysql_mdp.LineFocusedColor = System.Drawing.Color.MediumSeaGreen;
            this.tb_mysql_mdp.LineIdleColor = System.Drawing.Color.White;
            this.tb_mysql_mdp.LineMouseHoverColor = System.Drawing.Color.MediumSeaGreen;
            this.tb_mysql_mdp.LineThickness = 3;
            this.tb_mysql_mdp.Location = new System.Drawing.Point(637, 317);
            this.tb_mysql_mdp.Margin = new System.Windows.Forms.Padding(4);
            this.tb_mysql_mdp.MaxLength = 32767;
            this.tb_mysql_mdp.Name = "tb_mysql_mdp";
            this.tb_mysql_mdp.Size = new System.Drawing.Size(94, 31);
            this.tb_mysql_mdp.TabIndex = 68;
            this.tb_mysql_mdp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label14
            // 
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(489, 317);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 28);
            this.label14.TabIndex = 69;
            this.label14.Text = "Mot de passe MySQL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 739);
            this.Controls.Add(this.tb_mysql_mdp);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.tb_mysql_user);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.sw_apache);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cb_conf);
            this.Controls.Add(this.btn_loadconf);
            this.Controls.Add(this.btn_saveconf);
            this.Controls.Add(this.pg_etat);
            this.Controls.Add(this.btn_reduce);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_creation);
            this.Controls.Add(this.btn_testco);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.labelmdp);
            this.Controls.Add(this.tb_ip);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.sw_servername);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_servername);
            this.Controls.Add(this.tb_nomfichier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_nombdd);
            this.Controls.Add(this.tb_nomdossier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        private Bunifu.Framework.UI.BunifuFlatButton btn_creation;
        private Bunifu.Framework.UI.BunifuFlatButton btn_loadconf;
        private Bunifu.Framework.UI.BunifuFlatButton btn_quit;
        private Bunifu.Framework.UI.BunifuFlatButton btn_reduce;
        private Bunifu.Framework.UI.BunifuFlatButton btn_saveconf;
        private Bunifu.Framework.UI.BunifuFlatButton btn_testco;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ComboBox cb_conf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelmdp;
        public System.Windows.Forms.Label lbl_status;
        public Bunifu.Framework.UI.BunifuProgressBar pg_etat;
        private Bunifu.Framework.UI.BunifuiOSSwitch sw_apache;
        private Bunifu.Framework.UI.BunifuiOSSwitch sw_servername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_ip;
        public Bunifu.Framework.UI.BunifuMaterialTextbox tb_mysql_mdp;
        public Bunifu.Framework.UI.BunifuMaterialTextbox tb_mysql_user;
        public Bunifu.Framework.UI.BunifuMaterialTextbox tb_nombdd;
        public Bunifu.Framework.UI.BunifuMaterialTextbox tb_nomdossier;
        public Bunifu.Framework.UI.BunifuMaterialTextbox tb_nomfichier;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_pass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_servername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_user;

        #endregion
    }
}