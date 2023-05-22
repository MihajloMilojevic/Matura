using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A26
{
    public partial class Placanje : Form
    {
        public Placanje()
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
        List<Ugovor> ugovori = new List<Ugovor>();
        private void GetData()
        {
            Konekcija();
            konekcija.Open();
            komanda.CommandText = @"SELECT r.rezervacija_id, m.ime + ' ' + m.prezime as ""Ugovarač"", FORMAT(r.pocetak_rezervacije, 'dd.MM.yyyy') as ""Početak usluge"", DATEDIFF(day, r.pocetak_rezervacije, r.kraj_rezervacije) as ""Dana"", r.suma_za_uplatu, FORMAT(r.rok_za_uplatu, 'dd.MM.yyyy') as ""Rok za uplatu"", r.suma_za_uplatu - SUM(u.iznos) as ""Dug"" FROM rezervacija r JOIN musterija m ON m.musterija_id = r.musterija_id JOIN uplata u ON u.rezervacija_id = r.rezervacija_id GROUP BY r.rezervacija_id, m.ime, m.prezime, r.pocetak_rezervacije, r.kraj_rezervacije, r.suma_za_uplatu, r.rok_za_uplatu";
            adapter.SelectCommand = komanda;
            adapter.Fill(tabela);
            ugovori.Clear();
            foreach (DataRow red in tabela.Rows) {
                Ugovor u = new Ugovor(
                    red[0].ToString(),
                    red[1].ToString(),
                    red[2].ToString(),
                    red[3].ToString(),
                    red[4].ToString(),
                    red[5].ToString(),
                    red[6].ToString()
                );
                ugovori.Add( u );
            }
            konekcija.Close();
        }
        private void Placanje_Load(object sender, EventArgs e)
        {
            GetData();
            foreach(Ugovor u in ugovori)
                brojeviCB.Items.Add(u.ugovorId);
            Konekcija();
            konekcija.Open();
            komanda.CommandText = @"SELECT DISTINCT nacin_placanja FROM nacin_placanja";
            adapter.SelectCommand = komanda;
            adapter.Fill(tabela);
            nacinPlacanjaCb.Items.Add("Izaberite način plaćanja...");
            nacinPlacanjaCb.SelectedIndex = 0;
            foreach(DataRow red in tabela.Rows)
            {
                nacinPlacanjaCb.Items.Add(red[0].ToString());
            }
            konekcija.Close();
        }

        private void brojeviCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ugovor ugovor = null;
            foreach (Ugovor u in ugovori) if (u.ugovorId == brojeviCB.SelectedItem.ToString()) ugovor = u;
            if(ugovor == null)
            {
                brojUgovoraLb.Text = "/";
                ugovaracLb.Text = "/";
                pocetakLb.Text = "/";
                brojDanaLb.Text = "/";
                ukupanIznosLb.Text = "/";
                rokZaIsplatuLb.Text = "/";
                dugLb.Text = "/";
                uplateList.Clear();
            }
            else
            {
                brojUgovoraLb.Text = ugovor.ugovorId;
                ugovaracLb.Text = ugovor.ugovarac;
                pocetakLb.Text = ugovor.pocetak;
                brojDanaLb.Text = ugovor.dana;
                ukupanIznosLb.Text = ugovor.zaUplatu;
                rokZaIsplatuLb.Text = ugovor.rok;
                dugLb.Text = ugovor.dug;
                ListaUplata();
            }
        }

        private void zatvoriBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        void ListaUplata()
        {
            string id = brojeviCB.SelectedItem.ToString();
            Konekcija();
            konekcija.Open();
            komanda.CommandText = @"SELECT u.iznos, n.nacin_placanja FROM uplata u JOIN nacin_placanja n on u.nacin_placanja_id = n.nacin_placanja_id WHERE u.rezervacija_id = @ID ORDER BY u.uplata_id ASC";
            komanda.Parameters.AddWithValue("@ID", id);
            adapter.SelectCommand = komanda;
            adapter.Fill(tabela);
            uplateList.Clear();
            uplateList.Columns.Add("Rata", 70);
            uplateList.Columns.Add("Iznos", 120);
            uplateList.Columns.Add("Način plaćanja", 200);
            uplateList.View = View.Details;
            uplateList.GridLines = true;
            uplateList.FullRowSelect = true;
            for(int i = 0; i < tabela.Rows.Count; i++)
            {
                string[] cols =
                {
                    (i + 1).ToString(),
                    int.Parse(tabela.Rows[i][0].ToString()).ToString("0.00"),
                    tabela.Rows[i][1].ToString()
                };
                ListViewItem it = new ListViewItem(cols);
                uplateList.Items.Add(it);
            }
            konekcija.Close();
        }
        private void uplatiBtn_Click(object sender, EventArgs e)
        {
            if(nacinPlacanjaCb.SelectedIndex == 0)
            {
                MessageBox.Show(
                        "Odaberite način plaćanja",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return;
            }
            string id = brojeviCB.SelectedItem.ToString();
            string nacinPlacanja = nacinPlacanjaCb.SelectedItem.ToString();
            int iznos;
            if (!int.TryParse(iznosTB.Text, out iznos))
            {
                MessageBox.Show(
                        "Unesite iznos",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return;
            }
            Konekcija();
            konekcija.Open();
            komanda.CommandText = @"INSERT INTO uplata(iznos, nacin_placanja_id, rezervacija_id) VALUES(@IZNOS, (SELECT nacin_placanja_id FROM nacin_placanja WHERE nacin_placanja = @NACIN), @ID);";            komanda.Parameters.AddWithValue("@IZNOS", iznos);
            komanda.Parameters.AddWithValue("@NACIN", nacinPlacanja);
            komanda.Parameters.AddWithValue("@ID", id);
            komanda.ExecuteNonQuery();
            konekcija.Close();
            iznosTB.Text = "";
            ListaUplata();
        }
    }
}
