namespace A13
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
            this.izmeniMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.analizaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAplikacijiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sifraTB = new System.Windows.Forms.TextBox();
            this.imeTB = new System.Windows.Forms.TextBox();
            this.mailTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // izmeniMenuItem
            // 
            this.izmeniMenuItem.Image = global::A13.Properties.Resources.izmeni;
            this.izmeniMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.izmeniMenuItem.Name = "izmeniMenuItem";
            this.izmeniMenuItem.Size = new System.Drawing.Size(115, 93);
            this.izmeniMenuItem.Text = "Izmeni";
            this.izmeniMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.izmeniMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.izmeniMenuItem.Click += new System.EventHandler(this.izmeniMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izmeniMenuItem,
            this.analizaMenuItem,
            this.oAplikacijiMenuItem,
            this.izlazMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(124, 439);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // analizaMenuItem
            // 
            this.analizaMenuItem.Image = global::A13.Properties.Resources.analiza;
            this.analizaMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.analizaMenuItem.Name = "analizaMenuItem";
            this.analizaMenuItem.Size = new System.Drawing.Size(82, 84);
            this.analizaMenuItem.Text = "Analiza";
            this.analizaMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.analizaMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // oAplikacijiMenuItem
            // 
            this.oAplikacijiMenuItem.Image = global::A13.Properties.Resources.o_aplikaciji;
            this.oAplikacijiMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.oAplikacijiMenuItem.Name = "oAplikacijiMenuItem";
            this.oAplikacijiMenuItem.Size = new System.Drawing.Size(82, 94);
            this.oAplikacijiMenuItem.Text = "O Aplikaciji";
            this.oAplikacijiMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.oAplikacijiMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // izlazMenuItem
            // 
            this.izlazMenuItem.Image = global::A13.Properties.Resources.exit;
            this.izlazMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.izlazMenuItem.Name = "izlazMenuItem";
            this.izlazMenuItem.Size = new System.Drawing.Size(115, 94);
            this.izlazMenuItem.Text = "Izlaz";
            this.izlazMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.izlazMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.izlazMenuItem.Click += new System.EventHandler(this.izlazMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(113, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Šifra: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(113, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ime: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(113, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "E-mail:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sifraTB
            // 
            this.sifraTB.Location = new System.Drawing.Point(173, 26);
            this.sifraTB.Name = "sifraTB";
            this.sifraTB.ReadOnly = true;
            this.sifraTB.Size = new System.Drawing.Size(373, 26);
            this.sifraTB.TabIndex = 4;
            // 
            // imeTB
            // 
            this.imeTB.Location = new System.Drawing.Point(173, 62);
            this.imeTB.Name = "imeTB";
            this.imeTB.Size = new System.Drawing.Size(373, 26);
            this.imeTB.TabIndex = 5;
            // 
            // mailTB
            // 
            this.mailTB.Location = new System.Drawing.Point(173, 105);
            this.mailTB.Name = "mailTB";
            this.mailTB.Size = new System.Drawing.Size(373, 26);
            this.mailTB.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(113, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Šifra: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 20;
            this.lista.Location = new System.Drawing.Point(117, 204);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(552, 204);
            this.lista.TabIndex = 8;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(214, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(190, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Naziv producentske kuće";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(442, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(171, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "E-mail adresa";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(696, 439);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mailTB);
            this.Controls.Add(this.imeTB);
            this.Controls.Add(this.sifraTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Korekcija podataka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem izmeniMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem analizaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAplikacijiMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sifraTB;
        private System.Windows.Forms.TextBox imeTB;
        private System.Windows.Forms.TextBox mailTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

