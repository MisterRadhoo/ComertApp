using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComertApp.Models
{
    [Serializable]
    public class Raion
    {
        private static int id = 1;
        public Magazin Magazin {get; set;}
        public int MagazinId => Magazin?.MagazinId ?? -1;
        public int RaionId { get; private set; }
        public string Categorie { get; set; }
        public string Articol { get; set; }
        public double PretUnitar { get; set; }
        public int Stoc { get; set; }
        public static void SetCounter(int value) => id = value;
        public Raion() { }
        public Raion(Magazin m, string categorie, string art, double pret, int stoc)
        {
            Magazin = m;
            RaionId = id++;
            Categorie = categorie;
            Articol = art;
            PretUnitar = pret;
            Stoc = stoc;

        }
        public bool ScadeStoc(int cantitate)
        {
            if (cantitate <= 0) return false;
            if(Stoc >= cantitate)
            {
                Stoc -= cantitate;
                MessageBox.Show($"Stoc ramas: -> {Stoc} - Articol: {Articol}","Stoc update.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
                
            }
            return false;
        }
        public override string ToString()
        {
            return $"Magazin Id: {MagazinId} ,Raion Id: {RaionId}, Categorie: -> {Categorie}, Articol: -> {Articol},Pret: -> {PretUnitar:0.00} lei,Stoc: -> {Stoc}";
        }

    }
}
