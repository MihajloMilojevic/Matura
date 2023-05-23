namespace A30
{
    partial class Analiza
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.odCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.doCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.prikaziBtn = new System.Windows.Forms.Button();
            this.izadjiBtn = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.izadjiBtn);
            this.panel1.Controls.Add(this.prikaziBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.doCB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.odCB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 111);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odaberi dužinu trajanja parije.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Partije koje su trajale od ";
            // 
            // odCB
            // 
            this.odCB.FormattingEnabled = true;
            this.odCB.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "21",
            "22",
            "23",
            "24"});
            this.odCB.Location = new System.Drawing.Point(296, 57);
            this.odCB.Name = "odCB";
            this.odCB.Size = new System.Drawing.Size(113, 37);
            this.odCB.TabIndex = 2;
            this.odCB.SelectedIndexChanged += new System.EventHandler(this.odCB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(410, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "h  do";
            // 
            // doCB
            // 
            this.doCB.FormattingEnabled = true;
            this.doCB.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "21",
            "22",
            "23",
            "24"});
            this.doCB.Location = new System.Drawing.Point(482, 57);
            this.doCB.Name = "doCB";
            this.doCB.Size = new System.Drawing.Size(113, 37);
            this.doCB.TabIndex = 4;
            this.doCB.SelectedIndexChanged += new System.EventHandler(this.doCB_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(601, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "h.";
            // 
            // prikaziBtn
            // 
            this.prikaziBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.prikaziBtn.ForeColor = System.Drawing.Color.White;
            this.prikaziBtn.Location = new System.Drawing.Point(728, 42);
            this.prikaziBtn.Name = "prikaziBtn";
            this.prikaziBtn.Size = new System.Drawing.Size(152, 52);
            this.prikaziBtn.TabIndex = 6;
            this.prikaziBtn.Text = "Prikaži";
            this.prikaziBtn.UseVisualStyleBackColor = false;
            this.prikaziBtn.Click += new System.EventHandler(this.prikaziBtn_Click);
            // 
            // izadjiBtn
            // 
            this.izadjiBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.izadjiBtn.ForeColor = System.Drawing.Color.White;
            this.izadjiBtn.Location = new System.Drawing.Point(896, 42);
            this.izadjiBtn.Name = "izadjiBtn";
            this.izadjiBtn.Size = new System.Drawing.Size(152, 52);
            this.izadjiBtn.TabIndex = 7;
            this.izadjiBtn.Text = "Izađi";
            this.izadjiBtn.UseVisualStyleBackColor = false;
            this.izadjiBtn.Click += new System.EventHandler(this.izadjiBtn_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(12, 117);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Name = "podaci";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(515, 462);
            this.chart1.TabIndex = 1;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(557, 117);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.RowHeadersWidth = 51;
            this.grid.RowTemplate.Height = 24;
            this.grid.Size = new System.Drawing.Size(499, 462);
            this.grid.TabIndex = 2;
            // 
            // Analiza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 591);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Analiza";
            this.Text = "Analiza";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button izadjiBtn;
        private System.Windows.Forms.Button prikaziBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox doCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox odCB;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView grid;
    }
}