using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyonu_2.Kayıt
{
    /// <summary>
    /// gerialform sınıfı, kitap iade işlemleri için kullanılan formu temsil eder.
    /// </summary>
    public partial class gerialform : Form
    {
        /// <summary>
        /// gerialform sınıfının kurucusu. Form bileşenlerini başlatır.
        /// </summary>
        public gerialform()
        {
            InitializeComponent();
        }
        // Veritabanı bağlamı
        Kutuphane_Otomasyonu_2Entities db = new Kutuphane_Otomasyonu_2Entities();
        /// <summary>
        /// Form yüklendiğinde tetiklenen olay.
        /// İade edilmeyen kayıtları listeleyerek ilgili DataGridView kontrolüne bağlar.
        /// </summary>
        /// <param name="sender">Olayı tetikleyen nesne</param>
        /// <param name="e">Olay verileri</param>
        private void gerialform_Load(object sender, EventArgs e)
        {
            var kayitlar = db.zKayitlar.Where(x => x.durum == false).ToList();
            dataGridView1.DataSource = kayitlar.ToList();
        }
        /// <summary>
        /// Seçilen kaydı iade olarak işaretler ve kayıt listesini günceller.
        /// </summary>
        /// <param name="sender">Olayı tetikleyen nesne</param>
        /// <param name="e">Olay verileri</param>
        private void button1_Click(object sender, EventArgs e)
        {
            int secilenkayitId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var kayit = db.zKayitlar.Where(x => x.kayit_id == secilenkayitId).FirstOrDefault();
            kayit.durum = true;
            db.SaveChanges();

            //liste tazelendi
            var kayitlar = db.zKayitlar.Where(x => x.durum == false).ToList();
            dataGridView1.DataSource = kayitlar.ToList();


        }
    }
}
