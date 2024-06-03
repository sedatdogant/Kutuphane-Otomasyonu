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
    /// Kütüphane kitapları üzerinde güncelleme işlemlerini gerçekleştiren form.
    /// </summary>
    public partial class updateBookForm : Form
    {
        /// <summary>
        /// updateBookForm sınıfının yapıcı metodu.
        /// </summary>
        public updateBookForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Veritabanı bağlamı temsil eder.
        /// </summary>
        LMSEntities db = new LMSEntities();
        /// <summary>
        /// Form yüklendiğinde tetiklenen olay işleyicisi.
        /// </summary>
        private void updateBookForm_Load(object sender, EventArgs e)
        {
            RefreshBookList();
        }
        /// <summary>
        /// Kitap güncelleme işlemini gerçekleştiren yöntem.
        /// </summary>
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (dGW1.CurrentRow == null) return;

            int bookID = Convert.ToInt32(dGW1.CurrentRow.Cells[0].Value);
            var book = db.Books.FirstOrDefault(x => x.bookID == bookID);

            if (book != null)
            {
                book.bookName = txt_bookName.Text;
                book.bookAuthor = txt_bookAuthor.Text;
                book.bookPublisher = txt_bookPublisher.Text;
                book.bookPages = txt_bookPages.Text;

                db.SaveChanges();
                RefreshBookList();
            }

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
        /// DataGridView hücresine tıklanınca gerçekleşen işlemler.
        /// </summary>
        private void dGW1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGW1.CurrentRow != null)
            {
                txt_bookName.Text = dGW1.CurrentRow.Cells[1].Value.ToString();
                txt_bookAuthor.Text = dGW1.CurrentRow.Cells[2].Value.ToString();
                txt_bookPublisher.Text = dGW1.CurrentRow.Cells[3].Value.ToString();
                txt_bookPages.Text = dGW1.CurrentRow.Cells[4].Value.ToString();
            }
        }
        /// <summary>
        /// Kitap listesini güncelleyen yöntem.
        /// </summary>
        private void RefreshBookList()
        {
            var bookList = db.Books.ToList();
            dGW1.DataSource = bookList;

        }


    }
}
