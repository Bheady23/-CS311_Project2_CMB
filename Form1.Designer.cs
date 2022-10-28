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
            this.lblDice1.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDice1.Location = new System.Drawing.Point(201, 138);
            this.lblDice1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDice1.Name = "lblDice1";
            this.lblDice1.Size = new System.Drawing.Size(0, 85);
            this.lblDice1.TabIndex = 0;
            // 
            // lblDice2
            // 
            this.lblDice2.AutoSize = true;
            this.lblDice2.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDice2.Location = new System.Drawing.Point(366, 138);
            this.lblDice2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDice2.Name = "lblDice2";
            this.lblDice2.Size = new System.Drawing.Size(0, 85);
            this.lblDice2.TabIndex = 1;
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Location = new System.Drawing.Point(920, 105);
            this.lblBank.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(0, 29);
            this.lblBank.TabIndex = 2;
            // 
            // txtBet
            // 
            this.txtBet.Location = new System.Drawing.Point(769, 178);
            this.txtBet.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtBet.Name = "txtBet";
            this.txtBet.PlaceholderText = "Enter Your Bet";
            this.txtBet.Size = new System.Drawing.Size(267, 36);
            this.txtBet.TabIndex = 3;
            this.txtBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBet1
            // 
            this.lblBet1.AutoSize = true;
            this.lblBet1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBet1.Location = new System.Drawing.Point(769, 105);
            this.lblBet1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBet1.Name = "lblBet1";
            this.lblBet1.Size = new System.Drawing.Size(82, 29);
            this.lblBet1.TabIndex = 4;
            this.lblBet1.Text = "Bank";
            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRoll.Location = new System.Drawing.Point(769, 270);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(267, 187);
            this.btnRoll.TabIndex = 5;
            this.btnRoll.Text = "ROLL!";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lblWinLosePoint
            // 
            this.lblWinLosePoint.AutoSize = true;
            this.lblWinLosePoint.Font = new System.Drawing.Font("Stencil", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWinLosePoint.Location = new System.Drawing.Point(201, 339);
            this.lblWinLosePoint.Name = "lblWinLosePoint";
            this.lblWinLosePoint.Size = new System.Drawing.Size(0, 52);
            this.lblWinLosePoint.TabIndex = 6;
            this.lblWinLosePoint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmCraps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 522);
            this.Controls.Add(this.lblWinLosePoint);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.lblBet1);
            this.Controls.Add(this.txtBet);
            this.Controls.Add(this.lblBank);
            this.Controls.Add(this.lblDice2);
            this.Controls.Add(this.lblDice1);
            this.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
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