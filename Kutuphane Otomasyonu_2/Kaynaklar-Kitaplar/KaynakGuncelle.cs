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
    public partial class KaynakGuncelle : Form
    {
        public KaynakGuncelle()
        {
            InitializeComponent();
        }
        Kutuphane_Otomasyonu_2Entities db = new Kutuphane_Otomasyonu_2Entities();
        private void KaynakGuncelle_Load(object sender, EventArgs e)
        {
            var kaynaklar = db.zKaynaklar.ToList();
            dataGridView1.DataSource = kaynaklar.ToList();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            adKaynaktxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            yazarKaynaktxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            yayinciKaynaktxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            kaynakSayfaSayisi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
           
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            int secilenID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
           var guncellenenKaynak = db.zKaynaklar.Where(x => x.kaynak_id == secilenID).FirstOrDefault();
            guncellenenKaynak.kaynak_ad = adKaynaktxt.Text;
            guncellenenKaynak.kaynak_yazar = yazarKaynaktxt.Text;
            guncellenenKaynak.kaynak_yayinevi = yayinciKaynaktxt.Text;
            guncellenenKaynak.kaynak_sayfasayisi = kaynakSayfaSayisi.Text;
            

            db.SaveChanges();
            var kaynaklar = db.zKaynaklar.ToList();
            dataGridView1.DataSource = kaynaklar.ToList();
        }
    }
}
