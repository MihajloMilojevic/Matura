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
using System.Windows.Forms.DataVisualization.Charting;

namespace A30
{
    public partial class Analiza : Form
    {
        public Analiza()
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

        private void prikaziBtn_Click(object sender, EventArgs e)
        {
            chart1.Series["podaci"].Points.Clear();
            
            foreach(DataGridViewRow x in grid.Rows)
            {
                chart1.Series["podaci"].Points.AddXY(x.Cells[1].Value.ToString(), x.Cells[3].Value.ToString());
            }
            Random r = new Random();
            foreach (DataPoint p in chart1.Series["podaci"].Points)
            {
                p.Color = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            }
        }

        private void izadjiBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void odCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetData();
        }
        private void doCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetData();
        }
        private void GetData()
        {
            if (odCB.SelectedIndex < 0 || doCB.SelectedIndex < 0) return;
            int odT = int.Parse(odCB.SelectedItem.ToString());
            int doT = int.Parse(doCB.SelectedItem.ToString());
            Konekcija();
            konekcija.Open();
            komanda.CommandText = @"SELECT p.partija_id as ""PartijaID"", t.teren as ""Teren"", FORMAT(p.datum, 'dd.MM.yyyy') as ""Datum"", DATEDIFF(MINUTE, p.vreme_pocetka, p.vreme_kraja) as ""Trajanje"" FROM partija P JOIN teren t ON P.teren_id = t.teren_id WHERE DATEDIFF(MINUTE, p.vreme_pocetka, p.vreme_kraja) BETWEEN @S AND @E";
            komanda.Parameters.AddWithValue("@S", odT * 60);
            komanda.Parameters.AddWithValue("@E", doT * 60);
            adapter.SelectCommand = komanda;
            adapter.Fill(tabela);
            grid.DataSource = tabela;
            konekcija.Close();
        }
    }
}
