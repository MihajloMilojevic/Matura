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
            }
        }
    }
}
