using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MY_BROWSER
{
    public partial class mainPage : Form
    {   
        private bool pncKnt = false;


        private bool mouseDown = false;
        private Point lastLocation;
        private bool wasMaximized = false;
        private Size oldSize;
        private Point oldLocation;
        private bool isDragging = false; // Sürükleme başladı mı?

        private bool resizing = false; // Boyutlandırma aktif mi?
        private Point lastMousePosition; // Son mouse konumu
        private int borderSize = 5; // Kenarlardan kaç piksel içinde boyutlandırma çalışsın

        public mainPage()
        {
            InitializeComponent();
           


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Resize += new EventHandler(Form1_Resize);
            pncKnt = false;

            if (pncKnt == false)
            {
                Btnfs.Visible = true;
                Btnfs.Enabled = true;
                pncBTN.Visible = false;
                pncBTN.Visible = false;

                
            }
            else if (pncKnt == true)
            {
                pncBTN.Visible = false;
                pncBTN.Enabled = false;
                Btnfs.Enabled = true;
                Btnfs.Visible = true;

                
            }

            TMRtakip.Start();
            //panel1.Paint += new PaintEventHandler(panel1_Paint); // Doğrudan Paint event'ine bağla

            this.KeyPreview = true; // Form’un klavye olaylarını önce işlemesini sağlar

        }



        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;


            navBarPNL.Top = 0; // Paneli en üste sabitle
            navBarPNL.Left = 0; // Panelin sol kenardan başlamasını sağla
            navBarPNL.Width = this.ClientSize.Width; // Paneli pencere genişliğine göre ayarla
            navBarPNL.Height = 38; // Panel yüksekliği (Bunu değiştirebilirsin)
            //BTNcıkıs.Anchor = AnchorStyles.Top | AnchorStyles.Left;

           
        
            int topYuk = 4; // Sağ kenardan boşluk (istersen 0 yap)
            BTNcıkıs.Top = topYuk;
            BTNcıkıs.Left = this.ClientSize.Width - BTNcıkıs.Width - 10; // En sağa al

            BTNminimaze.Top = topYuk;
            BTNminimaze.Left = this.ClientSize.Width - BTNminimaze.Width - 60;

            Btnfs.Top = topYuk;
            Btnfs.Left = this.ClientSize.Width - Btnfs.Width - 110;

            pncBTN.Top = topYuk;
            pncBTN.Left = this.ClientSize.Width - pncBTN.Width - 110;




        }

        private void BTNcıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTNminimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pncBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

            if (pncKnt == false)
            {
                Btnfs.Visible = false;
                Btnfs.Enabled = false;
                pncBTN.Visible = true;
                pncBTN.Enabled = true;
            }


            
            pncKnt = false;

        }



        private void Btnfs_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            pncKnt = true;
        }

        private void TMRtakip_Tick(object sender, EventArgs e)
        {
            if (pncKnt == false)
            {
                Btnfs.Visible = true;
                Btnfs.Enabled = true;
                pncBTN.Visible = false;
                pncBTN.Visible = false;

                
            }else if(pncKnt == true)
            {
                pncBTN.Visible = true;
                pncBTN.Enabled = true;
                Btnfs.Enabled = false;
                Btnfs.Visible = false;

                
            }
        }

        private void navBarPNL_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = true;
                lastLocation = e.Location;

                // Eğer pencere tam ekransa, kayıpsız dönüş için işlemi geciktir
                if (this.WindowState == FormWindowState.Maximized)
                {
                    wasMaximized = true;
                    oldSize = this.Size;
                    oldLocation = this.Location;
                    isDragging = false; // Henüz sürükleme başlamadı
                    pncKnt = false;
                }
                else
                {
                    wasMaximized = false;
                    isDragging = true; // Direkt sürüklemeye başla
                }
            }

            if (e.Button == MouseButtons.Left && this.Cursor != Cursors.Default)
            {
                resizing = true;
                lastMousePosition = e.Location;
            }

        }

        private void navBarPNL_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                // Eğer pencere tam ekransa ve sürükleme başlamadıysa
                if (wasMaximized && !isDragging)
                {
                    this.WindowState = FormWindowState.Normal; // Önce normale dön
                    this.Left = Cursor.Position.X - (this.Width / 2); // Konumu ayarla
                    this.Top = Cursor.Position.Y - 10;
                    isDragging = true; // Artık sürüklemeye hazırız
                }

                if (isDragging) // Eğer pencere artık normal moddaysa
                {
                    this.Left = Cursor.Position.X - lastLocation.X;
                    this.Top = Cursor.Position.Y - lastLocation.Y;
                }
            }

            if (resizing)
            {
                int diffX = e.X - lastMousePosition.X;
                int diffY = e.Y - lastMousePosition.Y;

                if (this.Cursor == Cursors.SizeWE) // Sol veya sağ kenar
                {
                    this.Width += diffX;
                    lastMousePosition.X = e.X;
                }
                else if (this.Cursor == Cursors.SizeNS) // Üst veya alt kenar
                {
                    this.Height += diffY;
                    lastMousePosition.Y = e.Y;
                }
                else if (this.Cursor == Cursors.SizeNWSE) // Sağ alt köşe
                {
                    this.Width += diffX;
                    this.Height += diffY;
                    lastMousePosition = e.Location;
                }
            }
            else
            {
                // İmleç hangi kenara veya köşeye yakınsa ona göre değiştir
                if (e.X <= borderSize || e.X >= this.Width - borderSize)
                    this.Cursor = Cursors.SizeWE;
                else if (e.Y <= borderSize || e.Y >= this.Height - borderSize)
                    this.Cursor = Cursors.SizeNS;
                else if ((e.X >= this.Width - borderSize && e.Y >= this.Height - borderSize))
                    this.Cursor = Cursors.SizeNWSE;
                else
                    this.Cursor = Cursors.Default;
            }

        }

        private void navBarPNL_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = false;
                isDragging = false;
            }

            resizing = false;
        }

        private void mainPage_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Enter aKTİF");
                e.SuppressKeyPress = true; // Enter’ın normal işlevini engelle
            }
        }

        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics g = e.Graphics;
        //    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        //    using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
        //    {
        //        int radius = 15; // Köşe yuvarlaklığı
        //        path.AddArc(0, 0, radius, radius, 180, 90);
        //        path.AddArc(panel1.Width - radius, 0, radius, radius, 270, 90);
        //        path.AddArc(panel1.Width - radius, panel1.Height - radius, radius, radius, 0, 90);
        //        path.AddArc(0, panel1.Height - radius, radius, radius, 90, 90);
        //        path.CloseFigure();
        //        panel1.Region = new Region(path);
        //        g.DrawPath(Pens.Gray, path); // Kenarlık çiz
        //    }



    }
}
