namespace A9
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
            this.podaciOKlubovimaTab = new System.Windows.Forms.TabPage();
            this.sajtLB = new System.Windows.Forms.Label();
            this.stadionLB = new System.Windows.Forms.Label();
            this.imeLB = new System.Windows.Forms.Label();
            this.izlazBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.klubCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gradCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.drzavaCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pregledRezultataTab = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.datumPicker = new System.Windows.Forms.DateTimePicker();
            this.prikaziBtn = new System.Windows.Forms.Button();
            this.izlaz2Btn = new System.Windows.Forms.Button();
            this.prikazUtakmica = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.podaciOKlubovimaTab.SuspendLayout();
            this.pregledRezultataTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.podaciOKlubovimaTab);
            this.tabControl1.Controls.Add(this.pregledRezultataTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(830, 355);
            this.tabControl1.TabIndex = 0;
            // 
            // podaciOKlubovimaTab
            // 
            this.podaciOKlubovimaTab.Controls.Add(this.sajtLB);
            this.podaciOKlubovimaTab.Controls.Add(this.stadionLB);
            this.podaciOKlubovimaTab.Controls.Add(this.imeLB);
            this.podaciOKlubovimaTab.Controls.Add(this.izlazBtn);
            this.podaciOKlubovimaTab.Controls.Add(this.resetBtn);
            this.podaciOKlubovimaTab.Controls.Add(this.label4);
            this.podaciOKlubovimaTab.Controls.Add(this.klubCB);
            this.podaciOKlubovimaTab.Controls.Add(this.label3);
            this.podaciOKlubovimaTab.Controls.Add(this.gradCB);
            this.podaciOKlubovimaTab.Controls.Add(this.label2);
            this.podaciOKlubovimaTab.Controls.Add(this.drzavaCB);
            this.podaciOKlubovimaTab.Controls.Add(this.label1);
            this.podaciOKlubovimaTab.Location = new System.Drawing.Point(4, 38);
            this.podaciOKlubovimaTab.Name = "podaciOKlubovimaTab";
            this.podaciOKlubovimaTab.Padding = new System.Windows.Forms.Padding(3);
            this.podaciOKlubovimaTab.Size = new System.Drawing.Size(822, 313);
            this.podaciOKlubovimaTab.TabIndex = 0;
            this.podaciOKlubovimaTab.Text = "Podaci o klubovima";
            this.podaciOKlubovimaTab.UseVisualStyleBackColor = true;
            // 
            // sajtLB
            // 
            this.sajtLB.AutoSize = true;
            this.sajtLB.Location = new System.Drawing.Point(30, 246);
            this.sajtLB.Name = "sajtLB";
            this.sajtLB.Size = new System.Drawing.Size(20, 29);
            this.sajtLB.TabIndex = 11;
            this.sajtLB.Text = "/";
            // 
            // stadionLB
            // 
            this.stadionLB.AutoSize = true;
            this.stadionLB.Location = new System.Drawing.Point(30, 198);
            this.stadionLB.Name = "stadionLB";
            this.stadionLB.Size = new System.Drawing.Size(20, 29);
            this.stadionLB.TabIndex = 10;
            this.stadionLB.Text = "/";
            // 
            // imeLB
            // 
            this.imeLB.AutoSize = true;
            this.imeLB.Location = new System.Drawing.Point(30, 155);
            this.imeLB.Name = "imeLB";
            this.imeLB.Size = new System.Drawing.Size(20, 29);
            this.imeLB.TabIndex = 9;
            this.imeLB.Text = "/";
            // 
            // izlazBtn
            // 
            this.izlazBtn.Location = new System.Drawing.Point(628, 207);
            this.izlazBtn.Name = "izlazBtn";
            this.izlazBtn.Size = new System.Drawing.Size(172, 79);
            this.izlazBtn.TabIndex = 8;
            this.izlazBtn.Text = "Izlaz";
            this.izlazBtn.UseVisualStyleBackColor = true;
            this.izlazBtn.Click += new System.EventHandler(this.izlazBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(628, 13);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(172, 79);
            this.resetBtn.TabIndex = 7;
            this.resetBtn.Text = "Resetuj pretragu";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Podaci o klubu:";
            // 
            // klubCB
            // 
            this.klubCB.FormattingEnabled = true;
            this.klubCB.Location = new System.Drawing.Point(428, 55);
            this.klubCB.Name = "klubCB";
            this.klubCB.Size = new System.Drawing.Size(181, 37);
            this.klubCB.TabIndex = 5;
            this.klubCB.SelectedIndexChanged += new System.EventHandler(this.klubCB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Klub:";
            // 
            // gradCB
            // 
            this.gradCB.FormattingEnabled = true;
            this.gradCB.Location = new System.Drawing.Point(230, 55);
            this.gradCB.Name = "gradCB";
            this.gradCB.Size = new System.Drawing.Size(181, 37);
            this.gradCB.TabIndex = 3;
            this.gradCB.SelectedIndexChanged += new System.EventHandler(this.gradCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Grad:";
            // 
            // drzavaCB
            // 
            this.drzavaCB.FormattingEnabled = true;
            this.drzavaCB.Location = new System.Drawing.Point(29, 55);
            this.drzavaCB.Name = "drzavaCB";
            this.drzavaCB.Size = new System.Drawing.Size(181, 37);
            this.drzavaCB.TabIndex = 1;
            this.drzavaCB.SelectedIndexChanged += new System.EventHandler(this.drzavaCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Država:";
            // 
            // pregledRezultataTab
            // 
            this.pregledRezultataTab.Controls.Add(this.prikazUtakmica);
            this.pregledRezultataTab.Controls.Add(this.izlaz2Btn);
            this.pregledRezultataTab.Controls.Add(this.prikaziBtn);
            this.pregledRezultataTab.Controls.Add(this.datumPicker);
            this.pregledRezultataTab.Controls.Add(this.label5);
            this.pregledRezultataTab.Location = new System.Drawing.Point(4, 38);
            this.pregledRezultataTab.Name = "pregledRezultataTab";
            this.pregledRezultataTab.Padding = new System.Windows.Forms.Padding(3);
            this.pregledRezultataTab.Size = new System.Drawing.Size(822, 313);
            this.pregledRezultataTab.TabIndex = 1;
            this.pregledRezultataTab.Text = "Pregled rezultata";
            this.pregledRezultataTab.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Datum utakmice: ";
            // 
            // datumPicker
            // 
            this.datumPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumPicker.Location = new System.Drawing.Point(195, 15);
            this.datumPicker.Name = "datumPicker";
            this.datumPicker.Size = new System.Drawing.Size(171, 34);
            this.datumPicker.TabIndex = 1;
            // 
            // prikaziBtn
            // 
            this.prikaziBtn.Location = new System.Drawing.Point(459, 15);
            this.prikaziBtn.Name = "prikaziBtn";
            this.prikaziBtn.Size = new System.Drawing.Size(170, 34);
            this.prikaziBtn.TabIndex = 2;
            this.prikaziBtn.Text = "Prikaži";
            this.prikaziBtn.UseVisualStyleBackColor = true;
            this.prikaziBtn.Click += new System.EventHandler(this.prikaziBtn_Click);
            // 
            // izlaz2Btn
            // 
            this.izlaz2Btn.Location = new System.Drawing.Point(638, 15);
            this.izlaz2Btn.Name = "izlaz2Btn";
            this.izlaz2Btn.Size = new System.Drawing.Size(170, 34);
            this.izlaz2Btn.TabIndex = 3;
            this.izlaz2Btn.Text = "Izađi";
            this.izlaz2Btn.UseVisualStyleBackColor = true;
            this.izlaz2Btn.Click += new System.EventHandler(this.izlaz2Btn_Click);
            // 
            // prikazUtakmica
            // 
            this.prikazUtakmica.HideSelection = false;
            this.prikazUtakmica.Location = new System.Drawing.Point(13, 66);
            this.prikazUtakmica.Name = "prikazUtakmica";
            this.prikazUtakmica.Size = new System.Drawing.Size(795, 234);
            this.prikazUtakmica.TabIndex = 4;
            this.prikazUtakmica.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 355);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Fudbalski klubovi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.podaciOKlubovimaTab.ResumeLayout(false);
            this.podaciOKlubovimaTab.PerformLayout();
            this.pregledRezultataTab.ResumeLayout(false);
            this.pregledRezultataTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage podaciOKlubovimaTab;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox klubCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox gradCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox drzavaCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage pregledRezultataTab;
        private System.Windows.Forms.Label sajtLB;
        private System.Windows.Forms.Label stadionLB;
        private System.Windows.Forms.Label imeLB;
        private System.Windows.Forms.Button izlazBtn;
        private System.Windows.Forms.DateTimePicker datumPicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button izlaz2Btn;
        private System.Windows.Forms.Button prikaziBtn;
        private System.Windows.Forms.ListView prikazUtakmica;
    }
}

