namespace CS311_Project2_CMB
{
    partial class frmCraps
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDice1 = new System.Windows.Forms.Label();
            this.lblDice2 = new System.Windows.Forms.Label();
            this.lblBank = new System.Windows.Forms.Label();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.lblBet1 = new System.Windows.Forms.Label();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblWinLosePoint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDice1
            // 
            this.lblDice1.AutoSize = true;
            this.lblDice1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDice1.Location = new System.Drawing.Point(77, 90);
            this.lblDice1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDice1.Name = "lblDice1";
            this.lblDice1.Size = new System.Drawing.Size(0, 109);
            this.lblDice1.TabIndex = 0;
            // 
            // lblDice2
            // 
            this.lblDice2.AutoSize = true;
            this.lblDice2.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDice2.Location = new System.Drawing.Point(191, 90);
            this.lblDice2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDice2.Name = "lblDice2";
            this.lblDice2.Size = new System.Drawing.Size(0, 109);
            this.lblDice2.TabIndex = 1;
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBank.Location = new System.Drawing.Point(579, 30);
            this.lblBank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(0, 26);
            this.lblBank.TabIndex = 2;
            // 
            // txtBet
            // 
            this.txtBet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBet.Location = new System.Drawing.Point(347, 74);
            this.txtBet.Margin = new System.Windows.Forms.Padding(4);
            this.txtBet.Name = "txtBet";
            this.txtBet.PlaceholderText = "Enter Your Bet";
            this.txtBet.Size = new System.Drawing.Size(327, 35);
            this.txtBet.TabIndex = 3;
            this.txtBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBet1
            // 
            this.lblBet1.AutoSize = true;
            this.lblBet1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBet1.Location = new System.Drawing.Point(347, 30);
            this.lblBet1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBet1.Name = "lblBet1";
            this.lblBet1.Size = new System.Drawing.Size(66, 26);
            this.lblBet1.TabIndex = 4;
            this.lblBet1.Text = "Bank";
            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRoll.Image = global::CS311_Project2_CMB.Properties.Resources.dicepic;
            this.btnRoll.Location = new System.Drawing.Point(347, 116);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(327, 254);
            this.btnRoll.TabIndex = 5;
            this.btnRoll.Text = "  ROLL!";
            this.btnRoll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lblWinLosePoint
            // 
            this.lblWinLosePoint.AutoSize = true;
            this.lblWinLosePoint.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWinLosePoint.Location = new System.Drawing.Point(77, 260);
            this.lblWinLosePoint.Name = "lblWinLosePoint";
            this.lblWinLosePoint.Size = new System.Drawing.Size(0, 60);
            this.lblWinLosePoint.TabIndex = 6;
            this.lblWinLosePoint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmCraps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 390);
            this.Controls.Add(this.lblWinLosePoint);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.lblBet1);
            this.Controls.Add(this.txtBet);
            this.Controls.Add(this.lblBank);
            this.Controls.Add(this.lblDice2);
            this.Controls.Add(this.lblDice1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCraps";
            this.Text = "CRAPS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDice1;
        private Label lblDice2;
        private Label lblBank;
        private TextBox txtBet;
        private Label lblBet1;
        private Button btnRoll;
        private Label lblWinLosePoint;
    }
}