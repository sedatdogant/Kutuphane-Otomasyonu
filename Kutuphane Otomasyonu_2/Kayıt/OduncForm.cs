using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyonu_2.Kayıt
{
    public partial class OduncForm : Form
    {
        public OduncForm()
        {
            InitializeComponent();
        }

        Kutuphane_Otomasyonu_2Entities db = new Kutuphane_Otomasyonu_2Entities();
        private void OduncForm_Load(object sender, EventArgs e)
        {
            //Listeledik(kayitlar)
            var kayitList = db.zKayitlar.ToList();
            dataGridView1.DataSource = kayitList.ToList();

            //Listeledik(kaynaklar)
            var kaynakList = db.zKaynaklar.ToList();
            dataGridView2.DataSource = kaynakList.ToList();


            //istenmeyen kaynak ve kullanici kolonunu gizledik
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;

            //kolon adlarini duzenledik
            dataGridView1.Columns[1].HeaderText = "Kullanici";
            dataGridView1.Columns[2].HeaderText = "kaynak ad";

        }
        private void btn_TC_Click(object sender, EventArgs e)
        {
            string secilenID = txt_TC.Text;

            var kullaniciVarMi = db.Kullanicilar.Where(x => x.kullanici_tc == secilenID).FirstOrDefault();

            if(kullaniciVarMi !=null )
            {
                label2.Text = kullaniciVarMi.kullanici_ad + " " + kullaniciVarMi.kullanici_soyad;
            }
            else
            {
                label2.Text = "Böyle bir kullanıcı yok!";
            }

        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string gelenAd = textBox1.Text;
            var bulunanKaynaklar = db.zKaynaklar.Where(x => x.kaynak_ad.Contains(gelenAd)).ToList();
            dataGridView2.DataSource = bulunanKaynaklar;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //kisiyi aldik
            string secilenKisiTc = txt_TC.Text;
            var secilenKisi = db.Kullanicilar.Where(x => x.kullanici_tc.Equals(secilenKisiTc)).FirstOrDefault();

            //kitabi aldik
            int secilenKitapId = Convert.ToInt16(dataGridView2.CurrentRow.Cells[0].Value);
            var secilenKitap = db.zKaynaklar.Where(x => x.kaynak_id==secilenKitapId).FirstOrDefault();

            zKayitlar yeniKayit = new zKayitlar(); 
            yeniKayit.kitap_id = secilenKitap.kaynak_id;
            yeniKayit.kullanici_id = secilenKisi.kullanici_id;
            yeniKayit.alis_tarih = DateTime.Today;
            yeniKayit.son_tarih = DateTime.Today.AddDays(15);
            db.zKayitlar.Add(yeniKayit);
            db.SaveChanges();


            //Listeledik(kayitlar)
            var kayitList = db.zKayitlar.ToList();
            dataGridView1.DataSource = kayitList.ToList();
        }

       
    }
}
