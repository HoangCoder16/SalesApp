using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesApp
{
    public partial class LoginAcount : Form
    {
        public LoginAcount()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != "123456")
            {
                MessageBox.Show("PassWord không đúng !!");
            } else
            {
                this.Close();
            }
        }

        private void textBoxAccount_TextChanged(object sender, EventArgs e)
        {
            buttonSignIn.Enabled = false;
            if (textBoxAccount.Text.Length == 0)
            {
                this.errorProvider.SetError(textBoxAccount, "You must enter data (A)");
            }

            else if (textBoxPassword.Text.Length == 0)
            {
                this.errorProvider.SetError(textBoxPassword, "You must enter data (B)");
            }
            else
            {
                this.errorProvider.Clear();
                buttonSignIn.Enabled = true;
            }
        }
    }
}
