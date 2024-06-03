namespace Transaction
{
    partial class Transaction
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
            this.lblGreetings = new System.Windows.Forms.Label();
            this.pnlViewBal = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblavailablebalance = new System.Windows.Forms.Label();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnWithdrawmain = new System.Windows.Forms.Button();
            this.btnDepositMain = new System.Windows.Forms.Button();
            this.pnlWithdraw = new System.Windows.Forms.Panel();
            this.btnwithraw = new System.Windows.Forms.Button();
            this.lblentercahs = new System.Windows.Forms.Label();
            this.txtEnterCash = new System.Windows.Forms.TextBox();
            this.pnlViewBal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlWithdraw.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGreetings
            // 
            this.lblGreetings.AutoSize = true;
            this.lblGreetings.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreetings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGreetings.Location = new System.Drawing.Point(28, 28);
            this.lblGreetings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.Size = new System.Drawing.Size(172, 29);
            this.lblGreetings.TabIndex = 4;
            this.lblGreetings.Text = "HELLO USER!";
            // 
            // pnlViewBal
            // 
            this.pnlViewBal.BackColor = System.Drawing.Color.MintCream;
            this.pnlViewBal.Controls.Add(this.pictureBox1);
            this.pnlViewBal.Controls.Add(this.lblBalance);
            this.pnlViewBal.Controls.Add(this.lblavailablebalance);
            this.pnlViewBal.Location = new System.Drawing.Point(33, 81);
            this.pnlViewBal.Margin = new System.Windows.Forms.Padding(4);
            this.pnlViewBal.Name = "pnlViewBal";
            this.pnlViewBal.Size = new System.Drawing.Size(533, 138);
            this.pnlViewBal.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Transaction.Properties.Resources.cuba_peso_currency_symbol;
            this.pictureBox1.Location = new System.Drawing.Point(65, 52);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(100, 63);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(139, 41);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "20,000";
            // 
            // lblavailablebalance
            // 
            this.lblavailablebalance.AutoSize = true;
            this.lblavailablebalance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavailablebalance.Location = new System.Drawing.Point(19, 17);
            this.lblavailablebalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblavailablebalance.Name = "lblavailablebalance";
            this.lblavailablebalance.Size = new System.Drawing.Size(167, 24);
            this.lblavailablebalance.TabIndex = 0;
            this.lblavailablebalance.Text = "Available Balance";
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTransaction.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.Image = global::Transaction.Properties.Resources.report;
            this.btnTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaction.Location = new System.Drawing.Point(167, 374);
            this.btnTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(244, 59);
            this.btnTransaction.TabIndex = 6;
            this.btnTransaction.Text = "Transaction History";
            this.btnTransaction.UseVisualStyleBackColor = false;
            // 
            // btnWithdrawmain
            // 
            this.btnWithdrawmain.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnWithdrawmain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWithdrawmain.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.btnWithdrawmain.Image = global::Transaction.Properties.Resources.withdrawal;
            this.btnWithdrawmain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWithdrawmain.Location = new System.Drawing.Point(33, 278);
            this.btnWithdrawmain.Margin = new System.Windows.Forms.Padding(4);
            this.btnWithdrawmain.Name = "btnWithdrawmain";
            this.btnWithdrawmain.Size = new System.Drawing.Size(244, 59);
            this.btnWithdrawmain.TabIndex = 1;
            this.btnWithdrawmain.Text = "Withdraw";
            this.btnWithdrawmain.UseVisualStyleBackColor = false;
            this.btnWithdrawmain.Click += new System.EventHandler(this.btnWithdrawmain_Click);
            // 
            // btnDepositMain
            // 
            this.btnDepositMain.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnDepositMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDepositMain.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositMain.Image = global::Transaction.Properties.Resources.deposit;
            this.btnDepositMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepositMain.Location = new System.Drawing.Point(323, 278);
            this.btnDepositMain.Margin = new System.Windows.Forms.Padding(4);
            this.btnDepositMain.Name = "btnDepositMain";
            this.btnDepositMain.Size = new System.Drawing.Size(244, 59);
            this.btnDepositMain.TabIndex = 0;
            this.btnDepositMain.Text = "Deposit";
            this.btnDepositMain.UseVisualStyleBackColor = false;
            // 
            // pnlWithdraw
            // 
            this.pnlWithdraw.Controls.Add(this.btnwithraw);
            this.pnlWithdraw.Controls.Add(this.lblentercahs);
            this.pnlWithdraw.Controls.Add(this.txtEnterCash);
            this.pnlWithdraw.Location = new System.Drawing.Point(33, 28);
            this.pnlWithdraw.Name = "pnlWithdraw";
            this.pnlWithdraw.Size = new System.Drawing.Size(534, 462);
            this.pnlWithdraw.TabIndex = 3;
            // 
            // btnwithraw
            // 
            this.btnwithraw.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwithraw.Location = new System.Drawing.Point(182, 268);
            this.btnwithraw.Name = "btnwithraw";
            this.btnwithraw.Size = new System.Drawing.Size(152, 41);
            this.btnwithraw.TabIndex = 2;
            this.btnwithraw.Text = "WITHDRAW";
            this.btnwithraw.UseVisualStyleBackColor = true;
            this.btnwithraw.Click += new System.EventHandler(this.btnwithraw_Click);
            // 
            // lblentercahs
            // 
            this.lblentercahs.AutoSize = true;
            this.lblentercahs.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblentercahs.Location = new System.Drawing.Point(111, 116);
            this.lblentercahs.Name = "lblentercahs";
            this.lblentercahs.Size = new System.Drawing.Size(298, 28);
            this.lblentercahs.TabIndex = 1;
            this.lblentercahs.Text = "Enter Cash to Withdraw:";
            // 
            // txtEnterCash
            // 
            this.txtEnterCash.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterCash.Location = new System.Drawing.Point(134, 160);
            this.txtEnterCash.Name = "txtEnterCash";
            this.txtEnterCash.Size = new System.Drawing.Size(256, 44);
            this.txtEnterCash.TabIndex = 0;
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(599, 514);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.pnlViewBal);
            this.Controls.Add(this.lblGreetings);
            this.Controls.Add(this.btnWithdrawmain);
            this.Controls.Add(this.btnDepositMain);
            this.Controls.Add(this.pnlWithdraw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Transaction";
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.Transaction_Load);
            this.pnlViewBal.ResumeLayout(false);
            this.pnlViewBal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlWithdraw.ResumeLayout(false);
            this.pnlWithdraw.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDepositMain;
        private System.Windows.Forms.Button btnWithdrawmain;
        private System.Windows.Forms.Label lblGreetings;
        private System.Windows.Forms.Panel pnlViewBal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblavailablebalance;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Panel pnlWithdraw;
        private System.Windows.Forms.TextBox txtEnterCash;
        private System.Windows.Forms.Button btnwithraw;
        private System.Windows.Forms.Label lblentercahs;
    }
}