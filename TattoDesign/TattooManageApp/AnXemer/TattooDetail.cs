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

namespace TattoDesign.AnXemer
{
    public partial class TattooDetail : Form
    {
        private ITattoService tattoService;
        private IUserService userService;
        private ICartService cartService;
        private int tattooId;
        public TattooDetail(int id)
        {
            userService = new UserService();
            tattoService = new TattooService();
            cartService = new CartService();
            InitializeComponent();
            tattooId = id;
            loadTattooDetail(id);
        }
        private void loadTattooDetail(int id)
        {

            TattooImg tattoo = tattoService.GetTattooById(id);
            if (tattoo != null && !string.IsNullOrEmpty(tattoo.Image))
            {
                try
                {

                    tattooimage.Image = Image.FromFile(tattoo.Image);
                    txtname.Text = tattoo.Name;
                    txtprice.Text = tattoo.Price.ToString();
                    txtdesctip.Text = tattoo.Description;

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
          User user =  userService.getUser(txtusername.Text);
            cartService.addCart(user.Id, tattooId);
            MessageBox.Show("Bạn đã chọn được 1 hình đẹp đấy, giờ hãy vào 'Booking' để xem các cảnh bạn đã chọn và chọn 1 Artist để xăm cho bạn đi nào !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
