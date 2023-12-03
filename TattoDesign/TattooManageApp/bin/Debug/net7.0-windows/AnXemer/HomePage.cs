using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TattoDesign.AnXemer;
using TattooManagerObject.Models;

namespace TattoDesign
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btntatto_Click(object sender, EventArgs e)
        {
            TattoShopping tatto = new TattoShopping();
            tatto.txtusername.Text = txtusername.Text;
            tatto.Show();
            this.Hide();
        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnartist_Click(object sender, EventArgs e)
        {
            staffbooking staffbooking = new staffbooking();
            staffbooking.Show();
            staffbooking.txtusn.Text = txtusername.Text;
            this.Hide();

        }

        private void btnbooking_Click(object sender, EventArgs e)
        {
            TattooCart tattooCart = new TattooCart();
            tattooCart.txtusername.Text = txtusername.Text;
            tattooCart.Show();
            this.Hide();
        }
    }
}
