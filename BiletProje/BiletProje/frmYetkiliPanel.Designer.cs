namespace BiletProje
{
    partial class frmYetkiliPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYetkiliPanel));
            this.rchDuyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDuyuruOlustur = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnYetkiliAtama = new System.Windows.Forms.Button();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSeferSil = new System.Windows.Forms.Button();
            this.btnSeferGüncelle = new System.Windows.Forms.Button();
            this.btnSeferDüzenle = new System.Windows.Forms.Button();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtYolculukSüre = new System.Windows.Forms.TextBox();
            this.mskSaat = new System.Windows.Forms.MaskedTextBox();
            this.cmbNereye = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mskTarih = new System.Windows.Forms.MaskedTextBox();
            this.cmbNereden = new System.Windows.Forms.ComboBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rchDuyuru
            // 
            this.rchDuyuru.Location = new System.Drawing.Point(31, 35);
            this.rchDuyuru.Name = "rchDuyuru";
            this.rchDuyuru.Size = new System.Drawing.Size(325, 127);
            this.rchDuyuru.TabIndex = 2;
            this.rchDuyuru.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDuyuruOlustur);
            this.groupBox1.Controls.Add(this.rchDuyuru);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 209);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Duyuru";
            // 
            // btnDuyuruOlustur
            // 
            this.btnDuyuruOlustur.Location = new System.Drawing.Point(143, 171);
            this.btnDuyuruOlustur.Name = "btnDuyuruOlustur";
            this.btnDuyuruOlustur.Size = new System.Drawing.Size(87, 32);
            this.btnDuyuruOlustur.TabIndex = 7;
            this.btnDuyuruOlustur.Text = "Oluştur";
            this.btnDuyuruOlustur.UseVisualStyleBackColor = true;
            this.btnDuyuruOlustur.Click += new System.EventHandler(this.btnDuyuruOlustur_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnYetkiliAtama);
            this.groupBox2.Controls.Add(this.mskTC);
            this.groupBox2.Controls.Add(this.txtSoyad);
            this.groupBox2.Controls.Add(this.txtAd);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 206);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yetkili Bilgileri";
            // 
            // btnYetkiliAtama
            // 
            this.btnYetkiliAtama.Location = new System.Drawing.Point(112, 168);
            this.btnYetkiliAtama.Name = "btnYetkiliAtama";
            this.btnYetkiliAtama.Size = new System.Drawing.Size(144, 32);
            this.btnYetkiliAtama.TabIndex = 13;
            this.btnYetkiliAtama.Text = "Yetkili İşlemleri";
            this.btnYetkiliAtama.UseVisualStyleBackColor = true;
            this.btnYetkiliAtama.Click += new System.EventHandler(this.btnYetkiliAtama_Click);
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(127, 117);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(114, 27);
            this.mskTC.TabIndex = 11;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(127, 77);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(114, 27);
            this.txtSoyad.TabIndex = 12;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(127, 37);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(114, 27);
            this.txtAd.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ad:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSeferSil);
            this.groupBox4.Controls.Add(this.btnSeferGüncelle);
            this.groupBox4.Controls.Add(this.btnSeferDüzenle);
            this.groupBox4.Controls.Add(this.txtFiyat);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtYolculukSüre);
            this.groupBox4.Controls.Add(this.mskSaat);
            this.groupBox4.Controls.Add(this.cmbNereye);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.mskTarih);
            this.groupBox4.Controls.Add(this.cmbNereden);
            this.groupBox4.Controls.Add(this.txtid);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(399, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(313, 443);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Otobüs Seferi Oluşturma Paneli";
            // 
            // btnSeferSil
            // 
            this.btnSeferSil.Location = new System.Drawing.Point(95, 380);
            this.btnSeferSil.Name = "btnSeferSil";
            this.btnSeferSil.Size = new System.Drawing.Size(144, 32);
            this.btnSeferSil.TabIndex = 9;
            this.btnSeferSil.Text = "Sefer Sil";
            this.btnSeferSil.UseVisualStyleBackColor = true;
            this.btnSeferSil.Click += new System.EventHandler(this.btnSeferSil_Click);
            // 
            // btnSeferGüncelle
            // 
            this.btnSeferGüncelle.Location = new System.Drawing.Point(95, 335);
            this.btnSeferGüncelle.Name = "btnSeferGüncelle";
            this.btnSeferGüncelle.Size = new System.Drawing.Size(144, 32);
            this.btnSeferGüncelle.TabIndex = 8;
            this.btnSeferGüncelle.Text = "Sefer Güncelle";
            this.btnSeferGüncelle.UseVisualStyleBackColor = true;
            this.btnSeferGüncelle.Click += new System.EventHandler(this.btnSeferGüncelle_Click);
            // 
            // btnSeferDüzenle
            // 
            this.btnSeferDüzenle.Location = new System.Drawing.Point(95, 289);
            this.btnSeferDüzenle.Name = "btnSeferDüzenle";
            this.btnSeferDüzenle.Size = new System.Drawing.Size(144, 32);
            this.btnSeferDüzenle.TabIndex = 7;
            this.btnSeferDüzenle.Text = "Sefer Düzenle";
            this.btnSeferDüzenle.UseVisualStyleBackColor = true;
            this.btnSeferDüzenle.Click += new System.EventHandler(this.btnSeferDüzenle_Click);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(141, 237);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(130, 27);
            this.txtFiyat.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(77, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 19);
            this.label10.TabIndex = 25;
            this.label10.Text = "Fiyat:";
            // 
            // txtYolculukSüre
            // 
            this.txtYolculukSüre.Location = new System.Drawing.Point(141, 200);
            this.txtYolculukSüre.Name = "txtYolculukSüre";
            this.txtYolculukSüre.Size = new System.Drawing.Size(130, 27);
            this.txtYolculukSüre.TabIndex = 5;
            // 
            // mskSaat
            // 
            this.mskSaat.Location = new System.Drawing.Point(141, 167);
            this.mskSaat.Mask = "00:00";
            this.mskSaat.Name = "mskSaat";
            this.mskSaat.Size = new System.Drawing.Size(130, 27);
            this.mskSaat.TabIndex = 4;
            this.mskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // cmbNereye
            // 
            this.cmbNereye.FormattingEnabled = true;
            this.cmbNereye.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara",
            "Adana",
            "Amasya",
            "Mersin",
            "Kastamonu",
            "Ağrı",
            "Diyarbakır",
            "İzmir",
            "Kocaeli",
            "Gaziantep",
            "Şanlıurfa",
            "Adıyaman",
            "Bursa",
            "Edirne",
            "Antalya",
            "Eskişehir",
            "Bilecik",
            "Yalova",
            "Batman"});
            this.cmbNereye.Location = new System.Drawing.Point(141, 101);
            this.cmbNereye.Name = "cmbNereye";
            this.cmbNereye.Size = new System.Drawing.Size(130, 27);
            this.cmbNereye.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Yolculuk Süresi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Saat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tarih:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Nereye:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Nereden:";
            // 
            // mskTarih
            // 
            this.mskTarih.Location = new System.Drawing.Point(141, 134);
            this.mskTarih.Mask = "00/00/0000";
            this.mskTarih.Name = "mskTarih";
            this.mskTarih.Size = new System.Drawing.Size(130, 27);
            this.mskTarih.TabIndex = 3;
            this.mskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // cmbNereden
            // 
            this.cmbNereden.FormattingEnabled = true;
            this.cmbNereden.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara",
            "Adana",
            "Amasya",
            "Mersin",
            "Kastamonu",
            "Ağrı",
            "Diyarbakır",
            "İzmir",
            "Kocaeli",
            "Gaziantep",
            "Şanlıurfa",
            "Adıyaman",
            "Bursa",
            "Edirne",
            "Antalya",
            "Eskişehir",
            "Bilecik",
            "Yalova",
            "Batman"});
            this.cmbNereden.Location = new System.Drawing.Point(141, 68);
            this.cmbNereden.Name = "cmbNereden";
            this.cmbNereden.Size = new System.Drawing.Size(130, 27);
            this.cmbNereden.TabIndex = 1;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(141, 35);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(130, 27);
            this.txtid.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(91, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(718, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(694, 443);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seferler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(688, 417);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // frmYetkiliPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1421, 461);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmYetkiliPanel";
            this.Text = "frmYetkiliPanel";
            this.Load += new System.EventHandler(this.frmYetkiliPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rchDuyuru;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDuyuruOlustur;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYetkiliAtama;
        private System.Windows.Forms.TextBox txtYolculukSüre;
        private System.Windows.Forms.MaskedTextBox mskSaat;
        private System.Windows.Forms.ComboBox cmbNereye;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskTarih;
        private System.Windows.Forms.ComboBox cmbNereden;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSeferSil;
        private System.Windows.Forms.Button btnSeferGüncelle;
        private System.Windows.Forms.Button btnSeferDüzenle;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}