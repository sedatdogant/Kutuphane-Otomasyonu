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
    public partial class KaynakSilForm : Form
    {
        public KaynakSilForm()
        {
            InitializeComponent();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int secilenID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            var kaynak= db.zKaynaklar.Where(x => x.kaynak_id == secilenID).FirstOrDefault(); //kaynaklar tablosuna git idsini denk olan kolonu al

            db.zKaynaklar.Remove(kaynak);
            db.SaveChanges();
            Listele();
        }
        Kutuphane_Otomasyonu_2Entities db = new Kutuphane_Otomasyonu_2Entities();
        public void Listele()
        {

            var kaynaklar = db.zKaynaklar.ToList();
            dataGridView1.DataSource = kaynaklar.ToList();
        }

        private void KaynakSilForm_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
