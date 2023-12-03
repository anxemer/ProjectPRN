using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using static System.Net.WebRequestMethods;
using System.Windows.Forms.Design;
using TattooManagerService;
using TattooManagerObject.Models;
using TattoDesign.AnXemer;

namespace TattoDesign
{
    public partial class TattooCart : Form
    {
        private ITattoService tattoService;
        private IUserService userService;
        private ICartService cartService;
        private int userid;
        public TattooCart()
        {
            userService = new UserService();
            cartService = new CartService();
            tattoService = new TattooService();

            InitializeComponent();

        }
        private async void Staff_Load(object sender, EventArgs e)
        {
            await Task.Delay(1000);
            loadCart();
        }
        private void loadCart()
        {
            dtgcart.Columns["image"].Width = 100;


            dtgcart.RowTemplate.Height = 100;
            User user = userService.getUser(txtusername.Text);
            userid = user.Id;
            List<Cart> cart = cartService.getCartByUserId(userid);
            foreach (Cart c in cart)
            {
                var tattoo = tattoService.GetTattooById(c.TattooId);
                Image image = null;
                if (System.IO.File.Exists(tattoo.Image))
                {
                    image = Image.FromFile(tattoo.Image);
                    int height = dtgcart.RowTemplate.Height;
                    int width = image.Width * height / image.Height;
                    image = new Bitmap(image, new Size(width, height));
                }
                dtgcart.Rows.Add(tattoo.Id, tattoo.Name, image, tattoo.Price);

            }
        }

        private void btnstaff_Click(object sender, EventArgs e)
        {
            staffbooking staffbooking = new staffbooking();
            staffbooking.Show();
            staffbooking.txtusn.Text = txtusername.Text;

        }

        private void btntattoo_Click(object sender, EventArgs e)
        {
            TattoShopping tatto = new TattoShopping();
            tatto.txtusername.Text = txtusername.Text;
            tatto.Show();
            this.Hide();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void TattooCart_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
