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
        private IArtistService artistService;
        private int artistId;
        public StaffInfo(int id)
        {
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

    }
}
