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

namespace A9
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

        public List<Klub> klubovi;
        public SortedSet<string> drzave;
        public void Konekcija()
        {
            konekcija = new SqlConnection();
            konekcija.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MM_A9;Integrated Security=True;";
            komanda = new SqlCommand();
            komanda.Connection = konekcija;
            tabela = new DataTable();
            adapter = new SqlDataAdapter();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            klubovi = new List<Klub>();
            drzave = new SortedSet<string>();
            Konekcija();
            komanda.CommandText = @"SELECT k.NazivKluba, s.Naziv, g.Grad, d.Naziv, k.Sajt FROM KLUB k JOIN STADION s on k.StadionID = s.StadionID JOIN GRAD g on g.GradID = s.GradID JOIN DRZAVA d ON d.DrzavaID = g.DrzavaID;";
            adapter.SelectCommand = komanda;
            adapter.Fill(tabela);
            foreach(DataRow red in tabela.Rows)
            {
                Klub k = new Klub(
                        red[0].ToString(),
                        red[1].ToString(),
                        red[2].ToString(),
                        red[3].ToString(),
                        red[4].ToString()
                    );
                klubovi.Add(k);
                drzave.Add(k.drzava);
            }
            drzavaCB.Items.Add("Sve države");
            foreach (string drzava in drzave)
            {
                drzavaCB.Items.Add(drzava);
            }
            Reset();
            konekcija.Close();
        }
        private void Reset()
        {
            drzavaCB.SelectedIndex = 0;
            gradCB.Items.Clear();
            gradCB.Items.Add("Svi gradovi");
            gradCB.SelectedIndex = 0;
            klubCB.Items.Clear();
            klubCB.Items.Add("Svi klubovi");
            klubCB.SelectedIndex = 0;
            klubCB.Enabled = false;
            gradCB.Enabled = false;
        }

        private void drzavaCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drzavaCB.SelectedIndex == 0) { Reset(); return; }
            string drzava = drzavaCB.SelectedItem.ToString();
            gradCB.Items.Clear();
            gradCB.Items.Add("Svi gradovi");
            SortedSet<string> gradovi = new SortedSet<string>();
            foreach (Klub k in klubovi) if(k.drzava == drzava) gradovi.Add(k.grad);
            gradCB.Items.AddRange(gradovi.ToArray());
            gradCB.SelectedIndex = 0;
            gradCB.Enabled = true;
        }

        private void izlazBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void gradCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gradCB.SelectedIndex == 0) 
            {
                klubCB.Items.Clear();
                klubCB.Items.Add("Svi klubovi");
                klubCB.SelectedIndex = 0;
                klubCB.Enabled = false;
                return; 
            }
            string grad = gradCB.SelectedItem.ToString();
            klubCB.Items.Clear();
            klubCB.Items.Add("Svi klubovi");
            SortedSet<string> lista = new SortedSet<string>();
            foreach (Klub k in klubovi) if (k.grad == grad) lista.Add(k.ime);
            klubCB.Items.AddRange(lista.ToArray());
            klubCB.Enabled = true;
            klubCB.SelectedIndex = 0;
        }

        private void klubCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(klubCB.SelectedIndex == 0)
            {
                imeLB.Text = "/";
                stadionLB.Text = "/";
                sajtLB.Text = "/";
            }
            else
            {
                Klub klub = klubovi[0];
                foreach(Klub k in klubovi)
                {
                    if (k.ime == klubCB.SelectedItem.ToString()) klub = k;
                }
                imeLB.Text = klub.ime;
                stadionLB.Text = klub.stadion;
                sajtLB.Text =klub.sajt;
            }
        }

        private void izlaz2Btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void prikaziBtn_Click(object sender, EventArgs e)
        {
            Konekcija();
            konekcija.Open();
            komanda.CommandText = @"SELECT s.naziv, dom.NazivKluba, u.GolovaDomacin, u.GolovaGost, gost.NazivKluba FROM UTAKMICA U JOIN KLUB dom ON dom.klubId = u.domacinId JOIN klub gost ON gost.klubId = u.GostId JOIN stadion s on dom.StadionId = s.StadionId WHERE U.DATUMIgranja = @DATUM";
            komanda.Parameters.AddWithValue("@DATUM", datumPicker.Value.Date);
            adapter.SelectCommand = komanda;
            adapter.Fill(tabela);
            prikazUtakmica.Clear();
            prikazUtakmica.Columns.Add("Stadion", 250);
            prikazUtakmica.Columns.Add("Domaćin", 150);
            prikazUtakmica.Columns.Add("Golovi domaći", 120);
            prikazUtakmica.Columns.Add("Golovi gosti", 120);
            prikazUtakmica.Columns.Add("Gost", 150);
            prikazUtakmica.View = View.Details;
            prikazUtakmica.GridLines = true;
            prikazUtakmica.FullRowSelect = true;
            foreach (DataRow red in tabela.Rows)
            {
                string[] data =
                {
                    red[0].ToString(),
                    red[1].ToString(),
                    red[2].ToString(),
                    red[3].ToString(),
                    red[4].ToString(),
                };
                ListViewItem item = new ListViewItem(data);
                prikazUtakmica.Items.Add(item);
            }
            konekcija.Close();

        }
    }
}
