using System;
using System.Windows.Forms;
using SM.BL;

namespace SM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_CLear_Click(object sender, EventArgs e)
        {
            txb_Name.Clear();
            txb_Pass.Clear();
            txb_Name.Focus();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string userLogin = txb_Name.Text;
            string userPass = txb_Pass.Text;
            string message = string.Empty;

            LoginPart loginPart = new LoginPart();
            bool loginResult = LoginPart.Check(userLogin, userPass, ref message);

            if (loginResult == false)
            {
                MessageBox.Show(message);
            }
            else
            {
                this.Hide();
                StockMain main = new StockMain();
                main.Show();
            }
        }
    }
}
