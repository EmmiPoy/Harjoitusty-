namespace Harjoitustyö
{
    partial class AloitusForm
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
            this.rdBtnYksin = new System.Windows.Forms.RadioButton();
            this.rdBtnKaksin = new System.Windows.Forms.RadioButton();
            this.btn12Kaksin = new System.Windows.Forms.Button();
            this.btn20Kaksin = new System.Windows.Forms.Button();
            this.btn36Kaksin = new System.Windows.Forms.Button();
            this.menuStr = new System.Windows.Forms.MenuStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn12Yksin = new System.Windows.Forms.Button();
            this.btn20Yksin = new System.Windows.Forms.Button();
            this.btn36Yksin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdBtnYksin
            // 
            this.rdBtnYksin.AutoSize = true;
            this.rdBtnYksin.Location = new System.Drawing.Point(30, 73);
            this.rdBtnYksin.Name = "rdBtnYksin";
            this.rdBtnYksin.Size = new System.Drawing.Size(97, 24);
            this.rdBtnYksin.TabIndex = 2;
            this.rdBtnYksin.TabStop = true;
            this.rdBtnYksin.Text = "Yksinpeli";
            this.rdBtnYksin.UseVisualStyleBackColor = true;
            this.rdBtnYksin.CheckedChanged += new System.EventHandler(this.rdBtnYksin_CheckedChanged);
            // 
            // rdBtnKaksin
            // 
            this.rdBtnKaksin.AutoSize = true;
            this.rdBtnKaksin.Location = new System.Drawing.Point(30, 127);
            this.rdBtnKaksin.Name = "rdBtnKaksin";
            this.rdBtnKaksin.Size = new System.Drawing.Size(105, 24);
            this.rdBtnKaksin.TabIndex = 3;
            this.rdBtnKaksin.TabStop = true;
            this.rdBtnKaksin.Text = "Kaksinpeli";
            this.rdBtnKaksin.UseVisualStyleBackColor = true;
            this.rdBtnKaksin.CheckedChanged += new System.EventHandler(this.rdBtnKaksin_CheckedChanged);
            // 
            // btn12Kaksin
            // 
            this.btn12Kaksin.Location = new System.Drawing.Point(66, 57);
            this.btn12Kaksin.Name = "btn12Kaksin";
            this.btn12Kaksin.Size = new System.Drawing.Size(131, 41);
            this.btn12Kaksin.TabIndex = 4;
            this.btn12Kaksin.Text = "12 korttia";
            this.btn12Kaksin.UseVisualStyleBackColor = true;
            this.btn12Kaksin.Click += new System.EventHandler(this.btn12Kaksin_Click);
            // 
            // btn20Kaksin
            // 
            this.btn20Kaksin.Location = new System.Drawing.Point(66, 119);
            this.btn20Kaksin.Name = "btn20Kaksin";
            this.btn20Kaksin.Size = new System.Drawing.Size(131, 43);
            this.btn20Kaksin.TabIndex = 5;
            this.btn20Kaksin.Text = "20 korttia";
            this.btn20Kaksin.UseVisualStyleBackColor = true;
            this.btn20Kaksin.Click += new System.EventHandler(this.btn20Kaksin_Click);
            // 
            // btn36Kaksin
            // 
            this.btn36Kaksin.Location = new System.Drawing.Point(66, 184);
            this.btn36Kaksin.Name = "btn36Kaksin";
            this.btn36Kaksin.Size = new System.Drawing.Size(131, 42);
            this.btn36Kaksin.TabIndex = 6;
            this.btn36Kaksin.Text = "36 korttia";
            this.btn36Kaksin.UseVisualStyleBackColor = true;
            this.btn36Kaksin.Click += new System.EventHandler(this.btn36Kaksin_Click);
            // 
            // menuStr
            // 
            this.menuStr.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStr.Location = new System.Drawing.Point(0, 0);
            this.menuStr.Name = "menuStr";
            this.menuStr.Size = new System.Drawing.Size(652, 24);
            this.menuStr.TabIndex = 9;
            this.menuStr.Text = "menuStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBtnKaksin);
            this.groupBox1.Controls.Add(this.rdBtnYksin);
            this.groupBox1.Location = new System.Drawing.Point(25, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 239);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valitse yksin-tai kaksinpeli:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn12Kaksin);
            this.groupBox3.Controls.Add(this.btn20Kaksin);
            this.groupBox3.Controls.Add(this.btn36Kaksin);
            this.groupBox3.Location = new System.Drawing.Point(306, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 240);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Valitse korttien määrä:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(480, 308);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 43);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Poistu";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn12Yksin);
            this.groupBox2.Controls.Add(this.btn20Yksin);
            this.groupBox2.Controls.Add(this.btn36Yksin);
            this.groupBox2.Location = new System.Drawing.Point(306, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 240);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valitse korttien määrä:";
            // 
            // btn12Yksin
            // 
            this.btn12Yksin.Location = new System.Drawing.Point(66, 57);
            this.btn12Yksin.Name = "btn12Yksin";
            this.btn12Yksin.Size = new System.Drawing.Size(131, 41);
            this.btn12Yksin.TabIndex = 4;
            this.btn12Yksin.Text = "12 korttia";
            this.btn12Yksin.UseVisualStyleBackColor = true;
            this.btn12Yksin.Click += new System.EventHandler(this.btn12Yksin_Click);
            // 
            // btn20Yksin
            // 
            this.btn20Yksin.Location = new System.Drawing.Point(66, 119);
            this.btn20Yksin.Name = "btn20Yksin";
            this.btn20Yksin.Size = new System.Drawing.Size(131, 43);
            this.btn20Yksin.TabIndex = 5;
            this.btn20Yksin.Text = "20 korttia";
            this.btn20Yksin.UseVisualStyleBackColor = true;
            this.btn20Yksin.Click += new System.EventHandler(this.btn20Yksin_Click);
            // 
            // btn36Yksin
            // 
            this.btn36Yksin.Location = new System.Drawing.Point(66, 184);
            this.btn36Yksin.Name = "btn36Yksin";
            this.btn36Yksin.Size = new System.Drawing.Size(131, 42);
            this.btn36Yksin.TabIndex = 6;
            this.btn36Yksin.Text = "36 korttia";
            this.btn36Yksin.UseVisualStyleBackColor = true;
            this.btn36Yksin.Click += new System.EventHandler(this.btn36Yksin_Click);
            // 
            // AloitusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 388);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStr);
            this.MainMenuStrip = this.menuStr;
            this.Name = "AloitusForm";
            this.Text = "Muistipeli";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdBtnYksin;
        private System.Windows.Forms.RadioButton rdBtnKaksin;
        private System.Windows.Forms.Button btn12Kaksin;
        private System.Windows.Forms.Button btn20Kaksin;
        private System.Windows.Forms.Button btn36Kaksin;
        private System.Windows.Forms.MenuStrip menuStr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn12Yksin;
        private System.Windows.Forms.Button btn20Yksin;
        private System.Windows.Forms.Button btn36Yksin;
    }
}

