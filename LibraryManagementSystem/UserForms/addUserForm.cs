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
    /// Yeni kullanıcı eklemek için kullanılan form.
    /// </summary>
    public partial class addUserForm : Form
    {
        /// <summary>
        /// Veritabanı bağlamı temsil eder.
        /// </summary>
        LMSEntities db = new LMSEntities();
        /// <summary>
        /// addUserForm sınıfının yapıcı metodu.
        /// </summary>
        public addUserForm()
        {
            InitializeComponent();// Form bileşenlerini başlatır.
        }
        /// <summary>
        /// Form yüklenirken çalışan olay işleyicisi.
        /// </summary>
        private void addUserForm_Load(object sender, EventArgs e)
        {
            RefreshUserList();// Kullanıcı listesini yeniler
        }
        /// <summary>
        /// Kullanıcı eklemek için kaydetme butonuna tıklanınca çalışan olay işleyicisi.
        /// </summary>
        private void saveButton_Click(object sender, EventArgs e)
        {
            AddNewUser();// Yeni kullanıcı ekler
        }
        /// <summary>
        /// Geri butonuna tıklanınca ana forma dönme işlemini gerçekleştirir.
        /// </summary>
        private void backButton_Click(object sender, EventArgs e)
        {
            // Ana forma dön
            eForm newForm = new eForm();
            newForm.Show();
            this.Hide();
        }
        /// <summary>
        /// Kullanıcı listesini yenileyen yöntem.
        /// </summary>
        private void RefreshUserList()
        {
            dGW1.DataSource = db.Users.ToList(); // Kullanıcıları veritabanından alıp DataGridView'e bağlar
        }
        /// <summary>
        /// Yeni kullanıcı ekleyen yöntem.
        /// </summary>
        private void AddNewUser()
        {
            Users newUser = new Users();// Yeni kullanıcı nesnesi oluşturur
            newUser.userName = txt_username.Text; // Kullanıcı adını alır
            newUser.userSurname = txt_surname.Text; // Kullanıcı soyadını alır
            newUser.userPhoneNumber = txt_phoneNumber.Text; // Kullanıcı telefon numarasını alır

            db.Users.Add(newUser);// Yeni kullanıcıyı veritabanına ekler
            db.SaveChanges(); // Değişiklikleri kaydeder

            dGW1.DataSource = db.Users.ToList();// Kullanıcı listesini yeniler
        }
        /// <summary>
        /// DataGridView hücresine tıklanınca çalışan olay işleyicisi.
        /// </summary>
        private void dGW1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Bu olay işleyicisi şu an için boş bırakılmıştır
        }
        /// <summary>
        /// Ana forma geri dönmeyi sağlayan yöntem.
        /// </summary>
        private void ReturnToMainForm()
        {
            var mainForm = new eForm(); // Yeni ana form oluştur
            mainForm.Show(); // Ana formu göster
            Hide(); // Mevcut formu gizle
        }
    }
}
