using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TattooManagerObject.Models;
using TattooManagerService;

namespace TattoDesign
{
    public partial class Login : Form
    {
        private IUserService userService;

        public Login()
        {
            InitializeComponent();
            userService = new UserService();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            User user = userService.getUser(txtusername.Text);
            if (user != null && txtpass.Text.Trim().Equals(user.Password))
            {
                if (user.RoleId == 1)
                {
                    Admin admin = new Admin();
                    admin.username.Text = txtusername.Text;
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    HomePage homePage = new HomePage();
                    homePage.Show();
                    homePage.txtusername.Text = user.Username.ToString();
                    this.Hide();
                }
            }
            else { MessageBox.Show("please check you email or password"); }
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
