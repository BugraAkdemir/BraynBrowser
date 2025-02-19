using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Wpf;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MY_BROWSER
{
	public partial class mainPage : Form
	{
		public string versiontxt = "v1.5 - Closed Beta";

		private bool pncKnt = false;
		private bool ayarlarPNCkn = false;


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
			verionLBL.Text = $"Uygulama Sürümü: {versiontxt}";


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

			
		
			this.MaximizedBounds = Screen.PrimaryScreen.WorkingArea; // Kullanılabilir alanı kullan
																	 //this.FormBorderStyle = FormBorderStyle.Sizable; // Yeniden boyutlandırılabilir olsun

			dataİnput.Height = 25;

			dataİnput.Text = "Google'da Arayın Veya Bir URL Girin"; // Varsayılan metni ekle
			dataİnput.ForeColor = Color.Gray; // Placeholder rengi

			dataİnput.Enter += dataİnput_Enter; // Tıklanınca çalışacak
			dataİnput.Leave += dataİnput_Leave; // Dışına çıkınca çalışacak

			this.ActiveControl = panel1; // Varsa bir `Label`, `Panel` veya başka bir kontrolü odakla

			BTNback.Visible = false;

            this.AllowDrop = true;
            this.DragEnter += mainPage_DragEnter;
            this.DragDrop += mainPage_DragDrop;
			
        }



		

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		   
		}

		private void Form1_Resize(object sender, EventArgs e)
		{
			panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
			panel1.Top = 200;


			navBarPNL.Top = 0; // Paneli en üste sabitle
			navBarPNL.Left = 0; // Panelin sol kenardan başlamasını sağla
			navBarPNL.Width = this.ClientSize.Width; // Paneli pencere genişliğine göre ayarla
			navBarPNL.Height = 38; // Panel yüksekliği (Bunu değiştirebilirsin)
								   //BTNcıkıs.Anchor = AnchorStyles.Top | AnchorStyles.Left;

			panel2.Top = 40; // Paneli en üste sabitle
			panel2.Left = 0; // Panelin sol kenardan başlamasını sağla
			panel2.Width = this.ClientSize.Width; // Paneli pencere genişliğine göre ayarla
			panel2.Height = 38; // Panel yüksekliği (Bunu değiştirebilirsin)
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

			ayarlarBTN.Top = topYuk;
			ayarlarBTN.Left = this.ClientSize.Width - ayarlarBTN.Width - 10;

			ayarlarPanel.Top = 83;
			ayarlarPanel.Left = this.ClientSize.Width - ayarlarPanel.Width - 8;

			// Eğer panel görünüyorsa
			if (panelTrayıcı.Visible)
			{
				// Panelin boyutlarını formun boyutlarına göre ayarlıyoruz
				panelTrayıcı.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);

				// WebView2'nin boyutlarını da panelle uyumlu hale getiriyoruz
				webView21.Size = panelTrayıcı.Size;
			}
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

				if (this.Cursor == Cursors.Default) // Sol veya sağ kenar
				{
					this.Width += diffX;
					lastMousePosition.X = e.X;
				}
				else if (this.Cursor == Cursors.Default) // Üst veya alt kenar
				{
					this.Height += diffY;
					lastMousePosition.Y = e.Y;
				}
				else if (this.Cursor == Cursors.Default) // Sağ alt köşe
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
					this.Cursor = Cursors.Default;
				else if (e.Y <= borderSize || e.Y >= this.Height - borderSize)
					this.Cursor = Cursors.Default;
				else if ((e.X >= this.Width - borderSize && e.Y >= this.Height - borderSize))
					this.Cursor = Cursors.Default;
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
			
		}

		private void dataİnput_Click(object sender, EventArgs e)
		{
			
		}

		private void dataİnput_Enter(object sender, EventArgs e)
		{
			if (dataİnput.Text == "Google'da Arayın Veya Bir URL Girin")
			{
				dataİnput.Text = ""; // İçeriği temizle
				dataİnput.ForeColor = Color.Black; // Normal yazı rengi
			}
		}

		private void dataİnput_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(dataİnput.Text))
			{
				dataİnput.Text = "Google'da Arayın Veya Bir URL Girin"; // Tekrar placeholder ekle
				dataİnput.ForeColor = Color.Gray; // Placeholder rengine geri dön
			}
		}

		private void ayarlarBTN_Click(object sender, EventArgs e)
		{
			ayarlarPanel.Visible = !ayarlarPanel.Visible;
		}

		private void bilgiPanel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			bilgiPanel.Visible = !bilgiPanel.Visible;
		}

		private void dataİnput_MouseDown(object sender, MouseEventArgs e)
		{

		}

		private void dataİnput_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				// TextBox'ın içi boşsa, uyarı göster
				if (string.IsNullOrEmpty(dataİnput.Text))
				{
					//pass
				}
				else
				{
					int marginTop = 40; // Üstte bırakacağımız boşluk

					// Panelin boyutlarını ve konumunu ayarla
					panelTrayıcı.Location = new Point(0, marginTop);  // Üstten 50px boşluk bırak
					panelTrayıcı.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - marginTop);  // Panel formu kaplasın
					panelTrayıcı.Visible = true; // Paneli görünür yap

					// WebView2'nin boyutlarını ayarla (panelin içine dahil olacak şekilde)
					webView21.Size = new Size(panelTrayıcı.Width, panelTrayıcı.Height);
					webView21.Location = new Point(0, 0);  // Panelin içinde sıfırdan başla

                    string anlıkSaat = DateTime.Now.ToString("HH:mm:ss");
                    string anlıkTarih = DateTime.Now.ToString("dd.MM.yyyy");




                    string aramaTerimi = dataİnput.Text; // TextBox'tan metni al
					if (!string.IsNullOrWhiteSpace(aramaTerimi))
					{
						string googleUrl = $"https://www.google.com/search?q={Uri.EscapeDataString(aramaTerimi)}";
						webView21.Source = new Uri(googleUrl); // WebView2'de aç

                        string dosyaYolu = "gecmis.txt"; // TXT dosya yolu
                        string yeniVeri = $"{dataİnput.Text} || {anlıkTarih} {anlıkSaat}"; // Boşlukları temizle

                        if (!string.IsNullOrEmpty(yeniVeri)) // Eğer TextBox boş değilse
                        {
                            File.AppendAllText(dosyaYolu, yeniVeri + Environment.NewLine); // Yeni satır ekleyerek kaydet
                            gecmisList.Items.Add(yeniVeri); // ListBox’a ekle
							dataİnput.Clear(); // TextBox'ı temizle
                        }
                        else
                        {
                            MessageBox.Show("Lütfen bir metin girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

					

                   

					
					
                }


				e.SuppressKeyPress = true; // Enter’ın normal işlevini engelle
			}
		}

		private void BTNev_Click(object sender, EventArgs e)
		{
			// Eğer panel açık (görünürse), paneli kapat
			if (panelTrayıcı.Visible)
			{
				panelTrayıcı.Visible = false; // Paneli gizle
			}
			// Eğer panel kapalıysa, hiçbir şey yapma
			else
			{
				
			}
		}

		private void BTNback_Click(object sender, EventArgs e)
		{
			//// Eğer panel açık (görünürse), paneli kapat
			//if (panelTrayıcı.Visible)
			//{
			//    panelTrayıcı.Visible = false; // Paneli gizle
			//}
			//// Eğer panel kapalıysa, hiçbir şey yapma
			//else if(webView21.Source == new Uri("https://www.google.com/search?q="))
			//{
			//    panelTrayıcı.Visible = true;
			//}
		}

        private void OPENpdf_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Dosyaları (*.pdf)|*.pdf"; // Sadece PDF seçilsin
            openFileDialog.Title = "Bir PDF Dosyası Seçin";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenPDF(openFileDialog.FileName); // Seçilen PDF dosyasını aç
				panelTrayıcı.Visible = true;
            }
        }

        private void OpenPDF(string pdfPath)
        {
            if (File.Exists(pdfPath)) // Dosyanın var olup olmadığını kontrol et
            {
                panelTrayıcı.Visible = true; // Paneli görünür yap
				panelTrayıcı.Dock = DockStyle.None; // Dock'u kapat ki manuel ayarlayabilelim
                panelTrayıcı.Location = new Point(0, 40); // Paneli 50 piksel aşağıya kaydır
                panelTrayıcı.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - 100); // Paneli tam ekran yap ama üstte boşluk bırak

                webView21.Dock = DockStyle.Fill; // WebView2'yi tam ekran yap
                webView21.Source = new Uri(pdfPath); // PDF dosyasını WebView2 içinde aç
            }
            else
            {
                MessageBox.Show("Seçilen PDF dosyası bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mainPage_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0 && Path.GetExtension(files[0]).ToLower() == ".pdf")
                {
                    e.Effect = DragDropEffects.Copy; // PDF ise sürükleme aktif olsun
                }
                else
                {
                    e.Effect = DragDropEffects.None; // PDF değilse engelle
                }
            }
        }

        private void mainPage_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                OpenPDF(files[0]); // İlk PDF dosyasını aç
				
            }
        }

        private void gemisBTN_Click(object sender, EventArgs e)
        {
            gecmişPanel.Visible = !gecmişPanel.Visible;

            string dosyaYolu = "gecmis.txt"; // TXT dosyanın yolu

            if (File.Exists(dosyaYolu)) // Dosya var mı?
            {
                gecmisList.Items.Clear(); // Önce listeyi temizle
                string[] satirlar = File.ReadAllLines(dosyaYolu); // Tüm satırları oku
				gecmisList.Items.AddRange(satirlar); // ListBox'a ekle
            }
            else
            {
                MessageBox.Show("Dosya bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void webView21_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            string dosyaYolu = "gecmis.txt"; // Dosya yolu
            string url = webView21.Source?.ToString(); // Güncel URL'yi al

            if (!string.IsNullOrEmpty(url)) // Eğer URL boş değilse
            {
                File.AppendAllText(dosyaYolu, url + Environment.NewLine); // URL'yi yeni satıra ekle
            }
        }

        private void gecmisSil_Click(object sender, EventArgs e)
        {
            string dosyaYolu = "gecmis.txt"; // Dosya yolu

            if (File.Exists(dosyaYolu)) // Eğer dosya varsa
            {
                File.WriteAllText(dosyaYolu, " "); // İçeriği tamamen sil (boş bir metin yaz)

                gecmisList.Items.Clear(); // Önce listeyi temizle
                string[] satirlar = File.ReadAllLines(dosyaYolu); // Tüm satırları oku
                gecmisList.Items.AddRange(satirlar); // ListBox'a ekle

            }
            else
            {
                MessageBox.Show("Dosya bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
