﻿namespace A1
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.citaociTab = new System.Windows.Forms.TabPage();
            this.izlazBTN = new System.Windows.Forms.Button();
            this.upisiBtn = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AdresaTB = new System.Windows.Forms.TextBox();
            this.prezimeTB = new System.Windows.Forms.TextBox();
            this.imeTB = new System.Windows.Forms.TextBox();
            this.jmbgTB = new System.Windows.Forms.TextBox();
            this.brojTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iznajmljivanjaTab = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.izlaz2Btn = new System.Windows.Forms.Button();
            this.prikaziBtn = new System.Windows.Forms.Button();
            this.podaciDGV = new System.Windows.Forms.DataGridView();
            this.citalacCb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.maxGodNUD = new System.Windows.Forms.NumericUpDown();
            this.minGodNUD = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.oAplikacijiTab = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.citaociTab.SuspendLayout();
            this.iznajmljivanjaTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.podaciDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxGodNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minGodNUD)).BeginInit();
            this.oAplikacijiTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.citaociTab);
            this.tabControl1.Controls.Add(this.iznajmljivanjaTab);
            this.tabControl1.Controls.Add(this.oAplikacijiTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1134, 399);
            this.tabControl1.TabIndex = 0;
            // 
            // citaociTab
            // 
            this.citaociTab.Controls.Add(this.izlazBTN);
            this.citaociTab.Controls.Add(this.upisiBtn);
            this.citaociTab.Controls.Add(this.lista);
            this.citaociTab.Controls.Add(this.AdresaTB);
            this.citaociTab.Controls.Add(this.prezimeTB);
            this.citaociTab.Controls.Add(this.imeTB);
            this.citaociTab.Controls.Add(this.jmbgTB);
            this.citaociTab.Controls.Add(this.brojTB);
            this.citaociTab.Controls.Add(this.label5);
            this.citaociTab.Controls.Add(this.label4);
            this.citaociTab.Controls.Add(this.label3);
            this.citaociTab.Controls.Add(this.label2);
            this.citaociTab.Controls.Add(this.label1);
            this.citaociTab.Location = new System.Drawing.Point(4, 38);
            this.citaociTab.Name = "citaociTab";
            this.citaociTab.Padding = new System.Windows.Forms.Padding(3);
            this.citaociTab.Size = new System.Drawing.Size(1126, 357);
            this.citaociTab.TabIndex = 0;
            this.citaociTab.Text = "Čitaoci";
            this.citaociTab.UseVisualStyleBackColor = true;
            this.citaociTab.Enter += new System.EventHandler(this.citaociTab_Enter);
            // 
            // izlazBTN
            // 
            this.izlazBTN.Location = new System.Drawing.Point(31, 296);
            this.izlazBTN.Name = "izlazBTN";
            this.izlazBTN.Size = new System.Drawing.Size(348, 43);
            this.izlazBTN.TabIndex = 12;
            this.izlazBTN.Text = "Izlaz";
            this.izlazBTN.UseVisualStyleBackColor = true;
            this.izlazBTN.Click += new System.EventHandler(this.izlazBTN_Click);
            // 
            // upisiBtn
            // 
            this.upisiBtn.Location = new System.Drawing.Point(31, 247);
            this.upisiBtn.Name = "upisiBtn";
            this.upisiBtn.Size = new System.Drawing.Size(348, 43);
            this.upisiBtn.TabIndex = 11;
            this.upisiBtn.Text = "Upiši čitaoca";
            this.upisiBtn.UseVisualStyleBackColor = true;
            this.upisiBtn.Click += new System.EventHandler(this.upisiBtn_Click);
            // 
            // lista
            // 
            this.lista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lista.FullRowSelect = true;
            this.lista.Location = new System.Drawing.Point(401, 34);
            this.lista.MultiSelect = false;
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(707, 305);
            this.lista.TabIndex = 10;
            this.lista.UseCompatibleStateImageBehavior = false;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Članska karta";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "JMBG";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ime";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Prezime";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adresa";
            this.columnHeader5.Width = 100;
            // 
            // AdresaTB
            // 
            this.AdresaTB.Location = new System.Drawing.Point(138, 198);
            this.AdresaTB.Name = "AdresaTB";
            this.AdresaTB.Size = new System.Drawing.Size(241, 34);
            this.AdresaTB.TabIndex = 9;
            // 
            // prezimeTB
            // 
            this.prezimeTB.Location = new System.Drawing.Point(138, 158);
            this.prezimeTB.Name = "prezimeTB";
            this.prezimeTB.Size = new System.Drawing.Size(241, 34);
            this.prezimeTB.TabIndex = 8;
            // 
            // imeTB
            // 
            this.imeTB.Location = new System.Drawing.Point(138, 118);
            this.imeTB.Name = "imeTB";
            this.imeTB.Size = new System.Drawing.Size(241, 34);
            this.imeTB.TabIndex = 7;
            // 
            // jmbgTB
            // 
            this.jmbgTB.Location = new System.Drawing.Point(138, 78);
            this.jmbgTB.Name = "jmbgTB";
            this.jmbgTB.Size = new System.Drawing.Size(241, 34);
            this.jmbgTB.TabIndex = 6;
            // 
            // brojTB
            // 
            this.brojTB.Location = new System.Drawing.Point(224, 34);
            this.brojTB.Name = "brojTB";
            this.brojTB.Size = new System.Drawing.Size(155, 34);
            this.brojTB.TabIndex = 5;
            this.brojTB.TextChanged += new System.EventHandler(this.brojTB_TextChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(26, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 34);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adresa";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(26, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prezime";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(26, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ime";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(26, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "JMBG";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Br. članske karte";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // iznajmljivanjaTab
            // 
            this.iznajmljivanjaTab.Controls.Add(this.chart1);
            this.iznajmljivanjaTab.Controls.Add(this.izlaz2Btn);
            this.iznajmljivanjaTab.Controls.Add(this.prikaziBtn);
            this.iznajmljivanjaTab.Controls.Add(this.podaciDGV);
            this.iznajmljivanjaTab.Controls.Add(this.citalacCb);
            this.iznajmljivanjaTab.Controls.Add(this.label8);
            this.iznajmljivanjaTab.Controls.Add(this.label7);
            this.iznajmljivanjaTab.Controls.Add(this.maxGodNUD);
            this.iznajmljivanjaTab.Controls.Add(this.minGodNUD);
            this.iznajmljivanjaTab.Controls.Add(this.label6);
            this.iznajmljivanjaTab.Location = new System.Drawing.Point(4, 38);
            this.iznajmljivanjaTab.Name = "iznajmljivanjaTab";
            this.iznajmljivanjaTab.Padding = new System.Windows.Forms.Padding(3);
            this.iznajmljivanjaTab.Size = new System.Drawing.Size(1126, 357);
            this.iznajmljivanjaTab.TabIndex = 1;
            this.iznajmljivanjaTab.Text = "Pregled Iznamljivanja";
            this.iznajmljivanjaTab.UseVisualStyleBackColor = true;
            this.iznajmljivanjaTab.Enter += new System.EventHandler(this.iznajmljivanjaTab_Enter);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(437, 13);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "iznajmljeno";
            series2.ChartArea = "ChartArea1";
            series2.Name = "vraceno";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(672, 339);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // izlaz2Btn
            // 
            this.izlaz2Btn.Location = new System.Drawing.Point(277, 317);
            this.izlaz2Btn.Name = "izlaz2Btn";
            this.izlaz2Btn.Size = new System.Drawing.Size(144, 37);
            this.izlaz2Btn.TabIndex = 8;
            this.izlaz2Btn.Text = "Izlađi";
            this.izlaz2Btn.UseVisualStyleBackColor = true;
            this.izlaz2Btn.Click += new System.EventHandler(this.izlaz2Btn_Click);
            // 
            // prikaziBtn
            // 
            this.prikaziBtn.Location = new System.Drawing.Point(19, 317);
            this.prikaziBtn.Name = "prikaziBtn";
            this.prikaziBtn.Size = new System.Drawing.Size(144, 37);
            this.prikaziBtn.TabIndex = 7;
            this.prikaziBtn.Text = "Prikaži";
            this.prikaziBtn.UseVisualStyleBackColor = true;
            this.prikaziBtn.Click += new System.EventHandler(this.prikaziBtn_Click);
            // 
            // podaciDGV
            // 
            this.podaciDGV.AllowUserToAddRows = false;
            this.podaciDGV.AllowUserToDeleteRows = false;
            this.podaciDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.podaciDGV.Location = new System.Drawing.Point(19, 90);
            this.podaciDGV.Name = "podaciDGV";
            this.podaciDGV.ReadOnly = true;
            this.podaciDGV.RowHeadersVisible = false;
            this.podaciDGV.RowHeadersWidth = 51;
            this.podaciDGV.Size = new System.Drawing.Size(402, 221);
            this.podaciDGV.TabIndex = 6;
            // 
            // citalacCb
            // 
            this.citalacCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.citalacCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.citalacCb.FormattingEnabled = true;
            this.citalacCb.Location = new System.Drawing.Point(86, 52);
            this.citalacCb.Name = "citalacCb";
            this.citalacCb.Size = new System.Drawing.Size(335, 37);
            this.citalacCb.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 29);
            this.label8.TabIndex = 4;
            this.label8.Text = "Čitalac";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 29);
            this.label7.TabIndex = 3;
            this.label7.Text = "do";
            // 
            // maxGodNUD
            // 
            this.maxGodNUD.Location = new System.Drawing.Point(337, 13);
            this.maxGodNUD.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.maxGodNUD.Name = "maxGodNUD";
            this.maxGodNUD.Size = new System.Drawing.Size(84, 34);
            this.maxGodNUD.TabIndex = 2;
            this.maxGodNUD.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.maxGodNUD.ValueChanged += new System.EventHandler(this.maxGodNUD_ValueChanged);
            // 
            // minGodNUD
            // 
            this.minGodNUD.Location = new System.Drawing.Point(208, 13);
            this.minGodNUD.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.minGodNUD.Name = "minGodNUD";
            this.minGodNUD.Size = new System.Drawing.Size(84, 34);
            this.minGodNUD.TabIndex = 1;
            this.minGodNUD.Value = new decimal(new int[] {
            2013,
            0,
            0,
            0});
            this.minGodNUD.ValueChanged += new System.EventHandler(this.minGodNUD_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Vremenski period od";
            // 
            // oAplikacijiTab
            // 
            this.oAplikacijiTab.Controls.Add(this.textBox1);
            this.oAplikacijiTab.Location = new System.Drawing.Point(4, 38);
            this.oAplikacijiTab.Name = "oAplikacijiTab";
            this.oAplikacijiTab.Size = new System.Drawing.Size(1126, 357);
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
            this.textBox1.Size = new System.Drawing.Size(1126, 357);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 399);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Biblioteka";
            this.tabControl1.ResumeLayout(false);
            this.citaociTab.ResumeLayout(false);
            this.citaociTab.PerformLayout();
            this.iznajmljivanjaTab.ResumeLayout(false);
            this.iznajmljivanjaTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.podaciDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxGodNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minGodNUD)).EndInit();
            this.oAplikacijiTab.ResumeLayout(false);
            this.oAplikacijiTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage citaociTab;
        private System.Windows.Forms.TabPage iznajmljivanjaTab;
        private System.Windows.Forms.TabPage oAplikacijiTab;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView lista;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox AdresaTB;
        private System.Windows.Forms.TextBox prezimeTB;
        private System.Windows.Forms.TextBox imeTB;
        private System.Windows.Forms.TextBox jmbgTB;
        private System.Windows.Forms.TextBox brojTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button izlazBTN;
        private System.Windows.Forms.Button upisiBtn;
        private System.Windows.Forms.Button izlaz2Btn;
        private System.Windows.Forms.Button prikaziBtn;
        private System.Windows.Forms.DataGridView podaciDGV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown maxGodNUD;
        private System.Windows.Forms.NumericUpDown minGodNUD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox citalacCb;
    }
}

