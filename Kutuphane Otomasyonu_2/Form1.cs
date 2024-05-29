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
    public partial class Form1 : Form
    {
        Kutuphane_Otomasyonu_2Entities db = new Kutuphane_Otomasyonu_2Entities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string gelenAd = txt_personelAdi.Text;
            string gelenSifre = txt_sifre.Text;

            var personel = db.Personel.Where(x => x.personel_kullaniciAd.Equals(gelenAd) && x.personel_sifre.Equals(gelenSifre));

            if(personel == null)
            {
                MessageBox.Show("Giriş Başarısız");
            }
            else
            {
                MessageBox.Show("Giriş Başarılı");
            }

        }
    }
}
