namespace havasavunma2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kamera = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gorev1basla = new System.Windows.Forms.Button();
            this.gorev2basla = new System.Windows.Forms.Button();
            this.gorev3basla = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.teklıatıs = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.yasaklıblg = new System.Windows.Forms.Button();
            this.hareket = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sistemidurdur = new System.Windows.Forms.Button();
            this.gorev1bitir = new System.Windows.Forms.Button();
            this.gorev3bitir = new System.Windows.Forms.Button();
            this.gorev2bitir = new System.Windows.Forms.Button();
            this.ucluatıs = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.kameraKapat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // kamera
            // 
            this.kamera.BackColor = System.Drawing.SystemColors.Info;
            this.kamera.Location = new System.Drawing.Point(3, 387);
            this.kamera.Name = "kamera";
            this.kamera.Size = new System.Drawing.Size(375, 32);
            this.kamera.TabIndex = 0;
            this.kamera.Text = "KAMERA AÇ";
            this.kamera.UseVisualStyleBackColor = false;
            this.kamera.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mod Seçimi:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Manuel Mod",
            "Otonom Mod"});
            this.comboBox1.Location = new System.Drawing.Point(195, 424);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(233, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gorev1basla
            // 
            this.gorev1basla.BackColor = System.Drawing.SystemColors.Highlight;
            this.gorev1basla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gorev1basla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gorev1basla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gorev1basla.Location = new System.Drawing.Point(529, 447);
            this.gorev1basla.Name = "gorev1basla";
            this.gorev1basla.Size = new System.Drawing.Size(210, 50);
            this.gorev1basla.TabIndex = 6;
            this.gorev1basla.Text = "GÖREV1";
            this.gorev1basla.UseVisualStyleBackColor = false;
            this.gorev1basla.Click += new System.EventHandler(this.button3_Click);
            // 
            // gorev2basla
            // 
            this.gorev2basla.BackColor = System.Drawing.SystemColors.Highlight;
            this.gorev2basla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gorev2basla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gorev2basla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gorev2basla.Location = new System.Drawing.Point(529, 575);
            this.gorev2basla.Name = "gorev2basla";
            this.gorev2basla.Size = new System.Drawing.Size(210, 50);
            this.gorev2basla.TabIndex = 7;
            this.gorev2basla.Text = "GÖREV2";
            this.gorev2basla.UseVisualStyleBackColor = false;
            this.gorev2basla.Click += new System.EventHandler(this.button4_Click);
            // 
            // gorev3basla
            // 
            this.gorev3basla.BackColor = System.Drawing.SystemColors.Highlight;
            this.gorev3basla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gorev3basla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gorev3basla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gorev3basla.Location = new System.Drawing.Point(529, 700);
            this.gorev3basla.Name = "gorev3basla";
            this.gorev3basla.Size = new System.Drawing.Size(210, 50);
            this.gorev3basla.TabIndex = 8;
            this.gorev3basla.Text = "GÖREV3";
            this.gorev3basla.UseVisualStyleBackColor = false;
            this.gorev3basla.Click += new System.EventHandler(this.button5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(774, 766);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Bullet Count:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(764, 712);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Kalan Süre:";
            // 
            // teklıatıs
            // 
            this.teklıatıs.BackColor = System.Drawing.SystemColors.HotTrack;
            this.teklıatıs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.teklıatıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teklıatıs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.teklıatıs.Location = new System.Drawing.Point(3, 522);
            this.teklıatıs.Name = "teklıatıs";
            this.teklıatıs.Size = new System.Drawing.Size(234, 43);
            this.teklıatıs.TabIndex = 13;
            this.teklıatıs.Text = "TEKLİ ATIŞ";
            this.teklıatıs.UseVisualStyleBackColor = false;
            this.teklıatıs.Click += new System.EventHandler(this.button6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(1135, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Hareket açısı sınırları:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(947, 401);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 22);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1355, 403);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 22);
            this.textBox2.TabIndex = 18;
            // 
            // yasaklıblg
            // 
            this.yasaklıblg.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.yasaklıblg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yasaklıblg.Location = new System.Drawing.Point(947, 429);
            this.yasaklıblg.Name = "yasaklıblg";
            this.yasaklıblg.Size = new System.Drawing.Size(128, 32);
            this.yasaklıblg.TabIndex = 19;
            this.yasaklıblg.Text = "ONAYLA";
            this.yasaklıblg.UseVisualStyleBackColor = false;
            this.yasaklıblg.Click += new System.EventHandler(this.button8_Click);
            // 
            // hareket
            // 
            this.hareket.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.hareket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hareket.Location = new System.Drawing.Point(1355, 431);
            this.hareket.Name = "hareket";
            this.hareket.Size = new System.Drawing.Size(128, 32);
            this.hareket.TabIndex = 20;
            this.hareket.Text = "ONAYLA";
            this.hareket.UseVisualStyleBackColor = false;
            this.hareket.Click += new System.EventHandler(this.button9_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(757, 476);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.richTextBox1.Location = new System.Drawing.Point(765, 36);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(746, 351);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(765, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "SİSTEM AKTİFLİĞİ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1133, 476);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(373, 220);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(910, 762);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(910, 712);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "300 s";
            // 
            // sistemidurdur
            // 
            this.sistemidurdur.BackColor = System.Drawing.Color.Red;
            this.sistemidurdur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sistemidurdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sistemidurdur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sistemidurdur.Location = new System.Drawing.Point(1144, 712);
            this.sistemidurdur.Name = "sistemidurdur";
            this.sistemidurdur.Size = new System.Drawing.Size(217, 93);
            this.sistemidurdur.TabIndex = 30;
            this.sistemidurdur.Text = "SİSTEMİ DURDUR";
            this.sistemidurdur.UseVisualStyleBackColor = false;
            this.sistemidurdur.Click += new System.EventHandler(this.button1_Click);
            // 
            // gorev1bitir
            // 
            this.gorev1bitir.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.gorev1bitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gorev1bitir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gorev1bitir.Location = new System.Drawing.Point(529, 499);
            this.gorev1bitir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gorev1bitir.Name = "gorev1bitir";
            this.gorev1bitir.Size = new System.Drawing.Size(210, 50);
            this.gorev1bitir.TabIndex = 32;
            this.gorev1bitir.Text = "BİTİR";
            this.gorev1bitir.UseVisualStyleBackColor = false;
            this.gorev1bitir.Click += new System.EventHandler(this.button11_Click);
            // 
            // gorev3bitir
            // 
            this.gorev3bitir.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.gorev3bitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gorev3bitir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gorev3bitir.Location = new System.Drawing.Point(529, 751);
            this.gorev3bitir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gorev3bitir.Name = "gorev3bitir";
            this.gorev3bitir.Size = new System.Drawing.Size(210, 50);
            this.gorev3bitir.TabIndex = 33;
            this.gorev3bitir.Text = "BİTİR";
            this.gorev3bitir.UseVisualStyleBackColor = false;
            this.gorev3bitir.Click += new System.EventHandler(this.button12_Click);
            // 
            // gorev2bitir
            // 
            this.gorev2bitir.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.gorev2bitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gorev2bitir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gorev2bitir.Location = new System.Drawing.Point(529, 627);
            this.gorev2bitir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gorev2bitir.Name = "gorev2bitir";
            this.gorev2bitir.Size = new System.Drawing.Size(210, 50);
            this.gorev2bitir.TabIndex = 34;
            this.gorev2bitir.Text = "BİTİR";
            this.gorev2bitir.UseVisualStyleBackColor = false;
            this.gorev2bitir.Click += new System.EventHandler(this.button13_Click);
            // 
            // ucluatıs
            // 
            this.ucluatıs.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ucluatıs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucluatıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ucluatıs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ucluatıs.Location = new System.Drawing.Point(249, 525);
            this.ucluatıs.Name = "ucluatıs";
            this.ucluatıs.Size = new System.Drawing.Size(244, 43);
            this.ucluatıs.TabIndex = 35;
            this.ucluatıs.Text = "3\'LÜ ATIŞ";
            this.ucluatıs.UseVisualStyleBackColor = false;
            this.ucluatıs.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(928, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(57, 28);
            this.panel2.TabIndex = 26;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.Location = new System.Drawing.Point(7, 5);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(753, 380);
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1390, 712);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(129, 108);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(3, 575);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(511, 229);
            this.pictureBox5.TabIndex = 39;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(1084, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(83, 30);
            this.pictureBox6.TabIndex = 40;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(1173, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(69, 30);
            this.pictureBox7.TabIndex = 41;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(1248, 3);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(81, 30);
            this.pictureBox8.TabIndex = 42;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(1335, 3);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(82, 30);
            this.pictureBox9.TabIndex = 43;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(1423, 3);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(88, 30);
            this.pictureBox10.TabIndex = 44;
            this.pictureBox10.TabStop = false;
            // 
            // kameraKapat
            // 
            this.kameraKapat.BackColor = System.Drawing.SystemColors.Info;
            this.kameraKapat.Location = new System.Drawing.Point(384, 387);
            this.kameraKapat.Name = "kameraKapat";
            this.kameraKapat.Size = new System.Drawing.Size(375, 32);
            this.kameraKapat.TabIndex = 45;
            this.kameraKapat.Text = "KAMERA KAPAT";
            this.kameraKapat.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(249, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 43);
            this.button1.TabIndex = 46;
            this.button1.Text = "TAM OTOMATİK ATIŞ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(3, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 43);
            this.button2.TabIndex = 47;
            this.button2.Text = "GÜVENLİ MOD";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(764, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Ateş açısı sınırları:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1517, 816);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kameraKapat);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.kamera);
            this.Controls.Add(this.ucluatıs);
            this.Controls.Add(this.gorev2bitir);
            this.Controls.Add(this.gorev3bitir);
            this.Controls.Add(this.gorev1bitir);
            this.Controls.Add(this.sistemidurdur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hareket);
            this.Controls.Add(this.yasaklıblg);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.teklıatıs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gorev3basla);
            this.Controls.Add(this.gorev2basla);
            this.Controls.Add(this.gorev1basla);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hava Savunma Sistemleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button kamera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button gorev1basla;
        private System.Windows.Forms.Button gorev2basla;
        private System.Windows.Forms.Button gorev3basla;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button teklıatıs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button yasaklıblg;
        private System.Windows.Forms.Button hareket;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sistemidurdur;
        private System.Windows.Forms.Button gorev1bitir;
        private System.Windows.Forms.Button gorev3bitir;
        private System.Windows.Forms.Button gorev2bitir;
        private System.Windows.Forms.Button ucluatıs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Button kameraKapat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
    }
}

