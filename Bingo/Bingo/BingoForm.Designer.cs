namespace Bingo
{
    partial class frmBingo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBingo));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblReady = new System.Windows.Forms.Label();
            this.btnLetsGo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblRules = new System.Windows.Forms.Label();
            this.txtCalledNumbers = new System.Windows.Forms.TextBox();
            this.btnDontHave = new System.Windows.Forms.Button();
            this.lblCard = new System.Windows.Forms.Label();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblWelcome.Location = new System.Drawing.Point(136, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(282, 26);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome To The Game Of BINGO";
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Location = new System.Drawing.Point(86, 46);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(87, 13);
            this.lblEnterName.TabIndex = 1;
            this.lblEnterName.Text = "Enter your name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(218, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(284, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblReady
            // 
            this.lblReady.AutoSize = true;
            this.lblReady.Location = new System.Drawing.Point(62, 79);
            this.lblReady.Name = "lblReady";
            this.lblReady.Size = new System.Drawing.Size(113, 13);
            this.lblReady.TabIndex = 3;
            this.lblReady.Text = "Are you ready to Play?";
            // 
            // btnLetsGo
            // 
            this.btnLetsGo.Location = new System.Drawing.Point(218, 74);
            this.btnLetsGo.Name = "btnLetsGo";
            this.btnLetsGo.Size = new System.Drawing.Size(119, 23);
            this.btnLetsGo.TabIndex = 2;
            this.btnLetsGo.Text = "Yes! Let\'s Go!";
            this.btnLetsGo.UseVisualStyleBackColor = true;
            this.btnLetsGo.Click += new System.EventHandler(this.btnLetsGo_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(394, 74);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "No! Exit!";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.Location = new System.Drawing.Point(62, 100);
            this.lblRules.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(297, 65);
            this.lblRules.TabIndex = 6;
            this.lblRules.Text = resources.GetString("lblRules.Text");
            // 
            // txtCalledNumbers
            // 
            this.txtCalledNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalledNumbers.Location = new System.Drawing.Point(394, 103);
            this.txtCalledNumbers.Multiline = true;
            this.txtCalledNumbers.Name = "txtCalledNumbers";
            this.txtCalledNumbers.ReadOnly = true;
            this.txtCalledNumbers.Size = new System.Drawing.Size(108, 52);
            this.txtCalledNumbers.TabIndex = 7;
            this.txtCalledNumbers.TabStop = false;
            this.txtCalledNumbers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDontHave
            // 
            this.btnDontHave.Location = new System.Drawing.Point(412, 161);
            this.btnDontHave.Name = "btnDontHave";
            this.btnDontHave.Size = new System.Drawing.Size(75, 26);
            this.btnDontHave.TabIndex = 4;
            this.btnDontHave.Text = "Don\'t Have";
            this.btnDontHave.UseVisualStyleBackColor = true;
            this.btnDontHave.Click += new System.EventHandler(this.btnDontHave_Click);
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCard.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblCard.Location = new System.Drawing.Point(234, 170);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(112, 20);
            this.lblCard.TabIndex = 9;
            this.lblCard.Text = "Your Bingo Card";
            // 
            // pnlCard
            // 
            this.pnlCard.Location = new System.Drawing.Point(12, 193);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(560, 532);
            this.pnlCard.TabIndex = 11;
            // 
            // frmBingo
            // 
            this.AcceptButton = this.btnLetsGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 737);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.lblCard);
            this.Controls.Add(this.btnDontHave);
            this.Controls.Add(this.txtCalledNumbers);
            this.Controls.Add(this.lblRules);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLetsGo);
            this.Controls.Add(this.lblReady);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblEnterName);
            this.Controls.Add(this.lblWelcome);
            this.Name = "frmBingo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bingo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblReady;
        private System.Windows.Forms.Button btnLetsGo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.TextBox txtCalledNumbers;
        private System.Windows.Forms.Button btnDontHave;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.Panel pnlCard;
    }
}

