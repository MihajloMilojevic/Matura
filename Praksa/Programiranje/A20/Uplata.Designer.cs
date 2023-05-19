namespace A20
{
    partial class Uplata
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.destinacijaCb = new System.Windows.Forms.ComboBox();
            this.aranzmanCb = new System.Windows.Forms.ComboBox();
            this.datumi = new System.Windows.Forms.MonthCalendar();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uplatiBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dugLB = new System.Windows.Forms.Label();
            this.ukupnaCenaLB = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Destinacija:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aranžman: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 65);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trajanje aranžmana:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // destinacijaCb
            // 
            this.destinacijaCb.FormattingEnabled = true;
            this.destinacijaCb.Location = new System.Drawing.Point(125, 24);
            this.destinacijaCb.Name = "destinacijaCb";
            this.destinacijaCb.Size = new System.Drawing.Size(227, 37);
            this.destinacijaCb.TabIndex = 3;
            this.destinacijaCb.SelectedIndexChanged += new System.EventHandler(this.destinacijaCb_SelectedIndexChanged);
            // 
            // aranzmanCb
            // 
            this.aranzmanCb.FormattingEnabled = true;
            this.aranzmanCb.Location = new System.Drawing.Point(125, 61);
            this.aranzmanCb.Name = "aranzmanCb";
            this.aranzmanCb.Size = new System.Drawing.Size(227, 37);
            this.aranzmanCb.TabIndex = 4;
            this.aranzmanCb.SelectedIndexChanged += new System.EventHandler(this.aranzmanCb_SelectedIndexChanged);
            // 
            // datumi
            // 
            this.datumi.Location = new System.Drawing.Point(125, 109);
            this.datumi.MaxSelectionCount = 100000;
            this.datumi.Name = "datumi";
            this.datumi.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(385, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(362, 165);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.uplatiBtn);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.dugLB);
            this.panel1.Controls.Add(this.ukupnaCenaLB);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(385, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 191);
            this.panel1.TabIndex = 7;
            // 
            // uplatiBtn
            // 
            this.uplatiBtn.Location = new System.Drawing.Point(17, 140);
            this.uplatiBtn.Name = "uplatiBtn";
            this.uplatiBtn.Size = new System.Drawing.Size(333, 37);
            this.uplatiBtn.TabIndex = 14;
            this.uplatiBtn.Text = "Uplati";
            this.uplatiBtn.UseVisualStyleBackColor = true;
            this.uplatiBtn.Click += new System.EventHandler(this.uplatiBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 34);
            this.textBox1.TabIndex = 13;
            // 
            // dugLB
            // 
            this.dugLB.AutoSize = true;
            this.dugLB.ForeColor = System.Drawing.Color.White;
            this.dugLB.Location = new System.Drawing.Point(189, 61);
            this.dugLB.Name = "dugLB";
            this.dugLB.Size = new System.Drawing.Size(26, 29);
            this.dugLB.TabIndex = 12;
            this.dugLB.Text = "0";
            this.dugLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ukupnaCenaLB
            // 
            this.ukupnaCenaLB.AutoSize = true;
            this.ukupnaCenaLB.ForeColor = System.Drawing.Color.White;
            this.ukupnaCenaLB.Location = new System.Drawing.Point(189, 18);
            this.ukupnaCenaLB.Name = "ukupnaCenaLB";
            this.ukupnaCenaLB.Size = new System.Drawing.Size(26, 29);
            this.ukupnaCenaLB.TabIndex = 11;
            this.ukupnaCenaLB.Text = "0";
            this.ukupnaCenaLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Iznos za uplatu:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(45, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Iznos duga:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ukupna cena:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Uplata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(759, 389);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.datumi);
            this.Controls.Add(this.aranzmanCb);
            this.Controls.Add(this.destinacijaCb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Uplata";
            this.Text = "Uplata";
            this.Load += new System.EventHandler(this.Uplata_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox destinacijaCb;
        private System.Windows.Forms.ComboBox aranzmanCb;
        private System.Windows.Forms.MonthCalendar datumi;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button uplatiBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label dugLB;
        private System.Windows.Forms.Label ukupnaCenaLB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}