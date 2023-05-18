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

namespace A13
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
            konekcija.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MM_A13;Integrated Security=True;";
            komanda = new SqlCommand();
            komanda.Connection = konekcija;
            tabela = new DataTable();
            adapter = new SqlDataAdapter();
        }

        private void izlazBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void prikazBTN_Click(object sender, EventArgs e)
        {
            Konekcija();
            komanda.CommandText = @"SELECT p.Ime as ""Producent"", COUNT(*) as ""Broj filmova "" FROM producent p JOIN producirao pr ON p.ProducentID = pr.ProducentID GROUP BY p.Ime";
            adapter.SelectCommand = komanda;
            adapter.Fill(tabela);
            dataGridView1.DataSource = tabela;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].Width = 70;
            Random r = new Random();
            for(int i = 0; i < tabela.Rows.Count; i++)
            {
                chart1.Series["prikaz"].Points.AddXY(tabela.Rows[i][0], tabela.Rows[i][1]);
            }
            foreach(DataPoint p in chart1.Series["prikaz"].Points)
            {
                p.Color = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            }
            chart1.Visible = true;
        }
    }
}
