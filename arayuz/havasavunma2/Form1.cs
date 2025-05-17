using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Diagnostics;
using System.Management;




namespace havasavunma2
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer geriSayimTimer;
        private int kalanSure;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private Bitmap arkaPlanKopya;
        private bool isTask2Active = false;
        Panel sistemIsik;
        bool sistemAktif = false;
        private Bitmap sonGelenGorsel;


        private UdpClient udpClient;
        private Thread receiveThread;

        public Form1()
        {
            InitializeComponent();
            IşikKur();

            // Ekran açılış ayarları
            this.Size = new Size(1150, 700); // Geniş başlangıç boyutu
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;

            this.Load += new EventHandler(Form1_Load);
            this.Resize += new EventHandler(Form1_Resize);
            this.pictureBox3.Paint += new PaintEventHandler(this.panel1_Paint);

        }

        // dosyanın en üstüne ekle



    private void IşikKur()
        {
            // sistem ışığını oluştur
            sistemIsik = new Panel();
            sistemIsik.Size = new Size(10, 10);
            sistemIsik.BackColor = Color.Red;

            // panel2 içinde uygun konum
            sistemIsik.Location = new Point(10, 8); // panel2 içi konum

            // yuvarlak şekil ver
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, sistemIsik.Width, sistemIsik.Height);
            sistemIsik.Region = new Region(path);

            // panel2 içine ekle
            panel2.Controls.Add(sistemIsik);
        }
    private void GuncelleSistemIsigi(bool aktif)
    {
            sistemIsik.BackColor = aktif ? Color.Green : Color.Red;
   }
        Dictionary<Control, Rectangle> originalRects = new Dictionary<Control, Rectangle>();
        Size originalFormSize;
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox5.Image = Image.FromFile(@"C:\Users\Busra\Desktop\eren_bülbül2.jpg");
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox6.Image = Image.FromFile(@"C:\Users\Busra\Desktop\kaplanlar.jpg");
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox7.Image = Image.FromFile(@"C:\Users\Busra\Desktop\ucaksan.jpg");
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox8.Image = Image.FromFile(@"C:\Users\Busra\Desktop\ozdisan.jpg");
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox9.Image = Image.FromFile(@"C:\Users\Busra\Desktop\akka_kalıp.jpg");
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox10.Image = Image.FromFile(@"C:\Users\Busra\Desktop\bereketli_topraklar.jpg");
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;


            originalFormSize = this.Size;
            SaveControlBounds(this);

            if (pictureBox1.Image != null)
            {
                arkaPlanKopya = new Bitmap(pictureBox1.Image);
            }
            if (pictureBox2.Image != null)
            {
                arkaPlanKopya = new Bitmap(pictureBox2.Image);
            }



        }
        private void ReceiveImages2()
        {
            IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);

            while (true)
            {
                try
                {
                    byte[] data = udpClient.Receive(ref remoteEP);

                    if (data != null && data.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(data))
                        {
                            Bitmap bmp = new Bitmap(ms);

                            pictureBox3.Invoke(new Action(() =>
                            {
                                pictureBox3.Image?.Dispose();
                                pictureBox3.Image = new Bitmap(bmp);
                            }));
                        }
                    }

                    Thread.Sleep(30); // akıcılık için
                }
                catch (Exception ex)
                {
                    MessageBox.Show("UDP görüntü alma hatası:\n" + ex.Message);
                    sistemAktif = false;
                    break;
                }
            }
        }



        private void Form1_Resize(object sender, EventArgs e)
        {
            float xRatio = (float)this.Width / originalFormSize.Width;
            float yRatio = (float)this.Height / originalFormSize.Height;

            foreach (Control ctrl in originalRects.Keys)
            {
                Rectangle original = originalRects[ctrl];
                ctrl.Left = (int)(original.Left * xRatio);
                ctrl.Top = (int)(original.Top * yRatio);
                ctrl.Width = (int)(original.Width * xRatio);
                ctrl.Height = (int)(original.Height * yRatio);
            }
        }

        private void SaveControlBounds(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                originalRects[ctrl] = ctrl.Bounds;
                if (ctrl.HasChildren)
                    SaveControlBounds(ctrl);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!sistemAktif)
            {
                // KAMERA AÇ butonuna basıldığında:
                try
                {
                    // Python açık olabilir, kapat
                    foreach (var process in Process.GetProcessesByName("python"))
                    {
                        process.Kill();
                    }

                    // Önceki video kaynağı varsa kapat
                    if (videoSource != null && videoSource.IsRunning)
                    {
                        videoSource.SignalToStop();
                        videoSource.WaitForStop();
                        videoSource = null;
                    }

                    // Kamera cihazlarını tara
                    videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                    if (videoDevices.Count > 0)
                    {
                        videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                        videoSource.NewFrame += Video_NewFrame;
                        videoSource.Start();

                        richTextBox1.AppendText("Bilgisayar kamerası başlatıldı.\n");
                        GuncelleSistemIsigi(true);
                    }
                    else
                    {
                        MessageBox.Show("Kamera bulunamadı.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kamera başlatılırken hata oluştu:\n" + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Kamera zaten açık.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                Bitmap frame = (Bitmap)eventArgs.Frame.Clone();

                if (pictureBox3.IsHandleCreated && !pictureBox3.IsDisposed)
                {
                    pictureBox3.Invoke(new MethodInvoker(delegate
                    {
                        using (Graphics g = pictureBox3.CreateGraphics())
                        {
                            g.DrawImage(frame, new Rectangle(0, 0, pictureBox3.Width, pictureBox3.Height));
                        }
                    }));
                }

                frame.Dispose();
            }
            catch (ObjectDisposedException)
            {
                // Form veya panel kapanmış, işlem yapılmasın
            }
            catch (InvalidAsynchronousStateException)
            {
                // Aynı şekilde panel yoksa, işlem yapılmasın
            }
        }
        private void GeriSayimTimer_Tick(object sender, EventArgs e)
        {
            kalanSure--;

            if (kalanSure <= 0)
            {
                geriSayimTimer.Stop();
                label4.Text = "Süre doldu!";
                // Burada görev sonlandırılabilir veya alarm verilebilir
            }
            else
            {
                label4.Text = $" {kalanSure} s";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
         
        
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir Mod Seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            kalanSure = 300; // 10 saniyelik geri sayım
            label4.Text = $" {kalanSure} s";

            // Timer başlat
            if (geriSayimTimer == null)
            {
                geriSayimTimer = new System.Windows.Forms.Timer(); // ✅ Doğru olan
                geriSayimTimer.Interval = 1000; // 1 saniyelik aralıklarla
                geriSayimTimer.Tick += GeriSayimTimer_Tick;
            }
            geriSayimTimer.Start();

            // 1. Video kaynağını durdur
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                videoSource = null;
            }

            // 2. Python başlat (arka planda)
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = @"C:\Users\Busra\AppData\Local\Microsoft\WindowsApps\python.exe";
                psi.Arguments = @"C:\Users\Busra\Desktop\opencv\balonalgilama.py";
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Python başlatılamadı:\n" + ex.Message);
            }

            // 3. UDP alım thread’i başlat
            if (!sistemAktif)
            {
                udpClient = new UdpClient();
                udpClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                udpClient.Client.Bind(new IPEndPoint(IPAddress.Any, 5005));

                receiveThread = new Thread(ReceiveImages2);
                receiveThread.IsBackground = true;
                receiveThread.Start();

                sistemAktif = true;
                GuncelleSistemIsigi(true);
                richTextBox1.AppendText("Görev 2 'ye başlandı.\n");
                richTextBox1.AppendText("Görev2 kamera görüntüsü başlatıldı.\n");
            }

            // 4. Buton renkleri
            gorev1bitir.ForeColor = SystemColors.ControlLightLight;
            gorev2bitir.ForeColor = SystemColors.ControlLightLight;
            gorev1basla.ForeColor = SystemColors.ControlLightLight;
            gorev3basla.ForeColor = SystemColors.ControlLightLight;
            gorev2basla.ForeColor = Color.Red;
        }


        private void button8_Click(object sender, EventArgs e)
        {
            
            string[] acilar = textBox1.Text.Trim().Split(',');

            if (arkaPlanKopya == null)
            {
                MessageBox.Show("Arka plan resmi yüklenemedi.");
                return;
            }

            if (acilar.Length == 2 &&
                float.TryParse(acilar[0], out float aci1) &&
                float.TryParse(acilar[1], out float aci2))
            {
                // Önceki çizimleri silmek için arka planın temiz kopyasını kullan
                Bitmap yeniGorsel = new Bitmap(arkaPlanKopya);
                Graphics g = Graphics.FromImage(yeniGorsel);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Point merkez = new Point(yeniGorsel.Width , yeniGorsel.Height / 2);
                int uzunluk = 2000;

                Point p1 = AciyaGoreNokta(merkez, uzunluk, aci1);
                Point p2 = AciyaGoreNokta(merkez, uzunluk, aci2);
                Point[] ucgen = new Point[] { merkez, p1, p2 };

                Brush dolgu = new SolidBrush(Color.FromArgb(80, Color.Red));
                Pen kenar = new Pen(Color.Red, 2);

                g.FillPolygon(dolgu, ucgen);
                g.DrawPolygon(kenar, ucgen);

                pictureBox1.Image = yeniGorsel;
            }
            else
            {
                MessageBox.Show("Açıları şu formatta giriniz: -30,60");
            }
        }
        
        private Point AciyaGoreNokta(Point merkez, int uzunluk, float aci)
        {
            double rad = (aci+180) * Math.PI / 180;
            int x = merkez.X + (int)(Math.Cos(rad) * uzunluk);
            int y = merkez.Y + (int)(Math.Sin(rad) * uzunluk);
            return new Point(x, y);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            isTask2Active = !isTask2Active;


            if (comboBox1.SelectedItem != null)
            {

                // Diğer Butonların rengini normala çevir.
                gorev2bitir.ForeColor = SystemColors.ControlLightLight;
                gorev3bitir.ForeColor = SystemColors.ControlLightLight;
                gorev1bitir.ForeColor = SystemColors.ControlLightLight;
                gorev2basla.ForeColor = SystemColors.ControlLightLight;
                gorev3basla.ForeColor = SystemColors.ControlLightLight;
                // Arka plan rengini değiştir
                gorev1basla.ForeColor = Color.Red;


                richTextBox1.AppendText("Görev 1 'e başlandı.\n");
            }
            else
            {
                MessageBox.Show("Lütfen bir Mod Seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
         }

        private void button5_Click(object sender, EventArgs e)
        {
          

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir Mod Seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Video kaynağını durdur
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                videoSource = null;
            }

            // 2. Python başlat
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = @"C:\Users\Busra\AppData\Local\Programs\Python\Python313\python.exe";
                psi.Arguments = @"C:\Users\Busra\Desktop\opencv\birleştirilmis.py";
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Python başlatılamadı:\n" + ex.Message);
            }

            // 3. UDP alım thread’i başlat
            if (!sistemAktif)
            {
                udpClient = new UdpClient();
                udpClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                udpClient.Client.Bind(new IPEndPoint(IPAddress.Any, 5005));

                receiveThread = new Thread(ReceiveImages2);
                receiveThread.IsBackground = true;
                receiveThread.Start();

                // SADECE 1 kere bu yazılar gelsin
                richTextBox1.AppendText("Görev 3'e başlandı.\n");
                richTextBox1.AppendText("Görev 3 kamera görüntüsü başlatıldı.\n");

                sistemAktif = true;
                GuncelleSistemIsigi(true);
            }

            // 4. Buton renkleri
            gorev1basla.ForeColor = SystemColors.ControlLightLight;
            gorev1bitir.ForeColor = SystemColors.ControlLightLight;
            gorev2bitir.ForeColor = SystemColors.ControlLightLight;
            gorev2basla.ForeColor = SystemColors.ControlLightLight;
            gorev3basla.ForeColor = Color.Red;
        }




        private void button6_Click(object sender, EventArgs e)
        {
            isTask2Active = !isTask2Active;
            ucluatıs.ForeColor = SystemColors.ControlLightLight;
            teklıatıs.ForeColor = Color.Red; // Aktif
             // Pasif

            richTextBox1.AppendText("Tekli Atış Modu Aktif.\n");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            isTask2Active = !isTask2Active;
            teklıatıs.ForeColor = SystemColors.ControlLightLight;
            ucluatıs.ForeColor = Color.Red; // Aktif
            // Pasif

            richTextBox1.AppendText("3'lü Atış Modu Aktif.\n");
        }
        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string[] acilar = textBox2.Text.Trim().Split(',');

            if (arkaPlanKopya == null)
            {
                MessageBox.Show("Arka plan resmi yüklenemedi.");
                return;
            }

            if (acilar.Length == 2 &&
                float.TryParse(acilar[0], out float aci1) &&
                float.TryParse(acilar[1], out float aci2))
            {
                // Önceki çizimleri silmek için arka planın temiz kopyasını kullan
                Bitmap yeniGorsel = new Bitmap(arkaPlanKopya);
                Graphics g = Graphics.FromImage(yeniGorsel);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Point merkez = new Point(yeniGorsel.Width, yeniGorsel.Height / 2);
                int uzunluk = 3000;

                Point p1 = AciyaGoreNokta(merkez, uzunluk, aci1);
                Point p2 = AciyaGoreNokta(merkez, uzunluk, aci2);
                Point[] ucgen = new Point[] { merkez, p1, p2 };

                Brush dolgu = new SolidBrush(Color.FromArgb(80, 173, 216, 230)); // Açık mavi (LightBlue) + şeffaf
                Pen kenar = new Pen(Color.FromArgb(180, 70, 130, 180), 2);       // Hafif koyu mavi kenar (SteelBlue) + yarı saydam

                g.FillPolygon(dolgu, ucgen);
                g.DrawPolygon(kenar, ucgen);

                pictureBox2.Image = yeniGorsel;
            }
            else
            {
                MessageBox.Show("Açıları şu formatta giriniz: -30,60");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilen = comboBox1.SelectedItem.ToString();
            richTextBox1.AppendText($">> {secilen} seçildi.\n");

            // Manuel Mod Seçildiğinde, Mod durumunu Otonom yapmadan Otonom Görev Butonlarına tıklanmamaısını sağlar.
            if (secilen == "Manuel Mod")
            {
                gorev2bitir.Enabled = false; 
                gorev1bitir.Enabled = false; 
                gorev3bitir.Enabled = false;
                gorev1basla.Enabled = false;
                gorev2basla.Enabled = false;
                gorev3basla.Enabled = false;
            }
            else {
                gorev2bitir.Enabled = true;
                gorev1bitir.Enabled = true;
                gorev3bitir.Enabled = true;
                gorev1basla.Enabled=true;
                gorev2basla.Enabled=true;
                gorev3basla.Enabled=true;
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("TÜM SİSTEM DURDURULDU !!!!.\n");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            gorev3basla.ForeColor = SystemColors.ControlLightLight;
            gorev2basla.ForeColor = SystemColors.ControlLightLight;
            gorev1basla.ForeColor = SystemColors.ControlLightLight;
           
            // Arka plan rengini değiştir
            gorev1bitir.ForeColor = Color.Red;

            richTextBox1.AppendText("Görev 1 'e bitirildi.\n");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            isTask2Active = !isTask2Active;
       

                if (comboBox1.SelectedItem != null)
                 {   
                

                try
                {
                    // Python açık olabilir, kapat
                    foreach (var process in Process.GetProcessesByName("python"))
                    {
                        process.Kill();
                    }

                    // Önceki video kaynağı varsa kapat
                    if (videoSource != null && videoSource.IsRunning)
                    {
                        videoSource.SignalToStop();
                        videoSource.WaitForStop();
                        videoSource = null;
                    }

                    // Kamera cihazlarını tara
                    videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                    if (videoDevices.Count > 0)
                    {
                        videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                        videoSource.NewFrame += Video_NewFrame;
                        videoSource.Start();
                        richTextBox1.AppendText("Görev 2 bitirildi.\n");
                        richTextBox1.AppendText("Bilgisayar kamerasına geçildi.\n");
                    }
                    else
                    {
                        MessageBox.Show("Kamera bulunamadı.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kamera başlatılırken hata oluştu:\n" + ex.Message);
                }

                // Diğer Butonların rengini normala çevir.
                gorev1basla.ForeColor = SystemColors.ControlLightLight;
                gorev3bitir.ForeColor = SystemColors.ControlLightLight;
                gorev1bitir.ForeColor = SystemColors.ControlLightLight;
                gorev2basla.ForeColor = SystemColors.ControlLightLight;
                gorev3basla.ForeColor = SystemColors.ControlLightLight;
                // Arka plan rengini değiştir
                gorev2bitir.ForeColor = Color.Red;
                sistemAktif = false;
                if (geriSayimTimer != null)
                {
                    geriSayimTimer.Stop();
                }
                kalanSure = 0;
                label4.Text = " 300 s";

            }
            else
            {
                MessageBox.Show("Lütfen bir Mod Seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void button12_Click(object sender, EventArgs e)
        {
            isTask2Active = !isTask2Active;


            if (comboBox1.SelectedItem != null)
            {


                try
                {
                    // Python açık olabilir, kapat
                    foreach (var process in Process.GetProcessesByName("python"))
                    {
                        process.Kill();
                    }

                    // Önceki video kaynağı varsa kapat
                    if (videoSource != null && videoSource.IsRunning)
                    {
                        videoSource.SignalToStop();
                        videoSource.WaitForStop();
                        videoSource = null;
                    }

                    // Kamera cihazlarını tara
                    videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                    if (videoDevices.Count > 0)
                    {
                        videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                        videoSource.NewFrame += Video_NewFrame;
                        videoSource.Start();
                        richTextBox1.AppendText("Görev 3 bitirildi.\n");
                        richTextBox1.AppendText("Bilgisayar kamerasına geçildi.\n");
                    }
                    else
                    {
                        MessageBox.Show("Kamera bulunamadı.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kamera başlatılırken hata oluştu:\n" + ex.Message);
                }

                // Diğer Butonların rengini normala çevir.
                gorev1bitir.ForeColor = SystemColors.ControlLightLight;
                gorev2bitir.ForeColor = SystemColors.ControlLightLight;
                gorev3basla.ForeColor = SystemColors.ControlLightLight;
                gorev2basla.ForeColor = SystemColors.ControlLightLight;
                gorev1basla.ForeColor = SystemColors.ControlLightLight;

                // Arka plan rengini değiştir
                gorev3bitir.ForeColor = Color.Red;


            }
            else
            {
                MessageBox.Show("Lütfen bir Mod Seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
     

            
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 1. UDP kapat
            udpClient?.Close();

            // 2. UDP thread durdur
            if (receiveThread != null && receiveThread.IsAlive)
            {
                try { receiveThread.Abort(); } catch { }
            }

            // 3. C# kamerası varsa kapat
            if (videoSource != null && videoSource.IsRunning)
            {
                try
                {
                    videoSource.SignalToStop();
                    videoSource.WaitForStop();
                    videoSource = null;
                }
                catch { }
            }

            // 4. Tüm python.exe işlemlerini öldür
            foreach (var proc in Process.GetProcessesByName("python"))
            {
                try
                {
                    proc.Kill();
                    proc.WaitForExit();
                }
                catch { }
            }
        }

        


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (sonGelenGorsel != null)
            {
                e.Graphics.DrawImage(sonGelenGorsel, new Rectangle(0, 0, pictureBox3.Width, pictureBox3.Height));
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

    }
    
   }
