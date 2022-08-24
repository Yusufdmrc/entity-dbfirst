using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        testEntities db = new testEntities();


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.FUTBOLCU.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            FUTBOLCU d = new FUTBOLCU();
            d.AD = txtAd.Text;
            d.SOYAD = txtSoyad.Text;
            d.KULÜP = txtKulüp.Text;
            d.ÜLKE = txtÜlke.Text;

            db.FUTBOLCU.Add(d);
            db.SaveChanges();
            MessageBox.Show("Futbolcu listeye eklenmiştir.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var x = db.FUTBOLCU.Find(id);
            db.FUTBOLCU.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Futbolcu silinmiştir.");
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var x = db.FUTBOLCU.Find(id);
            x.AD = txtAd.Text;
            x.SOYAD = txtSoyad.Text;
            x.KULÜP = txtKulüp.Text;
            x.ÜLKE = txtÜlke.Text;

            db.SaveChanges();
            MessageBox.Show("Futbolcu bilgileri güncellenmiştir.");
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.FUTBOLCU.Where(x => x.AD == txtAd.Text || x.SOYAD == txtSoyad.Text).ToList();
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtAd.Text;
            var degerler = from item in db.FUTBOLCU
                           where item.AD.Contains(aranan)
                           select item;
            dataGridView1.DataSource = degerler.ToList();
        }

        private void btnLinqEntity_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                List<FUTBOLCU> liste1 = db.FUTBOLCU.OrderBy(p => p.AD).ToList();
                dataGridView1.DataSource = liste1;
            }
            if (radioButton2.Checked == true)
            {
                List<FUTBOLCU> liste2 = db.FUTBOLCU.OrderByDescending(p => p.AD).ToList();
                dataGridView1.DataSource = liste2;
            }
            if (radioButton3.Checked == true)
            {
                int toplam = db.FUTBOLCU.Count();
                MessageBox.Show(toplam.ToString(), "Toplam Futbolcu Sayısı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

            if (radioButton4.Checked == true)
            {
                List<FUTBOLCU> liste4 = db.FUTBOLCU.OrderBy(p => p.AD).Take(3).ToList();
                dataGridView1.DataSource = liste4;
            }

            if (radioButton5.Checked == true)
            {
                List<FUTBOLCU> liste5 = db.FUTBOLCU.Where(p => p.AD.StartsWith("a")).ToList();
                dataGridView1.DataSource = liste5;
            }

            if (radioButton6.Checked == true)
            {
                List<FUTBOLCU> liste6 = db.FUTBOLCU.Where(p => p.AD.EndsWith("O")).ToList();
                dataGridView1.DataSource = liste6;
            }

        }
    }
}
