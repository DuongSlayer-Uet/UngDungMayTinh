using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STMxBMP180
{
    public partial class loginform : Form
    {
        public string username { get; set; }
        public string password { get; set; }
        public Boolean isUser { get; set; }
        
        public loginform()
        {
            InitializeComponent();
            isUser = false;
        }

        private void loginform_Load(object sender, EventArgs e)
        {

        }
        private void btn_signIn_Click(object sender, EventArgs e)
        {
            if (tbx_userName.Text == "Duong" && tbx_password.Text == "123")
            {
                username = tbx_userName.Text;
                password = tbx_password.Text;
                isUser = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong password!");
            }
        }

        private void btn_signinAsGuest_Click(object sender, EventArgs e)
        {
            isUser = false;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
