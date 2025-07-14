using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComertApp.Models
{
    [Serializable]
    public class Desfacere

    {
        public static int id = 1;
        public int DesfacereId { get; private set; }
        public Raion Raion { get; set; }
        public string Produs => Raion?.Articol ?? "Unknown";
        public int Cantitate { get; set; }
        public double PretUnitar => Raion?.PretUnitar ?? 0;
        public double PretTotal => Cantitate * PretUnitar;
        public double PretTotalTVA => PretTotal * (1 + (0.19));
        public DateTime DataTranzactie { get; set; }
        public int RaionId => Raion?.RaionId ?? -1;
        public int MagazinId => Raion?.Magazin?.MagazinId ?? -1;

        public Desfacere() { }

        public Desfacere(Raion r, int cantitate)
        {
            DesfacereId = id++;
            Raion = r;
            Cantitate = cantitate;
            DataTranzactie = DateTime.Now;

        }
        public string GenereazaBonFiscal()
        {
            return $"---------------------------------------------\n" +
                   $"               Bon Fiscal                    \n" +
                   $"---------------------------------------------\n" +
                   $"Bon id: {DesfacereId}\n" +
                   $"Data: {DataTranzactie}\n" +
                   $"Magazin: {Raion.Magazin?.Nume}\n" +
                   $"Produs: {Produs}\n" +
                   $"Cantitate: {Cantitate} x {PretUnitar:0.00} lei\n" +
                   $"Total: {PretTotal:0.00} lei\n" +
                   $"TVA:  19%                  \n"+
                   $"Total cu TVA: {PretTotalTVA:0.00} lei\n" +
                   $"---------------------------------------------\n" +
                   $"      Multumim pentru cumparaturi !          \n" +
                   $"---------------------------------------------\n";
        }


        public override string ToString()
        {
            return $"{DesfacereId}: [{DataTranzactie:dd.MM.yyyy}] {Produs} x {Cantitate} -> {PretTotal:0.00} lei, fara TVA";
        }


    }
}
