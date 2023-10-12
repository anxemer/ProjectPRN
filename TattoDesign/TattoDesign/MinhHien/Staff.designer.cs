namespace TattoDesign
{
    partial class Staff
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
            this.components = new System.ComponentModel.Container();
            this.tpWorkSchedule = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.view_WorkSchedule = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tpInfo = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.picture_staff = new System.Windows.Forms.PictureBox();
            this.tcStaff = new System.Windows.Forms.TabControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_image = new System.Windows.Forms.TextBox();
            this.btn_BrowseImage = new System.Windows.Forms.Button();
            this.label_Info = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Address = new System.Windows.Forms.Label();
            this.label_Experience = new System.Windows.Forms.Label();
            this.label_Information = new System.Windows.Forms.Label();
            this.label_Phone = new System.Windows.Forms.Label();
            this.tpWorkSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_WorkSchedule)).BeginInit();
            this.panel1.SuspendLayout();
            this.tpInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_staff)).BeginInit();
            this.tcStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpWorkSchedule
            // 
            this.tpWorkSchedule.Controls.Add(this.richTextBox1);
            this.tpWorkSchedule.Controls.Add(this.label2);
            this.tpWorkSchedule.Controls.Add(this.view_WorkSchedule);
            this.tpWorkSchedule.Controls.Add(this.panel1);
            this.tpWorkSchedule.Location = new System.Drawing.Point(4, 22);
            this.tpWorkSchedule.Name = "tpWorkSchedule";
            this.tpWorkSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tpWorkSchedule.Size = new System.Drawing.Size(768, 569);
            this.tpWorkSchedule.TabIndex = 1;
            this.tpWorkSchedule.Text = "WorkSchedule";
            this.tpWorkSchedule.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(123, 496);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(639, 43);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 497);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Notes/Comments";
            // 
            // view_WorkSchedule
            // 
            this.view_WorkSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_WorkSchedule.Location = new System.Drawing.Point(6, 98);
            this.view_WorkSchedule.Name = "view_WorkSchedule";
            this.view_WorkSchedule.Size = new System.Drawing.Size(756, 369);
            this.view_WorkSchedule.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(144, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 55);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TATTOO ARTIST WORK SCHEDULE";
            // 
            // tpInfo
            // 
            this.tpInfo.Controls.Add(this.btn_Cancel);
            this.tpInfo.Controls.Add(this.txt_image);
            this.tpInfo.Controls.Add(this.panel2);
            this.tpInfo.Controls.Add(this.btn_Save);
            this.tpInfo.Controls.Add(this.label_Info);
            this.tpInfo.Controls.Add(this.btn_BrowseImage);
            this.tpInfo.Controls.Add(this.picture_staff);
            this.tpInfo.Location = new System.Drawing.Point(4, 22);
            this.tpInfo.Name = "tpInfo";
            this.tpInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpInfo.Size = new System.Drawing.Size(768, 569);
            this.tpInfo.TabIndex = 0;
            this.tpInfo.Text = "Infomation";
            this.tpInfo.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_Phone);
            this.panel2.Controls.Add(this.label_Information);
            this.panel2.Controls.Add(this.label_Experience);
            this.panel2.Controls.Add(this.label_Address);
            this.panel2.Controls.Add(this.label_Email);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(283, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 218);
            this.panel2.TabIndex = 16;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Cancel.Location = new System.Drawing.Point(130, 326);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 18;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Save.Location = new System.Drawing.Point(49, 326);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 17;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Phone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Experience:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(23, 81);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(72, 15);
            this.label25.TabIndex = 6;
            this.label25.Text = "Information:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(23, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 15);
            this.label15.TabIndex = 5;
            this.label15.Text = "Address:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 9);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(42, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Email:";
            // 
            // picture_staff
            // 
            this.picture_staff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_staff.Location = new System.Drawing.Point(6, 6);
            this.picture_staff.Name = "picture_staff";
            this.picture_staff.Size = new System.Drawing.Size(257, 259);
            this.picture_staff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_staff.TabIndex = 1;
            this.picture_staff.TabStop = false;
            // 
            // tcStaff
            // 
            this.tcStaff.Controls.Add(this.tpInfo);
            this.tcStaff.Controls.Add(this.tpWorkSchedule);
            this.tcStaff.Location = new System.Drawing.Point(12, 12);
            this.tcStaff.Name = "tcStaff";
            this.tcStaff.SelectedIndex = 0;
            this.tcStaff.Size = new System.Drawing.Size(776, 595);
            this.tcStaff.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_image
            // 
            this.txt_image.Location = new System.Drawing.Point(79, 271);
            this.txt_image.Name = "txt_image";
            this.txt_image.Size = new System.Drawing.Size(100, 20);
            this.txt_image.TabIndex = 17;
            this.txt_image.TextChanged += new System.EventHandler(this.txt_image_TextChanged);
            // 
            // btn_BrowseImage
            // 
            this.btn_BrowseImage.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BrowseImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_BrowseImage.Location = new System.Drawing.Point(91, 297);
            this.btn_BrowseImage.Name = "btn_BrowseImage";
            this.btn_BrowseImage.Size = new System.Drawing.Size(75, 23);
            this.btn_BrowseImage.TabIndex = 2;
            this.btn_BrowseImage.Text = "Browse";
            this.btn_BrowseImage.UseVisualStyleBackColor = true;
            this.btn_BrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Info.Location = new System.Drawing.Point(269, 6);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(169, 24);
            this.label_Info.TabIndex = 4;
            this.label_Info.Text = "Staff Information";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email.Location = new System.Drawing.Point(134, 9);
            this.label_Email.Name = "label_Email";
            this.label_Email.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Email.Size = new System.Drawing.Size(39, 15);
            this.label_Email.TabIndex = 13;
            this.label_Email.Text = "Email";
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Address.Location = new System.Drawing.Point(134, 45);
            this.label_Address.Name = "label_Address";
            this.label_Address.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Address.Size = new System.Drawing.Size(46, 15);
            this.label_Address.TabIndex = 14;
            this.label_Address.Text = "Adress";
            // 
            // label_Experience
            // 
            this.label_Experience.AutoSize = true;
            this.label_Experience.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Experience.Location = new System.Drawing.Point(134, 117);
            this.label_Experience.Name = "label_Experience";
            this.label_Experience.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Experience.Size = new System.Drawing.Size(68, 15);
            this.label_Experience.TabIndex = 15;
            this.label_Experience.Text = "Experience";
            // 
            // label_Information
            // 
            this.label_Information.AutoSize = true;
            this.label_Information.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Information.Location = new System.Drawing.Point(134, 81);
            this.label_Information.Name = "label_Information";
            this.label_Information.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Information.Size = new System.Drawing.Size(69, 15);
            this.label_Information.TabIndex = 16;
            this.label_Information.Text = "Information";
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Phone.Location = new System.Drawing.Point(134, 156);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Phone.Size = new System.Drawing.Size(43, 15);
            this.label_Phone.TabIndex = 17;
            this.label_Phone.Text = "Phone";
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 633);
            this.Controls.Add(this.tcStaff);
            this.Name = "Staff";
            this.Text = "Staff";
            this.tpWorkSchedule.ResumeLayout(false);
            this.tpWorkSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_WorkSchedule)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tpInfo.ResumeLayout(false);
            this.tpInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_staff)).EndInit();
            this.tcStaff.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpWorkSchedule;
        private System.Windows.Forms.TabPage tpInfo;
        private System.Windows.Forms.TabControl tcStaff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView view_WorkSchedule;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox picture_staff;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_image;
        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.Button btn_BrowseImage;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.Label label_Information;
        private System.Windows.Forms.Label label_Experience;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.Label label_Email;
    }
}