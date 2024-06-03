using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyonu_2
{
    /// <summary>
    /// LibraryManagementSystem ad alanı, kütüphane yönetim sistemi uygulamasını içerir.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Uygulama için görsel stilleri etkinleştirir
            Application.EnableVisualStyles();
            // Uygulamanın uyumlu metin işleme varsayılanını ayarlar
            Application.SetCompatibleTextRenderingDefault(false);
            // Uygulamayı başlatır ve Form1'i ana form olarak açar
            Application.Run(new Form1());
        }
    }
}
