namespace A8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Analiza));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.godinaNUD = new System.Windows.Forms.NumericUpDown();
            this.brojNUD = new System.Windows.Forms.NumericUpDown();
            this.grid = new System.Windows.Forms.DataGridView();
            this.prikaziBTN = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.godinaNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Godina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Broj otkrića:";
            // 
            // godinaNUD
            // 
            this.godinaNUD.Location = new System.Drawing.Point(125, 12);
            this.godinaNUD.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.godinaNUD.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.godinaNUD.Name = "godinaNUD";
            this.godinaNUD.Size = new System.Drawing.Size(120, 29);
            this.godinaNUD.TabIndex = 2;
            this.godinaNUD.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            // 
            // brojNUD
            // 
            this.brojNUD.Location = new System.Drawing.Point(125, 51);
            this.brojNUD.Name = "brojNUD";
            this.brojNUD.Size = new System.Drawing.Size(120, 29);
            this.brojNUD.TabIndex = 3;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToOrderColumns = true;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(16, 86);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.Size = new System.Drawing.Size(344, 150);
            this.grid.TabIndex = 4;
            // 
            // prikaziBTN
            // 
            this.prikaziBTN.Location = new System.Drawing.Point(16, 242);
            this.prikaziBTN.Name = "prikaziBTN";
            this.prikaziBTN.Size = new System.Drawing.Size(125, 34);
            this.prikaziBTN.TabIndex = 5;
            this.prikaziBTN.Text = "Prikaži";
            this.prikaziBTN.UseVisualStyleBackColor = true;
            this.prikaziBTN.Click += new System.EventHandler(this.prikaziBTN_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(387, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Name = "podaci";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(327, 264);
            this.chart1.TabIndex = 6;
            // 
            // Analiza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 287);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.prikaziBTN);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.brojNUD);
            this.Controls.Add(this.godinaNUD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Analiza";
            this.Text = "Analiza";
            ((System.ComponentModel.ISupportInitialize)(this.godinaNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown godinaNUD;
        private System.Windows.Forms.NumericUpDown brojNUD;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button prikaziBTN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}