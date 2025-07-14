using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComertApp.Models; // folosim modele// clase declarate;
using System.Data.SQLite;

namespace ComertApp
{
    public partial class MainForm : Form
    {
        private List<Magazin> mag;
       
        public MainForm()
        {
            InitializeComponent();
            mag = new List<Magazin>()
            {
            new Magazin("Peek & Cloppenburg", "Baneasa 6B"),
            new Magazin("Unirea Shopping Center", "Blvd. Unirii 44")
            };
           

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bine ai venit in aplicatia Comert ! <-> CRM.","Bun venit!",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
           
        }

        private void mainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void deschideMagazinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MagazinForm mf = new MagazinForm(mag);
            this.Hide();
            mf.ShowDialog();
            this.Show();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        


    }
}
