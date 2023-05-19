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
    public partial class Uplata : Form
    {
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
        public Uplata()
        {
            InitializeComponent();
        }
        private List<Ugovor> ugovori = new List<Ugovor>();

        private void Uplata_Load(object sender, EventArgs e)
        {
            Konekcija();
            konekcija.Open();
            komanda.CommandText = @"SELECT ta.UgovorID, td.NazivMesta, k.Ime + ' ' + k.Prezime, ta.DatumPolaska, ta.DatumPovratka  FROM Turisticki_aranzman ta JOIN Turisticka_destinacija td on ta.DestinacijaID = td.DestinacijaID JOIN Klijent k on ta.KlijentID = k.KlijentID";
            adapter.SelectCommand = komanda;
            adapter.Fill(tabela);
            foreach(DataRow red in tabela.Rows)
            {
                ugovori.Add(
                    new Ugovor(
                            red[0].ToString(),
                            red[1].ToString(),
                            red[2].ToString(),
                            DateTime.Parse(red[3].ToString()),
                            DateTime.Parse(red[4].ToString())
                        )
                );
            }
            SortedSet<string> destinacije = new SortedSet<string>();
            foreach(Ugovor u in ugovori)
            {
                destinacije.Add(u.destinacija);
            }
            destinacijaCb.Items.Add("Odaberi destinaciju");
            destinacijaCb.SelectedIndex = 0;
            aranzmanCb.Enabled = false;
            foreach(string destinacija in destinacije)
                destinacijaCb.Items.Add(destinacija);
            konekcija.Close();
        }

        private void destinacijaCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(destinacijaCb.SelectedIndex == 0)
            {
                aranzmanCb.Enabled = false;
                aranzmanCb.Items.Clear();
                aranzmanCb.Items.Add("Odaberi aranžman");
                aranzmanCb.SelectedIndex = 0;
            }
            else
            {
                SortedSet<string> aranzmani = new SortedSet<string>();
                foreach (Ugovor u in ugovori)
                    if (u.destinacija == destinacijaCb.SelectedItem)
                        aranzmani.Add("(Ugovor br. " + u.id + ") " + u.klijent);
                aranzmanCb.Items.Clear();
                aranzmanCb.Items.Add("Odaberi aranžman");
                aranzmanCb.Enabled = true;
                aranzmanCb.SelectedIndex = 0;
                foreach (string aranzman in aranzmani)
                    aranzmanCb.Items.Add(aranzman);
                aranzmanCb.Enabled = true;
                aranzmanCb.SelectedIndex = 0;
            }
        }


        private void aranzmanCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(aranzmanCb.SelectedIndex == 0)
            {
                datumi.SelectionStart = DateTime.Today;
                datumi.SelectionEnd = DateTime.Today;
                ukupnaCenaLB.Text = "0";
                dugLB.Text = "0";
            }
            else
            {
                Konekcija();
                konekcija.Open();
                string id = aranzmanCb.SelectedItem.ToString().Split(')')[0].Split(' ')[2];
                komanda.CommandText = @"SELECT ta.DatumPolaska, ta.DatumPovratka, ta.UkupnaCenaAranzmana as ""Cena"", ta.UkupnaCenaAranzmana - SUM(u.iznos) as ""Dugovanje"" FROM Turisticki_aranzman ta JOIN Uplata u on u.UgovorID = ta.UgovorID  WHERE ta.UgovorID = @ID GROUP BY ta.DatumPolaska, ta.DatumPovratka, ta.UkupnaCenaAranzmana";
                komanda.Parameters.AddWithValue("@ID", id);
                adapter.SelectCommand = komanda;
                adapter.Fill(tabela);
                DataRow red = tabela.Rows[0];
                datumi.SelectionStart = DateTime.Parse(red[0].ToString());
                datumi.SelectionEnd = DateTime.Parse(red[1].ToString());
                ukupnaCenaLB.Text = red[2].ToString();
                dugLB.Text = red[3].ToString();
                konekcija.Close();
            }
        }
    }
}
