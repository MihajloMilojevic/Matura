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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace A1
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
        public void Konekcija()
        {
            konekcija = new SqlConnection();
            konekcija.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MM_A1;Integrated Security=True;";
            komanda = new SqlCommand();
            komanda.Connection = konekcija;
            tabela = new DataTable();
            adapter = new SqlDataAdapter();
        }
        private void GetData()
        {
            Konekcija();
            komanda.CommandText = "SELECT CitalacID, Maticni_broj, Ime, Prezime, Adresa FROM Citalac";
            adapter.SelectCommand = komanda;
            adapter.Fill(tabela);
            konekcija.Close();
        }
        private void ShowList()
        {
            lista.Clear();

            lista.Columns.Add("Članska karta", 130);
            lista.Columns.Add("JMBG", 150);
            lista.Columns.Add("Ime", 100);
            lista.Columns.Add("Prezime", 100);
            lista.Columns.Add("Adresa", 250);

            lista.View = View.Details;
            lista.GridLines = true;
            lista.FullRowSelect = true;
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                string[] red = {
                    tabela.Rows[i][0].ToString(),
                    tabela.Rows[i][1].ToString(),
                    tabela.Rows[i][2].ToString(),
                    tabela.Rows[i][3].ToString(),
                    tabela.Rows[i][4].ToString(),
                };
                ListViewItem item = new ListViewItem(red);
                lista.Items.Add(item);
            }
        }
        private void ShowData(string id)
        {
            string[] data = Find(id);

            jmbgTB.Enabled = data == null && id != "";
            imeTB.Enabled = data == null && id != "";
            prezimeTB.Enabled = data == null && id != "";
            AdresaTB.Enabled = data == null && id != "";

            upisiBtn.Enabled = data == null && id != "";

            if (data == null)
            {
                jmbgTB.Text = "";
                imeTB.Text = "";
                prezimeTB.Text = "";
                AdresaTB.Text = "";
            }
            else
            {
                jmbgTB.Text = data[1];
                imeTB.Text = data[2];
                prezimeTB.Text = data[3];
                AdresaTB.Text = data[4];
            }
        }
        private string[] Find(string id) {
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                if(tabela.Rows[i][0].ToString() == id)
                {
                    string[] red = {
                        tabela.Rows[i][0].ToString(),
                        tabela.Rows[i][1].ToString(),
                        tabela.Rows[i][2].ToString(),
                        tabela.Rows[i][3].ToString(),
                        tabela.Rows[i][4].ToString(),
                    };
                    return red;
                }
                
            }
            return null;
        }
        private void izlazBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void citaociTab_Enter(object sender, EventArgs e)
        {
            GetData();
            ShowList();
            ShowData(brojTB.Text);

        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lista.SelectedItems.Count > 0)
            {
                brojTB.Text = lista.SelectedItems[0].SubItems[0].Text.ToString();

            }

        }

        private void brojTB_TextChanged(object sender, EventArgs e)
        {
            ShowData(brojTB.Text);
        }

        private void upisiBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Konekcija();
                konekcija.Open();
                komanda.CommandText = "INSERT INTO Citalac (CitalacID, Maticni_broj, Ime, Prezime, Adresa) VALUES(@CitalacID, @Maticni_broj, @Ime, @Prezime, @Adresa)";
                komanda.Parameters.AddWithValue("@CitalacID", brojTB.Text);
                komanda.Parameters.AddWithValue("@Maticni_broj", jmbgTB.Text);
                komanda.Parameters.AddWithValue("@Ime", imeTB.Text);
                komanda.Parameters.AddWithValue("@Prezime", prezimeTB.Text);
                komanda.Parameters.AddWithValue("@Adresa", AdresaTB.Text);
                komanda.ExecuteNonQuery();
                konekcija.Close();
                GetData();
                ShowList();
                ShowData(brojTB.Text);
                MessageBox.Show(
                        "Uspešno registrovan čitalac",
                        "Uspeh",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                        ex.Message,
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
            }
        }

        private void izlaz2Btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void prikaziBtn_Click(object sender, EventArgs e)
        {
            int max = DateTime.Now.Year;
            int min = max - 10;
            if (maxGodNUD.Value != 0) {
                max = (int)maxGodNUD.Value;
            }
            if(minGodNUD.Value != 0)
            {
                min = (int)minGodNUD.Value;
            }
            Konekcija();
            konekcija.Open();
            komanda.CommandText = @"SELECT c.Ime + ' ' + c.Prezime as ""Citalac"", YEAR(nc.Datum_uzimanja) as ""Godina"", COUNT(nc.Datum_uzimanja) as ""Broj iznajmljivanja"", COUNT(nc.Datum_vracanja) as ""Broj vraćanja"" FROM citalac c JOIN na_citanju nc ON c.citalacId = nc.CitalacID where c.citalacId = @ID and YEAR(nc.Datum_uzimanja) BETWEEN @MIN AND @MAX group by YEAR(datum_uzimanja), c.Ime, c.Prezime order by year(nc.Datum_uzimanja) asc ";
            komanda.Parameters.AddWithValue("@ID", citalacCb.SelectedItem.ToString().Split('-')[0]);
            komanda.Parameters.AddWithValue("@MIN", min);
            komanda.Parameters.AddWithValue("@MAX", max);
            adapter.SelectCommand = komanda;
            adapter.Fill(tabela);
            podaciDGV.DataSource = tabela;
            for(int i = 0; i < tabela.Rows.Count; i++)
            {
                chart1.Series["iznajmljeno"].Points.AddXY(tabela.Rows[i][1], tabela.Rows[i][2]);
                chart1.Series["vraceno"].Points.AddXY(tabela.Rows[i][1], tabela.Rows[i][3]);
            }
            konekcija.Close();
        }
        private void FillCombo()
        {
            citalacCb.Items.Clear();
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow red = tabela.Rows[i];
                citalacCb.Items.Add(red[0] + "-" + red[2] + " " + red[3]);
            }
        }

        private void iznajmljivanjaTab_Enter(object sender, EventArgs e)
        {
            GetData();
            FillCombo();
        }

        private void maxGodNUD_ValueChanged(object sender, EventArgs e)
        {
            int max = (int)maxGodNUD.Value;
            int min = (int)minGodNUD.Value;
            if (max < min) maxGodNUD.Value = min;
        }

        private void minGodNUD_ValueChanged(object sender, EventArgs e)
        {
            int max = (int)maxGodNUD.Value;
            int min = (int)minGodNUD.Value;
            if (max < min) minGodNUD.Value = max;
        }
    }
}
