using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyonu_2.Kaynaklar_Kitaplar
{
    public partial class KaynakEkleForm : Form
    {
        public KaynakEkleForm()
        {
            InitializeComponent();
        }

        Kutuphane_Otomasyonu_2Entities db = new Kutuphane_Otomasyonu_2Entities();
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Kaynaklar2 kaynaklar = new Kaynaklar2();
            kaynaklar.kaynak_ad = adKaynaktxt.Text;
            kaynaklar.kaynak_yazar = yazarKaynaktxt.Text;
            kaynaklar.kaynak_yayinevi = yayinciKaynaktxt.Text;
            kaynaklar.kaynak_sayfasayisi = kaynakSayfaSayisi.Text;
            kaynaklar.kaynak_basımtarihi = dateTimePicker1.Value;
            db.Kaynaklar2.Add(kaynaklar);
            db.SaveChanges();

            var kaynakListe = db.Kaynaklar2.ToList();
            dataGridView1.DataSource = kaynakListe.ToList();
        }
    }
}
