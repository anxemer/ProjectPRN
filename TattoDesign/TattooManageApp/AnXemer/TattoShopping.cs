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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TattoDesign.AnXemer
{

    public partial class TattoShopping : Form
    {
        private ITattoService tattoService;
        public TattoShopping()
        {
            tattoService = new TattooService();
            InitializeComponent();
            LoadImageTattoo();
        }

        private void LoadImageTattoo()
        {
            List<TattooImg> images = tattoService.GetAllTattoo();
            foreach (var product in images)
            {
                try
                {
                    Image image = Image.FromFile(product.Image);
                    listtattoo.Images.Add(product.Id.ToString(), image);

                    ListViewItem item = new ListViewItem
                    {
                        Text = product.Name,
                        ImageKey = product.Id.ToString()
                    };
                    lvtattoo.Items.Add(item);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message);
                    // Log lỗi hoặc xử lý nếu hình ảnh không tải được
                }
            }
        }

        private void btnall_Click(object sender, EventArgs e)
        {
            lvtattoo.Clear();
            LoadImageTattoo();
        }

        private void btnMinhHoa_Click(object sender, EventArgs e)
        {
            lvtattoo.Clear();
            List<TattooImg> images = tattoService.GetTattooByCateId(1);
            foreach (var product in images)
            {
                try
                {
                    Image image = Image.FromFile(product.Image);
                    listtattoo.Images.Add(product.Id.ToString(), image);

                    ListViewItem item = new ListViewItem
                    {
                        Text = product.Name,
                        ImageKey = product.Id.ToString()
                    };
                    lvtattoo.Items.Add(item);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message);
                    // Log lỗi hoặc xử lý nếu hình ảnh không tải được
                }
            }
        }

        private void btnDoHoa_Click(object sender, EventArgs e)
        {
            lvtattoo.Clear();
            List<TattooImg> images = tattoService.GetTattooByCateId(2);
            foreach (var product in images)
            {
                try
                {
                    Image image = Image.FromFile(product.Image);
                    listtattoo.Images.Add(product.Id.ToString(), image);

                    ListViewItem item = new ListViewItem
                    {
                        Text = product.Name,
                        ImageKey = product.Id.ToString()
                    };
                    lvtattoo.Items.Add(item);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message);
                    // Log lỗi hoặc xử lý nếu hình ảnh không tải được
                }
            }
        }

        private void btnMauNho_Click(object sender, EventArgs e)
        {
            lvtattoo.Clear();
            List<TattooImg> images = tattoService.GetTattooByCateId(3);
            foreach (var product in images)
            {
                try
                {
                    Image image = Image.FromFile(product.Image);
                    listtattoo.Images.Add(product.Id.ToString(), image);

                    ListViewItem item = new ListViewItem
                    {
                        Text = product.Name,
                        ImageKey = product.Id.ToString()
                    };
                    lvtattoo.Items.Add(item);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message);
                    // Log lỗi hoặc xử lý nếu hình ảnh không tải được
                }
            }
        }

        private void btnBieuTuong_Click(object sender, EventArgs e)
        {
            lvtattoo.Clear();
            List<TattooImg> images = tattoService.GetTattooByCateId(4);
            foreach (var product in images)
            {
                try
                {
                    Image image = Image.FromFile(product.Image);
                    listtattoo.Images.Add(product.Id.ToString(), image);

                    ListViewItem item = new ListViewItem
                    {
                        Text = product.Name,
                        ImageKey = product.Id.ToString()
                    };
                    lvtattoo.Items.Add(item);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message);
                    // Log lỗi hoặc xử lý nếu hình ảnh không tải được
                }
            }
        }

        private void btnVietNam_Click(object sender, EventArgs e)
        {
            lvtattoo.Clear();
            List<TattooImg> images = tattoService.GetTattooByCateId(5);
            foreach (var product in images)
            {
                try
                {
                    Image image = Image.FromFile(product.Image);
                    listtattoo.Images.Add(product.Id.ToString(), image);

                    ListViewItem item = new ListViewItem
                    {
                        Text = product.Name,
                        ImageKey = product.Id.ToString()
                    };
                    lvtattoo.Items.Add(item);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message);
                    // Log lỗi hoặc xử lý nếu hình ảnh không tải được
                }
            }
        }

        private void btnChauA_Click(object sender, EventArgs e)
        {
            lvtattoo.Clear();
            List<TattooImg> images = tattoService.GetTattooByCateId(6);
            foreach (var product in images)
            {
                try
                {
                    Image image = Image.FromFile(product.Image);
                    listtattoo.Images.Add(product.Id.ToString(), image);

                    ListViewItem item = new ListViewItem
                    {
                        Text = product.Name,
                        ImageKey = product.Id.ToString()
                    };
                    lvtattoo.Items.Add(item);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message);
                    // Log lỗi hoặc xử lý nếu hình ảnh không tải được
                }
            }
        }

        private void BtnDentrang_Click(object sender, EventArgs e)
        {
            lvtattoo.Clear();
            List<TattooImg> images = tattoService.GetTattooByCateId(7);
            foreach (var product in images)
            {
                try
                {
                    Image image = Image.FromFile(product.Image);
                    listtattoo.Images.Add(product.Id.ToString(), image);

                    ListViewItem item = new ListViewItem
                    {
                        Text = product.Name,
                        ImageKey = product.Id.ToString()
                    };
                    lvtattoo.Items.Add(item);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message);
                    // Log lỗi hoặc xử lý nếu hình ảnh không tải được
                }
            }
        }

        private void btnChu_Click(object sender, EventArgs e)
        {
            lvtattoo.Clear();
            List<TattooImg> images = tattoService.GetTattooByCateId(8);
            foreach (var product in images)
            {
                try
                {
                    Image image = Image.FromFile(product.Image);
                    listtattoo.Images.Add(product.Id.ToString(), image);

                    ListViewItem item = new ListViewItem
                    {
                        Text = product.Name,
                        ImageKey = product.Id.ToString()
                    };
                    lvtattoo.Items.Add(item);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message);
                    // Log lỗi hoặc xử lý nếu hình ảnh không tải được
                }
            }
        }

        private void btnMauLon_Click(object sender, EventArgs e)
        {
            lvtattoo.Clear();
            List<TattooImg> images = tattoService.GetTattooByCateId(9);
            foreach (var product in images)
            {
                try
                {
                    Image image = Image.FromFile(product.Image);
                    listtattoo.Images.Add(product.Id.ToString(), image);

                    ListViewItem item = new ListViewItem
                    {
                        Text = product.Name,
                        ImageKey = product.Id.ToString()
                    };
                    lvtattoo.Items.Add(item);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message);
                    // Log lỗi hoặc xử lý nếu hình ảnh không tải được
                }
            }
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            lvtattoo.Clear();
            List<TattooImg> images = tattoService.GetTattooByCateId(10);
            foreach (var product in images)
            {
                try
                {
                    Image image = Image.FromFile(product.Image);
                    listtattoo.Images.Add(product.Id.ToString(), image);

                    ListViewItem item = new ListViewItem
                    {
                        Text = product.Name,
                        ImageKey = product.Id.ToString()
                    };
                    lvtattoo.Items.Add(item);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message);
                    // Log lỗi hoặc xử lý nếu hình ảnh không tải được
                }
            }
        }

        private void btmHomePage_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.ShowDialog();
            this.Dispose();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            List<TattooImg> images = tattoService.GetTattooByName(search);
            lvtattoo.Items.Clear();
            foreach (var product in images)
            {
                try
                {
                    Image image = Image.FromFile(product.Image);
                    listtattoo.Images.Add(product.Id.ToString(), image);

                    ListViewItem item = new ListViewItem
                    {
                        Text = product.Name,
                        ImageKey = product.Id.ToString()
                    };
                    lvtattoo.Items.Add(item);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message);
                    // Log lỗi hoặc xử lý nếu hình ảnh không tải được
                }
            }
        }

        private void lvtattoo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem items = lvtattoo.GetItemAt(e.X, e.Y);
            if (items != null)
            {
                OpenTattooDetailsForm(items.ImageKey);
            }
        }
        private void OpenTattooDetailsForm(string imageId)
        {
            // Chuyển đổi imageId từ string sang int nếu cần
            int tattooId = int.Parse(imageId);

            TattooDetail detailsForm = new TattooDetail(tattooId);
            detailsForm.txtusername.Text = txtusername.Text;
            detailsForm.Show();
        }

        private void TattoShopping_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
