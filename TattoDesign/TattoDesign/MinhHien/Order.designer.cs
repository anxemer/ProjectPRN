namespace TattoDesign
{
    partial class Order
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
            this.label_Order = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_Order = new System.Windows.Forms.ComboBox();
            this.label_Sort = new System.Windows.Forms.Label();
            this.label_Record = new System.Windows.Forms.Label();
            this.view_Order = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_Order)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Order
            // 
            this.label_Order.AutoSize = true;
            this.label_Order.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Order.Location = new System.Drawing.Point(3, 22);
            this.label_Order.Name = "label_Order";
            this.label_Order.Size = new System.Drawing.Size(72, 23);
            this.label_Order.TabIndex = 0;
            this.label_Order.Text = "Orders";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_Order);
            this.panel1.Controls.Add(this.label_Sort);
            this.panel1.Controls.Add(this.label_Order);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 75);
            this.panel1.TabIndex = 1;
            // 
            // cb_Order
            // 
            this.cb_Order.FormattingEnabled = true;
            this.cb_Order.Items.AddRange(new object[] {
            "Total $",
            "Customer",
            "Date"});
            this.cb_Order.Location = new System.Drawing.Point(208, 29);
            this.cb_Order.Name = "cb_Order";
            this.cb_Order.Size = new System.Drawing.Size(121, 21);
            this.cb_Order.TabIndex = 2;
            this.cb_Order.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label_Sort
            // 
            this.label_Sort.AutoSize = true;
            this.label_Sort.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Sort.Location = new System.Drawing.Point(157, 29);
            this.label_Sort.Name = "label_Sort";
            this.label_Sort.Size = new System.Drawing.Size(45, 15);
            this.label_Sort.TabIndex = 1;
            this.label_Sort.Text = "Sort By";
            // 
            // label_Record
            // 
            this.label_Record.AutoSize = true;
            this.label_Record.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Record.Location = new System.Drawing.Point(46, 121);
            this.label_Record.Name = "label_Record";
            this.label_Record.Size = new System.Drawing.Size(106, 15);
            this.label_Record.TabIndex = 2;
            this.label_Record.Text = "Amount of Record";
            // 
            // view_Order
            // 
            this.view_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_Order.Location = new System.Drawing.Point(12, 155);
            this.view_Order.Name = "view_Order";
            this.view_Order.Size = new System.Drawing.Size(725, 290);
            this.view_Order.TabIndex = 3;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.view_Order);
            this.Controls.Add(this.label_Record);
            this.Controls.Add(this.panel1);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_Order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Order;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Record;
        private System.Windows.Forms.DataGridView view_Order;
        private System.Windows.Forms.Label label_Sort;
        private System.Windows.Forms.ComboBox cb_Order;

    }
}