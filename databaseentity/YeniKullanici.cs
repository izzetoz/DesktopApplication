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
    public partial class YeniKullanici : Form
    {
        Kullanici model = new Kullanici();
        dbAraf db = new dbAraf();
        public YeniKullanici()
        {
            InitializeComponent();
        }


        private void YeniKullanici_Load(object sender, EventArgs e)
        {

        }
        void Clear()
        {
            textAd.Text = textSoyad.Text = textMail.Text = textParola.Text = "";
            btnKaydet.Text = "Kaydet";
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            model.kullaniciad = textAd.Text.Trim();
            model.kullanicisoyad = textSoyad.Text.Trim();
            model.kullanicimail = textMail.Text.Trim();
            model.kullanicisifre = textParola.Text.Trim();
            using (dbAraf db = new dbAraf())
            {
                if (textAd.Text == "" || textAd.Text == null || textAd.Text == " ")
                {
                    MessageBox.Show("Lütfen bilgileri eksiksiz tamamlayınız.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textSoyad.Text == "" || textSoyad.Text == null || textSoyad.Text == " ")
                {
                    MessageBox.Show("Lütfen bilgileri eksiksiz tamamlayınız.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textMail.Text == "" || textMail.Text == null || textMail.Text == " ")
                {
                    MessageBox.Show("Lütfen bilgileri eksiksiz tamamlayınız.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textParola.Text == "" || textParola.Text == null || textParola.Text == " ")
                {
                    MessageBox.Show("Lütfen bilgileri eksiksiz tamamlayınız.","Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (model.kullaniciID == 0) //ekleme
                    db.Kullanicis.Add(model);
                else // güncelleme
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Kayıt işlemi gerçekleşti.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
                return;

            }


        }
    }
}
