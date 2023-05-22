﻿using System;
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

        }
    }
}