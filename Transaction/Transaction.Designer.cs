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
            this.pnlDiposite = new System.Windows.Forms.Panel();
            this.btnpnlDiposite = new System.Windows.Forms.Button();
            this.bntdeposite = new System.Windows.Forms.Button();
            this.lbldeposite = new System.Windows.Forms.Label();
            this.txtDeposite = new System.Windows.Forms.TextBox();
            this.pnlTransDetails = new System.Windows.Forms.Panel();
            this.btnpnlTransDetails = new System.Windows.Forms.Button();
            this.dgvViewTrans = new System.Windows.Forms.DataGridView();
            this.pnlWithdraw = new System.Windows.Forms.Panel();
            this.btnpnlWithdraw = new System.Windows.Forms.Button();
            this.btnwithraw = new System.Windows.Forms.Button();
            this.lblentercahs = new System.Windows.Forms.Label();
            this.txtEnterCash = new System.Windows.Forms.TextBox();
            this.pnlViewBal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlDiposite.SuspendLayout();
            this.pnlTransDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewTrans)).BeginInit();
            this.pnlWithdraw.SuspendLayout();
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
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnWithdrawmain
            // 
            this.btnWithdrawmain.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnWithdrawmain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWithdrawmain.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.btnWithdrawmain.Image = global::Transaction.Properties.Resources.withdrawal;
            this.btnWithdrawmain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWithdrawmain.Location = new System.Drawing.Point(25, 226);
            this.btnWithdrawmain.Name = "btnWithdrawmain";
            this.btnWithdrawmain.Size = new System.Drawing.Size(183, 48);
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
            this.btnDepositMain.Location = new System.Drawing.Point(242, 226);
            this.btnDepositMain.Name = "btnDepositMain";
            this.btnDepositMain.Size = new System.Drawing.Size(183, 48);
            this.btnDepositMain.TabIndex = 0;
            this.btnDepositMain.Text = "Deposit";
            this.btnDepositMain.UseVisualStyleBackColor = false;
            this.btnDepositMain.Click += new System.EventHandler(this.btnDepositMain_Click);
            // 
            // pnlDiposite
            // 
            this.pnlDiposite.Controls.Add(this.btnpnlDiposite);
            this.pnlDiposite.Controls.Add(this.bntdeposite);
            this.pnlDiposite.Controls.Add(this.lbldeposite);
            this.pnlDiposite.Controls.Add(this.txtDeposite);
            this.pnlDiposite.Location = new System.Drawing.Point(11, 25);
            this.pnlDiposite.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDiposite.Name = "pnlDiposite";
            this.pnlDiposite.Size = new System.Drawing.Size(423, 373);
            this.pnlDiposite.TabIndex = 4;
            this.pnlDiposite.Visible = false;
            // 
            // btnpnlDiposite
            // 
            this.btnpnlDiposite.Location = new System.Drawing.Point(296, 5);
            this.btnpnlDiposite.Name = "btnpnlDiposite";
            this.btnpnlDiposite.Size = new System.Drawing.Size(75, 23);
            this.btnpnlDiposite.TabIndex = 9;
            this.btnpnlDiposite.Text = "<<==";
            this.btnpnlDiposite.UseVisualStyleBackColor = true;
            this.btnpnlDiposite.Click += new System.EventHandler(this.btnpnlDiposite_Click);
            // 
            // bntdeposite
            // 
            this.bntdeposite.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntdeposite.Location = new System.Drawing.Point(136, 218);
            this.bntdeposite.Margin = new System.Windows.Forms.Padding(2);
            this.bntdeposite.Name = "bntdeposite";
            this.bntdeposite.Size = new System.Drawing.Size(114, 33);
            this.bntdeposite.TabIndex = 2;
            this.bntdeposite.Text = "Deposite";
            this.bntdeposite.UseVisualStyleBackColor = true;
            this.bntdeposite.Click += new System.EventHandler(this.bntdeposite_Click);
            // 
            // lbldeposite
            // 
            this.lbldeposite.AutoSize = true;
            this.lbldeposite.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeposite.Location = new System.Drawing.Point(83, 94);
            this.lbldeposite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldeposite.Name = "lbldeposite";
            this.lbldeposite.Size = new System.Drawing.Size(236, 23);
            this.lbldeposite.TabIndex = 1;
            this.lbldeposite.Text = "Enter Cash to Deposite:";
            // 
            // txtDeposite
            // 
            this.txtDeposite.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeposite.Location = new System.Drawing.Point(100, 130);
            this.txtDeposite.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeposite.Name = "txtDeposite";
            this.txtDeposite.Size = new System.Drawing.Size(193, 36);
            this.txtDeposite.TabIndex = 0;
            // 
            // pnlTransDetails
            // 
            this.pnlTransDetails.Controls.Add(this.btnpnlTransDetails);
            this.pnlTransDetails.Controls.Add(this.dgvViewTrans);
            this.pnlTransDetails.Location = new System.Drawing.Point(23, 23);
            this.pnlTransDetails.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTransDetails.Name = "pnlTransDetails";
            this.pnlTransDetails.Size = new System.Drawing.Size(400, 384);
            this.pnlTransDetails.TabIndex = 4;
            this.pnlTransDetails.Visible = false;
            // 
            // btnpnlTransDetails
            // 
            this.btnpnlTransDetails.Location = new System.Drawing.Point(302, 5);
            this.btnpnlTransDetails.Name = "btnpnlTransDetails";
            this.btnpnlTransDetails.Size = new System.Drawing.Size(75, 23);
            this.btnpnlTransDetails.TabIndex = 7;
            this.btnpnlTransDetails.Text = "<<==";
            this.btnpnlTransDetails.UseVisualStyleBackColor = true;
            this.btnpnlTransDetails.Click += new System.EventHandler(this.btnpnlTransDetails_Click);
            // 
            // dgvViewTrans
            // 
            this.dgvViewTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewTrans.Location = new System.Drawing.Point(28, 85);
            this.dgvViewTrans.Name = "dgvViewTrans";
            this.dgvViewTrans.Size = new System.Drawing.Size(349, 176);
            this.dgvViewTrans.TabIndex = 0;
            // 
            // pnlWithdraw
            // 
            this.pnlWithdraw.Controls.Add(this.btnpnlWithdraw);
            this.pnlWithdraw.Controls.Add(this.btnwithraw);
            this.pnlWithdraw.Controls.Add(this.lblentercahs);
            this.pnlWithdraw.Controls.Add(this.txtEnterCash);
            this.pnlWithdraw.Location = new System.Drawing.Point(25, 23);
            this.pnlWithdraw.Margin = new System.Windows.Forms.Padding(2);
            this.pnlWithdraw.Name = "pnlWithdraw";
            this.pnlWithdraw.Size = new System.Drawing.Size(400, 375);
            this.pnlWithdraw.TabIndex = 3;
            this.pnlWithdraw.Visible = false;
            // 
            // btnpnlWithdraw
            // 
            this.btnpnlWithdraw.Location = new System.Drawing.Point(292, 5);
            this.btnpnlWithdraw.Name = "btnpnlWithdraw";
            this.btnpnlWithdraw.Size = new System.Drawing.Size(75, 23);
            this.btnpnlWithdraw.TabIndex = 8;
            this.btnpnlWithdraw.Text = "<<==";
            this.btnpnlWithdraw.UseVisualStyleBackColor = true;
            this.btnpnlWithdraw.Click += new System.EventHandler(this.btnpnlWithdraw_Click);
            // 
            // btnwithraw
            // 
            this.btnwithraw.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwithraw.Location = new System.Drawing.Point(130, 209);
            this.btnwithraw.Margin = new System.Windows.Forms.Padding(2);
            this.btnwithraw.Name = "btnwithraw";
            this.btnwithraw.Size = new System.Drawing.Size(103, 30);
            this.btnwithraw.TabIndex = 2;
            this.btnwithraw.Text = "WITHDRAW";
            this.btnwithraw.UseVisualStyleBackColor = true;
            this.btnwithraw.Click += new System.EventHandler(this.btnwithraw_Click);
            // 
            // lblentercahs
            // 
            this.lblentercahs.AutoSize = true;
            this.lblentercahs.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblentercahs.Location = new System.Drawing.Point(77, 85);
            this.lblentercahs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblentercahs.Name = "lblentercahs";
            this.lblentercahs.Size = new System.Drawing.Size(246, 23);
            this.lblentercahs.TabIndex = 1;
            this.lblentercahs.Text = "Enter Cash to Withdraw:";
            // 
            // txtEnterCash
            // 
            this.txtEnterCash.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterCash.Location = new System.Drawing.Point(94, 121);
            this.txtEnterCash.Margin = new System.Windows.Forms.Padding(2);
            this.txtEnterCash.Name = "txtEnterCash";
            this.txtEnterCash.Size = new System.Drawing.Size(193, 36);
            this.txtEnterCash.TabIndex = 0;
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(445, 418);
            this.Controls.Add(this.lblGreetings);
            this.Controls.Add(this.pnlTransDetails);
            this.Controls.Add(this.pnlDiposite);
            this.Controls.Add(this.btnWithdrawmain);
            this.Controls.Add(this.btnDepositMain);
            this.Controls.Add(this.pnlWithdraw);
            this.Controls.Add(this.pnlViewBal);
            this.Controls.Add(this.btnTransaction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.Transaction_Load);
            this.pnlViewBal.ResumeLayout(false);
            this.pnlViewBal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlDiposite.ResumeLayout(false);
            this.pnlDiposite.PerformLayout();
            this.pnlTransDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewTrans)).EndInit();
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
        private System.Windows.Forms.Panel pnlDiposite;
        private System.Windows.Forms.Button bntdeposite;
        private System.Windows.Forms.Label lbldeposite;
        private System.Windows.Forms.TextBox txtDeposite;
        private System.Windows.Forms.Panel pnlTransDetails;
        private System.Windows.Forms.DataGridView dgvViewTrans;
        private System.Windows.Forms.Panel pnlWithdraw;
        private System.Windows.Forms.Button btnwithraw;
        private System.Windows.Forms.Label lblentercahs;
        private System.Windows.Forms.TextBox txtEnterCash;
        private System.Windows.Forms.Button btnpnlTransDetails;
        private System.Windows.Forms.Button btnpnlDiposite;
        private System.Windows.Forms.Button btnpnlWithdraw;
    }
}