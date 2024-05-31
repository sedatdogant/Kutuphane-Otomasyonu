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
    /// <summary>
    /// IslemPaneli sınıfı, kütüphane otomasyonu için işlem panelini temsil eder.
    /// </summary>
    public partial class IslemPaneli : Form
    {
        Kutuphane_Otomasyonu_2Entities db = new Kutuphane_Otomasyonu_2Entities();
        /// <summary>
        /// IslemPaneli sınıfının kurucusu. Form bileşenlerini başlatır.
        /// </summary>
        public IslemPaneli()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Form yüklendiğinde tetiklenen olay.
        /// Kullanıcı ve kitap butonlarını gizler.
        /// </summary>
        /// <param name="sender">Olayı tetikleyen nesne</param>
        /// <param name="e">Olay verileri</param>
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
        /// <summary>
        /// Kullanıcı işlemleri butonuna tıklanıldığında tetiklenen olay.
        /// Kullanıcı butonlarını gösterir veya gizler ve kullanıcı listeleme formunu açar.
        /// </summary>
        /// <param name="sender">Olayı tetikleyen nesne</param>
        /// <param name="e">Olay verileri</param>
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
        /// <summary>
        /// Kullanıcı ekleme butonuna tıklanıldığında tetiklenen olay.
        /// Kullanıcı ekleme formunu açar.
        /// </summary>
        /// <param name="sender">Olayı tetikleyen nesne</param>
        /// <param name="e">Olay verileri</param>
        private void ekleKullanicibtn_Click(object sender, EventArgs e)
        {
            kullaniciEkle ekleForm = new kullaniciEkle();
            ekleForm.MdiParent = this;
            ekleForm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// Kullanıcı silme butonuna tıklanıldığında tetiklenen olay.
        /// Kullanıcı silme formunu açar.
        /// </summary>
        /// <param name="sender">Olayı tetikleyen nesne</param>
        /// <param name="e">Olay verileri</param>
        private void silKullanicibtn_Click(object sender, EventArgs e)
        {
            KullaniciSil kullaniciSil = new KullaniciSil();
            kullaniciSil.MdiParent = this;
            kullaniciSil.Show();

            //nesne olusturduk nesnenin babası bu dedik nesneyi göster dedik.
        }
        /// <summary>
        /// Kullanıcı güncelleme butonuna tıklanıldığında tetiklenen olay.
        /// Kullanıcı güncelleme formunu açar.
        /// </summary>
        /// <param name="sender">Olayı tetikleyen nesne</param>
        /// <param name="e">Olay verileri</param>
        private void guncelleKullanicibtn_Click(object sender, EventArgs e)
        {
            kullaniciGuncelle kullaniciGuncelle = new kullaniciGuncelle();
            kullaniciGuncelle.MdiParent = this;
            kullaniciGuncelle.Show();
        }
        /// <summary>
        /// Kitap işlemleri butonuna tıklanıldığında tetiklenen olay.
        /// Kitap butonlarını gösterir veya gizler ve kitap listeleme formunu açar.
        /// </summary>
        /// <param name="sender">Olayı tetikleyen nesne</param>
        /// <param name="e">Olay verileri</param>
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
        /// <summary>
        /// Kitap ekleme butonuna tıklanıldığında tetiklenen olay.
        /// Kitap ekleme formunu açar.
        /// </summary>
        /// <param name="sender">Olayı tetikleyen nesne</param>
        /// <param name="e">Olay verileri</param>
        private void ekleKitapbtn_Click(object sender, EventArgs e)
        {
            KaynakEkleForm kaynakEkle = new KaynakEkleForm();
            kaynakEkle.MdiParent = this;
            kaynakEkle.Show();
        }
        /// <summary>
        /// Kitap silme butonuna tıklanıldığında tetiklenen olay.
        /// Kitap silme formunu açar.
        /// </summary>
        /// <param name="sender">Olayı tetikleyen nesne</param>
        /// <param name="e">Olay verileri</param>
        private void silKitapbtn_Click(object sender, EventArgs e)
        {
            KaynakSilForm kaynakSil = new KaynakSilForm();
            kaynakSil.MdiParent = this;
            kaynakSil.Show();
        }
        /// <summary>
        /// Kitap güncelleme butonuna tıklanıldığında tetiklenen olay.
        /// Kitap güncelleme formunu açar.
        /// </summary>
        /// <param name="sender">Olayı tetikleyen nesne</param>
        /// <param name="e">Olay verileri</param>

        private void guncelleKitapbtn_Click(object sender, EventArgs e)
        {
            KaynakGuncelle kaynakGuncelle = new KaynakGuncelle();
            kaynakGuncelle.MdiParent = this;
            kaynakGuncelle.Show();
        }
        /// <summary>
        /// Ödünç alma butonuna tıklanıldığında tetiklenen olay.
        /// Ödünç formunu açar.
        /// </summary>
        /// <param name="sender">Olayı tetikleyen nesne</param>
        /// <param name="e">Olay verileri</param>
        private void btn_odunc_Click(object sender, EventArgs e)
        {
            OduncForm oduncVer = new OduncForm();
            oduncVer.MdiParent = this;
            oduncVer.Show();
        }
        /// <summary>
        /// Geri alma butonuna tıklanıldığında tetiklenen olay.
        /// Geri alma formunu açar.
        /// </summary>
        /// <param name="sender">Olayı tetikleyen nesne</param>
        /// <param name="e">Olay verileri</param>
        private void button2_Click(object sender, EventArgs e)
        {
            gerialform geri = new gerialform();
            geri.MdiParent = this;
            geri.Show();

        }
    }
}
