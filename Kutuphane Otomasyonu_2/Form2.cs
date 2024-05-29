using Kutuphane_Otomasyonu_2.Kayıt;
using Kutuphane_Otomasyonu_2.Kaynaklar_Kitaplar;
using Kutuphane_Otomasyonu_2.Kullanici;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyonu_2
{
    public partial class IslemPaneli : Form
    {
        Kutuphane_Otomasyonu_2Entities db = new Kutuphane_Otomasyonu_2Entities();
        public IslemPaneli()
        {
            InitializeComponent();
        }

        private void IslemPaneli_Load(object sender, EventArgs e)
        {
            //kullanıcı butonları girişte kapalı
            ekleKullanicibtn.Visible = false;
            guncelleKullanicibtn.Visible = false;
            silKullanicibtn.Visible=false;

            //kitap butonları girişte kapalı
            ekleKitapbtn.Visible = false;
            guncelleKitapbtn.Visible = false;
            silKitapbtn.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ekleKullanicibtn.Visible == false)
            { 
                ekleKullanicibtn.Visible = true;
                guncelleKullanicibtn.Visible = true;
                silKullanicibtn.Visible = true;
            }
            else
            {
                ekleKullanicibtn.Visible = false;
                guncelleKullanicibtn.Visible = false;
                silKullanicibtn.Visible = false;
            }
            
            kullaniciListeForm listeForm = new kullaniciListeForm();
            listeForm.MdiParent = this; //IslemPanelindeki formu KullaniciListe Formuna attık.
            listeForm.Show();
            
        }

        private void ekleKullanicibtn_Click(object sender, EventArgs e)
        {
            kullaniciEkle ekleForm = new kullaniciEkle();
            ekleForm.MdiParent = this;
            ekleForm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void silKullanicibtn_Click(object sender, EventArgs e)
        {
            KullaniciSil kullaniciSil = new KullaniciSil();
            kullaniciSil.MdiParent = this;
            kullaniciSil.Show();

            //nesne olusturduk nesnenin babası bu dedik nesneyi göster dedik.
        }

        private void guncelleKullanicibtn_Click(object sender, EventArgs e)
        {
            kullaniciGuncelle kullaniciGuncelle = new kullaniciGuncelle();
            kullaniciGuncelle.MdiParent = this;
            kullaniciGuncelle.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(ekleKitapbtn.Visible == false)
            {
                ekleKitapbtn.Visible = true;
                guncelleKitapbtn.Visible = true;
                silKitapbtn.Visible = true;
            }
            else
            {
                ekleKitapbtn.Visible = false;
                guncelleKitapbtn.Visible = false;
                silKitapbtn.Visible = false;
            }
            KaynakListeForm kaynakListe = new KaynakListeForm();
            kaynakListe.MdiParent = this;
            kaynakListe.Show();
        }

        private void ekleKitapbtn_Click(object sender, EventArgs e)
        {
            KaynakEkleForm kaynakEkle = new KaynakEkleForm();
            kaynakEkle.MdiParent = this;
            kaynakEkle.Show();
        }

        private void silKitapbtn_Click(object sender, EventArgs e)
        {
            KaynakSilForm kaynakSil = new KaynakSilForm();
            kaynakSil.MdiParent = this;
            kaynakSil.Show();
        }

        private void guncelleKitapbtn_Click(object sender, EventArgs e)
        {
            KaynakGuncelle kaynakGuncelle = new KaynakGuncelle();
            kaynakGuncelle.MdiParent = this;
            kaynakGuncelle.Show();
        }

        private void btn_odunc_Click(object sender, EventArgs e)
        {
            oduncVer oduncVer = new oduncVer();
            oduncVer.MdiParent = this;
            oduncVer.Show();
        }
    }
}
