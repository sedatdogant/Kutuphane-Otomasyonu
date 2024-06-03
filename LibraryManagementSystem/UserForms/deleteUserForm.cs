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
    /// Kullanıcı silme formunu temsil eden sınıf.
    /// </summary>
    public partial class deleteUserForm : Form
    {
        /// <summary>
        /// Veritabanı bağlamı.
        /// </summary>
        LMSEntities db =new LMSEntities();
        /// <summary>
        /// deleteUserForm sınıfının yapıcı metodu.
        /// </summary>
        public deleteUserForm()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// Geri butonuna basıldığında ana formu açar.
        /// </summary>
        /// <param name="sender">Olayı tetikleyen nesne.</param>
        /// <param name="e">Olay argümanları.</param>
        private void backButton_Click(object sender, EventArgs e)
        {
           ReturnToMainForm();
        }
        /// <summary>
        /// Form yüklendiğinde yapılacak işlemler.
        /// </summary>
        /// <param name="sender">Olayı tetikleyen nesne.</param>
        /// <param name="e">Olay argümanları.</param>
        private void deleteUserForm_Load(object sender, EventArgs e)
        {
            RefreshUserList();
        }
        /// <summary>
        /// Kullanıcı silme işlemini gerçekleştirir.
        /// </summary>
        /// <param name="sender">Olayı tetikleyen nesne.</param>
        /// <param name="e">Olay argümanları.</param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            deleteUser();
        }
        /// <summary>
        /// Seçilen kullanıcıyı veritabanından siler.
        /// </summary>
        public void deleteUser()
        {
            int userID = Convert.ToInt32(dGW1.CurrentRow.Cells[0].Value);

            var user= db.Users.Where(x => x.userID == userID).FirstOrDefault(); //kullanıcı tablosuna git idsini denk olan kolonu al

            db.Users.Remove(user);
            db.SaveChanges();
            RefreshUserList();
        }
        /// <summary>
        /// Kullanıcı listesini yeniler.
        /// </summary>
        public void RefreshUserList()
        {

            var users = db.Users.ToList();
            dGW1.DataSource = users.ToList();
        }
        /// <summary>
        /// Kullanıcı listesini yeniler.
        /// </summary>
        public void ReturnToMainForm()
        {
            eForm newForm = new eForm();
            newForm.Show();
            this.Hide();
        }
    }
}
