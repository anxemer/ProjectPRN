namespace TattoDesign.AnXemer
{
    partial class TattooDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TattooDetail));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            txtprice = new Label();
            txtdesctip = new Label();
            label6 = new Label();
            label7 = new Label();
            txtname = new Label();
            label8 = new Label();
            button1 = new Button();
            tattooimage = new PictureBox();
            txtusername = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tattooimage).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(txtusername);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
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
            pictureBox1.Location = new Point(447, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UD Digi Kyokasho NP-B", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(533, 34);
            label1.Name = "label1";
            label1.Size = new Size(202, 34);
            label1.TabIndex = 1;
            label1.Text = "Tattoo Shop";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(tattooimage);
            panel2.Location = new Point(12, 169);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1238, 758);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtprice);
            panel3.Controls.Add(txtdesctip);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txtname);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(553, 32);
            panel3.Name = "panel3";
            panel3.Size = new Size(645, 582);
            panel3.TabIndex = 4;
            // 
            // txtprice
            // 
            txtprice.AutoSize = true;
            txtprice.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtprice.ForeColor = Color.Black;
            txtprice.Location = new Point(135, 112);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(79, 31);
            txtprice.TabIndex = 3;
            txtprice.Text = "label9";
            // 
            // txtdesctip
            // 
            txtdesctip.AutoEllipsis = true;
            txtdesctip.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtdesctip.ForeColor = Color.Black;
            txtdesctip.Location = new Point(209, 177);
            txtdesctip.MaximumSize = new Size(500, 300);
            txtdesctip.Name = "txtdesctip";
            txtdesctip.Size = new Size(421, 300);
            txtdesctip.TabIndex = 3;
            txtdesctip.Text = "label9";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(8, 53);
            label6.Name = "label6";
            label6.Size = new Size(94, 31);
            label6.TabIndex = 1;
            label6.Text = "NAME :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(8, 112);
            label7.Name = "label7";
            label7.Size = new Size(88, 31);
            label7.TabIndex = 1;
            label7.Text = "PRICE :";
            // 
            // txtname
            // 
            txtname.AutoSize = true;
            txtname.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtname.ForeColor = Color.Black;
            txtname.Location = new Point(135, 58);
            txtname.Name = "txtname";
            txtname.Size = new Size(79, 31);
            txtname.TabIndex = 3;
            txtname.Text = "label9";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(11, 177);
            label8.Name = "label8";
            label8.Size = new Size(173, 31);
            label8.TabIndex = 1;
            label8.Text = "DESCRIPTION :";
            // 
            // button1
            // 
            button1.Location = new Point(1015, 648);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(193, 71);
            button1.TabIndex = 2;
            button1.Text = "Book";
            button1.UseVisualStyleBackColor = true;
            // 
            // tattooimage
            // 
            tattooimage.Location = new Point(28, 32);
            tattooimage.Margin = new Padding(3, 4, 3, 4);
            tattooimage.Name = "tattooimage";
            tattooimage.Size = new Size(425, 582);
            tattooimage.SizeMode = PictureBoxSizeMode.StretchImage;
            tattooimage.TabIndex = 0;
            tattooimage.TabStop = false;
            // 
            // txtusername
            // 
            txtusername.AutoSize = true;
            txtusername.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtusername.Location = new Point(22, 34);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(79, 31);
            txtusername.TabIndex = 13;
            txtusername.Text = "label2";
            // 
            // TattooDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1262, 941);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TattooDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TattooDetail";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tattooimage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button button1;
        private Label label8;
        private Label label7;
        private Label label6;
        private PictureBox tattooimage;
        private Label txtdesctip;
        private Label txtprice;
        private Label txtname;
        private Panel panel3;
        public Label txtusername;
    }
}