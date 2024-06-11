using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transaction
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        tblUser tblUser = new tblUser();
        DataClasses1DataContext db = new DataClasses1DataContext();
         

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(ValidateCredential(txtUsername.Text ,txtPassword.Text))
            {
                User.Userid = (int)db.getUserId(txtUsername.Text, txtPassword.Text);               
                MessageBox.Show("successfully login");
                Clear();
                this.Hide();
                Pin pn = new Pin();
                pn.Show();
            }
            else
            {
                MessageBox.Show("wrong credintials");
                Clear();
            }

        }

        private bool ValidateCredential(string username, string password)
        {
           bool isValidated = Repositories.VLogin(username, password);
            return isValidated;             
        }

        private void lbRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // display register pnl
            pnlRegister.Visible = true;
        }

        public void Clear()
        {
            //clear data
            txtfname.Clear();
            txtlname.Clear();
            txtpass.Clear();
            txtpin.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            
            
        }
        private void btncreatereg_Click(object sender, EventArgs e)
        {            
            if (txtfname.Text != "" || txtlname.Text != "" || txtpass.Text != "")
            {
                tblUser.fname = txtfname.Text;
                tblUser.lname = txtlname.Text;
                tblUser.username = txtuname.Text;
                tblUser.upassword = txtpass.Text;
                tblUser.userpin = Convert.ToInt32(txtpin.Text);
                tblUser.Balance = 0;               
                Repositories.AddUser(tblUser);
                pnlRegister.Visible = false;
               
            }
            else
            {
                MessageBox.Show("Fill out the Fields");
                Clear();
            }        
        }

        public int UserPin()
        {
            return 0;
        }               

        private void txtlname_KeyPress(object sender, KeyPressEventArgs e)
        {
            //txtuname.Text = StaticUsername();
        }

        private void txtpin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled= true;
            }
        }

        private void txtpin_TextChanged(object sender, EventArgs e)
        {
            if (txtpin.Text.Length > 4)
            {
                txtpin.Text = txtpin.Text.Substring(0, 4);
                txtpin.SelectionStart = txtpin.Text.Length;
            }
        }

    }
}
