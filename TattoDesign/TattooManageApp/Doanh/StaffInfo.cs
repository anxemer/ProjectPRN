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
    public partial class StaffInfo : Form
    {
        private IUserService userService;
        private IArtistService artistService;
        private ICartService cartService;
        private IOrderService orderService;
        private int artistId;
        public StaffInfo(int id)
        {
            orderService = new OrderService();
            cartService = new CartService();
            userService = new UserService();
            InitializeComponent();
            artistId = id;
            artistService = new ArtistService();
            loadArtistInfor(artistId);
        }

        private void StaffInfo_Load(object sender, EventArgs e)
        {
        }
        private void loadArtistInfor(int id)
        {
            Artist artist = artistService.getStaffById(id);
            if (artist != null && !string.IsNullOrEmpty(artist.Image))
            {
                try
                {

                    tattooimage.Image = Image.FromFile(artist.Image);
                    txtname.Text = artist.Namestaff;
                    txtprice.Text = artist.Experience.ToString();
                    txtdesctip.Text = artist.Information;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message);

                    tattooimage.Image = null;
                }
            }
            else
            {

                tattooimage.Image = null;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = userService.getUser(txtuser.Text);


            List<Cart> cartItems = cartService.getCartByUserId(user.Id);

            if (cartItems == null || cartItems.Count == 0)
            {

                MessageBox.Show("Your cart is empty. Please add some tattoos before creating an order.", "Cart Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                Artist artist = artistService.getStaffById(artistId);

                // Gọi service để tạo Order và OrderDetails
                orderService.placeOrder(user, cartItems, artist);

                // Hiển thị thông báo thành công
                MessageBox.Show("Order has been created successfully.", "Order Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
