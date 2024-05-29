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
        private void OduncVer_Load(object sender, EventArgs e)
        {
            var kayitList = db.zKa
        }
    }
}
