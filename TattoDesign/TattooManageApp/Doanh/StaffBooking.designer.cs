namespace TattoDesign
{
    partial class staffbooking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staffbooking));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label1 = new Label();
            btnBooking = new Guna.UI2.WinForms.Guna2ImageButton();
            label4 = new Label();
            label3 = new Label();
            btnArtists = new Guna.UI2.WinForms.Guna2ImageButton();
            btmHomePage = new Guna.UI2.WinForms.Guna2ImageButton();
            label2 = new Label();
            btnTattoo = new Guna.UI2.WinForms.Guna2ImageButton();
            staffimage = new ImageList(components);
            panel2 = new Panel();
            lvstaff = new ListView();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            txtusn = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnBooking);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnArtists);
            panel1.Controls.Add(btmHomePage);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnTattoo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 116);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(1066, 81);
            label5.Name = "label5";
            label5.Size = new Size(77, 22);
            label5.TabIndex = 8;
            label5.Text = "Booking";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UD Digi Kyokasho NP-B", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(107, 31);
            label1.Name = "label1";
            label1.Size = new Size(202, 34);
            label1.TabIndex = 1;
            label1.Text = "Tattoo Shop";
            // 
            // btnBooking
            // 
            btnBooking.CheckedState.ImageSize = new Size(64, 64);
            btnBooking.HoverState.Image = (Image)resources.GetObject("resource.Image");
            btnBooking.HoverState.ImageSize = new Size(40, 40);
            btnBooking.Image = (Image)resources.GetObject("btnBooking.Image");
            btnBooking.ImageOffset = new Point(0, 0);
            btnBooking.ImageRotate = 0F;
            btnBooking.ImageSize = new Size(40, 40);
            btnBooking.Location = new Point(1070, 15);
            btnBooking.Margin = new Padding(3, 4, 3, 4);
            btnBooking.Name = "btnBooking";
            btnBooking.PressedState.ImageSize = new Size(64, 64);
            btnBooking.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnBooking.Size = new Size(60, 75);
            btnBooking.TabIndex = 4;
            btnBooking.Click += btnBooking_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(916, 81);
            label4.Name = "label4";
            label4.Size = new Size(67, 22);
            label4.TabIndex = 9;
            label4.Text = "Artists";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(741, 81);
            label3.Name = "label3";
            label3.Size = new Size(64, 22);
            label3.TabIndex = 10;
            label3.Text = "Tattoo";
            // 
            // btnArtists
            // 
            btnArtists.CheckedState.ImageSize = new Size(64, 64);
            btnArtists.Enabled = false;
            btnArtists.HoverState.Image = (Image)resources.GetObject("resource.Image1");
            btnArtists.HoverState.ImageSize = new Size(40, 40);
            btnArtists.Image = (Image)resources.GetObject("btnArtists.Image");
            btnArtists.ImageOffset = new Point(0, 0);
            btnArtists.ImageRotate = 0F;
            btnArtists.ImageSize = new Size(40, 40);
            btnArtists.Location = new Point(920, 15);
            btnArtists.Margin = new Padding(3, 4, 3, 4);
            btnArtists.Name = "btnArtists";
            btnArtists.PressedState.ImageSize = new Size(64, 64);
            btnArtists.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnArtists.Size = new Size(60, 75);
            btnArtists.TabIndex = 5;
            // 
            // btmHomePage
            // 
            btmHomePage.CheckedState.ImageSize = new Size(64, 64);
            btmHomePage.HoverState.Image = (Image)resources.GetObject("resource.Image2");
            btmHomePage.HoverState.ImageSize = new Size(40, 40);
            btmHomePage.Image = (Image)resources.GetObject("btmHomePage.Image");
            btmHomePage.ImageOffset = new Point(0, 0);
            btmHomePage.ImageRotate = 0F;
            btmHomePage.ImageSize = new Size(40, 40);
            btmHomePage.Location = new Point(565, 15);
            btmHomePage.Margin = new Padding(3, 4, 3, 4);
            btmHomePage.Name = "btmHomePage";
            btmHomePage.PressedState.ImageSize = new Size(64, 64);
            btmHomePage.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btmHomePage.Size = new Size(60, 75);
            btmHomePage.TabIndex = 7;
            btmHomePage.Click += btmHomePage_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(540, 81);
            label2.Name = "label2";
            label2.Size = new Size(99, 22);
            label2.TabIndex = 11;
            label2.Text = "HomePage";
            // 
            // btnTattoo
            // 
            btnTattoo.CheckedState.ImageSize = new Size(64, 64);
            btnTattoo.HoverState.Image = (Image)resources.GetObject("resource.Image3");
            btnTattoo.HoverState.ImageSize = new Size(40, 40);
            btnTattoo.Image = (Image)resources.GetObject("btnTattoo.Image");
            btnTattoo.ImageOffset = new Point(0, 0);
            btnTattoo.ImageRotate = 0F;
            btnTattoo.ImageSize = new Size(40, 40);
            btnTattoo.Location = new Point(745, 15);
            btnTattoo.Margin = new Padding(3, 4, 3, 4);
            btnTattoo.Name = "btnTattoo";
            btnTattoo.PressedState.ImageSize = new Size(64, 64);
            btnTattoo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnTattoo.Size = new Size(60, 75);
            btnTattoo.TabIndex = 6;
            btnTattoo.Click += btnTattoo_Click;
            // 
            // staffimage
            // 
            staffimage.ColorDepth = ColorDepth.Depth8Bit;
            staffimage.ImageSize = new Size(150, 150);
            staffimage.TransparentColor = Color.Transparent;
            // 
            // panel2
            // 
            panel2.Controls.Add(lvstaff);
            panel2.Location = new Point(12, 209);
            panel2.Name = "panel2";
            panel2.Size = new Size(1238, 720);
            panel2.TabIndex = 2;
            // 
            // lvstaff
            // 
            lvstaff.Dock = DockStyle.Fill;
            lvstaff.LargeImageList = staffimage;
            lvstaff.Location = new Point(0, 0);
            lvstaff.Name = "lvstaff";
            lvstaff.Size = new Size(1238, 720);
            lvstaff.TabIndex = 0;
            lvstaff.UseCompatibleStateImageBehavior = false;
            lvstaff.MouseDoubleClick += lvstaff_MouseDoubleClick;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.BorderRadius = 20;
            txtSearch.Cursor = Cursors.IBeam;
            txtSearch.CustomizableEdges = customizableEdges5;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.IconLeft = (Image)resources.GetObject("txtSearch.IconLeft");
            txtSearch.IconLeftSize = new Size(35, 35);
            txtSearch.Location = new Point(898, 125);
            txtSearch.Margin = new Padding(3, 5, 3, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderText = "SEARCH";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtSearch.Size = new Size(352, 61);
            txtSearch.TabIndex = 3;
            // 
            // txtusn
            // 
            txtusn.AutoSize = true;
            txtusn.Location = new Point(12, 125);
            txtusn.Name = "txtusn";
            txtusn.Size = new Size(50, 20);
            txtusn.TabIndex = 4;
            txtusn.Text = "label6";
            txtusn.Visible = false;
            // 
            // staffbooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 941);
            Controls.Add(txtusn);
            Controls.Add(txtSearch);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "staffbooking";
            Text = "staffbooking";
            FormClosed += staffbooking_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton btnBooking;
        private Label label4;
        private Label label3;
        private Guna.UI2.WinForms.Guna2ImageButton btnArtists;
        private Guna.UI2.WinForms.Guna2ImageButton btmHomePage;
        private Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton btnTattoo;
        private PictureBox pictureBox1;
        private ImageList staffimage;
        private Panel panel2;
        private ListView lvstaff;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        public Label txtusn;
    }
}