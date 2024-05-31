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
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblavailablebalance = new System.Windows.Forms.Label();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.pnlViewBal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGreetings
            // 
            this.lblGreetings.AutoSize = true;
            this.lblGreetings.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreetings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGreetings.Location = new System.Drawing.Point(21, 23);
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.Size = new System.Drawing.Size(139, 23);
            this.lblGreetings.TabIndex = 4;
            this.lblGreetings.Text = "HELLO USER!";
            // 
            // pnlViewBal
            // 
            this.pnlViewBal.BackColor = System.Drawing.Color.MintCream;
            this.pnlViewBal.Controls.Add(this.pictureBox1);
            this.pnlViewBal.Controls.Add(this.lblBalance);
            this.pnlViewBal.Controls.Add(this.lblavailablebalance);
            this.pnlViewBal.Location = new System.Drawing.Point(25, 66);
            this.pnlViewBal.Name = "pnlViewBal";
            this.pnlViewBal.Size = new System.Drawing.Size(400, 112);
            this.pnlViewBal.TabIndex = 5;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(75, 51);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(108, 33);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "20,000";
            // 
            // lblavailablebalance
            // 
            this.lblavailablebalance.AutoSize = true;
            this.lblavailablebalance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavailablebalance.Location = new System.Drawing.Point(14, 14);
            this.lblavailablebalance.Name = "lblavailablebalance";
            this.lblavailablebalance.Size = new System.Drawing.Size(131, 19);
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
            this.btnTransaction.Location = new System.Drawing.Point(125, 304);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(183, 48);
            this.btnTransaction.TabIndex = 6;
            this.btnTransaction.Text = "Transaction History";
            this.btnTransaction.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Transaction.Properties.Resources.cuba_peso_currency_symbol;
            this.pictureBox1.Location = new System.Drawing.Point(49, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnDeposit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeposit.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.btnDeposit.Image = global::Transaction.Properties.Resources.withdrawal;
            this.btnDeposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeposit.Location = new System.Drawing.Point(25, 226);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(183, 48);
            this.btnDeposit.TabIndex = 1;
            this.btnDeposit.Text = "Withdraw";
            this.btnDeposit.UseVisualStyleBackColor = false;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnWithdraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWithdraw.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.Image = global::Transaction.Properties.Resources.deposit;
            this.btnWithdraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWithdraw.Location = new System.Drawing.Point(242, 226);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(183, 48);
            this.btnWithdraw.TabIndex = 0;
            this.btnWithdraw.Text = "Deposit";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(449, 418);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.pnlViewBal);
            this.Controls.Add(this.lblGreetings);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnWithdraw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transaction";
            this.Text = "Transaction";
            this.pnlViewBal.ResumeLayout(false);
            this.pnlViewBal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label lblGreetings;
        private System.Windows.Forms.Panel pnlViewBal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblavailablebalance;
        private System.Windows.Forms.Button btnTransaction;
    }
}