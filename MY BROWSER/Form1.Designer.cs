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
            this.navBarPNL = new System.Windows.Forms.Panel();
            this.logoIMGbox = new System.Windows.Forms.PictureBox();
            this.Btnfs = new System.Windows.Forms.Button();
            this.pncBTN = new System.Windows.Forms.Button();
            this.BTNminimaze = new System.Windows.Forms.Button();
            this.BTNcıkıs = new System.Windows.Forms.Button();
            this.TMRtakip = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.navBarPNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoIMGbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataİnput
            // 
            this.dataİnput.BackColor = System.Drawing.Color.AliceBlue;
            this.dataİnput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataİnput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataİnput.Location = new System.Drawing.Point(66, 136);
            this.dataİnput.Name = "dataİnput";
            this.dataİnput.Size = new System.Drawing.Size(373, 17);
            this.dataİnput.TabIndex = 1;
            this.dataİnput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dataİnput);
            this.panel1.Location = new System.Drawing.Point(366, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 208);
            this.panel1.TabIndex = 2;
            // 
            // navBarPNL
            // 
            this.navBarPNL.BackColor = System.Drawing.Color.CornflowerBlue;
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
            // logoIMGbox
            // 
            this.logoIMGbox.BackColor = System.Drawing.Color.Transparent;
            this.logoIMGbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.Btnfs.BackgroundImage = global::MY_BROWSER.Properties.Resources.Adsız_tasarım__5_1;
            this.Btnfs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btnfs.FlatAppearance.BorderSize = 0;
            this.Btnfs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnfs.Location = new System.Drawing.Point(1029, 0);
            this.Btnfs.Name = "Btnfs";
            this.Btnfs.Size = new System.Drawing.Size(42, 34);
            this.Btnfs.TabIndex = 3;
            this.Btnfs.UseVisualStyleBackColor = false;
            this.Btnfs.Click += new System.EventHandler(this.Btnfs_Click);
            // 
            // pncBTN
            // 
            this.pncBTN.BackColor = System.Drawing.Color.Transparent;
            this.pncBTN.BackgroundImage = global::MY_BROWSER.Properties.Resources.pncBt;
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
            this.BTNminimaze.BackgroundImage = global::MY_BROWSER.Properties.Resources.minimaze;
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
            this.BTNcıkıs.BackgroundImage = global::MY_BROWSER.Properties.Resources.X;
            this.BTNcıkıs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNcıkıs.FlatAppearance.BorderSize = 0;
            this.BTNcıkıs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNcıkıs.Location = new System.Drawing.Point(1173, 1);
            this.BTNcıkıs.Name = "BTNcıkıs";
            this.BTNcıkıs.Size = new System.Drawing.Size(42, 34);
            this.BTNcıkıs.TabIndex = 0;
            this.BTNcıkıs.UseVisualStyleBackColor = false;
            this.BTNcıkıs.Click += new System.EventHandler(this.BTNcıkıs_Click);
            // 
            // TMRtakip
            // 
            this.TMRtakip.Interval = 500;
            this.TMRtakip.Tick += new System.EventHandler(this.TMRtakip_Tick);
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
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MY_BROWSER.Properties.Resources.brBCK;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1217, 656);
            this.Controls.Add(this.navBarPNL);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainPage_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.navBarPNL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoIMGbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}

