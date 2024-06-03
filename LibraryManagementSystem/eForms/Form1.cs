using System;
using System.Windows.Forms;
namespace Kutuphane_Otomasyonu_2
{
    /**
    * @class Form1
    * @brief Ana giriş formunu temsil eder.
    *
    * Bu sınıf, kullanıcıların giriş yapabileceği ana formu temsil eder.
    */
    public partial class Form1 : Form
    {
        /**
        * @brief Form1 sınıfının yapıcı metodu.
        *
        * Form bileşenlerini başlatır ve şifre giriş kutusunun karakterlerini gizler.
        */
        public Form1()
        {
            InitializeComponent(); // Form bileşenlerini başlatır.
            txt_userPassword.PasswordChar = '*'; // Şifre giriş kutusunda girilen karakterlerin '*' ile gizlenmesini sağlar.
        }
        /**
        * @brief Giriş butonuna tıklanma olayı.
        * @param sender Olayı tetikleyen nesne.
        * @param e Olay argümanları.
        *
        * Kullanıcı adı ve şifreyi kontrol eder ve doğruysa yeni formu açar, yanlışsa hata mesajı gösterir.
        */
        private void loginbutton_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifreyi al
            string username = txt_username.Text;
            string userpassword = txt_userPassword.Text;
            // Kullanıcı adı ve şifre doğrulaması
            if ((username == "sedatdogan" && userpassword == "2133") || (username == "rumeysaer" && userpassword == "1234"))
            {
                // Eğer kullanıcı adı ve şifre doğruysa yeni formu aç ve mevcut formu gizle
                eForm newForm = new eForm();
                newForm.Show();
                this.Hide();
            }
            else
            {
                // Eğer kullanıcı adı veya şifre yanlışsa hata mesajı göster
                MessageBox.Show("Personel'in adi veya sifresi yanlis!");
            }
        }
        /**
        * @brief Form yüklendiğinde yapılacak işlemler.
        * @param sender Olayı tetikleyen nesne.
        * @param e Olay argümanları.
        */
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /**
        * @brief Label2 tıklanma olayı.
        * @param sender Olayı tetikleyen nesne.
        * @param e Olay argümanları.
        */
        private void label2_Click(object sender, EventArgs e)
        {

        }
        /**
        * @brief Label1 tıklanma olayı.
        * @param sender Olayı tetikleyen nesne.
        * @param e Olay argümanları.
        */
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}