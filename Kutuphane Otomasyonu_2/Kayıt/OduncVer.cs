using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyonu_2.Kayıt
{
    public partial class OduncVer : Form
    {
        public OduncVer()
        {
            InitializeComponent();
        }

        Kutuphane_Otomasyonu_2Entities db = new Kutuphane_Otomasyonu_2Entities();   
        private void btn_TC_Click(object sender, EventArgs e)
        {
            string secilenID = txt_TC.Text;

            var kullaniciVarMi = db.Kullanicilar.Where(x => x.kullanici_tc == secilenID).FirstOrDefault();

            if(kullaniciVarMi !=null )
            {
                label2.Text = kullaniciVarMi.kullanici_ad + " " + kullaniciVarMi.kullanici_soyad;
            }
            else
            {
                label2.Text = "Böyle bir kullanıcı yok!";
            }

        }

        private void OduncVer_Load(object sender, EventArgs e)
        {

        }
    }
}
