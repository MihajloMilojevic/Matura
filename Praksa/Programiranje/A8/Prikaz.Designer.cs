namespace A8
{
    partial class Prikaz
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
            this.sifraLB = new System.Windows.Forms.Label();
            this.imeTB = new System.Windows.Forms.TextBox();
            this.sacuvajBTN = new System.Windows.Forms.Button();
            this.nazadBTN = new System.Windows.Forms.Button();
            this.napredBTN = new System.Windows.Forms.Button();
            this.slikaPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.slikaPB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Šifra: ";
            // 
            // sifraLB
            // 
            this.sifraLB.Location = new System.Drawing.Point(106, 27);
            this.sifraLB.Name = "sifraLB";
            this.sifraLB.Size = new System.Drawing.Size(101, 28);
            this.sifraLB.TabIndex = 1;
            this.sifraLB.Text = "0";
            // 
            // imeTB
            // 
            this.imeTB.Location = new System.Drawing.Point(37, 67);
            this.imeTB.Name = "imeTB";
            this.imeTB.Size = new System.Drawing.Size(170, 29);
            this.imeTB.TabIndex = 2;
            // 
            // sacuvajBTN
            // 
            this.sacuvajBTN.Location = new System.Drawing.Point(37, 117);
            this.sacuvajBTN.Name = "sacuvajBTN";
            this.sacuvajBTN.Size = new System.Drawing.Size(170, 37);
            this.sacuvajBTN.TabIndex = 3;
            this.sacuvajBTN.Text = "Upamti izmene";
            this.sacuvajBTN.UseVisualStyleBackColor = true;
            this.sacuvajBTN.Click += new System.EventHandler(this.sacuvajBTN_Click);
            // 
            // nazadBTN
            // 
            this.nazadBTN.Location = new System.Drawing.Point(37, 176);
            this.nazadBTN.Name = "nazadBTN";
            this.nazadBTN.Size = new System.Drawing.Size(82, 45);
            this.nazadBTN.TabIndex = 4;
            this.nazadBTN.Text = "Nazad";
            this.nazadBTN.UseVisualStyleBackColor = true;
            this.nazadBTN.Click += new System.EventHandler(this.nazadBTN_Click);
            // 
            // napredBTN
            // 
            this.napredBTN.Location = new System.Drawing.Point(125, 176);
            this.napredBTN.Name = "napredBTN";
            this.napredBTN.Size = new System.Drawing.Size(82, 45);
            this.napredBTN.TabIndex = 5;
            this.napredBTN.Text = "Napred";
            this.napredBTN.UseVisualStyleBackColor = true;
            this.napredBTN.Click += new System.EventHandler(this.napredBTN_Click);
            // 
            // slikaPB
            // 
            this.slikaPB.Location = new System.Drawing.Point(252, 27);
            this.slikaPB.Name = "slikaPB";
            this.slikaPB.Size = new System.Drawing.Size(265, 194);
            this.slikaPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.slikaPB.TabIndex = 6;
            this.slikaPB.TabStop = false;
            this.slikaPB.Click += new System.EventHandler(this.slikaPB_Click);
            // 
            // Prikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 247);
            this.Controls.Add(this.slikaPB);
            this.Controls.Add(this.napredBTN);
            this.Controls.Add(this.nazadBTN);
            this.Controls.Add(this.sacuvajBTN);
            this.Controls.Add(this.imeTB);
            this.Controls.Add(this.sifraLB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Prikaz";
            this.Text = "Prikaz";
            this.Load += new System.EventHandler(this.Prikaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slikaPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sifraLB;
        private System.Windows.Forms.TextBox imeTB;
        private System.Windows.Forms.Button sacuvajBTN;
        private System.Windows.Forms.Button nazadBTN;
        private System.Windows.Forms.Button napredBTN;
        private System.Windows.Forms.PictureBox slikaPB;
    }
}