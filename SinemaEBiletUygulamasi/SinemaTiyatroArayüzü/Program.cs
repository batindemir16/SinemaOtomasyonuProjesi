using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaTiyatroArayüzü
{
    internal static class Program
    {
        static LogKayit logkayit = new LogKayit();
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            logkayit.AddLog("Info", "Uygulama Açıldı.", "UygulamaAçıldı");
            
        }
    }
}
