namespace BiletProje
{
    partial class frmOtobusSec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOtobusSec));
            this.btnBiletAl = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOtobüsDurum = new System.Windows.Forms.Label();
            this.lblSecilenOtobusID = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtYolculukSüre = new System.Windows.Forms.TextBox();
            this.mskSaat = new System.Windows.Forms.MaskedTextBox();
            this.cmbNereye = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mskTarih = new System.Windows.Forms.MaskedTextBox();
            this.cmbNereden = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblBiletId = new System.Windows.Forms.Label();
            this.btnBiletİptal = new System.Windows.Forms.Button();
            this.mskBiletSaat = new System.Windows.Forms.MaskedTextBox();
            this.cmbBiletNereden = new System.Windows.Forms.ComboBox();
            this.cmbBiletNereye = new System.Windows.Forms.ComboBox();
            this.mskBiletTarih = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBiletAl
            // 
            this.btnBiletAl.Location = new System.Drawing.Point(164, 266);
            this.btnBiletAl.Margin = new System.Windows.Forms.Padding(4);
            this.btnBiletAl.Name = "btnBiletAl";
            this.btnBiletAl.Size = new System.Drawing.Size(100, 34);
            this.btnBiletAl.TabIndex = 0;
            this.btnBiletAl.Text = "Bilet Al";
            this.btnBiletAl.UseVisualStyleBackColor = true;
            this.btnBiletAl.Click += new System.EventHandler(this.btnBiletAl_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblOtobüsDurum);
            this.groupBox1.Controls.Add(this.lblSecilenOtobusID);
            this.groupBox1.Controls.Add(this.txtFiyat);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.btnBiletAl);
            this.groupBox1.Controls.Add(this.txtYolculukSüre);
            this.groupBox1.Controls.Add(this.mskSaat);
            this.groupBox1.Controls.Add(this.cmbNereye);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mskTarih);
            this.groupBox1.Controls.Add(this.cmbNereden);
            this.groupBox1.Location = new System.Drawing.Point(779, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 307);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sefer Bilgileri";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(146, 236);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 23);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Kabul Ediyorum";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Kullanım Koşulları:";
            // 
            // lblOtobüsDurum
            // 
            this.lblOtobüsDurum.AutoSize = true;
            this.lblOtobüsDurum.Location = new System.Drawing.Point(298, 163);
            this.lblOtobüsDurum.Name = "lblOtobüsDurum";
            this.lblOtobüsDurum.Size = new System.Drawing.Size(49, 19);
            this.lblOtobüsDurum.TabIndex = 18;
            this.lblOtobüsDurum.Text = "label1";
            this.lblOtobüsDurum.Visible = false;
            // 
            // lblSecilenOtobusID
            // 
            this.lblSecilenOtobusID.AutoSize = true;
            this.lblSecilenOtobusID.Location = new System.Drawing.Point(320, 31);
            this.lblSecilenOtobusID.Name = "lblSecilenOtobusID";
            this.lblSecilenOtobusID.Size = new System.Drawing.Size(16, 19);
            this.lblSecilenOtobusID.TabIndex = 17;
            this.lblSecilenOtobusID.Text = "s";
            this.lblSecilenOtobusID.Visible = false;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(146, 188);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(130, 27);
            this.txtFiyat.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(89, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 19);
            this.label13.TabIndex = 15;
            this.label13.Text = "Fiyat:";
            // 
            // txtYolculukSüre
            // 
            this.txtYolculukSüre.Location = new System.Drawing.Point(146, 155);
            this.txtYolculukSüre.Name = "txtYolculukSüre";
            this.txtYolculukSüre.Size = new System.Drawing.Size(130, 27);
            this.txtYolculukSüre.TabIndex = 12;
            // 
            // mskSaat
            // 
            this.mskSaat.Location = new System.Drawing.Point(146, 122);
            this.mskSaat.Mask = "00:00";
            this.mskSaat.Name = "mskSaat";
            this.mskSaat.Size = new System.Drawing.Size(130, 27);
            this.mskSaat.TabIndex = 11;
            this.mskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // cmbNereye
            // 
            this.cmbNereye.FormattingEnabled = true;
            this.cmbNereye.Location = new System.Drawing.Point(146, 56);
            this.cmbNereye.Name = "cmbNereye";
            this.cmbNereye.Size = new System.Drawing.Size(130, 27);
            this.cmbNereye.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Yolculuk Süresi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Saat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tarih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nereye:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nereden:";
            // 
            // mskTarih
            // 
            this.mskTarih.Location = new System.Drawing.Point(146, 89);
            this.mskTarih.Mask = "00/00/0000";
            this.mskTarih.Name = "mskTarih";
            this.mskTarih.Size = new System.Drawing.Size(130, 27);
            this.mskTarih.TabIndex = 4;
            this.mskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // cmbNereden
            // 
            this.cmbNereden.FormattingEnabled = true;
            this.cmbNereden.Location = new System.Drawing.Point(146, 23);
            this.cmbNereden.Name = "cmbNereden";
            this.cmbNereden.Size = new System.Drawing.Size(130, 27);
            this.cmbNereden.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(761, 307);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seçilen Tarihdeki seferler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 281);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(12, 325);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(758, 261);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Biletlerim";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 23);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(752, 235);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblBiletId);
            this.groupBox4.Controls.Add(this.btnBiletİptal);
            this.groupBox4.Controls.Add(this.mskBiletSaat);
            this.groupBox4.Controls.Add(this.cmbBiletNereden);
            this.groupBox4.Controls.Add(this.cmbBiletNereye);
            this.groupBox4.Controls.Add(this.mskBiletTarih);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(779, 325);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(388, 261);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bilet Bilgileri";
            // 
            // lblBiletId
            // 
            this.lblBiletId.AutoSize = true;
            this.lblBiletId.Location = new System.Drawing.Point(320, 89);
            this.lblBiletId.Name = "lblBiletId";
            this.lblBiletId.Size = new System.Drawing.Size(27, 19);
            this.lblBiletId.TabIndex = 15;
            this.lblBiletId.Text = "ID:";
            this.lblBiletId.Visible = false;
            // 
            // btnBiletİptal
            // 
            this.btnBiletİptal.Location = new System.Drawing.Point(117, 195);
            this.btnBiletİptal.Margin = new System.Windows.Forms.Padding(4);
            this.btnBiletİptal.Name = "btnBiletİptal";
            this.btnBiletİptal.Size = new System.Drawing.Size(172, 34);
            this.btnBiletİptal.TabIndex = 15;
            this.btnBiletİptal.Text = "Bileti İptal Et";
            this.btnBiletİptal.UseVisualStyleBackColor = true;
            this.btnBiletİptal.Click += new System.EventHandler(this.btnBiletİptal_Click);
            // 
            // mskBiletSaat
            // 
            this.mskBiletSaat.Location = new System.Drawing.Point(146, 146);
            this.mskBiletSaat.Mask = "00:00";
            this.mskBiletSaat.Name = "mskBiletSaat";
            this.mskBiletSaat.Size = new System.Drawing.Size(130, 27);
            this.mskBiletSaat.TabIndex = 22;
            this.mskBiletSaat.ValidatingType = typeof(System.DateTime);
            // 
            // cmbBiletNereden
            // 
            this.cmbBiletNereden.FormattingEnabled = true;
            this.cmbBiletNereden.Location = new System.Drawing.Point(146, 47);
            this.cmbBiletNereden.Name = "cmbBiletNereden";
            this.cmbBiletNereden.Size = new System.Drawing.Size(130, 27);
            this.cmbBiletNereden.TabIndex = 15;
            // 
            // cmbBiletNereye
            // 
            this.cmbBiletNereye.FormattingEnabled = true;
            this.cmbBiletNereye.Location = new System.Drawing.Point(146, 80);
            this.cmbBiletNereye.Name = "cmbBiletNereye";
            this.cmbBiletNereye.Size = new System.Drawing.Size(130, 27);
            this.cmbBiletNereye.TabIndex = 21;
            // 
            // mskBiletTarih
            // 
            this.mskBiletTarih.Location = new System.Drawing.Point(146, 113);
            this.mskBiletTarih.Mask = "00/00/0000";
            this.mskBiletTarih.Name = "mskBiletTarih";
            this.mskBiletTarih.Size = new System.Drawing.Size(130, 27);
            this.mskBiletTarih.TabIndex = 16;
            this.mskBiletTarih.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Saat:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(55, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 19);
            this.label11.TabIndex = 17;
            this.label11.Text = "Nereden:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(78, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tarih:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 19);
            this.label10.TabIndex = 18;
            this.label10.Text = "Nereye:";
            // 
            // frmOtobusSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1179, 589);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmOtobusSec";
            this.Text = "Bilet Alma Paneli";
            this.Load += new System.EventHandler(this.frmOtobusSec_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBiletAl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtYolculukSüre;
        private System.Windows.Forms.MaskedTextBox mskSaat;
        private System.Windows.Forms.ComboBox cmbNereye;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskTarih;
        private System.Windows.Forms.ComboBox cmbNereden;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblBiletId;
        private System.Windows.Forms.Button btnBiletİptal;
        private System.Windows.Forms.MaskedTextBox mskBiletSaat;
        private System.Windows.Forms.ComboBox cmbBiletNereden;
        private System.Windows.Forms.ComboBox cmbBiletNereye;
        private System.Windows.Forms.MaskedTextBox mskBiletTarih;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblSecilenOtobusID;
        private System.Windows.Forms.Label lblOtobüsDurum;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
    }
}