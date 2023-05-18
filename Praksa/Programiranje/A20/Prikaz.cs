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

namespace A20
{
    public partial class Prikaz : Form
    {
        public Prikaz()
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
            konekcija.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MM_A20;Integrated Security=True;";
            komanda = new SqlCommand();
            komanda.Connection = konekcija;
            tabela = new DataTable();
            adapter = new SqlDataAdapter();
        }
        private void Prikaz_Load(object sender, EventArgs e)
        {
            DateTime start = DateTime.Today.Date;
            DateTime end = start.AddDays(15).Date;
            datumi.Text = "(polasci od " + start.ToString("dd.MM.yyyy.") + " do " + end.ToString("dd.MM.yyyy.") + ")";
            Konekcija();
            konekcija.Open();
            komanda.CommandText = @"SELECT ta.UgovorID, k.Ime, k.Prezime, td.NazivMesta, FORMAT(ta.DatumPolaska, 'dd.MM.yyyy.') as ""Polazak"", ta.UkupnaCenaAranzmana as ""Cena"", SUM(u.iznos) as ""Plaćeno"", ta.UkupnaCenaAranzmana - SUM(u.iznos) as ""Dugovanje"" FROM Turisticki_aranzman ta JOIN Klijent k ON ta.KlijentID = k.KlijentID JOIN Turisticka_destinacija td ON ta.DestinacijaID = td.DestinacijaID 	JOIN Uplata u on u.UgovorID = ta.UgovorID WHERE ta.DatumPolaska BETWEEN @START AND @END GROUP BY ta.UgovorID, k.Ime, k.Prezime, td.NazivMesta, ta.DatumPolaska, ta.UkupnaCenaAranzmana";
            komanda.Parameters.AddWithValue("@START", start);
            komanda.Parameters.AddWithValue("@END", end);
            adapter.SelectCommand = komanda;
            adapter.Fill(tabela);
            grid.DataSource = tabela;
            for(int i = 0; i < grid.Rows.Count; i++)
            {
                int value = int.Parse(grid.Rows[i].Cells[7].Value.ToString());
                if(value > 0)
                {
                    grid.Rows[i].Cells[7].Style.BackColor = Color.MediumVioletRed;
                }
                else if(value <0)
                {
                    grid.Rows[i].Cells[7].Style.BackColor = Color.MediumSpringGreen;
                }
            }
            konekcija.Close();
        }
    }
}
