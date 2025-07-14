using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using ComertApp.Models;

namespace ComertApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);          
            Application.Run(new MainForm());
            
        }
        static List<Raion> LoadRaioaneDinFisier(List<Magazin> magazine)
        {
            try
            {
                if (File.Exists("raioane.dat"))
                {
                    using (FileStream fs = new FileStream("raioane.dat", FileMode.Open))
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        var lista = (List<Raion>)bf.Deserialize(fs);
                        //eliminare dublicate dupa RaionId;
                        var unice = lista.GroupBy(r => r.RaionId).Select(g => g.First()).ToList();
                        foreach (var r in unice)
                        {
                            var m = magazine.FirstOrDefault(t => t.MagazinId == r.MagazinId);
                            if (m != null)
                                r.Magazin = m;
                        }
                        return unice;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la incarcare fisier binar: " + ex.Message);
            }
            return new List<Raion>();
        }

    }
}


