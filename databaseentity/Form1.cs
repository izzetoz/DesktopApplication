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
    public partial class Form1 : Form
    {
        Kullanici model = new Kullanici();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Clear();
        }
        void Clear()
        {
            textAd.Text = textSoyad.Text = textMail.Text = textParola.Text = "";
            btnKaydet.Text = "Kaydet";
            btnSil.Enabled = false;
            model.kullaniciID = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
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
                    MessageBox.Show("Lütfen bilgileri eksiksiz tamamlayınız.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (model.kullaniciID == 0) //ekleme
                    db.Kullanicis.Add(model);
                else // güncelleme
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                
            }
            Clear();
            PopulateDataGridView();
            MessageBox.Show("İşlem gerçekleşti.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void PopulateDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (dbAraf db = new dbAraf())
            {
                dataGridView1.DataSource = db.Kullanicis.ToList<Kullanici>(); 
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
                {
                model.kullaniciID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["kullaniciID"].Value);
                using (dbAraf db = new dbAraf())
                {
                    model = db.Kullanicis.Where(x => x.kullaniciID == model.kullaniciID).FirstOrDefault();
                    textAd.Text = model.kullaniciad;
                    textSoyad.Text = model.kullanicisoyad;
                    textMail.Text = model.kullanicimail;
                    textParola.Text = model.kullanicisifre;
                }
                btnKaydet.Text = "Update";
                btnSil.Enabled = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                using (dbAraf db = new dbAraf())
                {
                    var entry = db.Entry(model);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                        db.Kullanicis.Attach(model);
                    db.Kullanicis.Remove(model);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("İşlemi gerçekleşti.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }
    }

}
