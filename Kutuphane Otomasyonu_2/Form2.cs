﻿using Kutuphane_Otomasyonu_2.Kullanici;
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
    public partial class IslemPaneli : Form
    {
        Kutuphane_Otomasyonu_2Entities db = new Kutuphane_Otomasyonu_2Entities();
        public IslemPaneli()
        {
            InitializeComponent();
        }

        private void IslemPaneli_Load(object sender, EventArgs e)
        {
            ekleKullanicibtn.Visible = false;
            guncelleKullanicibtn.Visible = false;
            silKullanicibtn.Visible=false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ekleKullanicibtn.Visible == false)
            { 
                ekleKullanicibtn.Visible = true;
                guncelleKullanicibtn.Visible = true;
                silKullanicibtn.Visible = true;
            }
            else
            {
                ekleKullanicibtn.Visible = false;
                guncelleKullanicibtn.Visible = false;
                silKullanicibtn.Visible = false;
            }
            
            kullaniciListeForm listeForm = new kullaniciListeForm();
            listeForm.MdiParent = this; //IslemPanelindeki formu KullaniciListe Formuna attık.
            listeForm.Show();
            
        }

        private void ekleKullanicibtn_Click(object sender, EventArgs e)
        {
            kullaniciEkle ekleForm = new kullaniciEkle();
            ekleForm.MdiParent = this;
            ekleForm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void silKullanicibtn_Click(object sender, EventArgs e)
        {
            KullaniciSil kullaniciSil = new KullaniciSil();
            kullaniciSil.MdiParent = this;
            kullaniciSil.Show();

            //nesne olusturduk nesnenin babası bu dedik nesneyi göster dedik.
        }
    }
}
