namespace Harjoitustyö
{
    partial class TietojenTalletusForm
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
            this.btnKirjoita = new System.Windows.Forms.Button();
            this.tbPelaaja2 = new System.Windows.Forms.TextBox();
            this.lblPelaaja2 = new System.Windows.Forms.Label();
            this.tbPelaaja1 = new System.Windows.Forms.TextBox();
            this.lblPelaaja1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPoistu = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgPelaajat = new System.Windows.Forms.DataGridView();
            this.btnLisaa2 = new System.Windows.Forms.Button();
            this.btnLisaa1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tilastotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.näytäTilastotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPelaajat)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKirjoita
            // 
            this.btnKirjoita.Location = new System.Drawing.Point(622, 546);
            this.btnKirjoita.Name = "btnKirjoita";
            this.btnKirjoita.Size = new System.Drawing.Size(105, 56);
            this.btnKirjoita.TabIndex = 7;
            this.btnKirjoita.Text = "Tallenna tiedot";
            this.btnKirjoita.UseVisualStyleBackColor = true;
            this.btnKirjoita.Click += new System.EventHandler(this.btnKirjoita_Click);
            // 
            // tbPelaaja2
            // 
            this.tbPelaaja2.Location = new System.Drawing.Point(104, 173);
            this.tbPelaaja2.Name = "tbPelaaja2";
            this.tbPelaaja2.Size = new System.Drawing.Size(135, 26);
            this.tbPelaaja2.TabIndex = 11;
            this.tbPelaaja2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPelaaja2_KeyPress);
            // 
            // lblPelaaja2
            // 
            this.lblPelaaja2.AutoSize = true;
            this.lblPelaaja2.Location = new System.Drawing.Point(15, 179);
            this.lblPelaaja2.Name = "lblPelaaja2";
            this.lblPelaaja2.Size = new System.Drawing.Size(74, 20);
            this.lblPelaaja2.TabIndex = 1;
            this.lblPelaaja2.Text = "Pelaaja 2";
            // 
            // tbPelaaja1
            // 
            this.tbPelaaja1.Location = new System.Drawing.Point(104, 46);
            this.tbPelaaja1.Name = "tbPelaaja1";
            this.tbPelaaja1.Size = new System.Drawing.Size(135, 26);
            this.tbPelaaja1.TabIndex = 10;
            this.tbPelaaja1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPelaaja1_KeyPress);
            // 
            // lblPelaaja1
            // 
            this.lblPelaaja1.AutoSize = true;
            this.lblPelaaja1.Location = new System.Drawing.Point(15, 49);
            this.lblPelaaja1.Name = "lblPelaaja1";
            this.lblPelaaja1.Size = new System.Drawing.Size(74, 20);
            this.lblPelaaja1.TabIndex = 0;
            this.lblPelaaja1.Text = "Pelaaja 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPoistu);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnKirjoita);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dgPelaajat);
            this.groupBox2.Controls.Add(this.btnLisaa2);
            this.groupBox2.Controls.Add(this.btnLisaa1);
            this.groupBox2.Controls.Add(this.lblPelaaja1);
            this.groupBox2.Controls.Add(this.tbPelaaja1);
            this.groupBox2.Controls.Add(this.lblPelaaja2);
            this.groupBox2.Controls.Add(this.tbPelaaja2);
            this.groupBox2.Location = new System.Drawing.Point(12, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 625);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Syötä pelaajien tiedot:";
            // 
            // btnPoistu
            // 
            this.btnPoistu.Location = new System.Drawing.Point(19, 546);
            this.btnPoistu.Name = "btnPoistu";
            this.btnPoistu.Size = new System.Drawing.Size(105, 56);
            this.btnPoistu.TabIndex = 23;
            this.btnPoistu.Text = "Poistu";
            this.btnPoistu.UseVisualStyleBackColor = true;
            this.btnPoistu.Click += new System.EventHandler(this.btnPoistu_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(544, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(544, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(544, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(544, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // dgPelaajat
            // 
            this.dgPelaajat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPelaajat.Location = new System.Drawing.Point(19, 282);
            this.dgPelaajat.Name = "dgPelaajat";
            this.dgPelaajat.RowHeadersWidth = 62;
            this.dgPelaajat.RowTemplate.Height = 28;
            this.dgPelaajat.Size = new System.Drawing.Size(708, 243);
            this.dgPelaajat.TabIndex = 14;
            // 
            // btnLisaa2
            // 
            this.btnLisaa2.Location = new System.Drawing.Point(245, 165);
            this.btnLisaa2.Name = "btnLisaa2";
            this.btnLisaa2.Size = new System.Drawing.Size(91, 34);
            this.btnLisaa2.TabIndex = 13;
            this.btnLisaa2.Text = "Lisää";
            this.btnLisaa2.UseVisualStyleBackColor = true;
            this.btnLisaa2.Click += new System.EventHandler(this.btnLisaa2_Click);
            // 
            // btnLisaa1
            // 
            this.btnLisaa1.Location = new System.Drawing.Point(245, 42);
            this.btnLisaa1.Name = "btnLisaa1";
            this.btnLisaa1.Size = new System.Drawing.Size(91, 35);
            this.btnLisaa1.TabIndex = 12;
            this.btnLisaa1.Text = "Lisää";
            this.btnLisaa1.UseVisualStyleBackColor = true;
            this.btnLisaa1.Click += new System.EventHandler(this.btnLisaa1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tilastotToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 33);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tilastotToolStripMenuItem
            // 
            this.tilastotToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.näytäTilastotToolStripMenuItem});
            this.tilastotToolStripMenuItem.Name = "tilastotToolStripMenuItem";
            this.tilastotToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.tilastotToolStripMenuItem.Text = "Tilastot";
            // 
            // näytäTilastotToolStripMenuItem
            // 
            this.näytäTilastotToolStripMenuItem.Name = "näytäTilastotToolStripMenuItem";
            this.näytäTilastotToolStripMenuItem.Size = new System.Drawing.Size(219, 34);
            this.näytäTilastotToolStripMenuItem.Text = "Näytä tilastot";
            this.näytäTilastotToolStripMenuItem.Click += new System.EventHandler(this.näytäTilastotToolStripMenuItem_Click);
            // 
            // TietojenTalletusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 667);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TietojenTalletusForm";
            this.Text = "Tietojen tallentaminen";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPelaajat)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKirjoita;
        private System.Windows.Forms.TextBox tbPelaaja2;
        private System.Windows.Forms.Label lblPelaaja2;
        private System.Windows.Forms.TextBox tbPelaaja1;
        private System.Windows.Forms.Label lblPelaaja1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgPelaajat;
        private System.Windows.Forms.Button btnLisaa2;
        private System.Windows.Forms.Button btnLisaa1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tilastotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem näytäTilastotToolStripMenuItem;
        private System.Windows.Forms.Button btnPoistu;
    }
}