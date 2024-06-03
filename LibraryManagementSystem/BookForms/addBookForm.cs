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
    /// Kütüphaneye yeni kitap eklemek için kullanılan form.
    /// </summary>
    public partial class addBookForm : Form
    {
        /// <summary>
        /// Veritabanı bağlamı temsil eder.
        /// </summary>
        LMSEntities db = new LMSEntities();
        /// <summary>
        /// addBookForm sınıfının yapıcı metodu.
        /// </summary>
        public addBookForm()
        {
            InitializeComponent();
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
        /// Form yüklendiğinde tetiklenen olay işleyicisi.
        /// </summary>
        private void addBookForm_Load(object sender, EventArgs e)
        {
            RefreshBookList();
        }
        /// <summary>
        /// Yeni kitap kaydı oluşturan yöntem.
        /// </summary>
        private void saveButton_Click(object sender, EventArgs e)
        {
            Books newBook = new Books();
            newBook.bookName = txt_bookName.Text;
            newBook.bookAuthor = txt_bookAuthor.Text;
            newBook.bookPublisher = txt_bookPublisher.Text;
            newBook.bookPages = txt_bookPages.Text;

            db.Books.Add(newBook);
            db.SaveChanges();
            
            RefreshBookList();

        }
        /// <summary>
        /// DataGridView hücresine tıklanınca gerçekleşen işlemler.
        /// </summary>
        private void dGW1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
