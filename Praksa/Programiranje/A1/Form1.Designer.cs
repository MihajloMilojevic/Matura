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
            this.iznajmljivanjaTab = new System.Windows.Forms.TabPage();
            this.oAplikacijiTab = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(585, 318);
            this.tabControl1.TabIndex = 0;
            // 
            // citaociTab
            // 
            this.citaociTab.Location = new System.Drawing.Point(4, 33);
            this.citaociTab.Name = "citaociTab";
            this.citaociTab.Padding = new System.Windows.Forms.Padding(3);
            this.citaociTab.Size = new System.Drawing.Size(577, 281);
            this.citaociTab.TabIndex = 0;
            this.citaociTab.Text = "Čitaoci";
            this.citaociTab.UseVisualStyleBackColor = true;
            // 
            // iznajmljivanjaTab
            // 
            this.iznajmljivanjaTab.Location = new System.Drawing.Point(4, 33);
            this.iznajmljivanjaTab.Name = "iznajmljivanjaTab";
            this.iznajmljivanjaTab.Padding = new System.Windows.Forms.Padding(3);
            this.iznajmljivanjaTab.Size = new System.Drawing.Size(577, 281);
            this.iznajmljivanjaTab.TabIndex = 1;
            this.iznajmljivanjaTab.Text = "Pregled Iznamljivanja";
            this.iznajmljivanjaTab.UseVisualStyleBackColor = true;
            // 
            // oAplikacijiTab
            // 
            this.oAplikacijiTab.Controls.Add(this.textBox1);
            this.oAplikacijiTab.Location = new System.Drawing.Point(4, 33);
            this.oAplikacijiTab.Name = "oAplikacijiTab";
            this.oAplikacijiTab.Size = new System.Drawing.Size(577, 281);
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
            this.textBox1.Size = new System.Drawing.Size(577, 281);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 318);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Biblioteka";
            this.tabControl1.ResumeLayout(false);
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
    }
}

