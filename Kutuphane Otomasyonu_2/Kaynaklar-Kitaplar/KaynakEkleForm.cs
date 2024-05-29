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
            zKaynaklar kaynaklar = new zKaynaklar();
            kaynaklar.kaynak_ad = adKaynaktxt.Text;
            kaynaklar.kaynak_yazar = yazarKaynaktxt.Text;
            kaynaklar.kaynak_yayinevi = yayinciKaynaktxt.Text;
            kaynaklar.kaynak_sayfasayisi = kaynakSayfaSayisi.Text;
            
            db.zKaynaklar.Add(kaynaklar);
            db.SaveChanges();

            var kaynakListe = db.zKaynaklar.ToList();
            dataGridView1.DataSource = kaynakListe.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            adKaynaktxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            yazarKaynaktxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            yayinciKaynaktxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            kaynakSayfaSayisi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
           

        }

        private void KaynakEkleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
