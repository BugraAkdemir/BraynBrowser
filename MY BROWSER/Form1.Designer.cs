using System;

namespace MY_BROWSER
{
    partial class mainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPage));
            this.dataİnput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.navBarPNL = new System.Windows.Forms.Panel();
            this.BTNev = new System.Windows.Forms.Button();
            this.logoIMGbox = new System.Windows.Forms.PictureBox();
            this.Btnfs = new System.Windows.Forms.Button();
            this.pncBTN = new System.Windows.Forms.Button();
            this.BTNminimaze = new System.Windows.Forms.Button();
            this.BTNcıkıs = new System.Windows.Forms.Button();
            this.TMRtakip = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BTNapps = new System.Windows.Forms.Button();
            this.BTNindir = new System.Windows.Forms.Button();
            this.BTNgo = new System.Windows.Forms.Button();
            this.refBTN = new System.Windows.Forms.Button();
            this.BTNback = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.ayarlarBTN = new System.Windows.Forms.Button();
            this.ayarlarPanel = new System.Windows.Forms.Panel();
            this.BTNtema = new System.Windows.Forms.Button();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.gemisBTN = new System.Windows.Forms.Button();
            this.BTNbilgi = new System.Windows.Forms.Button();
            this.gecmisPanel = new System.Windows.Forms.Panel();
            this.gecmisSil = new System.Windows.Forms.Button();
            this.gecmisList = new System.Windows.Forms.ListBox();
            this.PNLtema = new System.Windows.Forms.Panel();
            this.PNLresimSecim = new System.Windows.Forms.Panel();
            this.backrondSelected = new System.Windows.Forms.ComboBox();
            this.colorSecims = new System.Windows.Forms.Button();
            this.resimSecims = new System.Windows.Forms.Button();
            this.bilgiPanel = new System.Windows.Forms.Panel();
            this.hakkındaLBL = new System.Windows.Forms.Label();
            this.verionLBL = new System.Windows.Forms.Label();
            this.panelTrayıcı = new System.Windows.Forms.Panel();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.PNLapps = new System.Windows.Forms.Panel();
            this.BTNappsGmail = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BTNappsGPT = new System.Windows.Forms.Button();
            this.BTNappsGOOGLE = new System.Windows.Forms.Button();
            this.BTNappsYT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.navBarPNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoIMGbox)).BeginInit();
            this.panel2.SuspendLayout();
            this.ayarlarPanel.SuspendLayout();
            this.gecmisPanel.SuspendLayout();
            this.PNLtema.SuspendLayout();
            this.PNLresimSecim.SuspendLayout();
            this.bilgiPanel.SuspendLayout();
            this.panelTrayıcı.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.PNLapps.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataİnput
            // 
            this.dataİnput.BackColor = System.Drawing.Color.AliceBlue;
            this.dataİnput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataİnput.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataİnput.Location = new System.Drawing.Point(96, 134);
            this.dataİnput.Name = "dataİnput";
            this.dataİnput.Size = new System.Drawing.Size(341, 15);
            this.dataİnput.TabIndex = 1;
            this.dataİnput.Text = "Google\'da Arayın Veya Bir Url Girin";
            this.dataİnput.Click += new System.EventHandler(this.dataİnput_Click);
            this.dataİnput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.dataİnput.Enter += new System.EventHandler(this.dataİnput_Enter);
            this.dataİnput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataİnput_KeyDown);
            this.dataİnput.Leave += new System.EventHandler(this.dataİnput_Leave);
            this.dataİnput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataİnput_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dataİnput);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 208);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::MY_BROWSER.Properties.Resources.ab;
            this.pictureBox2.Location = new System.Drawing.Point(41, 110);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(419, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MY_BROWSER.Properties.Resources.AKD_CARGO__300_x_150_piksel___727_x_150_piksel__Kopyası__4_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(491, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // navBarPNL
            // 
            this.navBarPNL.BackColor = System.Drawing.Color.CornflowerBlue;
            this.navBarPNL.Controls.Add(this.BTNev);
            this.navBarPNL.Controls.Add(this.logoIMGbox);
            this.navBarPNL.Controls.Add(this.Btnfs);
            this.navBarPNL.Controls.Add(this.pncBTN);
            this.navBarPNL.Controls.Add(this.BTNminimaze);
            this.navBarPNL.Controls.Add(this.BTNcıkıs);
            this.navBarPNL.Location = new System.Drawing.Point(0, 0);
            this.navBarPNL.Name = "navBarPNL";
            this.navBarPNL.Size = new System.Drawing.Size(1218, 38);
            this.navBarPNL.TabIndex = 3;
            this.navBarPNL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.navBarPNL_MouseDown);
            this.navBarPNL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.navBarPNL_MouseMove);
            this.navBarPNL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.navBarPNL_MouseUp);
            // 
            // BTNev
            // 
            this.BTNev.BackColor = System.Drawing.Color.Transparent;
            this.BTNev.BackgroundImage = global::MY_BROWSER.Properties.Resources.homeİcon;
            this.BTNev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNev.FlatAppearance.BorderSize = 0;
            this.BTNev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNev.Location = new System.Drawing.Point(75, 7);
            this.BTNev.Name = "BTNev";
            this.BTNev.Size = new System.Drawing.Size(33, 23);
            this.BTNev.TabIndex = 5;
            this.BTNev.UseVisualStyleBackColor = false;
            this.BTNev.Click += new System.EventHandler(this.BTNev_Click);
            // 
            // logoIMGbox
            // 
            this.logoIMGbox.BackColor = System.Drawing.Color.Transparent;
            this.logoIMGbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoIMGbox.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.logoIMGbox.Image = global::MY_BROWSER.Properties.Resources.logo;
            this.logoIMGbox.Location = new System.Drawing.Point(0, 0);
            this.logoIMGbox.Name = "logoIMGbox";
            this.logoIMGbox.Size = new System.Drawing.Size(60, 38);
            this.logoIMGbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoIMGbox.TabIndex = 4;
            this.logoIMGbox.TabStop = false;
            this.logoIMGbox.UseWaitCursor = true;
            // 
            // Btnfs
            // 
            this.Btnfs.BackColor = System.Drawing.Color.Transparent;
            this.Btnfs.BackgroundImage = global::MY_BROWSER.Properties.Resources.FFsC;
            this.Btnfs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btnfs.FlatAppearance.BorderSize = 0;
            this.Btnfs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnfs.Location = new System.Drawing.Point(1077, 3);
            this.Btnfs.Name = "Btnfs";
            this.Btnfs.Size = new System.Drawing.Size(42, 34);
            this.Btnfs.TabIndex = 3;
            this.Btnfs.UseVisualStyleBackColor = false;
            this.Btnfs.Click += new System.EventHandler(this.Btnfs_Click);
            // 
            // pncBTN
            // 
            this.pncBTN.BackColor = System.Drawing.Color.Transparent;
            this.pncBTN.BackgroundImage = global::MY_BROWSER.Properties.Resources.pnvv;
            this.pncBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pncBTN.FlatAppearance.BorderSize = 0;
            this.pncBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pncBTN.Location = new System.Drawing.Point(1125, 2);
            this.pncBTN.Name = "pncBTN";
            this.pncBTN.Size = new System.Drawing.Size(42, 34);
            this.pncBTN.TabIndex = 2;
            this.pncBTN.UseVisualStyleBackColor = false;
            this.pncBTN.Click += new System.EventHandler(this.pncBTN_Click);
            // 
            // BTNminimaze
            // 
            this.BTNminimaze.BackColor = System.Drawing.Color.Transparent;
            this.BTNminimaze.BackgroundImage = global::MY_BROWSER.Properties.Resources.mmb;
            this.BTNminimaze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNminimaze.FlatAppearance.BorderSize = 0;
            this.BTNminimaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNminimaze.Location = new System.Drawing.Point(1029, 3);
            this.BTNminimaze.Name = "BTNminimaze";
            this.BTNminimaze.Size = new System.Drawing.Size(42, 34);
            this.BTNminimaze.TabIndex = 1;
            this.BTNminimaze.UseVisualStyleBackColor = false;
            this.BTNminimaze.Click += new System.EventHandler(this.BTNminimaze_Click);
            // 
            // BTNcıkıs
            // 
            this.BTNcıkıs.BackColor = System.Drawing.Color.Transparent;
            this.BTNcıkıs.BackgroundImage = global::MY_BROWSER.Properties.Resources.EXİTbTN;
            this.BTNcıkıs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNcıkıs.FlatAppearance.BorderSize = 0;
            this.BTNcıkıs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNcıkıs.Location = new System.Drawing.Point(1174, 1);
            this.BTNcıkıs.Name = "BTNcıkıs";
            this.BTNcıkıs.Size = new System.Drawing.Size(42, 34);
            this.BTNcıkıs.TabIndex = 0;
            this.BTNcıkıs.UseVisualStyleBackColor = false;
            this.BTNcıkıs.Click += new System.EventHandler(this.BTNcıkıs_Click);
            // 
            // TMRtakip
            // 
            this.TMRtakip.Interval = 50;
            this.TMRtakip.Tick += new System.EventHandler(this.TMRtakip_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(102)))), ((int)(((byte)(187)))));
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.BTNapps);
            this.panel2.Controls.Add(this.BTNindir);
            this.panel2.Controls.Add(this.BTNgo);
            this.panel2.Controls.Add(this.refBTN);
            this.panel2.Controls.Add(this.BTNback);
            this.panel2.Controls.Add(this.txtUrl);
            this.panel2.Controls.Add(this.ayarlarBTN);
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1218, 36);
            this.panel2.TabIndex = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(129, 22);
            this.progressBar1.Maximum = 60;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(622, 11);
            this.progressBar1.TabIndex = 11;
            // 
            // BTNapps
            // 
            this.BTNapps.BackgroundImage = global::MY_BROWSER.Properties.Resources.BRAYN;
            this.BTNapps.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNapps.FlatAppearance.BorderSize = 0;
            this.BTNapps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNapps.Location = new System.Drawing.Point(1077, 2);
            this.BTNapps.Name = "BTNapps";
            this.BTNapps.Size = new System.Drawing.Size(42, 34);
            this.BTNapps.TabIndex = 10;
            this.BTNapps.UseVisualStyleBackColor = true;
            this.BTNapps.Click += new System.EventHandler(this.BTNapps_Click);
            // 
            // BTNindir
            // 
            this.BTNindir.BackgroundImage = global::MY_BROWSER.Properties.Resources.AKD_CARGO__300_x_150_piksel___727_x_150_piksel__Kopyası_Kopyası__5_;
            this.BTNindir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNindir.FlatAppearance.BorderSize = 0;
            this.BTNindir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNindir.Location = new System.Drawing.Point(1125, 2);
            this.BTNindir.Name = "BTNindir";
            this.BTNindir.Size = new System.Drawing.Size(42, 34);
            this.BTNindir.TabIndex = 10;
            this.BTNindir.UseVisualStyleBackColor = true;
            this.BTNindir.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // BTNgo
            // 
            this.BTNgo.BackColor = System.Drawing.Color.Transparent;
            this.BTNgo.BackgroundImage = global::MY_BROWSER.Properties.Resources.goFardddd;
            this.BTNgo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNgo.FlatAppearance.BorderSize = 0;
            this.BTNgo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNgo.Location = new System.Drawing.Point(51, 6);
            this.BTNgo.Name = "BTNgo";
            this.BTNgo.Size = new System.Drawing.Size(33, 23);
            this.BTNgo.TabIndex = 9;
            this.BTNgo.UseVisualStyleBackColor = false;
            this.BTNgo.Click += new System.EventHandler(this.BTNgo_Click);
            // 
            // refBTN
            // 
            this.refBTN.BackgroundImage = global::MY_BROWSER.Properties.Resources.reflash;
            this.refBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refBTN.FlatAppearance.BorderSize = 0;
            this.refBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refBTN.Location = new System.Drawing.Point(90, 6);
            this.refBTN.Name = "refBTN";
            this.refBTN.Size = new System.Drawing.Size(33, 23);
            this.refBTN.TabIndex = 8;
            this.refBTN.UseVisualStyleBackColor = true;
            this.refBTN.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BTNback
            // 
            this.BTNback.BackColor = System.Drawing.Color.Transparent;
            this.BTNback.BackgroundImage = global::MY_BROWSER.Properties.Resources.back;
            this.BTNback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNback.FlatAppearance.BorderSize = 0;
            this.BTNback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNback.ImageKey = "(none)";
            this.BTNback.Location = new System.Drawing.Point(12, 6);
            this.BTNback.Name = "BTNback";
            this.BTNback.Size = new System.Drawing.Size(33, 23);
            this.BTNback.TabIndex = 6;
            this.BTNback.UseVisualStyleBackColor = false;
            this.BTNback.Click += new System.EventHandler(this.BTNback_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.BackColor = System.Drawing.Color.AliceBlue;
            this.txtUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUrl.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrl.Location = new System.Drawing.Point(129, 4);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(622, 15);
            this.txtUrl.TabIndex = 6;
            this.txtUrl.Text = "Google\'da Arayın Veya Bir Url Girin";
            this.txtUrl.TextChanged += new System.EventHandler(this.txtUrl_TextChanged);
            this.txtUrl.Enter += new System.EventHandler(this.txtUrl_Enter);
            this.txtUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUrl_KeyDown);
            this.txtUrl.Leave += new System.EventHandler(this.txtUrl_Leave);
            // 
            // ayarlarBTN
            // 
            this.ayarlarBTN.BackColor = System.Drawing.Color.Transparent;
            this.ayarlarBTN.BackgroundImage = global::MY_BROWSER.Properties.Resources.AKD_CARGO__300_x_150_piksel___727_x_150_piksel__Kopyası_Kopyası__1_;
            this.ayarlarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ayarlarBTN.FlatAppearance.BorderSize = 0;
            this.ayarlarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ayarlarBTN.Location = new System.Drawing.Point(1173, 2);
            this.ayarlarBTN.Name = "ayarlarBTN";
            this.ayarlarBTN.Size = new System.Drawing.Size(42, 34);
            this.ayarlarBTN.TabIndex = 4;
            this.ayarlarBTN.UseVisualStyleBackColor = false;
            this.ayarlarBTN.Click += new System.EventHandler(this.ayarlarBTN_Click);
            // 
            // ayarlarPanel
            // 
            this.ayarlarPanel.BackColor = System.Drawing.SystemColors.Menu;
            this.ayarlarPanel.Controls.Add(this.BTNtema);
            this.ayarlarPanel.Controls.Add(this.gemisBTN);
            this.ayarlarPanel.Controls.Add(this.BTNbilgi);
            this.ayarlarPanel.Location = new System.Drawing.Point(932, 83);
            this.ayarlarPanel.Name = "ayarlarPanel";
            this.ayarlarPanel.Size = new System.Drawing.Size(283, 513);
            this.ayarlarPanel.TabIndex = 6;
            this.ayarlarPanel.Visible = false;
            // 
            // BTNtema
            // 
            this.BTNtema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNtema.FlatAppearance.BorderSize = 0;
            this.BTNtema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNtema.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNtema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNtema.ImageKey = "temaIC.png";
            this.BTNtema.ImageList = this.iconList;
            this.BTNtema.Location = new System.Drawing.Point(16, 43);
            this.BTNtema.Name = "BTNtema";
            this.BTNtema.Size = new System.Drawing.Size(95, 33);
            this.BTNtema.TabIndex = 10;
            this.BTNtema.Text = "TEMA";
            this.BTNtema.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNtema.UseVisualStyleBackColor = true;
            this.BTNtema.Click += new System.EventHandler(this.BTNtema_Click);
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "BTNfardIC");
            this.iconList.Images.SetKeyName(1, "BTNbackIC");
            this.iconList.Images.SetKeyName(2, "homeİcon.png");
            this.iconList.Images.SetKeyName(3, "bilgiIC.png");
            this.iconList.Images.SetKeyName(4, "gecmisIC.png");
            this.iconList.Images.SetKeyName(5, "temaIC.png");
            this.iconList.Images.SetKeyName(6, "ytIC.png");
            this.iconList.Images.SetKeyName(7, "googleIC.png");
            this.iconList.Images.SetKeyName(8, "chatgbtIC.png");
            this.iconList.Images.SetKeyName(9, "chatGbtIC2.png");
            this.iconList.Images.SetKeyName(10, "chatGptIC3.png");
            this.iconList.Images.SetKeyName(11, "googletanslateIC.png");
            this.iconList.Images.SetKeyName(12, "gmailIC.png");
            this.iconList.Images.SetKeyName(13, "gmailIC2.png");
            // 
            // gemisBTN
            // 
            this.gemisBTN.BackColor = System.Drawing.Color.Transparent;
            this.gemisBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gemisBTN.FlatAppearance.BorderSize = 0;
            this.gemisBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gemisBTN.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gemisBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gemisBTN.ImageKey = "gecmisIC.png";
            this.gemisBTN.ImageList = this.iconList;
            this.gemisBTN.Location = new System.Drawing.Point(170, 13);
            this.gemisBTN.Name = "gemisBTN";
            this.gemisBTN.Size = new System.Drawing.Size(103, 23);
            this.gemisBTN.TabIndex = 8;
            this.gemisBTN.Text = "GECMİS";
            this.gemisBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gemisBTN.UseVisualStyleBackColor = false;
            this.gemisBTN.Click += new System.EventHandler(this.gemisBTN_Click);
            // 
            // BTNbilgi
            // 
            this.BTNbilgi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNbilgi.FlatAppearance.BorderSize = 0;
            this.BTNbilgi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNbilgi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNbilgi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNbilgi.ImageKey = "bilgiIC.png";
            this.BTNbilgi.ImageList = this.iconList;
            this.BTNbilgi.Location = new System.Drawing.Point(13, 12);
            this.BTNbilgi.Name = "BTNbilgi";
            this.BTNbilgi.Size = new System.Drawing.Size(110, 23);
            this.BTNbilgi.TabIndex = 0;
            this.BTNbilgi.Text = "BİLGİ";
            this.BTNbilgi.UseVisualStyleBackColor = true;
            this.BTNbilgi.Click += new System.EventHandler(this.button1_Click);
            // 
            // gecmisPanel
            // 
            this.gecmisPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gecmisPanel.Controls.Add(this.gecmisSil);
            this.gecmisPanel.Controls.Add(this.gecmisList);
            this.gecmisPanel.Location = new System.Drawing.Point(663, 210);
            this.gecmisPanel.Name = "gecmisPanel";
            this.gecmisPanel.Size = new System.Drawing.Size(260, 254);
            this.gecmisPanel.TabIndex = 9;
            this.gecmisPanel.Visible = false;
            // 
            // gecmisSil
            // 
            this.gecmisSil.Location = new System.Drawing.Point(3, 222);
            this.gecmisSil.Name = "gecmisSil";
            this.gecmisSil.Size = new System.Drawing.Size(250, 23);
            this.gecmisSil.TabIndex = 10;
            this.gecmisSil.Text = "Geçmiş Sil";
            this.gecmisSil.UseVisualStyleBackColor = true;
            this.gecmisSil.Click += new System.EventHandler(this.gecmisSil_Click);
            // 
            // gecmisList
            // 
            this.gecmisList.FormattingEnabled = true;
            this.gecmisList.Location = new System.Drawing.Point(3, 4);
            this.gecmisList.Name = "gecmisList";
            this.gecmisList.Size = new System.Drawing.Size(250, 212);
            this.gecmisList.TabIndex = 0;
            this.gecmisList.SelectedIndexChanged += new System.EventHandler(this.gecmisList_SelectedIndexChanged);
            this.gecmisList.DoubleClick += new System.EventHandler(this.gecmisList_DoubleClick);
            // 
            // PNLtema
            // 
            this.PNLtema.BackColor = System.Drawing.SystemColors.GrayText;
            this.PNLtema.Controls.Add(this.PNLresimSecim);
            this.PNLtema.Controls.Add(this.colorSecims);
            this.PNLtema.Controls.Add(this.resimSecims);
            this.PNLtema.Location = new System.Drawing.Point(663, 83);
            this.PNLtema.Name = "PNLtema";
            this.PNLtema.Size = new System.Drawing.Size(261, 121);
            this.PNLtema.TabIndex = 8;
            this.PNLtema.Visible = false;
            // 
            // PNLresimSecim
            // 
            this.PNLresimSecim.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PNLresimSecim.Controls.Add(this.backrondSelected);
            this.PNLresimSecim.Location = new System.Drawing.Point(4, 28);
            this.PNLresimSecim.Name = "PNLresimSecim";
            this.PNLresimSecim.Size = new System.Drawing.Size(141, 86);
            this.PNLresimSecim.TabIndex = 2;
            this.PNLresimSecim.Visible = false;
            // 
            // backrondSelected
            // 
            this.backrondSelected.FormattingEnabled = true;
            this.backrondSelected.Items.AddRange(new object[] {
            "Default",
            "Orman",
            "Gökyüzü",
            "nulls"});
            this.backrondSelected.Location = new System.Drawing.Point(11, 29);
            this.backrondSelected.Name = "backrondSelected";
            this.backrondSelected.Size = new System.Drawing.Size(121, 21);
            this.backrondSelected.TabIndex = 0;
            this.backrondSelected.SelectedIndexChanged += new System.EventHandler(this.backrondSelected_SelectedIndexChanged);
            // 
            // colorSecims
            // 
            this.colorSecims.Location = new System.Drawing.Point(182, 3);
            this.colorSecims.Name = "colorSecims";
            this.colorSecims.Size = new System.Drawing.Size(75, 23);
            this.colorSecims.TabIndex = 1;
            this.colorSecims.Text = "Renk";
            this.colorSecims.UseVisualStyleBackColor = true;
            this.colorSecims.Click += new System.EventHandler(this.colorSecims_Click);
            // 
            // resimSecims
            // 
            this.resimSecims.Location = new System.Drawing.Point(4, 3);
            this.resimSecims.Name = "resimSecims";
            this.resimSecims.Size = new System.Drawing.Size(75, 23);
            this.resimSecims.TabIndex = 0;
            this.resimSecims.Text = "Resim";
            this.resimSecims.UseVisualStyleBackColor = true;
            this.resimSecims.Click += new System.EventHandler(this.resimSecims_Click);
            // 
            // bilgiPanel
            // 
            this.bilgiPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bilgiPanel.Controls.Add(this.hakkındaLBL);
            this.bilgiPanel.Controls.Add(this.verionLBL);
            this.bilgiPanel.Location = new System.Drawing.Point(663, 470);
            this.bilgiPanel.Name = "bilgiPanel";
            this.bilgiPanel.Size = new System.Drawing.Size(260, 126);
            this.bilgiPanel.TabIndex = 7;
            this.bilgiPanel.Visible = false;
            this.bilgiPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bilgiPanel_Paint);
            // 
            // hakkındaLBL
            // 
            this.hakkındaLBL.Location = new System.Drawing.Point(7, 6);
            this.hakkındaLBL.Name = "hakkındaLBL";
            this.hakkındaLBL.Size = new System.Drawing.Size(243, 84);
            this.hakkındaLBL.TabIndex = 1;
            this.hakkındaLBL.Text = "Brayn İnternet Tarayıcısı 18.02.2025 Tarihinde Başlanmış Bir Projedir\r\nBu Proje B" +
    "ugra Akdemir Tarafından Gerçekleştirilmektedir";
            this.hakkındaLBL.Click += new System.EventHandler(this.hakkındaLBL_Click);
            // 
            // verionLBL
            // 
            this.verionLBL.AutoSize = true;
            this.verionLBL.Location = new System.Drawing.Point(3, 101);
            this.verionLBL.Name = "verionLBL";
            this.verionLBL.Size = new System.Drawing.Size(22, 13);
            this.verionLBL.TabIndex = 0;
            this.verionLBL.Text = "1.9";
            this.verionLBL.Click += new System.EventHandler(this.verionLBL_Click);
            // 
            // panelTrayıcı
            // 
            this.panelTrayıcı.BackColor = System.Drawing.SystemColors.Control;
            this.panelTrayıcı.Controls.Add(this.webView21);
            this.panelTrayıcı.Location = new System.Drawing.Point(12, 296);
            this.panelTrayıcı.Name = "panelTrayıcı";
            this.panelTrayıcı.Size = new System.Drawing.Size(252, 149);
            this.panelTrayıcı.TabIndex = 7;
            this.panelTrayıcı.Visible = false;
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(3, 3);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(246, 143);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            this.webView21.CoreWebView2InitializationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs>(this.webView21_CoreWebView2InitializationCompleted);
            this.webView21.NavigationStarting += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs>(this.webView21_NavigationStarting);
            this.webView21.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.webView21_NavigationCompleted);
            this.webView21.SourceChanged += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs>(this.webView21_SourceChanged);
            this.webView21.ContentLoading += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventArgs>(this.webView21_ContentLoading);
            // 
            // PNLapps
            // 
            this.PNLapps.BackColor = System.Drawing.SystemColors.Menu;
            this.PNLapps.Controls.Add(this.BTNappsGmail);
            this.PNLapps.Controls.Add(this.button1);
            this.PNLapps.Controls.Add(this.BTNappsGPT);
            this.PNLapps.Controls.Add(this.BTNappsGOOGLE);
            this.PNLapps.Controls.Add(this.BTNappsYT);
            this.PNLapps.Location = new System.Drawing.Point(457, 435);
            this.PNLapps.Name = "PNLapps";
            this.PNLapps.Size = new System.Drawing.Size(200, 161);
            this.PNLapps.TabIndex = 10;
            this.PNLapps.Visible = false;
            // 
            // BTNappsGmail
            // 
            this.BTNappsGmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNappsGmail.FlatAppearance.BorderSize = 0;
            this.BTNappsGmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNappsGmail.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNappsGmail.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTNappsGmail.ImageKey = "gmailIC.png";
            this.BTNappsGmail.ImageList = this.iconList;
            this.BTNappsGmail.Location = new System.Drawing.Point(49, 104);
            this.BTNappsGmail.Name = "BTNappsGmail";
            this.BTNappsGmail.Size = new System.Drawing.Size(102, 46);
            this.BTNappsGmail.TabIndex = 15;
            this.BTNappsGmail.Text = "Gmail";
            this.BTNappsGmail.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNappsGmail.UseVisualStyleBackColor = true;
            this.BTNappsGmail.Click += new System.EventHandler(this.BTNappsGmail_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageKey = "googletanslateIC.png";
            this.button1.ImageList = this.iconList;
            this.button1.Location = new System.Drawing.Point(95, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 46);
            this.button1.TabIndex = 14;
            this.button1.Text = "Ceviri";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // BTNappsGPT
            // 
            this.BTNappsGPT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNappsGPT.FlatAppearance.BorderSize = 0;
            this.BTNappsGPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNappsGPT.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNappsGPT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTNappsGPT.ImageKey = "chatGptIC3.png";
            this.BTNappsGPT.ImageList = this.iconList;
            this.BTNappsGPT.Location = new System.Drawing.Point(3, 55);
            this.BTNappsGPT.Name = "BTNappsGPT";
            this.BTNappsGPT.Size = new System.Drawing.Size(102, 46);
            this.BTNappsGPT.TabIndex = 13;
            this.BTNappsGPT.Text = "CHAT GPT";
            this.BTNappsGPT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNappsGPT.UseVisualStyleBackColor = true;
            this.BTNappsGPT.Click += new System.EventHandler(this.BTNappsGPT_Click);
            // 
            // BTNappsGOOGLE
            // 
            this.BTNappsGOOGLE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNappsGOOGLE.FlatAppearance.BorderSize = 0;
            this.BTNappsGOOGLE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNappsGOOGLE.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNappsGOOGLE.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTNappsGOOGLE.ImageKey = "googleIC.png";
            this.BTNappsGOOGLE.ImageList = this.iconList;
            this.BTNappsGOOGLE.Location = new System.Drawing.Point(95, 3);
            this.BTNappsGOOGLE.Name = "BTNappsGOOGLE";
            this.BTNappsGOOGLE.Size = new System.Drawing.Size(102, 46);
            this.BTNappsGOOGLE.TabIndex = 12;
            this.BTNappsGOOGLE.Text = "GOOGLE";
            this.BTNappsGOOGLE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNappsGOOGLE.UseVisualStyleBackColor = true;
            this.BTNappsGOOGLE.Click += new System.EventHandler(this.BTNappsGOOGLE_Click);
            // 
            // BTNappsYT
            // 
            this.BTNappsYT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNappsYT.FlatAppearance.BorderSize = 0;
            this.BTNappsYT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNappsYT.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNappsYT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTNappsYT.ImageKey = "ytIC.png";
            this.BTNappsYT.ImageList = this.iconList;
            this.BTNappsYT.Location = new System.Drawing.Point(3, 3);
            this.BTNappsYT.Name = "BTNappsYT";
            this.BTNappsYT.Size = new System.Drawing.Size(102, 46);
            this.BTNappsYT.TabIndex = 11;
            this.BTNappsYT.Text = "YOUTUBE";
            this.BTNappsYT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNappsYT.UseVisualStyleBackColor = true;
            this.BTNappsYT.Click += new System.EventHandler(this.BTNappsYT_Click);
            // 
            // mainPage
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1217, 656);
            this.Controls.Add(this.PNLapps);
            this.Controls.Add(this.bilgiPanel);
            this.Controls.Add(this.gecmisPanel);
            this.Controls.Add(this.PNLtema);
            this.Controls.Add(this.panelTrayıcı);
            this.Controls.Add(this.ayarlarPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.navBarPNL);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.mainPage_Click);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.mainPage_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.mainPage_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainPage_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.navBarPNL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoIMGbox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ayarlarPanel.ResumeLayout(false);
            this.gecmisPanel.ResumeLayout(false);
            this.PNLtema.ResumeLayout(false);
            this.PNLresimSecim.ResumeLayout(false);
            this.bilgiPanel.ResumeLayout(false);
            this.bilgiPanel.PerformLayout();
            this.panelTrayıcı.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.PNLapps.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox dataİnput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel navBarPNL;
        private System.Windows.Forms.Button BTNcıkıs;
        private System.Windows.Forms.Button BTNminimaze;
        private System.Windows.Forms.Button pncBTN;
        private System.Windows.Forms.Button Btnfs;
        private System.Windows.Forms.Timer TMRtakip;
        private System.Windows.Forms.PictureBox logoIMGbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ayarlarBTN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel ayarlarPanel;
        private System.Windows.Forms.Button BTNbilgi;
        private System.Windows.Forms.Panel bilgiPanel;
        private System.Windows.Forms.Label hakkındaLBL;
        private System.Windows.Forms.Label verionLBL;
        private System.Windows.Forms.Panel panelTrayıcı;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Button BTNev;
        private System.Windows.Forms.Button BTNback;
        
        private System.Windows.Forms.Panel gecmisPanel;
        private System.Windows.Forms.Button gecmisSil;
        private System.Windows.Forms.ListBox gecmisList;
        private System.Windows.Forms.Button gemisBTN;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button refBTN;
        private System.Windows.Forms.Button BTNgo;
        private System.Windows.Forms.Panel PNLtema;
        private System.Windows.Forms.Button BTNtema;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.ComboBox backrondSelected;
        private System.Windows.Forms.Panel PNLresimSecim;
        private System.Windows.Forms.Button colorSecims;
        private System.Windows.Forms.Button resimSecims;
        private System.Windows.Forms.Button BTNindir;
        private System.Windows.Forms.Button BTNapps;
        private System.Windows.Forms.Panel PNLapps;
        private System.Windows.Forms.Button BTNappsYT;
        private System.Windows.Forms.Button BTNappsGOOGLE;
        private System.Windows.Forms.Button BTNappsGPT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTNappsGmail;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

