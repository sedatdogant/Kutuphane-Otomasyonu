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
using System.IO;

namespace Kutuphane_Otomasyonu_2.Innovative_Section
{
    public partial class bookSuggesitonForm : Form
    {
        LMSEntities db = new LMSEntities();
        public bookSuggesitonForm()
        {
            InitializeComponent();
        }

        private void bookSuggesitonForm_Load(object sender, EventArgs e)
        {
            var bookList2 = db.Registrations.ToList();
            dGW2.DataSource = bookList2;
            var bookList = db.Registrations.ToList();
            dGW1.DataSource = bookList.ToList();
            
            dGW1.Columns[1].Visible = false;
            dGW1.Columns[3].Visible = false;
            dGW1.Columns[4].Visible = false;
            dGW1.Columns[6].Visible = false;
            dGW1.Columns[7].Visible = false;
            dGW1.Columns[5].Visible = false;
            var yeniKayitList = from kayit in db.Registrations select new { kayit.Users.userName, kayit.Books.bookName, kayit.a_date, kayit.b_date, kayit.status };
            dGW1.DataSource = yeniKayitList.ToList();

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            eForm newForm = new eForm();
            newForm.Show();
            this.Hide();
        }

        private void suggestionButton_Click(object sender, EventArgs e)
        {
            List<string> books = new List<string>();

            foreach (DataGridViewRow row in dGW2.Rows)
            {
                if (row.Cells[2].Value != null) // Üçüncü sütun null kontrolü
                {
                    int value;
                    if (int.TryParse(row.Cells[2].Value.ToString(), out value))
                    {

                        var bookName = db.Books.FirstOrDefault(k => k.bookID == value)?.bookName;
                        if (bookName != null)
                        {
                            books.Add(bookName);
                        }
                    }
                }
            }

            if (books.Count == 0)
            {
                list.Items.Add("DataGridView'de eşleşen kitap adı bulunamadı.");
                return;
            }


            var mostCommonBooks = books.GroupBy(x => x)
                                          .OrderByDescending(g => g.Count())
                                          .Select((g, index) => new { KitapAd = g.Key, OkunmaSayisi = g.Count(), Sira = index + 1 })
                                          .Take(5);

            foreach (var book in mostCommonBooks)
            {
                list.Items.Add($"{book.Sira} - {book.KitapAd} ({book.OkunmaSayisi} defa okundu)");
            }


        }
        

        private void listBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            if (list.SelectedItem != null)
            {
                string secilenKitap = list.SelectedItem.ToString();

                if (list.SelectedIndex == 0)
                {

                    try
                    {
                        string kurkMantoluPath = "C:\\Users\\leose\\OneDrive\\Masaüstü\\Kutuphane Otomasyonu_2\\KitapOzetleri\\kurkmantolumadonna.txt";
                        string icerik1 = File.ReadAllText(kurkMantoluPath);
                        MessageBox.Show(icerik1, "Kitap İçeriği");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Dosya okunurken bir hata oluştu: " + ex.Message);
                    }

                }
                if (list.SelectedIndex == 1)
                {

                    try
                    {
                        string sucveCezaPath = "C:\\Users\\leose\\OneDrive\\Masaüstü\\Kutuphane Otomasyonu_2\\KitapOzetleri\\incememed.txt";
                        string icerik2 = File.ReadAllText(sucveCezaPath);
                        MessageBox.Show(icerik2, "Kitap İçeriği");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Dosya okunurken bir hata oluştu: " + ex.Message);
                    }

                }
                if (list.SelectedIndex == 2)
                {

                    try
                    {
                        string tutunamayanlarPath = "C:\\Users\\leose\\OneDrive\\Masaüstü\\Kutuphane Otomasyonu_2\\KitapOzetleri\\sefiller.txt";
                        string icerik3 = File.ReadAllText(tutunamayanlarPath);
                        MessageBox.Show(icerik3, "Kitap İçeriği");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Dosya okunurken bir hata oluştu: " + ex.Message);
                    }

                }
                if (list.SelectedIndex == 3)
                {

                    try
                    {
                        string beyazKalePath = "C:\\Users\\leose\\OneDrive\\Masaüstü\\Kutuphane Otomasyonu_2\\KitapOzetleri\\sucveceza.txt";
                        string icerik4 = File.ReadAllText(beyazKalePath);
                        MessageBox.Show(icerik4, "Kitap İçeriği");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Dosya okunurken bir hata oluştu: " + ex.Message);
                    }

                }
                if (list.SelectedIndex == 4)
                {

                    try
                    {
                        string sefillerPath = "C:\\Users\\leose\\OneDrive\\Masaüstü\\Kutuphane Otomasyonu_2\\KitapOzetleri\\beyazgemi.txt";
                        string icerik5 = File.ReadAllText(sefillerPath);
                        MessageBox.Show(icerik5, "Kitap İçeriği");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Dosya okunurken bir hata oluştu: " + ex.Message);
                    }

                }
            }
        }
    }
}
