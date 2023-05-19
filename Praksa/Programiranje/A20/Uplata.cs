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
                List<string> aranzmani = new List<string>();
                foreach (Ugovor u in ugovori)
                    if (u.destinacija == destinacijaCb.SelectedItem.ToString())
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
                PodaciOUgovoru();
            }
        }
        private void PodaciOUgovoru()
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
            Konekcija();
            konekcija.Open();
            komanda.CommandText = @"SELECT rata, iznos, FORMAT(DatumUplate, 'dd.MM.yyyy') FROM Uplata WHERE ugovorId = @ID ORDER BY RATA ASC";
            komanda.Parameters.AddWithValue("@ID", id);
            adapter.SelectCommand = komanda;
            adapter.Fill(tabela);
            konekcija.Close();

            listView1.Clear();
            listView1.Columns.Add("Rata", 70);
            listView1.Columns.Add("Iznos", 120);
            listView1.Columns.Add("Datum uplate", 150);

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            foreach (DataRow red2 in tabela.Rows)
            {
                listView1.Items.Add(new ListViewItem(new string[]{
                    red2[0].ToString(),
                    int.Parse(red2[1].ToString()).ToString("0.00"),
                    red2[2].ToString()
                }));
            }
        }

        private void uplatiBtn_Click(object sender, EventArgs e)
        {
            Konekcija();
            konekcija.Open();
            string id = aranzmanCb.SelectedItem.ToString().Split(')')[0].Split(' ')[2];
            int max = int.Parse(listView1.Items[0].SubItems[0].Text);
            foreach(ListViewItem it in listView1.Items)
            {
                int x = int.Parse(it.SubItems[0].Text);
                if (x > max) max = x;
            }
            komanda.CommandText = @"INSERT INTO Uplata (UgovorID, Rata, iznos, DatumUplate) VALUES(@ID, @RATA, @IZNOS, GETDATE());";
            komanda.Parameters.AddWithValue("@ID", id);
            komanda.Parameters.AddWithValue("@RATA", max+1);
            komanda.Parameters.AddWithValue("@IZNOS", textBox1.Text);
            komanda.ExecuteNonQuery();
            konekcija.Close();
            textBox1.Text = "";
            PodaciOUgovoru();
        }
    }
}
