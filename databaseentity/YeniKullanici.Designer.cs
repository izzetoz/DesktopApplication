namespace databaseentity
{
    partial class YeniKullanici
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textAd = new System.Windows.Forms.TextBox();
            this.textSoyad = new System.Windows.Forms.TextBox();
            this.textMail = new System.Windows.Forms.TextBox();
            this.textParola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(138, 205);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(71, 29);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseCompatibleTextRendering = true;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(57, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Parola";
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(154, 80);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(141, 20);
            this.textAd.TabIndex = 10;
            // 
            // textSoyad
            // 
            this.textSoyad.Location = new System.Drawing.Point(154, 105);
            this.textSoyad.Name = "textSoyad";
            this.textSoyad.Size = new System.Drawing.Size(141, 20);
            this.textSoyad.TabIndex = 9;
            // 
            // textMail
            // 
            this.textMail.Location = new System.Drawing.Point(154, 131);
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(141, 20);
            this.textMail.TabIndex = 8;
            // 
            // textParola
            // 
            this.textParola.Location = new System.Drawing.Point(154, 157);
            this.textParola.Name = "textParola";
            this.textParola.Size = new System.Drawing.Size(141, 20);
            this.textParola.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(57, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(57, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "E - posta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(57, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Soyad";
            // 
            // YeniKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(364, 311);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textParola);
            this.Controls.Add(this.textMail);
            this.Controls.Add(this.textSoyad);
            this.Controls.Add(this.textAd);
            this.Controls.Add(this.btnKaydet);
            this.Name = "YeniKullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Kullanıcı";
            this.Load += new System.EventHandler(this.YeniKullanici_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.TextBox textSoyad;
        private System.Windows.Forms.TextBox textMail;
        private System.Windows.Forms.TextBox textParola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}