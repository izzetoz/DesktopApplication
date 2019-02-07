namespace databaseentity
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kullaniciID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanicisoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanicimail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanicisifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textMail = new System.Windows.Forms.TextBox();
            this.textParola = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(45, 247);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(71, 29);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseCompatibleTextRendering = true;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kullaniciID,
            this.kullaniciad,
            this.kullanicisoyad,
            this.kullanicimail,
            this.kullanicisifre});
            this.dataGridView1.Location = new System.Drawing.Point(356, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(432, 422);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // kullaniciID
            // 
            this.kullaniciID.DataPropertyName = "kullaniciID";
            this.kullaniciID.HeaderText = "kullaniciID";
            this.kullaniciID.Name = "kullaniciID";
            this.kullaniciID.ReadOnly = true;
            this.kullaniciID.Visible = false;
            // 
            // kullaniciad
            // 
            this.kullaniciad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kullaniciad.DataPropertyName = "kullaniciad";
            this.kullaniciad.HeaderText = "Ad";
            this.kullaniciad.Name = "kullaniciad";
            this.kullaniciad.ReadOnly = true;
            // 
            // kullanicisoyad
            // 
            this.kullanicisoyad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kullanicisoyad.DataPropertyName = "kullanicisoyad";
            this.kullanicisoyad.HeaderText = "Soyad";
            this.kullanicisoyad.Name = "kullanicisoyad";
            this.kullanicisoyad.ReadOnly = true;
            // 
            // kullanicimail
            // 
            this.kullanicimail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kullanicimail.DataPropertyName = "kullanicimail";
            this.kullanicimail.HeaderText = "E - Posta";
            this.kullanicimail.Name = "kullanicimail";
            this.kullanicimail.ReadOnly = true;
            // 
            // kullanicisifre
            // 
            this.kullanicisifre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kullanicisifre.DataPropertyName = "kullanicisifre";
            this.kullanicisifre.HeaderText = "Parola";
            this.kullanicisifre.Name = "kullanicisifre";
            this.kullanicisifre.ReadOnly = true;
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(137, 120);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(141, 20);
            this.textAd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(40, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad";
            // 
            // textSoyad
            // 
            this.textSoyad.Location = new System.Drawing.Point(137, 145);
            this.textSoyad.Name = "textSoyad";
            this.textSoyad.Size = new System.Drawing.Size(141, 20);
            this.textSoyad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(40, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyad";
            // 
            // textMail
            // 
            this.textMail.Location = new System.Drawing.Point(137, 171);
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(141, 20);
            this.textMail.TabIndex = 2;
            // 
            // textParola
            // 
            this.textParola.Location = new System.Drawing.Point(137, 197);
            this.textParola.Name = "textParola";
            this.textParola.Size = new System.Drawing.Size(141, 20);
            this.textParola.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(40, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "E - posta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(40, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Parola";
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(122, 247);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 29);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.UseCompatibleTextRendering = true;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCikis.Location = new System.Drawing.Point(203, 247);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 29);
            this.btnCikis.TabIndex = 0;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseCompatibleTextRendering = true;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textParola);
            this.Controls.Add(this.textMail);
            this.Controls.Add(this.textSoyad);
            this.Controls.Add(this.textAd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araf";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textMail;
        private System.Windows.Forms.TextBox textParola;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciID;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciad;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanicisoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanicimail;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanicisifre;
    }
}

