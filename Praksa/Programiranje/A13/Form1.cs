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

namespace A13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Producent> producenti;

        public SqlConnection konekcija;
        public SqlDataAdapter adapter;
        public DataTable tabela;
        public SqlCommand komanda;

        public void Konekcija()
        {
            konekcija = new SqlConnection();
            konekcija.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=M2_A13;Integrated Security=True;";
            komanda = new SqlCommand();
            komanda.Connection = konekcija;
            tabela = new DataTable();
            adapter = new SqlDataAdapter();
        }
        public void Clear()
        {
            tabela.Rows.Clear();
            tabela.Columns.Clear();
        }
        public void UpdateUI()
        {
            Konekcija();
            komanda.CommandText = "SELECT producentid, ime, email FROM producent";
            adapter.SelectCommand = komanda;
            adapter.Fill(tabela);
            producenti = new List<Producent>();
            for (int i = 0; i < tabela.Rows.Count; i++)
                producenti.Add(new Producent(tabela.Rows[i][0].ToString(), tabela.Rows[i][1].ToString(), tabela.Rows[i][2].ToString()));
            lista.DataSource = producenti;
            konekcija.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            Producent p = producenti[lista.SelectedIndex];
            sifraTB.Text = p.sifra;
            imeTB.Text = p.ime;
            mailTB.Text = p.email;
        }

        private void izmeniMenuItem_Click(object sender, EventArgs e)
        {
            Konekcija();
            try
            {
                konekcija.Open();
                string sifra = sifraTB.Text;
                string ime = imeTB.Text;
                string email = mailTB.Text;
                komanda.CommandText = "UPDATE producent SET ime = @ime, email = @email WHERE  producentId = @sifra;";
                komanda.Parameters.AddWithValue("@ime", ime);
                komanda.Parameters.AddWithValue("@email", email);
                komanda.Parameters.AddWithValue("@sifra", sifra);
                komanda.ExecuteNonQuery();
                MessageBox.Show("Uspešno ažurirano");
                UpdateUI();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška");
            }
            finally
            {
                konekcija.Close();
            }
        }

        private void izlazMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
