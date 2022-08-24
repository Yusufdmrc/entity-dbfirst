namespace EntityFrame
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.txtKulüp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtÜlke = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.btnLinqEntity = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(888, 158);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(12, 214);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(97, 23);
            this.btnListele.TabIndex = 6;
            this.btnListele.Text = "Futbolcu Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(12, 268);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(97, 23);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = " Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(12, 320);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(97, 23);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(12, 371);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(97, 23);
            this.btnGüncelle.TabIndex = 9;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(12, 419);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(97, 23);
            this.btnBul.TabIndex = 10;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // txtKulüp
            // 
            this.txtKulüp.Location = new System.Drawing.Point(326, 340);
            this.txtKulüp.Name = "txtKulüp";
            this.txtKulüp.Size = new System.Drawing.Size(100, 20);
            this.txtKulüp.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Kulüp:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(326, 297);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Soyad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(326, 256);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 26;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(262, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Ad:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(326, 216);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(262, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "ID:";
            // 
            // txtÜlke
            // 
            this.txtÜlke.Location = new System.Drawing.Point(326, 388);
            this.txtÜlke.Name = "txtÜlke";
            this.txtÜlke.Size = new System.Drawing.Size(100, 20);
            this.txtÜlke.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Ülke:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(624, 257);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(131, 17);
            this.radioButton2.TabIndex = 34;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ada Göre Sırala(Z-->A)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(624, 214);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(131, 17);
            this.radioButton1.TabIndex = 33;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ada Göre Sırala(A-->Z)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(625, 302);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(130, 17);
            this.radioButton3.TabIndex = 35;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Toplam Öğrenci Sayısı";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(625, 343);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(70, 17);
            this.radioButton4.TabIndex = 36;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "İlk 3 kayıt";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(624, 419);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(103, 17);
            this.radioButton6.TabIndex = 38;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Adı O İle Bitenler";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(624, 377);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(121, 17);
            this.radioButton5.TabIndex = 37;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Adı A İle Başlayanlar";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // btnLinqEntity
            // 
            this.btnLinqEntity.Location = new System.Drawing.Point(625, 469);
            this.btnLinqEntity.Name = "btnLinqEntity";
            this.btnLinqEntity.Size = new System.Drawing.Size(110, 23);
            this.btnLinqEntity.TabIndex = 39;
            this.btnLinqEntity.Text = "Linq Entity";
            this.btnLinqEntity.UseVisualStyleBackColor = true;
            this.btnLinqEntity.Click += new System.EventHandler(this.btnLinqEntity_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 504);
            this.Controls.Add(this.btnLinqEntity);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txtÜlke);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKulüp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.TextBox txtKulüp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtÜlke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Button btnLinqEntity;
    }
}

