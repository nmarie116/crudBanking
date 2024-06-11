using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transaction
{
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }
        tblUser tblUser = new tblUser();
        tblTransaction tblTrans = new tblTransaction();
        DataClasses1DataContext db = new DataClasses1DataContext();


        private void Transaction_Load(object sender, EventArgs e)
        {
           
            lblGreetings.Text = $"Hello {User.Username}";
            lblBalance.Text = $"{db.GetBalance(User.Userid)}";
        }        
        public int userid = User.Userid;
        private void btnwithraw_Click(object sender, EventArgs e)
        {
            
            DateTime now = DateTime.Now;
            string transType = "Withdraw";
            decimal cashAmount = Convert.ToDecimal(txtEnterCash.Text);
            if (txtEnterCash.Text != "")
            {
                if (cashAmount <= db.GetBalance(User.Userid))
                {                   
                        decimal _cAmount = (decimal)db.GetBalance(userid) - cashAmount;
                        tblTrans.userid = userid;
                        tblTrans.transDate = now;
                        tblTrans.amount = cashAmount;
                        tblTrans.transType = transType;
                        tblUser.userId = User.Userid;
                        tblUser.Balance = (int?)_cAmount;
                        tblUser.username = User.Username;
                        tblUser.upassword = User.Password;
                        tblUser.userpin = User.Pin;
                        tblUser.fname = User.Fname;
                        tblUser.lname = User.Lname;
                        Repositories.UpdateUser(tblUser);
                        Repositories.AddTra(tblTrans);
                        Clear();                   
                   
                }
                else
                {
                    MessageBox.Show("Insuficiente Balance");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Amount to Withdraw");
            }
        }

        private void btnWithdrawmain_Click(object sender, EventArgs e)
        {
            pnlWithdraw.Visible = true;
            pnlViewBal.Visible = false;
            btnDepositMain.Visible = false;
            btnWithdrawmain.Visible = false;
            btnTransaction.Visible = false;
            pnlTransDetails.Visible = false;
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            pnlTransDetails.Visible = true;
            dgvViewTrans.DataSource = Repositories.ViewTra();
            pnlViewBal.Visible = false;
            btnDepositMain.Visible = false;
            btnWithdrawmain.Visible = false;
            btnTransaction.Visible = false;
        }

        private void bntdeposite_Click(object sender, EventArgs e)
        {
           
            DateTime now = DateTime.Now;
            string transType = "Deposite";
            if(txtDeposite.Text != "")
            {
                decimal cashAmount = Convert.ToDecimal(txtDeposite.Text);

                if (cashAmount >= db.GetBalance(User.Userid) || cashAmount <= db.GetBalance(User.Userid))
                {
                    decimal _cAmount = (decimal)db.GetBalance(User.Userid) + cashAmount;
                    tblTrans.userid = User.Userid;
                    tblTrans.transDate = now;
                    tblTrans.amount = _cAmount;
                    tblTrans.transType = transType;
                    tblUser.Balance = (int?)_cAmount;
                    Repositories.UpdateUser(tblUser);
                    Repositories.AddTra(tblTrans);
                    Clear();
                }
                else
                {
                    MessageBox.Show("testing 'error' ");
                }              
            }
            else
            {
                MessageBox.Show("Please Enter Amount to Deposite");
            }            
        }

        private void btnDepositMain_Click(object sender, EventArgs e)
        {
            pnlDiposite.Visible = true;
            pnlViewBal.Visible = false;
            btnDepositMain.Visible = false;
            btnWithdrawmain.Visible = false;
            btnTransaction.Visible = false;
        }

        private void btnpnlTransDetails_Click(object sender, EventArgs e)
        {
            //back
            pnlTransDetails.Visible = false;
            pnlViewBal.Visible = true;
            btnDepositMain.Visible = true;
            btnWithdrawmain.Visible = true;
            btnTransaction.Visible = true;
        }

        private void btnpnlDiposite_Click(object sender, EventArgs e)
        {
            //back
            pnlDiposite.Visible = false;
            pnlViewBal.Visible = true;
            btnDepositMain.Visible = true;
            btnWithdrawmain.Visible = true;
            btnTransaction.Visible = true;
        }

        private void btnpnlWithdraw_Click(object sender, EventArgs e)
        {
            //back
            pnlWithdraw.Visible = false;
            pnlViewBal.Visible = true;
            btnDepositMain.Visible = true;
            btnWithdrawmain.Visible = true;
            btnTransaction.Visible = true;
        }

        public void Clear()
        {
            txtDeposite.Clear();
            txtEnterCash.Clear();
        }
    }
}
