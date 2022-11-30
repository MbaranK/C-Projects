namespace kisiKayit
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.cmbSehir = new System.Windows.Forms.ComboBox();
            this.mskMaas = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnGrafik = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.txtMeslek = new System.Windows.Forms.TextBox();
            this.btnİstatistik = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kisiListesiDataSet = new kisiKayit.KisiListesiDataSet();
            this.tblKisiListesiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_KisiListesiTableAdapter = new kisiKayit.KisiListesiDataSetTableAdapters.tbl_KisiListesiTableAdapter();
            this.kisiListesiDataSet1 = new kisiKayit.KisiListesiDataSet1();
            this.tblKisiListesiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_KisiListesiTableAdapter1 = new kisiKayit.KisiListesiDataSet1TableAdapters.tbl_KisiListesiTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kisiListesiDataSet2 = new kisiKayit.KisiListesiDataSet2();
            this.tblKisiListesiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_KisiListesiTableAdapter2 = new kisiKayit.KisiListesiDataSet2TableAdapters.tbl_KisiListesiTableAdapter();
            this.kisiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kisiAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kisiSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kisiMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kisiMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kisiMedeniDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.kisiSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kisiYasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeşilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beyazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kisiListesiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKisiListesiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kisiListesiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKisiListesiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kisiListesiDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKisiListesiBindingSource2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(140, 26);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(117, 27);
            this.txtId.TabIndex = 1;
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.IndianRed;
            this.btnListele.Location = new System.Drawing.Point(420, 56);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(100, 30);
            this.btnListele.TabIndex = 7;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbSehir
            // 
            this.cmbSehir.FormattingEnabled = true;
            this.cmbSehir.Items.AddRange(new object[] {
            "İstanbul",
            "Kocaeli",
            "Bursa",
            "Adana",
            "Trabzon",
            "Aydın",
            "Manisa",
            "Samsun"});
            this.cmbSehir.Location = new System.Drawing.Point(140, 270);
            this.cmbSehir.Name = "cmbSehir";
            this.cmbSehir.Size = new System.Drawing.Size(121, 27);
            this.cmbSehir.TabIndex = 6;
            // 
            // mskMaas
            // 
            this.mskMaas.Location = new System.Drawing.Point(140, 188);
            this.mskMaas.Mask = "0000";
            this.mskMaas.Name = "mskMaas";
            this.mskMaas.Size = new System.Drawing.Size(117, 27);
            this.mskMaas.TabIndex = 5;
            this.mskMaas.ValidatingType = typeof(int);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtYas);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.btnListele);
            this.groupBox1.Controls.Add(this.btnGrafik);
            this.groupBox1.Controls.Add(this.cmbSehir);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.btnGüncelle);
            this.groupBox1.Controls.Add(this.txtMeslek);
            this.groupBox1.Controls.Add(this.btnİstatistik);
            this.groupBox1.Controls.Add(this.mskMaas);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 344);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Kayıt Ekranı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(427, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 26);
            this.label8.TabIndex = 19;
            this.label8.Text = "İşlemler";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.IndianRed;
            this.btnTemizle.Location = new System.Drawing.Point(420, 218);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(100, 30);
            this.btnTemizle.TabIndex = 11;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(197, 232);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(64, 23);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Bekar";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnGrafik
            // 
            this.btnGrafik.BackColor = System.Drawing.Color.IndianRed;
            this.btnGrafik.Location = new System.Drawing.Point(420, 300);
            this.btnGrafik.Name = "btnGrafik";
            this.btnGrafik.Size = new System.Drawing.Size(100, 30);
            this.btnGrafik.TabIndex = 13;
            this.btnGrafik.Text = "Grafik";
            this.btnGrafik.UseVisualStyleBackColor = false;
            this.btnGrafik.Click += new System.EventHandler(this.btnGrafik_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.IndianRed;
            this.btnKaydet.Location = new System.Drawing.Point(420, 99);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 30);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(140, 232);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 23);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Evli";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.IndianRed;
            this.btnGüncelle.Location = new System.Drawing.Point(420, 139);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(100, 30);
            this.btnGüncelle.TabIndex = 9;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // txtMeslek
            // 
            this.txtMeslek.Location = new System.Drawing.Point(140, 148);
            this.txtMeslek.Name = "txtMeslek";
            this.txtMeslek.Size = new System.Drawing.Size(117, 27);
            this.txtMeslek.TabIndex = 4;
            // 
            // btnİstatistik
            // 
            this.btnİstatistik.BackColor = System.Drawing.Color.IndianRed;
            this.btnİstatistik.Location = new System.Drawing.Point(420, 258);
            this.btnİstatistik.Name = "btnİstatistik";
            this.btnİstatistik.Size = new System.Drawing.Size(100, 30);
            this.btnİstatistik.TabIndex = 12;
            this.btnİstatistik.Text = "İstatistik";
            this.btnİstatistik.UseVisualStyleBackColor = false;
            this.btnİstatistik.Click += new System.EventHandler(this.btnİstatistik_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.IndianRed;
            this.btnSil.Location = new System.Drawing.Point(420, 178);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 30);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(140, 109);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(117, 27);
            this.txtSoyad.TabIndex = 3;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(140, 69);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(117, 27);
            this.txtAd.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Şehir:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Medeni Durum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Maaş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Meslek:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(862, 246);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(630, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 333);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // kisiListesiDataSet
            // 
            this.kisiListesiDataSet.DataSetName = "KisiListesiDataSet";
            this.kisiListesiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblKisiListesiBindingSource
            // 
            this.tblKisiListesiBindingSource.DataMember = "tbl_KisiListesi";
            this.tblKisiListesiBindingSource.DataSource = this.kisiListesiDataSet;
            // 
            // tbl_KisiListesiTableAdapter
            // 
            this.tbl_KisiListesiTableAdapter.ClearBeforeFill = true;
            // 
            // kisiListesiDataSet1
            // 
            this.kisiListesiDataSet1.DataSetName = "KisiListesiDataSet1";
            this.kisiListesiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblKisiListesiBindingSource1
            // 
            this.tblKisiListesiBindingSource1.DataMember = "tbl_KisiListesi";
            this.tblKisiListesiBindingSource1.DataSource = this.kisiListesiDataSet1;
            // 
            // tbl_KisiListesiTableAdapter1
            // 
            this.tbl_KisiListesiTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kisiidDataGridViewTextBoxColumn,
            this.kisiAdDataGridViewTextBoxColumn,
            this.kisiSoyadDataGridViewTextBoxColumn,
            this.kisiMeslekDataGridViewTextBoxColumn,
            this.kisiMaasDataGridViewTextBoxColumn,
            this.kisiMedeniDataGridViewCheckBoxColumn,
            this.kisiSehirDataGridViewTextBoxColumn,
            this.kisiYasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblKisiListesiBindingSource2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(856, 220);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // kisiListesiDataSet2
            // 
            this.kisiListesiDataSet2.DataSetName = "KisiListesiDataSet2";
            this.kisiListesiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblKisiListesiBindingSource2
            // 
            this.tblKisiListesiBindingSource2.DataMember = "tbl_KisiListesi";
            this.tblKisiListesiBindingSource2.DataSource = this.kisiListesiDataSet2;
            // 
            // tbl_KisiListesiTableAdapter2
            // 
            this.tbl_KisiListesiTableAdapter2.ClearBeforeFill = true;
            // 
            // kisiidDataGridViewTextBoxColumn
            // 
            this.kisiidDataGridViewTextBoxColumn.DataPropertyName = "kisiid";
            this.kisiidDataGridViewTextBoxColumn.HeaderText = "kisiid";
            this.kisiidDataGridViewTextBoxColumn.Name = "kisiidDataGridViewTextBoxColumn";
            this.kisiidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kisiAdDataGridViewTextBoxColumn
            // 
            this.kisiAdDataGridViewTextBoxColumn.DataPropertyName = "kisiAd";
            this.kisiAdDataGridViewTextBoxColumn.HeaderText = "kisiAd";
            this.kisiAdDataGridViewTextBoxColumn.Name = "kisiAdDataGridViewTextBoxColumn";
            // 
            // kisiSoyadDataGridViewTextBoxColumn
            // 
            this.kisiSoyadDataGridViewTextBoxColumn.DataPropertyName = "kisiSoyad";
            this.kisiSoyadDataGridViewTextBoxColumn.HeaderText = "kisiSoyad";
            this.kisiSoyadDataGridViewTextBoxColumn.Name = "kisiSoyadDataGridViewTextBoxColumn";
            // 
            // kisiMeslekDataGridViewTextBoxColumn
            // 
            this.kisiMeslekDataGridViewTextBoxColumn.DataPropertyName = "kisiMeslek";
            this.kisiMeslekDataGridViewTextBoxColumn.HeaderText = "kisiMeslek";
            this.kisiMeslekDataGridViewTextBoxColumn.Name = "kisiMeslekDataGridViewTextBoxColumn";
            // 
            // kisiMaasDataGridViewTextBoxColumn
            // 
            this.kisiMaasDataGridViewTextBoxColumn.DataPropertyName = "kisiMaas";
            this.kisiMaasDataGridViewTextBoxColumn.HeaderText = "kisiMaas";
            this.kisiMaasDataGridViewTextBoxColumn.Name = "kisiMaasDataGridViewTextBoxColumn";
            // 
            // kisiMedeniDataGridViewCheckBoxColumn
            // 
            this.kisiMedeniDataGridViewCheckBoxColumn.DataPropertyName = "kisiMedeni";
            this.kisiMedeniDataGridViewCheckBoxColumn.HeaderText = "kisiMedeni";
            this.kisiMedeniDataGridViewCheckBoxColumn.Name = "kisiMedeniDataGridViewCheckBoxColumn";
            // 
            // kisiSehirDataGridViewTextBoxColumn
            // 
            this.kisiSehirDataGridViewTextBoxColumn.DataPropertyName = "kisiSehir";
            this.kisiSehirDataGridViewTextBoxColumn.HeaderText = "kisiSehir";
            this.kisiSehirDataGridViewTextBoxColumn.Name = "kisiSehirDataGridViewTextBoxColumn";
            // 
            // kisiYasDataGridViewTextBoxColumn
            // 
            this.kisiYasDataGridViewTextBoxColumn.DataPropertyName = "kisiYas";
            this.kisiYasDataGridViewTextBoxColumn.HeaderText = "kisiYas";
            this.kisiYasDataGridViewTextBoxColumn.Name = "kisiYasDataGridViewTextBoxColumn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(281, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "label9";
            this.label9.Visible = false;
            this.label9.TextChanged += new System.EventHandler(this.label9_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(82, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "Yaş:";
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(140, 308);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(121, 27);
            this.txtYas.TabIndex = 22;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayarlarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renkToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // renkToolStripMenuItem
            // 
            this.renkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maviToolStripMenuItem,
            this.yeşilToolStripMenuItem,
            this.beyazToolStripMenuItem,
            this.griToolStripMenuItem});
            this.renkToolStripMenuItem.Name = "renkToolStripMenuItem";
            this.renkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.renkToolStripMenuItem.Text = "Renk";
            // 
            // maviToolStripMenuItem
            // 
            this.maviToolStripMenuItem.Name = "maviToolStripMenuItem";
            this.maviToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.maviToolStripMenuItem.Text = "Mavi";
            this.maviToolStripMenuItem.Click += new System.EventHandler(this.maviToolStripMenuItem_Click);
            // 
            // yeşilToolStripMenuItem
            // 
            this.yeşilToolStripMenuItem.Name = "yeşilToolStripMenuItem";
            this.yeşilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeşilToolStripMenuItem.Text = "Yeşil";
            this.yeşilToolStripMenuItem.Click += new System.EventHandler(this.yeşilToolStripMenuItem_Click);
            // 
            // beyazToolStripMenuItem
            // 
            this.beyazToolStripMenuItem.Name = "beyazToolStripMenuItem";
            this.beyazToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.beyazToolStripMenuItem.Text = "Beyaz";
            this.beyazToolStripMenuItem.Click += new System.EventHandler(this.beyazToolStripMenuItem_Click);
            // 
            // griToolStripMenuItem
            // 
            this.griToolStripMenuItem.Name = "griToolStripMenuItem";
            this.griToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.griToolStripMenuItem.Text = "Gri";
            this.griToolStripMenuItem.Click += new System.EventHandler(this.griToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(883, 611);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kisiListesiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKisiListesiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kisiListesiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKisiListesiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kisiListesiDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKisiListesiBindingSource2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.ComboBox cmbSehir;
        private System.Windows.Forms.MaskedTextBox mskMaas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btnGrafik;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.TextBox txtMeslek;
        private System.Windows.Forms.Button btnİstatistik;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private KisiListesiDataSet kisiListesiDataSet;
        private System.Windows.Forms.BindingSource tblKisiListesiBindingSource;
        private KisiListesiDataSetTableAdapters.tbl_KisiListesiTableAdapter tbl_KisiListesiTableAdapter;
        private KisiListesiDataSet1 kisiListesiDataSet1;
        private System.Windows.Forms.BindingSource tblKisiListesiBindingSource1;
        private KisiListesiDataSet1TableAdapters.tbl_KisiListesiTableAdapter tbl_KisiListesiTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KisiListesiDataSet2 kisiListesiDataSet2;
        private System.Windows.Forms.BindingSource tblKisiListesiBindingSource2;
        private KisiListesiDataSet2TableAdapters.tbl_KisiListesiTableAdapter tbl_KisiListesiTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn kisiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kisiAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kisiSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kisiMeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kisiMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn kisiMedeniDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kisiSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kisiYasDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeşilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beyazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem griToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}

