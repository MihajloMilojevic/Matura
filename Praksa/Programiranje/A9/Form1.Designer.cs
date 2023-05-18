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
            this.pregledRezultataTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.podaciOKlubovimaTab.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(872, 475);
            this.tabControl1.TabIndex = 0;
            // 
            // podaciOKlubovimaTab
            // 
            this.podaciOKlubovimaTab.Controls.Add(this.button1);
            this.podaciOKlubovimaTab.Controls.Add(this.label4);
            this.podaciOKlubovimaTab.Controls.Add(this.comboBox3);
            this.podaciOKlubovimaTab.Controls.Add(this.label3);
            this.podaciOKlubovimaTab.Controls.Add(this.comboBox2);
            this.podaciOKlubovimaTab.Controls.Add(this.label2);
            this.podaciOKlubovimaTab.Controls.Add(this.comboBox1);
            this.podaciOKlubovimaTab.Controls.Add(this.label1);
            this.podaciOKlubovimaTab.Location = new System.Drawing.Point(4, 33);
            this.podaciOKlubovimaTab.Name = "podaciOKlubovimaTab";
            this.podaciOKlubovimaTab.Padding = new System.Windows.Forms.Padding(3);
            this.podaciOKlubovimaTab.Size = new System.Drawing.Size(864, 438);
            this.podaciOKlubovimaTab.TabIndex = 0;
            this.podaciOKlubovimaTab.Text = "Podaci o klubovima";
            this.podaciOKlubovimaTab.UseVisualStyleBackColor = true;
            // 
            // pregledRezultataTab
            // 
            this.pregledRezultataTab.Location = new System.Drawing.Point(4, 33);
            this.pregledRezultataTab.Name = "pregledRezultataTab";
            this.pregledRezultataTab.Padding = new System.Windows.Forms.Padding(3);
            this.pregledRezultataTab.Size = new System.Drawing.Size(864, 438);
            this.pregledRezultataTab.TabIndex = 1;
            this.pregledRezultataTab.Text = "Pregled rezultata";
            this.pregledRezultataTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Država:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(29, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 32);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(230, 55);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(181, 32);
            this.comboBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Grad:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(428, 55);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(181, 32);
            this.comboBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Klub:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Podaci o klubu:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(689, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 55);
            this.button1.TabIndex = 7;
            this.button1.Text = "Resetuj pretragu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 475);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Fudbalski klubovi";
            this.tabControl1.ResumeLayout(false);
            this.podaciOKlubovimaTab.ResumeLayout(false);
            this.podaciOKlubovimaTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage podaciOKlubovimaTab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage pregledRezultataTab;
    }
}

