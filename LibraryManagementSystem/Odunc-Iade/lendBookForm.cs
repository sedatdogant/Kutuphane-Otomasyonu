using Kutuphane_Otomasyonu_2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kutuphane_Otomasyonu_2.Odunc_Iade
{
    /// <summary>
    /// Kitap ödünç verme ve iade işlemlerini gerçekleştiren form.
    /// </summary>
    public partial class lendBookForm : Form
    {
        /// <summary>
        /// Veritabanı bağlamı temsil eder.
        /// </summary>
        LMSEntities db = new LMSEntities();

        /// <summary>
        /// lendBookForm sınıfının yapıcı metodu.
        /// </summary>
        public lendBookForm()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// Kullanıcı arama işlemini gerçekleştiren yöntem.
        /// </summary>
        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchUser(); ;
        }
        /// <summary>
        /// Kitap ödünç verme işlemini gerçekleştiren yöntem.
        /// </summary>
        private void lendButton_Click(object sender, EventArgs e)
        {
            LendBook();
        }
        /// <summary>
        /// Geri butonuna tıklanınca ana forma dönme işlemini gerçekleştirir.
        /// </summary>
        private void backButton_Click(object sender, EventArgs e)
        {
            ReturnToMainForm();
        }
        /// <summary>
        /// Arama metni değiştiğinde gerçekleştirilen işlemler.
        /// </summary>
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            SearchBooks();
        }
        /// <summary>
        /// Form yüklendiğinde tetiklenen olay işleyicisi.
        /// </summary>
        private void lendBookForm_Load(object sender, EventArgs e)
        {
            RefreshRegistrations();
        }
        /// <summary>
        /// Kullanıcı arama işlemini gerçekleştiren yöntem.
        /// </summary>
        private void SearchUser()
        {
            if (!int.TryParse(txt_TC.Text, out int userID))
            {
                MessageBox.Show("Geçersiz kullanıcı IDsi.");
                return;
            }

            var user = db.Users.FirstOrDefault(x => x.userID == userID);
            //label1.Text = user != null ? $"{user.userName} {user.userSurname}" : "Böyle bir kullanıcı yok!";
        }
        /// <summary>
        /// Kitap ödünç verme işlemini gerçekleştiren yöntem.
        /// </summary>
        private void LendBook()
        {
            if (!int.TryParse(txt_TC.Text, out int userID))
            {
                MessageBox.Show("Geçersiz kullanıcı IDsi.");
                return;
            }

            if (dGW2.CurrentRow == null)
            {
                MessageBox.Show("Ödünç verilecek kitabı seçin.");
                return;
            }

            int bookID = Convert.ToInt32(dGW2.CurrentRow.Cells["bookID"].Value);
            var user = db.Users.FirstOrDefault(x => x.userID == userID);
            var book = db.Books.FirstOrDefault(x => x.bookID == bookID);

            if (user == null || book == null)
            {
                MessageBox.Show("Kullanıcı veya kitap bulunamadı.");
                return;
            }

            var registration = new Registrations
            {
                bookID = book.bookID,
                userID = user.userID,
                a_date = DateTime.Today,
                b_date = DateTime.Today.AddDays(30),
                status = false
            };

            db.Registrations.Add(registration);
            db.SaveChanges();

            RefreshRegistrations();
        }
        /// <summary>
        /// Kitap arama işlemini gerçekleştiren yöntem.
        /// </summary>
        private void SearchBooks()
        {
            string searchTerm = txt_search.Text.Trim();
            var books = db.Books.Where(x => x.bookName.Contains(searchTerm)).ToList();
            dGW2.DataSource = books;
        }
        /// <summary>
        /// Kitap ödünç verme kayıtlarını yenileyen yöntem.
        /// </summary>
        private void RefreshRegistrations()
        {
            var registrations = db.Registrations.Select(kayit => new
            {
                kayit.Users.userName,
                kayit.Books.bookName,
                kayit.a_date,
                kayit.b_date,
                kayit.status
            }).ToList();
            dGW1.DataSource = registrations;
        }
        /// <summary>
        /// Ana forma geri dönmeyi sağlayan yöntem.
        /// </summary>
        private void ReturnToMainForm()
        {
            var mainForm = new eForm();
            mainForm.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
