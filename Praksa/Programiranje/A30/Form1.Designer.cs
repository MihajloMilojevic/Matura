namespace A30
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.telefonTB = new System.Windows.Forms.TextBox();
            this.gradCB = new System.Windows.Forms.ComboBox();
            this.adresaTb = new System.Windows.Forms.TextBox();
            this.nazivTB = new System.Windows.Forms.TextBox();
            this.sifraCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listaTerena = new System.Windows.Forms.ListBox();
            this.headerLB = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton2,
            this.toolStripButton4,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 470);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(970, 78);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.BackgroundImage = global::A30.Properties.Resources.delete;
            this.toolStripButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(75, 75);
            this.toolStripButton3.Text = "toolStripButton1";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.BackgroundImage = global::A30.Properties.Resources.chart;
            this.toolStripButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(75, 75);
            this.toolStripButton2.Text = "toolStripButton1";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.AutoSize = false;
            this.toolStripButton4.BackgroundImage = global::A30.Properties.Resources.info;
            this.toolStripButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(75, 75);
            this.toolStripButton4.Text = "toolStripButton1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.BackgroundImage = global::A30.Properties.Resources.exit;
            this.toolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(75, 75);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.telefonTB);
            this.panel1.Controls.Add(this.gradCB);
            this.panel1.Controls.Add(this.adresaTb);
            this.panel1.Controls.Add(this.nazivTB);
            this.panel1.Controls.Add(this.sifraCB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 214);
            this.panel1.TabIndex = 1;
            // 
            // telefonTB
            // 
            this.telefonTB.Location = new System.Drawing.Point(108, 172);
            this.telefonTB.Name = "telefonTB";
            this.telefonTB.Size = new System.Drawing.Size(390, 34);
            this.telefonTB.TabIndex = 9;
            // 
            // gradCB
            // 
            this.gradCB.FormattingEnabled = true;
            this.gradCB.Location = new System.Drawing.Point(108, 129);
            this.gradCB.Name = "gradCB";
            this.gradCB.Size = new System.Drawing.Size(390, 37);
            this.gradCB.TabIndex = 8;
            // 
            // adresaTb
            // 
            this.adresaTb.Location = new System.Drawing.Point(108, 94);
            this.adresaTb.Name = "adresaTb";
            this.adresaTb.Size = new System.Drawing.Size(390, 34);
            this.adresaTb.TabIndex = 7;
            // 
            // nazivTB
            // 
            this.nazivTB.Location = new System.Drawing.Point(108, 55);
            this.nazivTB.Name = "nazivTB";
            this.nazivTB.Size = new System.Drawing.Size(390, 34);
            this.nazivTB.TabIndex = 6;
            // 
            // sifraCB
            // 
            this.sifraCB.FormattingEnabled = true;
            this.sifraCB.Location = new System.Drawing.Point(108, 11);
            this.sifraCB.Name = "sifraCB";
            this.sifraCB.Size = new System.Drawing.Size(390, 37);
            this.sifraCB.TabIndex = 5;
            this.sifraCB.SelectedIndexChanged += new System.EventHandler(this.sifraCB_SelectedIndexChanged);
            this.sifraCB.TextUpdate += new System.EventHandler(this.sifraCB_TextUpdate);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Grad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Šifra:";
            // 
            // listaTerena
            // 
            this.listaTerena.FormattingEnabled = true;
            this.listaTerena.ItemHeight = 29;
            this.listaTerena.Location = new System.Drawing.Point(12, 277);
            this.listaTerena.Name = "listaTerena";
            this.listaTerena.Size = new System.Drawing.Size(945, 149);
            this.listaTerena.TabIndex = 2;
            this.listaTerena.SelectedIndexChanged += new System.EventHandler(this.listaTerena_SelectedIndexChanged);
            // 
            // headerLB
            // 
            this.headerLB.BackColor = System.Drawing.SystemColors.Control;
            this.headerLB.Location = new System.Drawing.Point(12, 245);
            this.headerLB.Name = "headerLB";
            this.headerLB.Size = new System.Drawing.Size(945, 29);
            this.headerLB.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(970, 548);
            this.Controls.Add(this.headerLB);
            this.Controls.Add(this.listaTerena);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Evidencija golf terena";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listaTerena;
        private System.Windows.Forms.Label headerLB;
        private System.Windows.Forms.TextBox telefonTB;
        private System.Windows.Forms.ComboBox gradCB;
        private System.Windows.Forms.TextBox adresaTb;
        private System.Windows.Forms.TextBox nazivTB;
        private System.Windows.Forms.ComboBox sifraCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

