using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using ComertApp.Models;
using System.IO;



namespace ComertApp
{
    public partial class MagazinForm : Form
    {
        List<Magazin> magazine;

        private readonly string ConnectionString = $"Data Source={Path.Combine(Application.StartupPath, "Data", "database.db")}";

        public MagazinForm(List<Magazin>listaMagazine)
        {
            InitializeComponent();
            magazine = listaMagazine;

        }
        private void MagazinForm_Load(object sender, EventArgs e)
        {
            LoadMagazineDB();
            listBox1.Items.Clear();
            foreach (var mag in magazine)
            {
                listBox1.Items.Add(mag);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nume = textBox1.Text.Trim();
            string adresa = textBox2.Text.Trim();

            if (string.IsNullOrWhiteSpace(nume) || string.IsNullOrWhiteSpace(adresa))
            {
                MessageBox.Show("Completeaza ambele campuri.");
                return;
            }

            // Verificare duplicat;
            if (magazine.Any(m => m.Nume == nume && m.Adresa == adresa))
            {
                MessageBox.Show("Magazinul exista deja.");
                return;
            }

            

            // Adaugare si in baza de date si in lista;
            var mag = new Magazin(nume, adresa);
            AddMagazin(mag);
            magazine.Add(mag);
            listBox1.Items.Add(mag);

            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();

        }
        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if(index < 0)
            {
                MessageBox.Show("Select Store to update !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newName = textBox1.Text.Trim();
            string newAddress = textBox2.Text.Trim();
            if(string.IsNullOrWhiteSpace(newName) || string.IsNullOrWhiteSpace(newAddress)) {
                MessageBox.Show("Completeaza campurile!", "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Magazin m = magazine[index];
            m.Nume = newName;
            m.Adresa = newAddress;
            UpdateMagazin(m);

            listBox1.Items.RemoveAt(index);  //sterge elementul vechi;
            listBox1.Items.Insert(index, m);    // re-adaugare element actualizat;
            MessageBox.Show("Magazin actualizat cu succes!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();


        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Selecteaza un magazin din lista pentru a-l sterge.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var confirmare = MessageBox.Show("Stergere Magazin selectat ?", "Magazin Sters.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmare == DialogResult.Yes)
            {
                Magazin mag = magazine[index];
                DeleteMagazin(mag.MagazinId);
                magazine.RemoveAt(index);
                listBox1.Items.RemoveAt(index);
                textBox1.Clear();
                textBox2.Clear();
                listBox1.ClearSelected();
                MessageBox.Show("Magazin sters cu succes!", "Sterge.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex >= 0)
            {
                Magazin m = (Magazin)listBox1.SelectedItem;
                textBox1.Text = m.Nume;
                textBox2.Text = m.Adresa;

            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Nume Magazin")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.OrangeRed;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Nume Magazin";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void btnToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRaion_Click(object sender, EventArgs e)
        {
            if(magazine.Count == 0)
            {
                MessageBox.Show("Adauga cel putin un magazin!!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            RaionForm rf = new RaionForm(magazine, new List<Raion>());
            this.Hide();
            rf.ShowDialog();
            this.Show();
        }
        //add magazin in baza de date SQLite;
        private void AddMagazin(Magazin m)
        {
            var query = "INSERT INTO Magazin(Nume, Adresa) VALUES(@Nume, @Adresa); SELECT last_insert_rowId()";
            using (var connection = new SQLiteConnection(ConnectionString))
            {   using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nume", m.Nume);
                    command.Parameters.AddWithValue("@Adresa", m.Adresa);
                    connection.Open();
                    //command.ExecuteNonQuery();  // query care nu intoarce date;
                    m.MagazinId = (int)(long)command.ExecuteScalar();
                   // command.ExecuteScalar(); // returneaza o singula valoare ca object;
                }


            }
        }
        //update magazin baza de date;
        private void UpdateMagazin(Magazin magazin)
        {
            var query = "UPDATE Magazin SET Nume = @Nume, Adresa=@Adresa WHERE MagazinId=@Id";
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", magazin.MagazinId);
                    command.Parameters.AddWithValue("@Nume", magazin.Nume);
                    command.Parameters.AddWithValue("@Adresa", magazin.Adresa);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        //stergere Magazin din baza de date;
        private void DeleteMagazin(int id)
        {
            var query = "DELETE FROM Magazin WHERE MagazinId=@Id";
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

        }
        private void LoadMagazineDB()
        {
            const string query = "SELECT * FROM Magazin";
            magazine.Clear();
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(query, connection);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = (int)(long)reader["MagazinId"];
                        string nume = (string)reader["Nume"];
                        string adresa = (string)reader["Adresa"];
                        Magazin magazin = new Magazin(nume, adresa);
                        magazin.MagazinId =(int)id;
                        magazine.Add(magazin);

                    }
                }

            }
        }

    }
}
