namespace Harjoitustyö
{
    partial class TilastoFormi
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
            this.lbPelaajat = new System.Windows.Forms.ListBox();
            this.lblTilasto = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPoistu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPelaajat
            // 
            this.lbPelaajat.FormattingEnabled = true;
            this.lbPelaajat.ItemHeight = 20;
            this.lbPelaajat.Location = new System.Drawing.Point(65, 105);
            this.lbPelaajat.Name = "lbPelaajat";
            this.lbPelaajat.Size = new System.Drawing.Size(630, 264);
            this.lbPelaajat.TabIndex = 0;
            // 
            // lblTilasto
            // 
            this.lblTilasto.AutoSize = true;
            this.lblTilasto.Location = new System.Drawing.Point(65, 60);
            this.lblTilasto.Name = "lblTilasto";
            this.lblTilasto.Size = new System.Drawing.Size(64, 20);
            this.lblTilasto.TabIndex = 1;
            this.lblTilasto.Text = "Tilastot:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnPoistu
            // 
            this.btnPoistu.Location = new System.Drawing.Point(693, 393);
            this.btnPoistu.Name = "btnPoistu";
            this.btnPoistu.Size = new System.Drawing.Size(95, 45);
            this.btnPoistu.TabIndex = 3;
            this.btnPoistu.Text = "Poistu";
            this.btnPoistu.UseVisualStyleBackColor = true;
            this.btnPoistu.Click += new System.EventHandler(this.btnPoistu_Click);
            // 
            // TilastoFormi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPoistu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTilasto);
            this.Controls.Add(this.lbPelaajat);
            this.Name = "TilastoFormi";
            this.Text = "Pelaajien tilastot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPelaajat;
        private System.Windows.Forms.Label lblTilasto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPoistu;
    }
}