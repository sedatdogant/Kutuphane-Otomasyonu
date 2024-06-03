using Kutuphane_Otomasyonu_2.Innovative_Section;// Yeni kitap öneri bölümü için gerekli namespace
using Kutuphane_Otomasyonu_2.Odunc_Iade;// Ödünç ve iade bölümü için gerekli namespace
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
    /**
    * @class eForm
    * @brief Ana yönetim formunu temsil eder.
    *
    * Bu sınıf, kullanıcıların kitap ekleme, silme, güncelleme ve ödünç alma/iade işlemlerini
    * gerçekleştirebileceği ana formu temsil eder.
    */
    public partial class eForm : Form
    {
        /**
        * @brief eForm yapıcı metodu.
        *
        * Form bileşenlerini başlatır.
        */
        public eForm()
        {
            // Form bileşenlerini başlatır.
            InitializeComponent();
        }
        /**
        * @brief Kullanıcı ekleme formuna geçiş yapar.
        * @param sender Olayı tetikleyen nesne.
        * @param e Olay argümanları.
        */
        private void addUserButton_Click(object sender, EventArgs e)
        {
            // Kullanıcı ekleme formuna geç
            goToForm(new addUserForm());
        }
        /**
        * @brief Kullanıcı güncelleme formuna geçiş yapar.
        * @param sender Olayı tetikleyen nesne.
        * @param e Olay argümanları.
        */
        private void updateUserButton_Click(object sender, EventArgs e)
        {
            // Kullanıcı güncelleme formuna geç
            goToForm(new updateUserForm());
        }
        /**
        * @brief Kullanıcı silme formuna geçiş yapar.
        * @param sender Olayı tetikleyen nesne.
        * @param e Olay argümanları.
        */
        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            // Kullanıcı silme formuna geç
            goToForm(new deleteUserForm());
        }
        /**
        * @brief Kitap ekleme formuna geçiş yapar.
        * @param sender Olayı tetikleyen nesne.
        * @param e Olay argümanları.
        */
        private void addBookButton_Click(object sender, EventArgs e)
        {
            // Kitap ekleme formuna geç
            goToForm(new addBookForm());
        }
        /**
        * @brief Kitap güncelleme formuna geçiş yapar.
        * @param sender Olayı tetikleyen nesne.
        * @param e Olay argümanları.
        */
        private void updateBookButton_Click(object sender, EventArgs e)
        {
            // Kitap güncelleme formuna geç
            goToForm(new updateBookForm());
        }
        /**
       * @brief Kitap silme formuna geçiş yapar.
       * @param sender Olayı tetikleyen nesne.
       * @param e Olay argümanları.
       */
        private void deleteBookButton_Click(object sender, EventArgs e)
        {
            // Kitap silme formuna geç
            goToForm(new deleteBookForm());
        }
        /**
       * @brief Kitap ödünç verme formuna geçiş yapar.
       * @param sender Olayı tetikleyen nesne.
       * @param e Olay argümanları.
       */
        private void lendBookButton_Click(object sender, EventArgs e)
        {
            // Kitap ödünç verme formuna geç
            goToForm(new lendBookForm());
        }
        /**
       * @brief Kitap iade etme formuna geçiş yapar.
       * @param sender Olayı tetikleyen nesne.
       * @param e Olay argümanları.
       */
        private void button2_Click(object sender, EventArgs e)
        {
            // Kitap iade etme formuna geç
            goToForm(new returnForm());
        }
        /**
        * @brief Mevcut formu gizler.
        * @param sender Olayı tetikleyen nesne.
        * @param e Olay argümanları.
        */
        private void button3_Click(object sender, EventArgs e)
        {
            // Mevcut formu gizle
            this.Hide();
        }
        /**
        * @brief Kitap öneri formuna geçiş yapar.
        * @param sender Olayı tetikleyen nesne.
        * @param e Olay argümanları.
        */
        private void suggestionButton_Click(object sender, EventArgs e)
        {
            // Kitap öneri formuna geç
            goToForm(new bookSuggesitonForm());
        }
        /**
        * @brief Form yüklendiğinde yapılacak işlemler.
        * @param sender Olayı tetikleyen nesne.
        * @param e Olay argümanları.
        */
        private void eForm_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde yapılacak işlemler burada tanımlanabilir
        }
        /**
        * @brief Yeni bir forma geçiş yapar ve mevcut formu gizler.
        * @param newForm Geçiş yapılacak yeni form.
        */
        private void goToForm(Form newForm)
        {

            newForm.Show();// Yeni formu göster
            this.Hide();// Mevcut formu gizle
        }
    }
}
