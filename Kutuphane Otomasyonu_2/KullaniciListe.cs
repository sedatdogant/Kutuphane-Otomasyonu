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
    public partial class KullaniciListe : Form
    {
        public KullaniciListe()
        {
            InitializeComponent();
        }
        public void listele()
        {
            Kutuphane_Otomasyonu_2Entities db = new Kutuphane_Otomasyonu_2Entities();
            var kullanicilar = db.Kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList(); //kullanicilardaki datalari dataGriedwieve attık
        }
        private void KullaniciListe_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
