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

namespace A26
{
    public partial class Rezervacija : Form
    {
        public Rezervacija()
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
            konekcija.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MM_A26;Integrated Security=True;";
            komanda = new SqlCommand();
            komanda.Connection = konekcija;
            tabela = new DataTable();
            adapter = new SqlDataAdapter();
        }

        private void zatvoriBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Rezervacija_Load(object sender, EventArgs e)
        {
            Konekcija();
            konekcija.Open();
            komanda.CommandText = @"SELECT COUNT(*) FROM soba;";
            string kap = (komanda.ExecuteScalar()).ToString();
            ukupnoLB.Text = "Ukupni kapacitet: " + kap + " soba";
            konekcija.Close();
        }

        private void pretragaBtn_Click(object sender, EventArgs e)
        {
            Konekcija();
            konekcija.Open();
            DateTime S1 = polazakCalendar.SelectionStart.Date;
            DateTime E1 = polazakCalendar.SelectionEnd.Date;
            DateTime S2 = povratakCalendar.SelectionStart.Date;
            DateTime E2 = povratakCalendar.SelectionEnd.Date;
            komanda.CommandText = @"SELECT S.soba_id as ""No"", t.tip_sobe as ""Tip sobe"", s.sprat as ""Sprat"" FROM soba s JOIN tip_sobe t ON s.tip_sobe_id = t.tip_sobe_id WHERE soba_id NOT IN(SELECT DISTINCT soba_id from rezervacija_sobe WHERE rezervacija_id IN (SELECT rezervacija_id FROM rezervacija WHERE NOT( (pocetak_rezervacije NOT BETWEEN @S1 AND @S2 AND kraj_rezervacije NOT BETWEEN @E1 AND @E2) OR (kraj_rezervacije < @E1) AND (pocetak_rezervacije > @S2))))";
            komanda.Parameters.AddWithValue("@S1", S1);
            komanda.Parameters.AddWithValue("@S2", S2);
            komanda.Parameters.AddWithValue("@E1", E1);
            komanda.Parameters.AddWithValue("@E2", E2);
            adapter.SelectCommand = komanda;
            adapter.Fill(tabela);
            grid.DataSource = tabela;
            raspolozivoLB.Text = "Raspoloživi kapaciteti: " + tabela.Rows.Count.ToString();
            konekcija.Close();
        }
    }
}
