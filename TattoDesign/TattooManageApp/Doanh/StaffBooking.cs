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
using TattooManagerService;

namespace TattoDesign
{
    public partial class staffbooking : Form
    {
        private IArtistService artistService;

        public staffbooking()
        {
            artistService = new ArtistService();
            InitializeComponent();
            getAllArtist();
        }
        private void getAllArtist()
        {
            List<Artist> artists = artistService.getAllStaff();
            foreach (var product in artists)
            {
                try
                {
                    Image image = Image.FromFile(product.Image);
                    staffimage.Images.Add(product.Id.ToString(), image);

                    ListViewItem item = new ListViewItem
                    {
                        Text = product.Namestaff,
                        ImageKey = product.Id.ToString()
                    };
                    lvstaff.Items.Add(item);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message);
                    // Log lỗi hoặc xử lý nếu hình ảnh không tải được
                }
            }
        }
        private void getArtistByName(string name)
        {
            List<Artist> artists = artistService.getStaffByName(name);
        }

        private void lvstaff_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem items = lvstaff.GetItemAt(e.X, e.Y);
            if (items != null)
            {
                OpenTattooDetailsForm(items.ImageKey);
            }
        }
        private void OpenTattooDetailsForm(string imageId)
        {
            // Chuyển đổi imageId từ string sang int nếu cần
            int tattooId = int.Parse(imageId);

            StaffInfo staffInfo = new StaffInfo(tattooId);
            staffInfo.Show();
        }

        private void staffbooking_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

}

