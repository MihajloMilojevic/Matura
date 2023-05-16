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
    public partial class Prikaz : Form
    {
        public Prikaz()
        {
            InitializeComponent();
        }
        public SqlConnection konekcija;
        public SqlDataAdapter adapter;
        public DataTable tabela;
        public SqlCommand komanda;
        private int trenutna;
        private const string NO_IMAGE = "antikviteti\\no_image.jpg";

        public void Konekcija()
        {
            konekcija = new SqlConnection();
            konekcija.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MM_A8;Integrated Security=True;";
            komanda = new SqlCommand();
            komanda.Connection = konekcija;
            tabela = new DataTable();
            adapter = new SqlDataAdapter();
        }
        private void GetData() {
            Konekcija();
            komanda.CommandText = "SELECT tipAntikvitetaID, tip, slika FROM TIPOVI_ANTIKVITETA";
            adapter.SelectCommand = komanda;
            adapter.Fill(tabela);
            konekcija.Close();

        }
        private void Prikaz_Load(object sender, EventArgs e)
        {
            GetData();
            trenutna = 0;
            PrikazTrenunog();
        }
        private void PrikazTrenunog()
        {
            sifraLB.Text = tabela.Rows[trenutna][0].ToString();
            imeTB.Text = tabela.Rows[trenutna][1].ToString();
            if (tabela.Rows[trenutna][2] == DBNull.Value) 
            {
                slikaPB.Image = Image.FromFile(NO_IMAGE);
                slikaPB.Tag =NO_IMAGE;
            }
            else
            {
                slikaPB.Image = Image.FromFile(tabela.Rows[trenutna][2].ToString());
                slikaPB.Tag = tabela.Rows[trenutna][2].ToString();
            }
            nazadBTN.Enabled = (trenutna > 0);
            napredBTN.Enabled = (trenutna < tabela.Rows.Count - 1);
        }

        private void napredBTN_Click(object sender, EventArgs e)
        {
            trenutna++;
            PrikazTrenunog();
        }

        private void nazadBTN_Click(object sender, EventArgs e)
        {
            trenutna--;
            PrikazTrenunog();
        }

        private void slikaPB_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            DialogResult res = fd.ShowDialog(); 
            if(res == DialogResult.OK)
            {
                slikaPB.Image = Image.FromFile("antikviteti\\" + fd.SafeFileName);
                slikaPB.Tag = "antikviteti\\" + fd.SafeFileName;
            }
            else if(res == DialogResult.Cancel)
            {
                slikaPB.Image = Image.FromFile(NO_IMAGE);
                slikaPB.Tag = NO_IMAGE;
            }
        }

        private void sacuvajBTN_Click(object sender, EventArgs e)
        {
            string slika = slikaPB.Tag.ToString();
            string ime = imeTB.Text;
            konekcija.Open();
            try {
                komanda.CommandText = "UPDATE TIPOVI_ANTIKVITETA SET tip = @TIP, slika = @SLIKA WHERE tipAntikvitetaID = @ID";
                komanda.Parameters.AddWithValue("@TIP", ime);
                if (slika == NO_IMAGE)
                    komanda.Parameters.AddWithValue("@SLIKA", DBNull.Value);
                else
                    komanda.Parameters.AddWithValue("@SLIKA", slika);
                komanda.Parameters.AddWithValue("@ID", tabela.Rows[trenutna][0]);
                komanda.ExecuteNonQuery();
                GetData();
                PrikazTrenunog();
                MessageBox.Show(
                        "Usprešno sačuvane izmene",
                        "Uspeh",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
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
