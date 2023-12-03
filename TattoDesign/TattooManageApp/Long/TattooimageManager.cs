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
    public partial class TattooimageManager : Form
    {
        private ITattoService tattooservice;
        public TattooimageManager()
        {
            tattooservice = new TattooService();
            InitializeComponent();
            loadTattoo();
        }
        public void loadTattoo()
        {
            List<TattooImg> tattoos = tattooservice.GetAllTattoo();
            List<CategoryTattoo> cate = tattooservice.GetAllCate();
            foreach (TattooImg t in tattoos)
            {
                dtgtattoo.Rows.Add(t.Id, t.Name, t.Price, t.Image,t.Description, t.CateId);
            }
            cbcate.DataSource = cate;
            cbcate.DisplayMember = "CateName";
            cbcate.ValueMember = "Id";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            TattooImg tattoo = new TattooImg();
            //tattoo.Id =Convert.ToInt32(txtid.Text);
            tattoo.Name = txtname.Text;
            tattoo.Price = Convert.ToDecimal(txtprice.Text);
            tattoo.Image = txtimage.Text;
            tattoo.CateId = Convert.ToInt32(cbcate.SelectedValue.ToString());
            tattoo.Description = txtdescrip.Text;
            tattooservice.AddTatoo(tattoo);
            MessageBox.Show("Add successfull !");
            dtgtattoo.Rows.Clear();
            loadTattoo();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtid.Visible = true;
            txtname.Clear();
            txtprice.Clear();
            txtimage.Clear();
            txtdescrip.Clear();
        }

        private void dtgtattoo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dtgtattoo.Columns[e.ColumnIndex].Name;
            if (colname == "edit")
            {
                txtid.Text = dtgtattoo.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtid.Visible = false;
                txtname.Text = dtgtattoo.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtprice.Text = dtgtattoo.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtimage.Text = dtgtattoo.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtdescrip.Text = dtgtattoo.Rows[e.RowIndex].Cells[4].Value.ToString();
                
                cbcate.SelectedValue = dtgtattoo.Rows[e.RowIndex].Cells[5].ValueType.ToString();
            }
            else if (colname == "delete")
            {
                int idDele = Convert.ToInt32(dtgtattoo.Rows[e.RowIndex].Cells[0].Value.ToString());
                tattooservice.DeleteTattoo(idDele);
                dtgtattoo.Rows.Clear();
                loadTattoo();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                TattooImg updateTattoo = new TattooImg();
                updateTattoo.Name = txtname.Text;
                updateTattoo.Price = Convert.ToDecimal(txtprice.Text);
                updateTattoo.Image = txtimage.Text;
                updateTattoo.CateId = Convert.ToInt32(cbcate.SelectedValue.ToString());
                tattooservice.UpdateTattoo(updateTattoo, Convert.ToInt32(txtid.Text));
                dtgtattoo.Rows.Clear();
                loadTattoo();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TattooimageManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
