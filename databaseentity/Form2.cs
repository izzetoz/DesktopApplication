using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databaseentity
{
    public partial class Form2 : Form
    {
        public object Kullanici { get; private set; }
        Form1 frm = new Form1();
        public Form2()
        {
            InitializeComponent();
        }
        dbAraf db = new dbAraf();
        int hak = 3;
        private void giris_Click(object sender, EventArgs e)
        {
            if (hak != 0)
            {
                foreach(var user in db.Kullanicis)
                {

               
                if (textBox1.Text == user.kullaniciad.Replace(" ", "") && user.kullanicisifre.Replace(" ", "") == textBox2.Text)
                {
                    MessageBox.Show("Giriş başarılı.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm.Show();
                        this.Hide();
                        return;
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya parola yanlış.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    hak--;
                        return;
                }
                }
            }
            else
            {
                Application.Exit();
            }

        }

        private void kayitol_Click(object sender, EventArgs e)
        {
            YeniKullanici frm = new YeniKullanici();
            frm.Show();
            this.Hide();
            return;

        }
        }
}


