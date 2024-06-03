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

        private void Transaction_Load(object sender, EventArgs e)
        {
             lblGreetings.Text = $"Hello {Transac.Username}";
            lblBalance.Text = $"{Transac.Balance}";
        }

        

        private void btnwithraw_Click(object sender, EventArgs e)
        {
            //txtEnterCash.Text
            decimal cashAmount = Convert.ToDecimal(txtEnterCash.Text);

            if(cashAmount >= Transac.Balance)
            {
                //Repositories.AddTra;
            }

        }

        private void btnWithdrawmain_Click(object sender, EventArgs e)
        {
            pnlWithdraw.Visible = true;

        }
    }
}
