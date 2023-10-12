namespace TattoDesign
{
    partial class OrderDetails
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
            this.view_OrderDetails = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_OrderID = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Order = new System.Windows.Forms.Label();
            this.label_Customer = new System.Windows.Forms.Label();
            this.btn_BackToOrder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.view_OrderDetails)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // view_OrderDetails
            // 
            this.view_OrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_OrderDetails.Location = new System.Drawing.Point(384, 68);
            this.view_OrderDetails.Name = "view_OrderDetails";
            this.view_OrderDetails.Size = new System.Drawing.Size(426, 382);
            this.view_OrderDetails.TabIndex = 0;
            this.view_OrderDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label_Total);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label_Date);
            this.panel1.Controls.Add(this.label_OrderID);
            this.panel1.Controls.Add(this.label_Name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_Order);
            this.panel1.Controls.Add(this.label_Customer);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 272);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Total.Location = new System.Drawing.Point(115, 162);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(55, 14);
            this.label_Total.TabIndex = 11;
            this.label_Total.Text = "TotalDetail";
            this.label_Total.Click += new System.EventHandler(this.label9_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date.Location = new System.Drawing.Point(115, 117);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(55, 14);
            this.label_Date.TabIndex = 8;
            this.label_Date.Text = "DateDetail";
            // 
            // label_OrderID
            // 
            this.label_OrderID.AutoSize = true;
            this.label_OrderID.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_OrderID.Location = new System.Drawing.Point(115, 68);
            this.label_OrderID.Name = "label_OrderID";
            this.label_OrderID.Size = new System.Drawing.Size(44, 14);
            this.label_OrderID.TabIndex = 7;
            this.label_OrderID.Text = "OrderID";
            this.label_OrderID.Click += new System.EventHandler(this.label_OrderID_Click);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(115, 24);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(38, 14);
            this.label_Name.TabIndex = 6;
            this.label_Name.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date";
            this.label1.Click += new System.EventHandler(this.label6_Click);
            // 
            // label_Order
            // 
            this.label_Order.AutoSize = true;
            this.label_Order.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Order.Location = new System.Drawing.Point(21, 68);
            this.label_Order.Name = "label_Order";
            this.label_Order.Size = new System.Drawing.Size(44, 14);
            this.label_Order.TabIndex = 4;
            this.label_Order.Text = "Order #";
            this.label_Order.Click += new System.EventHandler(this.label5_Click);
            // 
            // label_Customer
            // 
            this.label_Customer.AutoSize = true;
            this.label_Customer.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Customer.Location = new System.Drawing.Point(21, 24);
            this.label_Customer.Name = "label_Customer";
            this.label_Customer.Size = new System.Drawing.Size(63, 14);
            this.label_Customer.TabIndex = 0;
            this.label_Customer.Text = "Customer";
            this.label_Customer.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_BackToOrder
            // 
            this.btn_BackToOrder.Location = new System.Drawing.Point(12, 21);
            this.btn_BackToOrder.Name = "btn_BackToOrder";
            this.btn_BackToOrder.Size = new System.Drawing.Size(98, 23);
            this.btn_BackToOrder.TabIndex = 11;
            this.btn_BackToOrder.Text = "Back to Order";
            this.btn_BackToOrder.UseVisualStyleBackColor = true;
            this.btn_BackToOrder.Click += new System.EventHandler(this.btnBackToOrder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(590, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 12;
            // 
            // OrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_BackToOrder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.view_OrderDetails);
            this.Name = "OrderDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderDetails";
            this.Load += new System.EventHandler(this.OrderDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view_OrderDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView view_OrderDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Customer;
        private System.Windows.Forms.Label label_OrderID;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Order;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Button btn_BackToOrder;
        private System.Windows.Forms.Label label4;
    }
}