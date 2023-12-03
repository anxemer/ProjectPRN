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
    public partial class Register : Form
    {
        private IUserService userService;
        public Register()
        {
            InitializeComponent();
            userService = new UserService();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Username = txtusername.Text;
            user.Password = txtpass.Text;
            user.Email = txtemail.Text;
            user.Address = txtaddress.Text;
            user.Phonenumber = txtphone.Text;
            user.RoleId = 3;

            if (txtusername.Text == "" || txtpass.Text == "" || txtemail.Text == "" || txtphone.Text == "" || txtaddress.Text == "")
            {
                MessageBox.Show("Vui lòng điền đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                userService.addUser(user);
                MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login login = new Login();
                login.ShowDialog();
                this.Hide();
            }


        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
