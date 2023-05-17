namespace A1
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
            this.oAplikacijiTab = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.citaociTab.SuspendLayout();
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
            this.lista.HideSelection = false;
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
            this.iznajmljivanjaTab.Location = new System.Drawing.Point(4, 38);
            this.iznajmljivanjaTab.Name = "iznajmljivanjaTab";
            this.iznajmljivanjaTab.Padding = new System.Windows.Forms.Padding(3);
            this.iznajmljivanjaTab.Size = new System.Drawing.Size(1126, 357);
            this.iznajmljivanjaTab.TabIndex = 1;
            this.iznajmljivanjaTab.Text = "Pregled Iznamljivanja";
            this.iznajmljivanjaTab.UseVisualStyleBackColor = true;
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
    }
}

