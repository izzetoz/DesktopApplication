namespace databaseentity
{
    partial class Form2
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
            this.giris = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.kullanici = new System.Windows.Forms.Label();
            this.parola = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.kayitol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // giris
            // 
            this.giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris.Location = new System.Drawing.Point(70, 165);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(95, 33);
            this.giris.TabIndex = 0;
            this.giris.Text = "Giriş Yap";
            this.giris.UseVisualStyleBackColor = true;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(157, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 26);
            this.textBox1.TabIndex = 1;
            // 
            // kullanici
            // 
            this.kullanici.AutoSize = true;
            this.kullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanici.ForeColor = System.Drawing.SystemColors.Window;
            this.kullanici.Location = new System.Drawing.Point(73, 78);
            this.kullanici.Name = "kullanici";
            this.kullanici.Size = new System.Drawing.Size(68, 24);
            this.kullanici.TabIndex = 2;
            this.kullanici.Text = "Kullanıcı";
            this.kullanici.UseCompatibleTextRendering = true;
            // 
            // parola
            // 
            this.parola.AutoSize = true;
            this.parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parola.ForeColor = System.Drawing.SystemColors.Window;
            this.parola.Location = new System.Drawing.Point(73, 118);
            this.parola.Name = "parola";
            this.parola.Size = new System.Drawing.Size(54, 24);
            this.parola.TabIndex = 2;
            this.parola.Text = "Parola";
            this.parola.UseCompatibleTextRendering = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(157, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(111, 26);
            this.textBox2.TabIndex = 1;
            // 
            // kayitol
            // 
            this.kayitol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitol.Location = new System.Drawing.Point(179, 165);
            this.kayitol.Name = "kayitol";
            this.kayitol.Size = new System.Drawing.Size(95, 33);
            this.kayitol.TabIndex = 3;
            this.kayitol.Text = "Kayıt Ol";
            this.kayitol.UseVisualStyleBackColor = true;
            this.kayitol.Click += new System.EventHandler(this.kayitol_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(364, 311);
            this.Controls.Add(this.kayitol);
            this.Controls.Add(this.parola);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.kullanici);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.giris);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button giris;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label kullanici;
        private System.Windows.Forms.Label parola;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button kayitol;
    }
}