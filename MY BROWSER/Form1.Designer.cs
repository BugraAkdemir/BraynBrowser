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
            this.BTNback = new System.Windows.Forms.Button();
            this.TMRtakip = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.ayarlarBTN = new System.Windows.Forms.Button();
            this.ayarlarPanel = new System.Windows.Forms.Panel();
            this.gecmişPanel = new System.Windows.Forms.Panel();
            this.gecmisSil = new System.Windows.Forms.Button();
            this.gecmisList = new System.Windows.Forms.ListBox();
            this.gemisBTN = new System.Windows.Forms.Button();
            this.bilgiPanel = new System.Windows.Forms.Panel();
            this.hakkındaLBL = new System.Windows.Forms.Label();
            this.verionLBL = new System.Windows.Forms.Label();
            this.BTNbilgi = new System.Windows.Forms.Button();
            this.panelTrayıcı = new System.Windows.Forms.Panel();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.navBarPNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoIMGbox)).BeginInit();
            this.panel2.SuspendLayout();
            this.ayarlarPanel.SuspendLayout();
            this.gecmişPanel.SuspendLayout();
            this.bilgiPanel.SuspendLayout();
            this.panelTrayıcı.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(367, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 208);
            this.panel1.TabIndex = 2;
            // 
            // OPENpdf
            // 
            
            
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
            this.Btnfs.Location = new System.Drawing.Point(1017, 2);
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
            this.pncBTN.Location = new System.Drawing.Point(1075, 2);
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
            this.BTNminimaze.Location = new System.Drawing.Point(1125, 1);
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
            // BTNback
            // 
            this.BTNback.BackColor = System.Drawing.Color.Transparent;
            this.BTNback.BackgroundImage = global::MY_BROWSER.Properties.Resources.back;
            this.BTNback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNback.FlatAppearance.BorderSize = 0;
            this.BTNback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNback.Location = new System.Drawing.Point(30, 6);
            this.BTNback.Name = "BTNback";
            this.BTNback.Size = new System.Drawing.Size(33, 23);
            this.BTNback.TabIndex = 6;
            this.BTNback.UseVisualStyleBackColor = false;
            this.BTNback.Click += new System.EventHandler(this.BTNback_Click);
            // 
            // TMRtakip
            // 
            this.TMRtakip.Tick += new System.EventHandler(this.TMRtakip_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(102)))), ((int)(((byte)(187)))));
            this.panel2.Controls.Add(this.BTNback);
            this.panel2.Controls.Add(this.txtUrl);
            this.panel2.Controls.Add(this.ayarlarBTN);
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1218, 36);
            this.panel2.TabIndex = 5;
            // 
            // txtUrl
            // 
            this.txtUrl.BackColor = System.Drawing.Color.AliceBlue;
            this.txtUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUrl.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrl.Location = new System.Drawing.Point(75, 11);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(622, 15);
            this.txtUrl.TabIndex = 6;
            this.txtUrl.Text = "Google\'da Arayın Veya Bir Url Girin";
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
            this.ayarlarBTN.Location = new System.Drawing.Point(1173, 3);
            this.ayarlarBTN.Name = "ayarlarBTN";
            this.ayarlarBTN.Size = new System.Drawing.Size(42, 34);
            this.ayarlarBTN.TabIndex = 4;
            this.ayarlarBTN.UseVisualStyleBackColor = false;
            this.ayarlarBTN.Click += new System.EventHandler(this.ayarlarBTN_Click);
            // 
            // ayarlarPanel
            // 
            this.ayarlarPanel.BackColor = System.Drawing.SystemColors.Menu;
            this.ayarlarPanel.Controls.Add(this.gecmişPanel);
            this.ayarlarPanel.Controls.Add(this.gemisBTN);
            this.ayarlarPanel.Controls.Add(this.bilgiPanel);
            this.ayarlarPanel.Controls.Add(this.BTNbilgi);
            this.ayarlarPanel.Location = new System.Drawing.Point(932, 83);
            this.ayarlarPanel.Name = "ayarlarPanel";
            this.ayarlarPanel.Size = new System.Drawing.Size(283, 513);
            this.ayarlarPanel.TabIndex = 6;
            this.ayarlarPanel.Visible = false;
            // 
            // gecmişPanel
            // 
            this.gecmişPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gecmişPanel.Controls.Add(this.gecmisSil);
            this.gecmişPanel.Controls.Add(this.gecmisList);
            this.gecmişPanel.Location = new System.Drawing.Point(13, 203);
            this.gecmişPanel.Name = "gecmişPanel";
            this.gecmişPanel.Size = new System.Drawing.Size(260, 254);
            this.gecmişPanel.TabIndex = 9;
            this.gecmişPanel.Visible = false;
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
            // 
            // gemisBTN
            // 
            this.gemisBTN.BackColor = System.Drawing.Color.Transparent;
            this.gemisBTN.BackgroundImage = global::MY_BROWSER.Properties.Resources.gecmisBTN;
            this.gemisBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gemisBTN.FlatAppearance.BorderSize = 0;
            this.gemisBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gemisBTN.Location = new System.Drawing.Point(148, 14);
            this.gemisBTN.Name = "gemisBTN";
            this.gemisBTN.Size = new System.Drawing.Size(135, 23);
            this.gemisBTN.TabIndex = 8;
            this.gemisBTN.UseVisualStyleBackColor = false;
            this.gemisBTN.Click += new System.EventHandler(this.gemisBTN_Click);
            // 
            // bilgiPanel
            // 
            this.bilgiPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bilgiPanel.Controls.Add(this.hakkındaLBL);
            this.bilgiPanel.Controls.Add(this.verionLBL);
            this.bilgiPanel.Location = new System.Drawing.Point(14, 43);
            this.bilgiPanel.Name = "bilgiPanel";
            this.bilgiPanel.Size = new System.Drawing.Size(188, 154);
            this.bilgiPanel.TabIndex = 7;
            this.bilgiPanel.Visible = false;
            this.bilgiPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bilgiPanel_Paint);
            // 
            // hakkındaLBL
            // 
            this.hakkındaLBL.Location = new System.Drawing.Point(20, 0);
            this.hakkındaLBL.Name = "hakkındaLBL";
            this.hakkındaLBL.Size = new System.Drawing.Size(142, 107);
            this.hakkındaLBL.TabIndex = 1;
            this.hakkındaLBL.Text = "Brayn İnternet Tarayıcısı 18.02.2025 Tarihinde Başlanmış Bir Projedir\r\nBu Proje B" +
    "ugra Akdemir Tarafından Gerçekleştirilmektedir\r\n";
            // 
            // verionLBL
            // 
            this.verionLBL.AutoSize = true;
            this.verionLBL.Location = new System.Drawing.Point(3, 124);
            this.verionLBL.Name = "verionLBL";
            this.verionLBL.Size = new System.Drawing.Size(0, 13);
            this.verionLBL.TabIndex = 0;
            // 
            // BTNbilgi
            // 
            this.BTNbilgi.BackgroundImage = global::MY_BROWSER.Properties.Resources.bilgiBTN;
            this.BTNbilgi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNbilgi.FlatAppearance.BorderSize = 0;
            this.BTNbilgi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNbilgi.Location = new System.Drawing.Point(3, 14);
            this.BTNbilgi.Name = "BTNbilgi";
            this.BTNbilgi.Size = new System.Drawing.Size(135, 23);
            this.BTNbilgi.TabIndex = 0;
            this.BTNbilgi.UseVisualStyleBackColor = true;
            this.BTNbilgi.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelTrayıcı
            // 
            this.panelTrayıcı.BackColor = System.Drawing.SystemColors.Control;
            this.panelTrayıcı.Controls.Add(this.webView21);
            this.panelTrayıcı.Location = new System.Drawing.Point(491, 405);
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
            this.webView21.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.webView21_NavigationCompleted);
            this.webView21.SourceChanged += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs>(this.webView21_SourceChanged);
            // 
            // mainPage
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1217, 656);
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
            this.gecmişPanel.ResumeLayout(false);
            this.bilgiPanel.ResumeLayout(false);
            this.bilgiPanel.PerformLayout();
            this.panelTrayıcı.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
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
        
        private System.Windows.Forms.Panel gecmişPanel;
        private System.Windows.Forms.Button gecmisSil;
        private System.Windows.Forms.ListBox gecmisList;
        private System.Windows.Forms.Button gemisBTN;
        private System.Windows.Forms.TextBox txtUrl;
    }
}

