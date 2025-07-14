using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ComertApp.Models
{
    [Serializable]
    public class Magazin
    {
        public static int id = 1; // incrementare automata id;
        public int MagazinId { get;  set; }
        public string Nume { get; set; }
        public string Adresa { get; set; }


        public Magazin() { }
        public Magazin(string nume, string adresa)
        {
            MagazinId = id++;
            Nume = nume;
            Adresa = adresa;
        }
        public override string ToString()
        {
            return $"Magazin id: {MagazinId} -->> {Nume} <<-->> {Adresa}";
        }
    }
}
