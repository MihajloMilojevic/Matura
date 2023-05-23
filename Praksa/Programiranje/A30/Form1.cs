using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public SqlConnection konekcija;
        public SqlDataAdapter adapter;
        public DataTable tabela;
        public SqlCommand komanda;
        public void Konekcija()
        {
            konekcija = new SqlConnection();
            konekcija.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MM_A30;Integrated Security=True;";
            komanda = new SqlCommand();
            komanda.Connection = konekcija;
            tabela = new DataTable();
            adapter = new SqlDataAdapter();
        }
        private List<Teren> tereni = new List<Teren>();
        private void Form1_Load(object sender, EventArgs e)
        {
            Teren headerT = new Teren("ID", "Naziv", "Adresa", "Telefon", "Grad");
            headerLB.Text = headerT.ToString();
            PrikaziListu();
        }
        private void PrikaziListu()
        {
            Konekcija();
            konekcija.Open();
            komanda.CommandText = @"SELECT t.teren_id, t.teren, t.adresa, t.kontakt_telefon, g.grad FROM teren t JOIN grad g ON t.grad_id = g.grad_id";
            adapter.SelectCommand = komanda;
            adapter.Fill(tabela);
            tereni.Clear();
            listaTerena.Items.Clear();
            gradCB.Items.Clear();
            sifraCB.Items.Clear();
            ObrisiTeren();
            SortedSet<string> gradovi = new SortedSet<string>();
            foreach (DataRow red in tabela.Rows)
            {
                Teren t = new Teren(
                    red[0].ToString(),
                    red[1].ToString(),
                    red[2].ToString(),
                    red[3].ToString(),
                    red[4].ToString()
                );
                gradovi.Add(t.grad);
                tereni.Add(t);
            }

            foreach (Teren t in tereni)
            {
                listaTerena.Items.Add(t.ToString());
                sifraCB.Items.Add(t.id);
            }
            foreach (string grad in gradovi) gradCB.Items.Add(grad);
            konekcija.Close();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ObrisiTeren()
        {
            sifraCB.Text = "";
            gradCB.Text = "";
            sifraCB.SelectedIndex = -1;
            gradCB.SelectedIndex = -1;
            nazivTB.Text = "";
            adresaTb.Text = "";
            telefonTB.Text = "";
        }
        private void PrikaziTeren(string id)
        {
            if (id == "")
            {
                ObrisiTeren();
                return;
            }
            Teren teren = null;
            foreach (Teren t in tereni) if (t.id == id) teren = t;
            if(teren == null)
            {
                MessageBox.Show("Ne postoji teren sa id-jem " + id);
                ObrisiTeren();
                return;
            }
            sifraCB.SelectedItem = teren.id;
            gradCB.SelectedItem = teren.grad;
            nazivTB.Text = teren.naziv;
            adresaTb.Text = teren.adresa;
            telefonTB.Text = teren.telefon;
        }

        private void listaTerena_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaTerena.SelectedIndex < 0 || listaTerena.SelectedIndex >= tereni.Count) return;
            Teren t = tereni[listaTerena.SelectedIndex];
            PrikaziTeren(t.id);
        }

        private void sifraCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrikaziTeren(sifraCB.Text);
        }

        private void sifraCB_TextUpdate(object sender, EventArgs e)
        {
            PrikaziTeren(sifraCB.Text);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da želite da obrišete " + nazivTB.Text, "Potrvda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            Konekcija();
            konekcija.Open();
            komanda.CommandText = "DELETE FROM teren WHERE teren_id = @ID";
            komanda.Parameters.AddWithValue("@ID", sifraCB.Text);
            komanda.ExecuteNonQuery();
            MessageBox.Show("Uspešno obrisano");
            PrikaziListu();
            konekcija.Close();
        }
    }
}
