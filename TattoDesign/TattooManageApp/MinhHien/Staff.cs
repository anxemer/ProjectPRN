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

namespace TattoDesign
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void txt_image_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picture_staff.Image = Image.FromFile(dlgOpen.FileName);
                txt_image.Text = dlgOpen.FileName;
            }
            picture_staff.Image = Image.FromFile(@"E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Staff\download.jpg");
        }*/
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }
    }
}
