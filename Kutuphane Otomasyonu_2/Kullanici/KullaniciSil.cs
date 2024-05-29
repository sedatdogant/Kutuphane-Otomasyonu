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
    public partial class KullaniciSil : Form
    {
        public KullaniciSil()
        {
            InitializeComponent();
        }
        public void Listele()
        {
            Kutuphane_Otomasyonu_2Entities db = new Kutuphane_Otomasyonu_2Entities();
            var kullanicilar = db.Kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
        }
        private void KullaniciSil_Load(object sender, EventArgs e)
        {
            Listele();
        }

        Kutuphane_Otomasyonu_2Entities db = new Kutuphane_Otomasyonu_2Entities();
        private void button1_Click(object sender, EventArgs e)
        {
            int secilenID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            var kullanici = db.Kullanicilar.Where(x=>x.kullanici_id==secilenID).FirstOrDefault(); //kullanıcı tablosuna git idsini denk olan kolonu al

            db.Kullanicilar.Remove(kullanici);
            db.SaveChanges();
            Listele();

        }
    }
}
