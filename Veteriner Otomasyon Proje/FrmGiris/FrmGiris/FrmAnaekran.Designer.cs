namespace FrmGiris
{
    partial class FrmAnaekran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaekran));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnMuayeneForm = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.RbtnKisir = new System.Windows.Forms.RadioButton();
            this.RbtnDisi = new System.Windows.Forms.RadioButton();
            this.RbtnErkek = new System.Windows.Forms.RadioButton();
            this.MskDogumTarih = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtRenk = new System.Windows.Forms.TextBox();
            this.CmbCins = new System.Windows.Forms.ComboBox();
            this.MskRandevuTarihi = new System.Windows.Forms.MaskedTextBox();
            this.MskMikrocip = new System.Windows.Forms.MaskedTextBox();
            this.TxtPetAd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MskTelNo = new System.Windows.Forms.MaskedTextBox();
            this.RtxtAdres = new System.Windows.Forms.RichTextBox();
            this.MskTcNo = new System.Windows.Forms.MaskedTextBox();
            this.TxtSahipSoyad = new System.Windows.Forms.TextBox();
            this.TxtSahipAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(1859, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(12, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1900, 38);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.BtnMuayeneForm, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1625, 953);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(149, 93);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // BtnMuayeneForm
            // 
            this.BtnMuayeneForm.BackColor = System.Drawing.Color.Maroon;
            this.BtnMuayeneForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMuayeneForm.BackgroundImage")));
            this.BtnMuayeneForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMuayeneForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMuayeneForm.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.BtnMuayeneForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMuayeneForm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMuayeneForm.Location = new System.Drawing.Point(3, 3);
            this.BtnMuayeneForm.Name = "BtnMuayeneForm";
            this.BtnMuayeneForm.Size = new System.Drawing.Size(143, 87);
            this.BtnMuayeneForm.TabIndex = 9;
            this.BtnMuayeneForm.Text = "Muayene Formu";
            this.BtnMuayeneForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnMuayeneForm.UseVisualStyleBackColor = false;
            this.BtnMuayeneForm.Click += new System.EventHandler(this.BtnMuayeneForm_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.BtnKaydet);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.RbtnKisir);
            this.groupBox2.Controls.Add(this.RbtnDisi);
            this.groupBox2.Controls.Add(this.RbtnErkek);
            this.groupBox2.Controls.Add(this.MskDogumTarih);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.TxtRenk);
            this.groupBox2.Controls.Add(this.CmbCins);
            this.groupBox2.Controls.Add(this.MskRandevuTarihi);
            this.groupBox2.Controls.Add(this.MskMikrocip);
            this.groupBox2.Controls.Add(this.TxtPetAd);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Sans Serif Collection", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox2.Location = new System.Drawing.Point(1424, 420);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 514);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pet Bilgileri";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.Maroon;
            this.BtnKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.BackgroundImage")));
            this.BtnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKaydet.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.BtnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKaydet.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.ForeColor = System.Drawing.Color.Maroon;
            this.BtnKaydet.Location = new System.Drawing.Point(201, 395);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(105, 86);
            this.BtnKaydet.TabIndex = 26;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.DarkOrange;
            this.label12.Location = new System.Drawing.Point(50, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 29);
            this.label12.TabIndex = 25;
            this.label12.Text = "Cinsiyet:";
            // 
            // RbtnKisir
            // 
            this.RbtnKisir.AutoSize = true;
            this.RbtnKisir.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RbtnKisir.Location = new System.Drawing.Point(289, 281);
            this.RbtnKisir.Name = "RbtnKisir";
            this.RbtnKisir.Size = new System.Drawing.Size(57, 23);
            this.RbtnKisir.TabIndex = 24;
            this.RbtnKisir.TabStop = true;
            this.RbtnKisir.Text = "Kısır";
            this.RbtnKisir.UseVisualStyleBackColor = true;
            // 
            // RbtnDisi
            // 
            this.RbtnDisi.AutoSize = true;
            this.RbtnDisi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RbtnDisi.Location = new System.Drawing.Point(230, 281);
            this.RbtnDisi.Name = "RbtnDisi";
            this.RbtnDisi.Size = new System.Drawing.Size(53, 23);
            this.RbtnDisi.TabIndex = 23;
            this.RbtnDisi.TabStop = true;
            this.RbtnDisi.Text = "Dişi";
            this.RbtnDisi.UseVisualStyleBackColor = true;
            // 
            // RbtnErkek
            // 
            this.RbtnErkek.AutoSize = true;
            this.RbtnErkek.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RbtnErkek.Location = new System.Drawing.Point(158, 281);
            this.RbtnErkek.Name = "RbtnErkek";
            this.RbtnErkek.Size = new System.Drawing.Size(66, 23);
            this.RbtnErkek.TabIndex = 22;
            this.RbtnErkek.TabStop = true;
            this.RbtnErkek.Text = "Erkek";
            this.RbtnErkek.UseVisualStyleBackColor = true;
            // 
            // MskDogumTarih
            // 
            this.MskDogumTarih.BackColor = System.Drawing.Color.DarkOrange;
            this.MskDogumTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskDogumTarih.ForeColor = System.Drawing.Color.Maroon;
            this.MskDogumTarih.Location = new System.Drawing.Point(201, 187);
            this.MskDogumTarih.Mask = "00/00/0000";
            this.MskDogumTarih.Name = "MskDogumTarih";
            this.MskDogumTarih.Size = new System.Drawing.Size(183, 26);
            this.MskDogumTarih.TabIndex = 21;
            this.MskDogumTarih.ValidatingType = typeof(System.DateTime);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.DarkOrange;
            this.label11.Location = new System.Drawing.Point(15, 338);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 29);
            this.label11.TabIndex = 20;
            this.label11.Text = "Randevu Tarihi:";
            // 
            // TxtRenk
            // 
            this.TxtRenk.BackColor = System.Drawing.Color.DarkOrange;
            this.TxtRenk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtRenk.ForeColor = System.Drawing.Color.Maroon;
            this.TxtRenk.Location = new System.Drawing.Point(201, 144);
            this.TxtRenk.Name = "TxtRenk";
            this.TxtRenk.Size = new System.Drawing.Size(183, 26);
            this.TxtRenk.TabIndex = 12;
            // 
            // CmbCins
            // 
            this.CmbCins.BackColor = System.Drawing.Color.DarkOrange;
            this.CmbCins.Font = new System.Drawing.Font("Sans Serif Collection", 5.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCins.ForeColor = System.Drawing.Color.Maroon;
            this.CmbCins.FormattingEnabled = true;
            this.CmbCins.Items.AddRange(new object[] {
            "Köpek",
            "Kedi",
            "Kuş",
            "Balık",
            "Kertenkele",
            "Tavşan",
            "Hamster"});
            this.CmbCins.Location = new System.Drawing.Point(201, 101);
            this.CmbCins.Name = "CmbCins";
            this.CmbCins.Size = new System.Drawing.Size(183, 28);
            this.CmbCins.TabIndex = 11;
            // 
            // MskRandevuTarihi
            // 
            this.MskRandevuTarihi.BackColor = System.Drawing.Color.DarkOrange;
            this.MskRandevuTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskRandevuTarihi.ForeColor = System.Drawing.Color.Maroon;
            this.MskRandevuTarihi.Location = new System.Drawing.Point(201, 338);
            this.MskRandevuTarihi.Mask = "00/00/0000";
            this.MskRandevuTarihi.Name = "MskRandevuTarihi";
            this.MskRandevuTarihi.Size = new System.Drawing.Size(183, 26);
            this.MskRandevuTarihi.TabIndex = 10;
            this.MskRandevuTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // MskMikrocip
            // 
            this.MskMikrocip.BackColor = System.Drawing.Color.DarkOrange;
            this.MskMikrocip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskMikrocip.ForeColor = System.Drawing.Color.Maroon;
            this.MskMikrocip.Location = new System.Drawing.Point(201, 231);
            this.MskMikrocip.Mask = "000000000000000";
            this.MskMikrocip.Name = "MskMikrocip";
            this.MskMikrocip.Size = new System.Drawing.Size(183, 26);
            this.MskMikrocip.TabIndex = 9;
            this.MskMikrocip.ValidatingType = typeof(int);
            // 
            // TxtPetAd
            // 
            this.TxtPetAd.BackColor = System.Drawing.Color.DarkOrange;
            this.TxtPetAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPetAd.ForeColor = System.Drawing.Color.Maroon;
            this.TxtPetAd.Location = new System.Drawing.Point(201, 64);
            this.TxtPetAd.Name = "TxtPetAd";
            this.TxtPetAd.Size = new System.Drawing.Size(183, 26);
            this.TxtPetAd.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.DarkOrange;
            this.label10.Location = new System.Drawing.Point(50, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 29);
            this.label10.TabIndex = 5;
            this.label10.Text = "Mikroçip No:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.DarkOrange;
            this.label9.Location = new System.Drawing.Point(32, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 29);
            this.label9.TabIndex = 4;
            this.label9.Text = "Doğum Tarihi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.DarkOrange;
            this.label8.Location = new System.Drawing.Point(121, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 29);
            this.label8.TabIndex = 3;
            this.label8.Text = "Renk:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(131, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "Cins:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(105, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Pet Ad:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MskTelNo);
            this.groupBox1.Controls.Add(this.RtxtAdres);
            this.groupBox1.Controls.Add(this.MskTcNo);
            this.groupBox1.Controls.Add(this.TxtSahipSoyad);
            this.groupBox1.Controls.Add(this.TxtSahipAd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Sans Serif Collection", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Location = new System.Drawing.Point(1424, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 367);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pet Sahibi Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // MskTelNo
            // 
            this.MskTelNo.BackColor = System.Drawing.Color.DarkOrange;
            this.MskTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTelNo.ForeColor = System.Drawing.Color.Maroon;
            this.MskTelNo.Location = new System.Drawing.Point(206, 181);
            this.MskTelNo.Mask = "(999) 000-0000";
            this.MskTelNo.Name = "MskTelNo";
            this.MskTelNo.Size = new System.Drawing.Size(183, 26);
            this.MskTelNo.TabIndex = 4;
            this.MskTelNo.ValidatingType = typeof(System.DateTime);
            // 
            // RtxtAdres
            // 
            this.RtxtAdres.BackColor = System.Drawing.Color.DarkOrange;
            this.RtxtAdres.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RtxtAdres.ForeColor = System.Drawing.Color.Maroon;
            this.RtxtAdres.Location = new System.Drawing.Point(128, 248);
            this.RtxtAdres.Name = "RtxtAdres";
            this.RtxtAdres.Size = new System.Drawing.Size(263, 107);
            this.RtxtAdres.TabIndex = 5;
            this.RtxtAdres.Text = "";
            // 
            // MskTcNo
            // 
            this.MskTcNo.BackColor = System.Drawing.Color.DarkOrange;
            this.MskTcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTcNo.ForeColor = System.Drawing.Color.Maroon;
            this.MskTcNo.Location = new System.Drawing.Point(208, 144);
            this.MskTcNo.Mask = "00000000000";
            this.MskTcNo.Name = "MskTcNo";
            this.MskTcNo.Size = new System.Drawing.Size(183, 26);
            this.MskTcNo.TabIndex = 3;
            this.MskTcNo.ValidatingType = typeof(int);
            // 
            // TxtSahipSoyad
            // 
            this.TxtSahipSoyad.BackColor = System.Drawing.Color.DarkOrange;
            this.TxtSahipSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSahipSoyad.ForeColor = System.Drawing.Color.Maroon;
            this.TxtSahipSoyad.Location = new System.Drawing.Point(209, 103);
            this.TxtSahipSoyad.Name = "TxtSahipSoyad";
            this.TxtSahipSoyad.Size = new System.Drawing.Size(180, 26);
            this.TxtSahipSoyad.TabIndex = 2;
            // 
            // TxtSahipAd
            // 
            this.TxtSahipAd.BackColor = System.Drawing.Color.DarkOrange;
            this.TxtSahipAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSahipAd.ForeColor = System.Drawing.Color.Maroon;
            this.TxtSahipAd.Location = new System.Drawing.Point(209, 61);
            this.TxtSahipAd.Name = "TxtSahipAd";
            this.TxtSahipAd.Size = new System.Drawing.Size(180, 26);
            this.TxtSahipAd.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(113, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tel No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(123, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(118, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(118, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(155, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Sans Serif Collection", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox3.Location = new System.Drawing.Point(12, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1406, 1041);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevular";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1400, 975);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FrmAnaekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1940, 1100);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAnaekran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmAnaekran_Load);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnMuayeneForm;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox MskDogumTarih;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtRenk;
        private System.Windows.Forms.ComboBox CmbCins;
        private System.Windows.Forms.MaskedTextBox MskRandevuTarihi;
        private System.Windows.Forms.MaskedTextBox MskMikrocip;
        private System.Windows.Forms.TextBox TxtPetAd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox MskTelNo;
        private System.Windows.Forms.RichTextBox RtxtAdres;
        private System.Windows.Forms.MaskedTextBox MskTcNo;
        private System.Windows.Forms.TextBox TxtSahipSoyad;
        private System.Windows.Forms.TextBox TxtSahipAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton RbtnErkek;
        private System.Windows.Forms.RadioButton RbtnDisi;
        private System.Windows.Forms.RadioButton RbtnKisir;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtnKaydet;
    }
}