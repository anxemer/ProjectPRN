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
        private int tattooId;
        public TattooDetail(int id)
        {
            tattoService = new TattooService();
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
    }
}
