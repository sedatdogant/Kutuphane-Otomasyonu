using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyonu_2.Kullanici
{
    public partial class kullaniciEkle : Form
    {
       
        public kullaniciEkle()
        {
            InitializeComponent();
        }
        Kutuphane_Otomasyonu_2Entities db = new Kutuphane_Otomasyonu_2Entities();

        private void button1_Click(object sender, EventArgs e)
        {
            Kullanicilar kullanicilar = new Kullanicilar();
            kullanicilar.kullanici_ad = kullaniciAdtxt.Text;
            kullanicilar.kullanici_soyad = kullaniciSoyadtxt.Text;
            kullanicilar.kullanici_tc = kullaniciTCtxt.Text;
            kullanicilar.kullanici_tel = kullaniciTeltxt.Text;
            kullanicilar.kullanici_mail = kullaniciMailtxt.Text;
            kullanicilar.kullanici_ceza = Convert.ToDouble(kullaniciCezatxt.Text);

            if(radioE.Checked == true)
            {
                kullanicilar.kullanici_cinsiyet = "E";
            }
            else if(radioK.Checked == true)
            {
                kullanicilar.kullanici_cinsiyet = "K";
            }
            db.Kullanicilar.Add(kullanicilar);
            db.SaveChanges();
            Listele();
            
        }

        private void kullaniciEkle_Load(object sender, EventArgs e)
        {
            Listele();
        }
        
        public void Listele()
        {
            
            var kullanicilar = db.Kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
        }
    }
}
