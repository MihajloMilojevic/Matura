namespace A16
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.prijavaTab = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.izlazBTN1 = new System.Windows.Forms.Button();
            this.prijavaBTN = new System.Windows.Forms.Button();
            this.kategorijaCB = new System.Windows.Forms.ComboBox();
            this.izlozbaCB = new System.Windows.Forms.ComboBox();
            this.pasCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statistikaTab = new System.Windows.Forms.TabPage();
            this.izlazBTN3 = new System.Windows.Forms.Button();
            this.prikaziBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statistikaUcestvovaloLB = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.statistikaPrijavljenoLB = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.statistikaIzlozbaCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.oAplikacijiTab = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.izlazTab = new System.Windows.Forms.TabPage();
            this.izlazBTN2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.prijavaTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statistikaTab.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.oAplikacijiTab.SuspendLayout();
            this.izlazTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.prijavaTab);
            this.tabControl1.Controls.Add(this.statistikaTab);
            this.tabControl1.Controls.Add(this.oAplikacijiTab);
            this.tabControl1.Controls.Add(this.izlazTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(814, 398);
            this.tabControl1.TabIndex = 0;
            // 
            // prijavaTab
            // 
            this.prijavaTab.Controls.Add(this.label5);
            this.prijavaTab.Controls.Add(this.label4);
            this.prijavaTab.Controls.Add(this.pictureBox1);
            this.prijavaTab.Controls.Add(this.izlazBTN1);
            this.prijavaTab.Controls.Add(this.prijavaBTN);
            this.prijavaTab.Controls.Add(this.kategorijaCB);
            this.prijavaTab.Controls.Add(this.izlozbaCB);
            this.prijavaTab.Controls.Add(this.pasCB);
            this.prijavaTab.Controls.Add(this.label3);
            this.prijavaTab.Controls.Add(this.label2);
            this.prijavaTab.Controls.Add(this.label1);
            this.prijavaTab.Location = new System.Drawing.Point(4, 29);
            this.prijavaTab.Name = "prijavaTab";
            this.prijavaTab.Padding = new System.Windows.Forms.Padding(3);
            this.prijavaTab.Size = new System.Drawing.Size(806, 365);
            this.prijavaTab.TabIndex = 0;
            this.prijavaTab.Text = "Unesi prijavu";
            this.prijavaTab.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Zatvori aplikaciju";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Prijava";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::A16.Properties.Resources.pas;
            this.pictureBox1.Location = new System.Drawing.Point(503, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // izlazBTN1
            // 
            this.izlazBTN1.Image = global::A16.Properties.Resources.close;
            this.izlazBTN1.Location = new System.Drawing.Point(378, 242);
            this.izlazBTN1.Margin = new System.Windows.Forms.Padding(0);
            this.izlazBTN1.Name = "izlazBTN1";
            this.izlazBTN1.Size = new System.Drawing.Size(80, 77);
            this.izlazBTN1.TabIndex = 7;
            this.izlazBTN1.UseVisualStyleBackColor = true;
            this.izlazBTN1.Click += new System.EventHandler(this.izlazBTN1_Click);
            // 
            // prijavaBTN
            // 
            this.prijavaBTN.Image = global::A16.Properties.Resources.prijava;
            this.prijavaBTN.Location = new System.Drawing.Point(38, 242);
            this.prijavaBTN.Margin = new System.Windows.Forms.Padding(0);
            this.prijavaBTN.Name = "prijavaBTN";
            this.prijavaBTN.Size = new System.Drawing.Size(80, 77);
            this.prijavaBTN.TabIndex = 6;
            this.prijavaBTN.UseVisualStyleBackColor = true;
            this.prijavaBTN.Click += new System.EventHandler(this.prijavaBTN_Click);
            // 
            // kategorijaCB
            // 
            this.kategorijaCB.FormattingEnabled = true;
            this.kategorijaCB.Location = new System.Drawing.Point(124, 151);
            this.kategorijaCB.Name = "kategorijaCB";
            this.kategorijaCB.Size = new System.Drawing.Size(334, 28);
            this.kategorijaCB.TabIndex = 5;
            // 
            // izlozbaCB
            // 
            this.izlozbaCB.FormattingEnabled = true;
            this.izlozbaCB.Location = new System.Drawing.Point(124, 98);
            this.izlozbaCB.Name = "izlozbaCB";
            this.izlozbaCB.Size = new System.Drawing.Size(334, 28);
            this.izlozbaCB.TabIndex = 4;
            // 
            // pasCB
            // 
            this.pasCB.FormattingEnabled = true;
            this.pasCB.Location = new System.Drawing.Point(124, 44);
            this.pasCB.Name = "pasCB";
            this.pasCB.Size = new System.Drawing.Size(334, 28);
            this.pasCB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kategorija:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Izložba:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pas:";
            // 
            // statistikaTab
            // 
            this.statistikaTab.Controls.Add(this.izlazBTN3);
            this.statistikaTab.Controls.Add(this.prikaziBTN);
            this.statistikaTab.Controls.Add(this.panel1);
            this.statistikaTab.Controls.Add(this.dataGridView1);
            this.statistikaTab.Controls.Add(this.statistikaUcestvovaloLB);
            this.statistikaTab.Controls.Add(this.label9);
            this.statistikaTab.Controls.Add(this.statistikaPrijavljenoLB);
            this.statistikaTab.Controls.Add(this.label7);
            this.statistikaTab.Controls.Add(this.statistikaIzlozbaCB);
            this.statistikaTab.Controls.Add(this.label6);
            this.statistikaTab.Location = new System.Drawing.Point(4, 29);
            this.statistikaTab.Name = "statistikaTab";
            this.statistikaTab.Padding = new System.Windows.Forms.Padding(3);
            this.statistikaTab.Size = new System.Drawing.Size(806, 365);
            this.statistikaTab.TabIndex = 1;
            this.statistikaTab.Text = "Statistika";
            this.statistikaTab.UseVisualStyleBackColor = true;
            // 
            // izlazBTN3
            // 
            this.izlazBTN3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.izlazBTN3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izlazBTN3.Location = new System.Drawing.Point(311, 318);
            this.izlazBTN3.Name = "izlazBTN3";
            this.izlazBTN3.Size = new System.Drawing.Size(125, 39);
            this.izlazBTN3.TabIndex = 14;
            this.izlazBTN3.Text = "Izađi";
            this.izlazBTN3.UseVisualStyleBackColor = false;
            this.izlazBTN3.Click += new System.EventHandler(this.izlazBTN3_Click);
            // 
            // prikaziBTN
            // 
            this.prikaziBTN.BackColor = System.Drawing.Color.CornflowerBlue;
            this.prikaziBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prikaziBTN.Location = new System.Drawing.Point(24, 318);
            this.prikaziBTN.Name = "prikaziBTN";
            this.prikaziBTN.Size = new System.Drawing.Size(125, 39);
            this.prikaziBTN.TabIndex = 13;
            this.prikaziBTN.Text = "Prikaži";
            this.prikaziBTN.UseVisualStyleBackColor = false;
            this.prikaziBTN.Click += new System.EventHandler(this.prikaziBTN_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(451, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 327);
            this.panel1.TabIndex = 12;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "rezultat";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(347, 327);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(412, 174);
            this.dataGridView1.TabIndex = 11;
            // 
            // statistikaUcestvovaloLB
            // 
            this.statistikaUcestvovaloLB.AutoSize = true;
            this.statistikaUcestvovaloLB.Location = new System.Drawing.Point(283, 99);
            this.statistikaUcestvovaloLB.Name = "statistikaUcestvovaloLB";
            this.statistikaUcestvovaloLB.Size = new System.Drawing.Size(18, 20);
            this.statistikaUcestvovaloLB.TabIndex = 10;
            this.statistikaUcestvovaloLB.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(248, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Ukupan broj pasa koji se takmičio:";
            // 
            // statistikaPrijavljenoLB
            // 
            this.statistikaPrijavljenoLB.AutoSize = true;
            this.statistikaPrijavljenoLB.Location = new System.Drawing.Point(283, 64);
            this.statistikaPrijavljenoLB.Name = "statistikaPrijavljenoLB";
            this.statistikaPrijavljenoLB.Size = new System.Drawing.Size(18, 20);
            this.statistikaPrijavljenoLB.TabIndex = 8;
            this.statistikaPrijavljenoLB.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(245, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ukupan broj pasa koji je prijavljan:";
            // 
            // statistikaIzlozbaCB
            // 
            this.statistikaIzlozbaCB.FormattingEnabled = true;
            this.statistikaIzlozbaCB.Location = new System.Drawing.Point(110, 18);
            this.statistikaIzlozbaCB.Name = "statistikaIzlozbaCB";
            this.statistikaIzlozbaCB.Size = new System.Drawing.Size(326, 28);
            this.statistikaIzlozbaCB.TabIndex = 6;
            this.statistikaIzlozbaCB.SelectedIndexChanged += new System.EventHandler(this.statistikaIzlozbaCB_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Izložba:";
            // 
            // oAplikacijiTab
            // 
            this.oAplikacijiTab.Controls.Add(this.textBox1);
            this.oAplikacijiTab.Location = new System.Drawing.Point(4, 29);
            this.oAplikacijiTab.Name = "oAplikacijiTab";
            this.oAplikacijiTab.Size = new System.Drawing.Size(806, 365);
            this.oAplikacijiTab.TabIndex = 2;
            this.oAplikacijiTab.Text = "O Aplikaciji";
            this.oAplikacijiTab.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(806, 365);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "\r\n\r\nZadatak A16 - Izložba pasa\r\n\r\n\r\n\r\nU tabu \"Unesi prijavu\" možete prijaviti psa" +
    " za neku izložbu.\r\n\r\nU tabu \"Statistika\" možete videti podatke o svakoj izložbi " +
    "ponaosob.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // izlazTab
            // 
            this.izlazTab.Controls.Add(this.izlazBTN2);
            this.izlazTab.Location = new System.Drawing.Point(4, 29);
            this.izlazTab.Name = "izlazTab";
            this.izlazTab.Size = new System.Drawing.Size(806, 365);
            this.izlazTab.TabIndex = 3;
            this.izlazTab.Text = "Izlaz";
            this.izlazTab.UseVisualStyleBackColor = true;
            // 
            // izlazBTN2
            // 
            this.izlazBTN2.Image = global::A16.Properties.Resources.close;
            this.izlazBTN2.Location = new System.Drawing.Point(341, 131);
            this.izlazBTN2.Margin = new System.Windows.Forms.Padding(0);
            this.izlazBTN2.Name = "izlazBTN2";
            this.izlazBTN2.Size = new System.Drawing.Size(80, 77);
            this.izlazBTN2.TabIndex = 8;
            this.izlazBTN2.UseVisualStyleBackColor = true;
            this.izlazBTN2.Click += new System.EventHandler(this.izlazBTN2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 398);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "A16 Izložba pasa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.prijavaTab.ResumeLayout(false);
            this.prijavaTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statistikaTab.ResumeLayout(false);
            this.statistikaTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.oAplikacijiTab.ResumeLayout(false);
            this.oAplikacijiTab.PerformLayout();
            this.izlazTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage prijavaTab;
        private System.Windows.Forms.Button prijavaBTN;
        private System.Windows.Forms.ComboBox kategorijaCB;
        private System.Windows.Forms.ComboBox izlozbaCB;
        private System.Windows.Forms.ComboBox pasCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage statistikaTab;
        private System.Windows.Forms.TabPage oAplikacijiTab;
        private System.Windows.Forms.TabPage izlazTab;
        private System.Windows.Forms.Button izlazBTN1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button izlazBTN2;
        private System.Windows.Forms.Button izlazBTN3;
        private System.Windows.Forms.Button prikaziBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label statistikaUcestvovaloLB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label statistikaPrijavljenoLB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox statistikaIzlozbaCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
    }
}

