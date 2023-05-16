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

namespace A8
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
            konekcija.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MM_A8;Integrated Security=True;";
            komanda = new SqlCommand();
            komanda.Connection = konekcija;
            tabela = new DataTable();
            adapter = new SqlDataAdapter();
        }
        private void prikaziBTN_Click(object sender, EventArgs e)
        {
            Konekcija();
            try
            {
                string select = "SELECT gradovi.ime_grada \"Grad\", COUNT(antikviteti.antikvitetID) \"Broj otkrića\"";
                string from = "FROM (gradovi INNER JOIN lokaliteti ON gradovi.gradID=lokaliteti.gradID) INNER JOIN antikviteti ON antikviteti.lokalitetID=lokaliteti.lokalitetID";
                string where = "WHERE antikviteti.datum_pronalaska>@godina";
                string group = "GROUP BY gradovi.ime_grada";
                string having = "HAVING COUNT(*)>@broj_antikviteta";
                komanda.Parameters.AddWithValue("@godina", godinaNUD.Value.ToString());
                komanda.Parameters.AddWithValue("@broj_antikviteta", brojNUD.Value);
                komanda.CommandText = select + " " + from + " " + where + " " + group + " " + having;
                adapter.SelectCommand = komanda;
                adapter.Fill(tabela);
                grid.DataSource = tabela;
                chart1.Series["podaci"].Points.Clear();
                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    chart1.Series["podaci"].Points.AddXY(tabela.Rows[i][0], tabela.Rows[i][1]);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                       ex.Message,
                       "Greška",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                   );
            }
            konekcija.Close();
        }
    }
}
