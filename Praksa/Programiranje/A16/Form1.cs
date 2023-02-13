using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace A16
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

        public void Konkcija()
        {
            konekcija = new SqlConnection();
            konekcija.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=M2_A16;Integrated Security=True;";
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

        private void izlazBTN1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void izlazBTN2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void izlazBTN3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Konkcija();
            komanda.CommandText = "SELECT id_izlozbe, mesto, datum FROM izlozba";
            adapter.SelectCommand = komanda;
            adapter.Fill(tabela);
            for (int i = 0; i < tabela.Rows.Count; i++ )
            {
                string id = tabela.Rows[i][0].ToString();
                string mesto = tabela.Rows[i][1].ToString();
                string datum = Convert.ToDateTime(tabela.Rows[i][2].ToString()).ToString("dd.MM.yyyy");
                izlozbaCB.Items.Add(id + " -  " + mesto + " - " + datum);
                statistikaIzlozbaCB.Items.Add(id + " -  " + mesto + " - " + datum);
            }
            Clear();
            komanda.CommandText = "SELECT id_kategorije, naziv FROM kategorija";
            adapter.SelectCommand = komanda;
            adapter.Fill(tabela);
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                string id = tabela.Rows[i][0].ToString();
                string naziv = tabela.Rows[i][1].ToString();
                kategorijaCB.Items.Add(id + " -  " + naziv);
            }
            Clear();
            komanda.CommandText = "SELECT pas_id, ime FROM pas";
            adapter.SelectCommand = komanda;
            adapter.Fill(tabela);
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                string id = tabela.Rows[i][0].ToString();
                string ime = tabela.Rows[i][1].ToString();
                pasCB.Items.Add(id + " -  " + ime);
            }
            Clear();
        }
        public bool VecPrijavljen(string pasId, string izlozbaId, string kategorijaId)
        {
            Konkcija();
            konekcija.Open();
            komanda.CommandText = "SELECT COUNT(*) FROM rezultat WHERE id_izlozbe = @izlozba AND id_kategorije = @kategorija AND pas_id = @pas";
            komanda.Parameters.AddWithValue("@izlozba", izlozbaId);
            komanda.Parameters.AddWithValue("@kategorija", kategorijaId);
            komanda.Parameters.AddWithValue("@pas", pasId);
            int br = int.Parse(komanda.ExecuteScalar().ToString());
            return br > 0;
        }

        private void prijavaBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string pasId = pasCB.Text.Split('-')[0];
                string izlozbaId = izlozbaCB.Text.Split('-')[0];
                string kategorijaId = kategorijaCB.Text.Split('-')[0];
                if(VecPrijavljen(pasId, izlozbaId, kategorijaId))
                {
                    MessageBox.Show("Pas je već prijavljen na ovu izložbu");
                    return;
                }
                Konkcija();
                konekcija.Open();
                komanda.CommandText = "INSERT INTO rezultat(id_izlozbe, id_kategorije, pas_id) VALUES (@izlozba, @kategorija, @pas)";
                komanda.Parameters.AddWithValue("@izlozba", izlozbaId);
                komanda.Parameters.AddWithValue("@kategorija", kategorijaId);
                komanda.Parameters.AddWithValue("@pas", pasId);
                komanda.ExecuteNonQuery();
                MessageBox.Show("Uspešan unos");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Greška");
            }
            finally
            {
                konekcija.Close();
            }
        }

        private void prikaziBTN_Click(object sender, EventArgs e)
        {
            string selectovanaIzlozba = statistikaIzlozbaCB.Text;
            if (selectovanaIzlozba == "")
            {
                MessageBox.Show("Prvo odaberite izložbu");
                return;
            }
            string izlozbaId = selectovanaIzlozba.Split('-')[0];
            Konkcija();
            komanda.CommandText = @"SELECT K.id_kategorije AS ""Šifra"", k.naziv as ""Naziv kategorije"", COUNT(R.rezultat) as ""Broj pasa"" FROM KATEGORIJA k INNER join rezultat r on r.id_kategorije = k.id_kategorije WHERE R.id_izlozbe =  @izlozbaId GROUP BY K.id_kategorije, k.naziv ORDER BY K.id_kategorije";
            komanda.Parameters.AddWithValue("@izlozbaId", izlozbaId);
            adapter.SelectCommand = komanda;
            adapter.Fill(tabela);
            dataGridView1.DataSource = tabela;

            chart1.Series["rezultat"].IsValueShownAsLabel = true;
            chart1.Series["rezultat"].Points.Clear();
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow row = tabela.Rows[i];
                chart1.Series["rezultat"].Points.AddXY(row[1].ToString(), row[2].ToString());
            }

            chart1.Visible = true;
        }

        private void statistikaIzlozbaCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectovanaIzlozba = statistikaIzlozbaCB.Text;
            if (selectovanaIzlozba == "")
            {
                MessageBox.Show("Prvo odaberite izložbu");
                return;
            }
            string izlozbaId = selectovanaIzlozba.Split('-')[0];
            Konkcija();
            komanda.CommandText = "SELECT COUNT(*) as prijavljeni, COUNT(rezultat) as ucestvovali from rezultat where id_izlozbe = @izlozbaId";
            komanda.Parameters.AddWithValue("@izlozbaId", izlozbaId);
            Clear();
            adapter.SelectCommand = komanda;
            adapter.Fill(tabela);
            string prijavljeni = tabela.Rows[0][0].ToString();
            string ucestvovali = tabela.Rows[0][1].ToString();
            statistikaPrijavljenoLB.Text = prijavljeni;
            statistikaUcestvovaloLB.Text = ucestvovali;
        }
    }
}
