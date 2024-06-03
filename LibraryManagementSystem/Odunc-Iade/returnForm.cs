using Kutuphane_Otomasyonu_2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyonu_2.Odunc_Iade
{
    /// <summary>
    /// Kitap iade işlemlerini gerçekleştiren form.
    /// </summary>
    public partial class returnForm : Form
    {
        /// <summary>
        /// Veritabanı bağlamı temsil eder.
        /// </summary>
        LMSEntities db = new LMSEntities();

        /// <summary>
        /// returnForm sınıfının yapıcı metodu.
        /// </summary>
        public returnForm()
        {
            InitializeComponent(); // Form bileşenlerini başlatır.
        }
        /// <summary>
        /// Geri butonuna tıklanınca ana forma dönme işlemini gerçekleştirir.
        /// </summary>
        private void backButton_Click(object sender, EventArgs e)
        {
            ReturnToMainForm();
        }
        /// <summary>
        /// Form yüklenirken tetiklenen olay işleyicisi.
        /// </summary>
        private void returnForm_Load(object sender, EventArgs e)
        {
            ListRegistrations();
        }
        /// <summary>
        /// Form yüklenirken tetiklenen olay işleyicisi.
        /// </summary>
        private void ReturnToMainForm()
        {
            var mainForm = new eForm(); // Yeni ana form oluştur
            mainForm.Show(); // Ana formu göster
            Hide(); // Mevcut formu gizle
        }
        /// <summary>
        /// Kayıtları listeleme işlemini gerçekleştirir.
        /// </summary>
        private void ListRegistrations()
        {
            try
            {
                // İade edilmemiş kitap kayıtlarını al
                var registrations = db.Registrations.Where(x => x.status == false).ToList();
                dGW1.DataSource = registrations;// Verileri DataGridView'e bağla

                // DataGridView'deki gereksiz sütunları gizle
                if (dGW1.Columns.Count > 6)
                {
                    dGW1.Columns[6].Visible = false;
                }
                if (dGW1.Columns.Count > 7)
                {
                    dGW1.Columns[7].Visible = false;
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj göster
                MessageBox.Show("An error occurred while loading data: " + ex.Message);
            }
        }
        /// <summary>
        /// İade butonuna tıklanınca gerçekleşen işlemler.
        /// </summary>
        private void returnButton_Click(object sender, EventArgs e)
        {
            ReturnBook();// Kitabı iade et
            db.SaveChanges(); // Veritabanı değişikliklerini kaydet
            ListRegistrations(); // Kayıtları yeniden listele
        }
        /// <summary>
        /// Kitabı iade etme işlemini gerçekleştirir.
        /// </summary>
        public void ReturnBook()
        {
            try
            {
                // Eğer bir satır seçilmişse
                if (dGW1.CurrentRow != null)
                {
                    // Seçilen satırdaki kullanıcı ID'sini al
                    int userID = Convert.ToInt32(dGW1.CurrentRow.Cells[0].Value);
                    // İlgili kaydı veritabanından bul
                    var registration = db.Registrations.FirstOrDefault(x => x.RegistrationID == userID);
                    // Eğer kayıt varsa, durumu güncelle
                    if (registration != null)
                    {
                        registration.status = true;
                    }
                    else
                    {
                        // Kayıt bulunamazsa hata mesajı göster
                        MessageBox.Show("Selected registration not found.");
                    }
                }
                else
                {
                    // Kayıt seçilmemişse hata mesajı göster
                    MessageBox.Show("No registration selected.");
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj göster
                MessageBox.Show("An error occurred while returning the book: " + ex.Message);
            }
        }
    }
}
