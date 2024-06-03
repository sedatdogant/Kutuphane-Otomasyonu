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

namespace Kutuphane_Otomasyonu_2
{
    /// <summary>
    /// Kütüphaneden kitap silme işlemlerini gerçekleştiren form.
    /// </summary>
    public partial class deleteBookForm : Form
    {
        /// <summary>
        /// Veritabanı bağlamı temsil eder.
        /// </summary>
        LMSEntities db = new LMSEntities();
        /// <summary>
        /// deleteBookForm sınıfının yapıcı metodu.
        /// </summary>
        public deleteBookForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Form yüklendiğinde tetiklenen olay işleyicisi.
        /// </summary>
        private void deleteBookForm_Load(object sender, EventArgs e)
        {
            RefreshBookList();
        }
        /// <summary>
        /// Geri butonuna tıklanınca ana forma dönme işlemini gerçekleştirir.
        /// </summary>
        private void backButton_Click(object sender, EventArgs e)
        {
            var newForm = new eForm();
            newForm.Show();
            Hide();
        }
        /// <summary>
        /// Kitap silme işlemini gerçekleştiren yöntem.
        /// </summary>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dGW1.CurrentRow == null) return;

            int bookID = Convert.ToInt32(dGW1.CurrentRow.Cells[0].Value);
            var book = db.Books.FirstOrDefault(x => x.bookID == bookID);

            if (book != null)
            {
                db.Books.Remove(book);
                db.SaveChanges();
                RefreshBookList();
            }
            else
            {
                MessageBox.Show("Kitap Bulunamadi!");
            }
        }
        /// <summary>
        /// Kitap listesini güncelleyen yöntem.
        /// </summary>
        private void RefreshBookList()
        {
            dGW1.DataSource = db.Books.ToList();
        }
    }
}
