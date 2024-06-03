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
    /// Kullanıcı güncelleme formunu temsil eden sınıf.
    /// </summary>
    public partial class updateUserForm : Form
    {
        LMSEntities db = new LMSEntities();
        public updateUserForm()
        {
            /// <summary>
            /// Veritabanı bağlamı.
            /// </summary>
            InitializeComponent();
            LoadUserList(); // Kullanıcı listesini yükleme işlemini burada çağırın
        }
        /// <summary>
        /// Geri butonuna basıldığında ana formu açar.
        /// </summary>
        /// <param name="sender">Olayı tetikleyen nesne.</param>
        /// <param name="e">Olay argümanları.</param>
        private void backButton_Click(object sender, EventArgs e)
        {
            // Geri butonuna basıldığında yeni formu açma işlemini tek bir metoda taşıdık
            OpenMainForm();
        }
        /// <summary>
        /// Ana formu açar ve mevcut formu gizler.
        /// </summary>
        private void OpenMainForm()
        {
            eForm newForm = new eForm();
            newForm.Show();
            this.Hide();
        }
        /// <summary>
        /// Kullanıcı listesini yükler.
        /// </summary>
        private void LoadUserList()
        {
            // Kullanıcı listesini yükleme işlemini tekrar kullanılabilir bir metoda taşıdık
            var userList = db.Users.ToList();
            dGW1.DataSource = userList;
        }
        /// <summary>
        /// Kaydet butonuna basıldığında yapılacak işlemler.
        /// </summary>
        /// <param name="sender">Olayı tetikleyen nesne.</param>
        /// <param name="e">Olay argümanları.</param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            // Ekleme işlemi burada gerçekleştirilebilir, ancak size bağlıdır
        }
        /// <summary>
        /// Güncelle butonuna basıldığında kullanıcıyı günceller.
        /// </summary>
        /// <param name="sender">Olayı tetikleyen nesne.</param>
        /// <param name="e">Olay argümanları.</param>
        private void updateButton_Click(object sender, EventArgs e)
        {
            // Seçilen kullanıcının bilgilerini güncelleme işlemini tek bir metoda taşıdık
            UpdateUser();
        }
        /// <summary>
        /// Seçilen kullanıcının bilgilerini günceller.
        /// </summary>
        private void UpdateUser()
        {
            // Seçilen kullanıcının ID'sini alın
            int userID = Convert.ToInt32(dGW1.CurrentRow.Cells[0].Value.ToString());

            // Kullanıcıyı veritabanından alın
            var user = db.Users.FirstOrDefault(x => x.userID == userID);

            // Kullanıcının bilgilerini güncelleyin
            if (user != null)
            {
                user.userName = txt_username.Text;
                user.userSurname = txt_surname.Text;
                user.userPhoneNumber = txt_phoneNumber.Text;

                // Değişiklikleri kaydedin
                db.SaveChanges();

                // Güncellenmiş kullanıcı listesini yükle
                LoadUserList();
            }
        }
        /// <summary>
        /// DataGridView hücrelerine tıklandığında ilgili kullanıcı bilgilerini yükler.
        /// </summary>
        /// <param name="sender">Olayı tetikleyen nesne.</param>
        /// <param name="e">Olay argümanları.</param>
        private void dGW1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridView hücrelerine tıklandığında ilgili kullanıcı bilgilerini yükleme işlemini taşıdık
            LoadSelectedUserDetails();
        }
        /// <summary>
        /// Seçilen kullanıcının detaylarını yükler.
        /// </summary>
        private void LoadSelectedUserDetails()
        {
            txt_username.Text = dGW1.CurrentRow.Cells[1].Value?.ToString();
            txt_surname.Text = dGW1.CurrentRow.Cells[2].Value?.ToString();
            txt_phoneNumber.Text = dGW1.CurrentRow.Cells[3].Value?.ToString();
        }
        /// <summary>
        /// Form yüklendiğinde yapılacak işlemler.
        /// </summary>
        /// <param name="sender">Olayı tetikleyen nesne.</param>
        /// <param name="e">Olay argümanları.</param>
        private void updateUserForm_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde yapılacak işlemler.
        }
    }
}
