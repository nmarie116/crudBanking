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
    public partial class Pin : Form
    {
        public Pin()
        {
            InitializeComponent();
        }

        tblUser tblUser = new tblUser();
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void txtenterpin_TextChanged(object sender, EventArgs e)
        {
            if (txtenterpin.Text.Length > 4)
            {
                txtenterpin.Text = txtenterpin.Text.Substring(0, 4);
                txtenterpin.SelectionStart = txtenterpin.Text.Length;
            }
        }

        private void txtenterpin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                int pin = Convert.ToInt32(txtenterpin.Text);
                if (pin == Repositories.GetPin(pin))
                {
                    MessageBox.Show("YOU HAVE SUCCESSFULLY VERIVERI");
                    this.Hide();
                    Transaction trans = new Transaction();
                    trans.Show();
                }
                else
                {
                    MessageBox.Show("WROMG PIN");
                }

            }
        }

        private void txtenterpin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       

        
    }
}
