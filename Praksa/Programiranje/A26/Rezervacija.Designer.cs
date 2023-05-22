namespace A26
{
    partial class Rezervacija
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
            this.label1 = new System.Windows.Forms.Label();
            this.polazakCalendar = new System.Windows.Forms.MonthCalendar();
            this.povratakCalendar = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.pretragaBtn = new System.Windows.Forms.Button();
            this.zatvoriBtn = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.ukupnoLB = new System.Windows.Forms.Label();
            this.raspolozivoLB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Polazak:";
            // 
            // polazakCalendar
            // 
            this.polazakCalendar.Location = new System.Drawing.Point(123, 72);
            this.polazakCalendar.Name = "polazakCalendar";
            this.polazakCalendar.TabIndex = 1;
            // 
            // povratakCalendar
            // 
            this.povratakCalendar.Location = new System.Drawing.Point(123, 297);
            this.povratakCalendar.Name = "povratakCalendar";
            this.povratakCalendar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Povratak";
            // 
            // pretragaBtn
            // 
            this.pretragaBtn.Location = new System.Drawing.Point(390, 12);
            this.pretragaBtn.Name = "pretragaBtn";
            this.pretragaBtn.Size = new System.Drawing.Size(197, 40);
            this.pretragaBtn.TabIndex = 4;
            this.pretragaBtn.Text = "Pretraga kapaciteta";
            this.pretragaBtn.UseVisualStyleBackColor = true;
            this.pretragaBtn.Click += new System.EventHandler(this.pretragaBtn_Click);
            // 
            // zatvoriBtn
            // 
            this.zatvoriBtn.Location = new System.Drawing.Point(593, 12);
            this.zatvoriBtn.Name = "zatvoriBtn";
            this.zatvoriBtn.Size = new System.Drawing.Size(197, 40);
            this.zatvoriBtn.TabIndex = 5;
            this.zatvoriBtn.Text = "Zatvori";
            this.zatvoriBtn.UseVisualStyleBackColor = true;
            this.zatvoriBtn.Click += new System.EventHandler(this.zatvoriBtn_Click);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(390, 73);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.RowHeadersWidth = 51;
            this.grid.Size = new System.Drawing.Size(398, 431);
            this.grid.TabIndex = 6;
            // 
            // ukupnoLB
            // 
            this.ukupnoLB.AutoSize = true;
            this.ukupnoLB.Location = new System.Drawing.Point(5, 522);
            this.ukupnoLB.Name = "ukupnoLB";
            this.ukupnoLB.Size = new System.Drawing.Size(221, 29);
            this.ukupnoLB.TabIndex = 7;
            this.ukupnoLB.Text = "Ukupni kapaciteti: 0";
            // 
            // raspolozivoLB
            // 
            this.raspolozivoLB.AutoSize = true;
            this.raspolozivoLB.Location = new System.Drawing.Point(385, 522);
            this.raspolozivoLB.Name = "raspolozivoLB";
            this.raspolozivoLB.Size = new System.Drawing.Size(270, 29);
            this.raspolozivoLB.TabIndex = 8;
            this.raspolozivoLB.Text = "Raspoloživi kapaciteti: 0";
            // 
            // Rezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 560);
            this.Controls.Add(this.raspolozivoLB);
            this.Controls.Add(this.ukupnoLB);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.zatvoriBtn);
            this.Controls.Add(this.pretragaBtn);
            this.Controls.Add(this.povratakCalendar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.polazakCalendar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "Rezervacija";
            this.Text = "Rezervacija";
            this.Load += new System.EventHandler(this.Rezervacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar polazakCalendar;
        private System.Windows.Forms.MonthCalendar povratakCalendar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button pretragaBtn;
        private System.Windows.Forms.Button zatvoriBtn;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label ukupnoLB;
        private System.Windows.Forms.Label raspolozivoLB;
    }
}