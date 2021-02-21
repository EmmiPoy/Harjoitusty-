namespace Harjoitustyö
{
    partial class Yksin12Form
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tlsPelaaja3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerHelppo2 = new System.Windows.Forms.Timer(this.components);
            this.tblHelppo2 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.btnUudestaan = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.tblHelppo2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsPelaaja3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 601);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(639, 32);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tlsPelaaja3
            // 
            this.tlsPelaaja3.Name = "tlsPelaaja3";
            this.tlsPelaaja3.Size = new System.Drawing.Size(141, 25);
            this.tlsPelaaja3.Text = "Löydetyt parit: 0";
            // 
            // timerHelppo2
            // 
            this.timerHelppo2.Interval = 800;
            this.timerHelppo2.Tick += new System.EventHandler(this.timerHelppo_Tick);
            // 
            // tblHelppo2
            // 
            this.tblHelppo2.BackColor = System.Drawing.Color.MistyRose;
            this.tblHelppo2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tblHelppo2.ColumnCount = 3;
            this.tblHelppo2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblHelppo2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblHelppo2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblHelppo2.Controls.Add(this.label12, 2, 3);
            this.tblHelppo2.Controls.Add(this.label11, 1, 3);
            this.tblHelppo2.Controls.Add(this.label10, 0, 3);
            this.tblHelppo2.Controls.Add(this.label9, 2, 2);
            this.tblHelppo2.Controls.Add(this.label8, 1, 2);
            this.tblHelppo2.Controls.Add(this.label7, 0, 2);
            this.tblHelppo2.Controls.Add(this.label6, 2, 1);
            this.tblHelppo2.Controls.Add(this.label5, 1, 1);
            this.tblHelppo2.Controls.Add(this.label4, 0, 1);
            this.tblHelppo2.Controls.Add(this.label3, 2, 0);
            this.tblHelppo2.Controls.Add(this.label2, 1, 0);
            this.tblHelppo2.Controls.Add(this.label1, 0, 0);
            this.tblHelppo2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblHelppo2.Location = new System.Drawing.Point(0, 0);
            this.tblHelppo2.Name = "tblHelppo2";
            this.tblHelppo2.RowCount = 4;
            this.tblHelppo2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblHelppo2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblHelppo2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblHelppo2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblHelppo2.Size = new System.Drawing.Size(639, 601);
            this.tblHelppo2.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label12.Location = new System.Drawing.Point(429, 449);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(205, 150);
            this.label12.TabIndex = 11;
            this.label12.Text = "s";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.lblHelppo_Click);
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label11.Location = new System.Drawing.Point(217, 449);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(204, 150);
            this.label11.TabIndex = 10;
            this.label11.Text = "s";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.lblHelppo_Click);
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label10.Location = new System.Drawing.Point(5, 449);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(204, 150);
            this.label10.TabIndex = 9;
            this.label10.Text = "s";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.lblHelppo_Click);
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label9.Location = new System.Drawing.Point(429, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 147);
            this.label9.TabIndex = 8;
            this.label9.Text = "s";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.lblHelppo_Click);
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label8.Location = new System.Drawing.Point(217, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 147);
            this.label8.TabIndex = 7;
            this.label8.Text = "s";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.lblHelppo_Click);
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label7.Location = new System.Drawing.Point(5, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 147);
            this.label7.TabIndex = 6;
            this.label7.Text = "s";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.lblHelppo_Click);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label6.Location = new System.Drawing.Point(429, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 147);
            this.label6.TabIndex = 5;
            this.label6.Text = "s";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.lblHelppo_Click);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label5.Location = new System.Drawing.Point(217, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 147);
            this.label5.TabIndex = 4;
            this.label5.Text = "s";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.lblHelppo_Click);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label4.Location = new System.Drawing.Point(5, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 147);
            this.label4.TabIndex = 3;
            this.label4.Text = "s";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.lblHelppo_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.Location = new System.Drawing.Point(429, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 147);
            this.label3.TabIndex = 2;
            this.label3.Text = "s";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.lblHelppo_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.Location = new System.Drawing.Point(217, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 147);
            this.label2.TabIndex = 1;
            this.label2.Text = "s";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.lblHelppo_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 147);
            this.label1.TabIndex = 0;
            this.label1.Text = "s";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.lblHelppo_Click);
            // 
            // btnTallenna
            // 
            this.btnTallenna.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTallenna.Location = new System.Drawing.Point(509, 601);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(106, 32);
            this.btnTallenna.TabIndex = 2;
            this.btnTallenna.Text = "Tallenna tiedot";
            this.btnTallenna.UseVisualStyleBackColor = true;
            this.btnTallenna.Click += new System.EventHandler(this.btnTallenna_Click);
            // 
            // btnUudestaan
            // 
            this.btnUudestaan.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUudestaan.Location = new System.Drawing.Point(402, 601);
            this.btnUudestaan.Name = "btnUudestaan";
            this.btnUudestaan.Size = new System.Drawing.Size(101, 32);
            this.btnUudestaan.TabIndex = 3;
            this.btnUudestaan.Text = "Uudestaan!";
            this.btnUudestaan.UseVisualStyleBackColor = true;
            this.btnUudestaan.Click += new System.EventHandler(this.btnUudestaan_Click);
            // 
            // Yksin12Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 633);
            this.Controls.Add(this.btnUudestaan);
            this.Controls.Add(this.btnTallenna);
            this.Controls.Add(this.tblHelppo2);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Yksin12Form";
            this.Text = "Yksinpeli - 12 korttia";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tblHelppo2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tlsPelaaja3;
        private System.Windows.Forms.Timer timerHelppo2;
        private System.Windows.Forms.TableLayoutPanel tblHelppo2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTallenna;
        private System.Windows.Forms.Button btnUudestaan;
    }
}