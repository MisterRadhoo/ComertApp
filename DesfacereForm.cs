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
    public partial class DesfacereForm : Form
    {
        private List<Magazin> magazine;
        private List<Raion> raioane;
        private List<Raion> raioaneCurente = new List<Raion>();
        private List<Desfacere> cosCumparaturi = new List<Desfacere>();
        private static List<Desfacere> tranzactiiGlobale = new List<Desfacere>();
        private int lastHoverIndex = -1;

        public DesfacereForm(List<Magazin> m, List<Raion>r)
        {
            InitializeComponent();
            magazine = m;
            raioane = r;

        }

        private void DesfacereForm_Load(object sender, EventArgs e)
        {
            cmbMagazin.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRaion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMagazin.DataSource = magazine;
            cmbMagazin.DisplayMember = "Nume";

            // alt shortcut-uri;
            btnAdaugaInCos.Text = "&Adauga in cos";
            btnTranzactie.Text = "&Tranzactie";
        }

        private void cmbMagazin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbMagazin.SelectedItem is Magazin magazin)
            {
                
                raioaneCurente = raioane
                    .Where(r => r.Magazin.MagazinId == magazin.MagazinId && r.Stoc > 0)
                    .GroupBy(r=>r.RaionId)
                    .Select(g=>g.First())
                    .ToList();
                cmbRaion.Items.Clear();
                foreach(var r in raioaneCurente)
                {
                    cmbRaion.Items.Add($"RaionId: {r.RaionId} -> Articol: {r.Articol}");
                }
                cmbRaion.SelectedIndex = -1;
                txtCantitate.Clear();
                txtPretTotal.Clear();

            }
        }

        private void cmbRaion_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculeazaTotal();

        }

        private void selectMag_Click(object sender, EventArgs e)
        {

        }

        private void selectRaion_Click(object sender, EventArgs e)
        {

        }

        private void txtCantitate_TextChanged(object sender, EventArgs e)
        {
            CalculeazaTotal();
        }
        private void CalculeazaTotal()
        {
            int index = cmbRaion.SelectedIndex;
            if( index >= 0 && int.TryParse(txtCantitate.Text, out int c))
            {
                Raion r = raioaneCurente[index];
                txtPretTotal.Text = $"{c * r.PretUnitar:0.00} lei";
            } else
            {
                txtPretTotal.Text = "0.00 lei";
            }

        }

        private void txtPretTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListBoxCos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (ListBoxCos.SelectedIndex >= 0)
            //{
            //    var desfacere = cosCumparaturi[ListBoxCos.SelectedIndex];
            //    MessageBox.Show(desfacere.ToString(), "Detalii produs din cos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            if (ListBoxCos.SelectedIndex >= 0)
            {
                var desfacere = cosCumparaturi[ListBoxCos.SelectedIndex];
                toolTip1.SetToolTip(ListBoxCos, desfacere.ToString()); 
            }
        }

        private void btnAdaugaInCos_Click(object sender, EventArgs e)
        {
            int index = cmbRaion.SelectedIndex;
            if(index >= 0 && int.TryParse(txtCantitate.Text, out int c) && c > 0)
            {
                Raion r = raioaneCurente[index];
                if(r.Stoc >= c)
                {
                    Desfacere d = new Desfacere(r, c);
                    cosCumparaturi.Add(d);
                    ListBoxCos.Items.Add(d.ToString());
                    txtCantitate.Clear();
                    txtPretTotal.Clear();
                } else
                {
                    MessageBox.Show("Stoc insuficient.");
                }

            }else
            {
                MessageBox.Show("Selecteaza un produs si introdu' o cantitate valida.");
            }
        }

        private void btnTranzactie_Click(object sender, EventArgs e)

        {    if(cosCumparaturi.Count == 0)
            {
                MessageBox.Show("Cosul este gol!");
                return;
            }

            foreach (var d in cosCumparaturi)
            {
                if (d.Cantitate > d.Raion.Stoc)
                {
                    MessageBox.Show($"Stoc insuficient pentru produsul '{d.Produs}' (disponibil: {d.Raion.Stoc}, cerut: {d.Cantitate})",
                        "Eroare tranzactie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            foreach (var d in cosCumparaturi)
            {
                d.Raion.ScadeStoc(d.Cantitate);
            }

            tranzactiiGlobale.AddRange(cosCumparaturi);

            string bon = string.Join("\n\n", cosCumparaturi.Select(c => c.GenereazaBonFiscal()));
            MessageBox.Show(bon, "Bon Fiscal", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Salvare bonFiscal intr-un fisier.txt; import;;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Salveaza bonul fiscal.";
            sfd.Filter = "Fisiere text (*.txt)|*.txt";
            sfd.FileName = $"BonFiscal_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.IO.File.WriteAllText(sfd.FileName, bon);
                    MessageBox.Show("Bonul fiscal salvat!", "Export txt.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                } catch (Exception ex)
                {
                    MessageBox.Show("Eroare la export: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ListBoxCos.Items.Clear();
            cosCumparaturi.Clear();
            cmbRaion_SelectedIndexChanged(null, null);


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(ListBoxCos.SelectedIndex >= 0)
            {
                int index = ListBoxCos.SelectedIndex;
                cosCumparaturi.RemoveAt(index);
                ListBoxCos.Items.RemoveAt(index);
            }else
            {
                MessageBox.Show("Selecteaza un articol pentru sters!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btnGraphic_Click(object sender, EventArgs e)
        {
            if (cmbMagazin.SelectedItem is Magazin magazin)
            {
                if (tranzactiiGlobale.Any(t => t.MagazinId == magazin.MagazinId))
                {
                    GraphicForm gf = new GraphicForm(tranzactiiGlobale, magazin);
                    gf.ShowDialog();  
                }
                else
                {
                    MessageBox.Show("Nu exista vanzari pentru acest magazin.");
                }
            }
            else
            {
                MessageBox.Show("Selecteaza un magazin!");
            }
        }

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListBoxMouseMove(object sender, MouseEventArgs e)
        {
            int index = ListBoxCos.IndexFromPoint(e.Location);

            if (index >= 0 && index < cosCumparaturi.Count)
            {
                var desfacere = cosCumparaturi[index];
                string tip = desfacere.ToString();

                
                if (index != lastHoverIndex || toolTip1.GetToolTip(ListBoxCos) != tip)
                {
                    lastHoverIndex = index;
                    toolTip1.SetToolTip(ListBoxCos, tip);
                }
            }
        }
    }
}
