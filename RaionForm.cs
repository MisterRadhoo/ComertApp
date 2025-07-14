using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using ComertApp.Models;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ComertApp
{
    public partial class RaionForm : Form
    {
        private List<Magazin> magazine;
        private List<Raion> raioane = new List<Raion>();
        public RaionForm(List<Magazin> listaMagazine, List<Raion> listaRaioane)
        {
            InitializeComponent();
            magazine = listaMagazine;
            raioane = listaRaioane;
            txtCategorie.Validating += TxtCategorie_Validating;
            txtArticol.Validating += TxtArticol_Validating;
            textPretUnitar.Validating += TextPretUnitar_Validating;
            txtStoc.Validating += TxtStoc_Validating;
            InitListView();

        }
        private void RaionForm_Load(object sender, EventArgs e)
        {
            ComboBoxMagazin.DropDownStyle = ComboBoxStyle.DropDownList;        // doar selectie
            foreach (var m in magazine)
            {
                ComboBoxMagazin.Items.Add(m);
            }
            ComboBoxMagazin.DisplayMember = "Nume"; // afisare nume magazine;
            LoadRaioaneDinFisier();
           
        }
        private void InitListView()
        {
            listViewRaioane.View = View.Details;
            listViewRaioane.FullRowSelect = true;
            listViewRaioane.GridLines = true;
            listViewRaioane.Columns.Add("RaionId", 60);
            listViewRaioane.Columns.Add("Magazin", 90);
            listViewRaioane.Columns.Add("Categorie", 90);
            listViewRaioane.Columns.Add("Articol", 90);
            listViewRaioane.Columns.Add("Pret Unitar ( Lei )", 65);
            listViewRaioane.Columns.Add("Stoc", 50);

            listViewRaioane.SelectedIndexChanged += listViewRaioane_SelectedIndexChanged;
        }
        private void AddToListViewRaion(Raion r)
        {
            var item = new ListViewItem(r.RaionId.ToString());
            item.SubItems.Add(r.Magazin?.Nume ?? "-");
            item.SubItems.Add(r.Categorie);
            item.SubItems.Add(r.Articol);
            item.SubItems.Add(r.PretUnitar.ToString("0.00"));
            item.SubItems.Add(r.Stoc.ToString());
            listViewRaioane.Items.Add(item);
        }

        private void txtCategorie_TextChanged(object sender, EventArgs e)
        {
            txtCategorie.ForeColor = Color.DarkOrange;
            txtArticol.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        private void txtArticol_TextChanged(object sender, EventArgs e)
        {

            txtArticol.ForeColor = Color.BlueViolet;

        }

        private void textPretUnitar_TextChanged(object sender, EventArgs e)
        {
            textPretUnitar.ForeColor = Color.DarkBlue;
            textPretUnitar.Font = new Font("Segoe UI", 10, FontStyle.Bold);


        }

        private void txtStoc_TextChanged(object sender, EventArgs e)
        {
            txtArticol.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        private void ComboBoxMagazin_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBoxMagazin.BackColor = Color.FromArgb(255, 140, 0); // DarkOrange manual
            ComboBoxMagazin.ForeColor = Color.Black;
            ComboBoxMagazin.FlatStyle = FlatStyle.Popup;

            // optional: schimbi si fontul sa para selectat
            ComboBoxMagazin.Font = new Font("Segoe UI", 10, FontStyle.Bold);

        }

        private void listViewRaioane_SelectedIndexChanged(object sender, EventArgs e)

        { if (listViewRaioane.SelectedItems.Count > 0)
            {
                var item = listViewRaioane.SelectedItems[0];
                int id = int.Parse(item.SubItems[0].Text);
                Raion r = raioane.FirstOrDefault(x => x.RaionId == id);

                if (r != null)
                {
                    txtCategorie.Text = r.Categorie;
                    txtArticol.Text = r.Articol;
                    textPretUnitar.Text = r.PretUnitar.ToString("0.00");
                    txtStoc.Text = r.Stoc.ToString();
                    ComboBoxMagazin.SelectedItem = r.Magazin;
                }

            }

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!ValidateChildren())
            {
                MessageBox.Show("Datele introduse sunt eronate.", "Eroare Validare !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (ComboBoxMagazin.SelectedItem is Magazin magazin &&
                !string.IsNullOrWhiteSpace(txtCategorie.Text) &&
                !string.IsNullOrWhiteSpace(txtArticol.Text) &&
                int.TryParse(txtStoc.Text, out int stoc) &&
                double.TryParse(textPretUnitar.Text, out double pret))
            {

                bool exista = raioane.Any(x =>
                x.Magazin.MagazinId == magazin.MagazinId &&
                x.Categorie.Equals(txtCategorie.Text.Trim(), StringComparison.OrdinalIgnoreCase) &&
                 x.Articol.Equals(txtArticol.Text.Trim(), StringComparison.OrdinalIgnoreCase));

                if (exista)
                {
                    MessageBox.Show("Raionul exista deja (categorie + articol).", "Duplicat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                Raion r = new Raion(magazin, txtCategorie.Text, txtArticol.Text, pret, stoc);
                raioane.Add(r);
                AddToListViewRaion(r);
                SaveRaioaneInFisier(); // salvare fisier binar "raioane";
                ResetInputs();

            } else
            {
                MessageBox.Show("Completeaza campurile corect si pretul!!", "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {



            if (listViewRaioane.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecteaza un raion pentru update.");
                return;
            }

            //errorProvider;
            if (!ValidateChildren())
            {
                MessageBox.Show("Datele introduse sunt eronate!", "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var item = listViewRaioane.SelectedItems[0];
            int id = int.Parse(item.SubItems[0].Text);
            Raion r = raioane.FirstOrDefault(x => x.RaionId == id);

            if (r != null && ComboBoxMagazin.SelectedItem is Magazin m &&
                int.TryParse(txtStoc.Text, out int stoc) &&
                double.TryParse(textPretUnitar.Text, out double pret)) {

                r.Magazin = m;
                r.Categorie = txtCategorie.Text;
                r.Articol = txtArticol.Text;
                r.PretUnitar = pret;
                r.Stoc = stoc;

                item.SubItems[1].Text = m.Nume;
                item.SubItems[2].Text = r.Categorie;
                item.SubItems[3].Text = r.Articol;
                item.SubItems[4].Text = r.PretUnitar.ToString("0.00");
                item.SubItems[5].Text = r.Stoc.ToString();

                SaveRaioaneInFisier();  // salvare in fisier binar;
                ResetInputs();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewRaioane.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecteaza un raion de sters.");
                return;
            }
            var item = listViewRaioane.SelectedItems[0];
            int id = int.Parse(item.SubItems[0].Text);
            Raion r = raioane.FirstOrDefault(x => x.RaionId == id);

            if (r != null)
            {
                raioane.Remove(r);
                listViewRaioane.Items.Remove(item);
                MessageBox.Show("Raion Sters.");
                ResetInputs();
            }

        }
        private void ResetInputs()
        {
            txtCategorie.Clear();
            txtArticol.Clear();
            textPretUnitar.Clear();
            txtStoc.Clear();
            ComboBoxMagazin.SelectedIndex = -1;
            listViewRaioane.SelectedItems.Clear();
        }

        private void select_Click(object sender, EventArgs e)
        {

        }

        //ErrorProvider1; (methods);
        private void TxtCategorie_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategorie.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCategorie, "Completeaza categoria.");
            } else
            {
                errorProvider1.SetError(txtCategorie, "");
            }
        }

        private void TxtArticol_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtArticol.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtArticol, "Completeaza Articol.");

            } else
            {
                errorProvider1.SetError(txtArticol, "");
            }
        }

        private void TextPretUnitar_Validating(object sender, CancelEventArgs e)
        {
            if (!double.TryParse(textPretUnitar.Text, out double pret) || pret <= 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(textPretUnitar, "Pret invalid (> 0) .");
            } else
            {
                errorProvider1.SetError(textPretUnitar, "");
            }
        }

        private void TxtStoc_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtStoc.Text, out int stoc) || stoc < 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtStoc, "Stoc invalid (>=0).");
            } else
            {
                errorProvider1.SetError(txtStoc, "");
            }
        }
        //serializare;
        private void SaveRaioaneInFisier()
        {
            try
            {
                var listaUnica = raioane.GroupBy(x => x.RaionId).Select(g => g.First()).ToList();
                using (FileStream fs = new FileStream("raioane.dat", FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs,listaUnica);

                }
                MessageBox.Show("Raioanele au fost salvate in fisierul binar.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvare fisier binar: " + ex.Message);
            }
        }

        //deserializare;
        private void LoadRaioaneDinFisier()
        {
            try
            {
                if (File.Exists("raioane.dat"))
                {
                    using (FileStream fs = new FileStream("raioane.dat", FileMode.Open))
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        var listaIncarcata = (List<Raion>)bf.Deserialize(fs);

                        
                        foreach (var r in listaIncarcata)
                        {
                            var m = magazine.FirstOrDefault(x => x.MagazinId == r.MagazinId);
                            if (m != null)
                                r.Magazin = m;

                            raioane.Add(r);
                            AddToListViewRaion(r);
                        }
                        int maxId = listaIncarcata.Max(r => r.RaionId);
                        Raion.SetCounter(maxId + 1);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la incarcare fisier binar: " + ex.Message);
            }
        }

        private void btnAddRaion_Click(object sender, EventArgs e)
        {
            btnAdd_Click(sender,e);
        }

        private void btnModificaRaion_Click(object sender, EventArgs e)
        {
            btnUpdate_Click(sender,e);
        }

        private void btnStergeRaion_Click(object sender, EventArgs e)
        {
            btnDelete_Click(sender, e);
        }

        private void btnDesfacere_Click(object sender, EventArgs e)
        {
            if (raioane.Count == 0)
            {
                MessageBox.Show("Adauga cel putin un raion inainte de a continua.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DesfacereForm df = new DesfacereForm(magazine, raioane);
            this.Hide();
            df.ShowDialog();
            this.Show();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    
}
