using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComertApp.Models;

namespace ComertApp
{
    public partial class GraphicForm : Form
    {
        private List<Desfacere> tranzactii;
        private Magazin magazinCurent;
        public GraphicForm(List<Desfacere> t, Magazin m)
        {
            InitializeComponent();
            this.tranzactii = t;
            this.magazinCurent = m;
            this.Text = $"Top Vanzari - {magazinCurent.Nume}";
            this.BackColor = Color.White;
            this.Width = 800;
            this.Height = 500;
            this.DoubleBuffered = true;
            this.Paint += GraphicForm_Paint;

        }

        private void GraphicForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            var tranzactiiMagazin = tranzactii
                .Where(t => t.MagazinId == magazinCurent.MagazinId)
                .GroupBy(t => t.Produs)
                .Select(gp => new
                {
                    Produs = gp.Key,
                    Cantitate = gp.Sum(cant => cant.Cantitate)
                }).OrderByDescending(cant => cant.Cantitate)
                .Take(5)
                .ToList();

            if(tranzactiiMagazin.Count == 0)
            {
                g.DrawString("Nu exista vanzari pentru acest magazin.", new Font("Segoe UI", 11), Brushes.Black, 50, 50);
                return;
            }

            int x = 60;
            int yBase = 300;
            int barWidth = 40;
            int spacing = 60;

            int maxVal = tranzactiiMagazin.Max(p => p.Cantitate);
            Font font = new Font("Segoe UI", 7);
            Brush brush = Brushes.OrangeRed;
            Pen axePen = new Pen(Color.Black, 2);

            g.DrawLine(axePen, 40, yBase, x+tranzactiiMagazin.Count * (barWidth + spacing), yBase);
            g.DrawLine(axePen, 40, yBase, 40, 50);

            StringFormat format = new StringFormat { Alignment = StringAlignment.Center };
 

            foreach(var p in tranzactiiMagazin)
            {
                int height = (int)(200.0 * p.Cantitate / maxVal);
                g.FillRectangle(brush, x, yBase - height, barWidth, height);
                string produsLabel = SplitText(p.Produs);

                g.DrawString(produsLabel, font, Brushes.Black, new RectangleF(x - 15, yBase + 5, barWidth + 30,50), format);
                g.DrawString($"Qty:{p.Cantitate}", font, Brushes.Black,new RectangleF( x, yBase - height - 20, barWidth, 20),format);
                x += barWidth + spacing;
            }

           
        }
        // split string in two;
        private string SplitText(string text)
        {
            if (text.Length <= 15) return text;

            var words = text.Split(' ');
            if (words.Length < 2) return text;

            int mid = words.Length / 2;
            return string.Join(" ", words.Take(mid)) + "\n" + string.Join(" ", words.Skip(mid));
        }
        private void GraphicForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }



}



   
