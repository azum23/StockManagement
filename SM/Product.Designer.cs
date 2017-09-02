namespace SM
{
    partial class Product
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
            this.label1 = new System.Windows.Forms.Label();
            this.txb_ProductCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_ProdName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbox_Status = new System.Windows.Forms.ComboBox();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.btn_DeleteProduct = new System.Windows.Forms.Button();
            this.dgv_Products = new System.Windows.Forms.DataGridView();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Products)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Code";
            // 
            // txb_ProductCode
            // 
            this.txb_ProductCode.Location = new System.Drawing.Point(15, 29);
            this.txb_ProductCode.Name = "txb_ProductCode";
            this.txb_ProductCode.Size = new System.Drawing.Size(126, 20);
            this.txb_ProductCode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(147, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product Name";
            // 
            // txb_ProdName
            // 
            this.txb_ProdName.Location = new System.Drawing.Point(150, 29);
            this.txb_ProdName.Name = "txb_ProdName";
            this.txb_ProdName.Size = new System.Drawing.Size(209, 20);
            this.txb_ProdName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(365, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Status";
            // 
            // cbox_Status
            // 
            this.cbox_Status.FormattingEnabled = true;
            this.cbox_Status.Items.AddRange(new object[] {
            "Active",
            "Deactive"});
            this.cbox_Status.Location = new System.Drawing.Point(368, 29);
            this.cbox_Status.Name = "cbox_Status";
            this.cbox_Status.Size = new System.Drawing.Size(150, 21);
            this.cbox_Status.TabIndex = 3;
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.Location = new System.Drawing.Point(540, 29);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(99, 36);
            this.btn_AddProduct.TabIndex = 4;
            this.btn_AddProduct.Text = "Add Product";
            this.btn_AddProduct.UseVisualStyleBackColor = true;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // btn_DeleteProduct
            // 
            this.btn_DeleteProduct.Location = new System.Drawing.Point(645, 29);
            this.btn_DeleteProduct.Name = "btn_DeleteProduct";
            this.btn_DeleteProduct.Size = new System.Drawing.Size(99, 36);
            this.btn_DeleteProduct.TabIndex = 5;
            this.btn_DeleteProduct.Text = "Delete Product";
            this.btn_DeleteProduct.UseVisualStyleBackColor = true;
            // 
            // dgv_Products
            // 
            this.dgv_Products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCode,
            this.ProductName,
            this.Status});
            this.dgv_Products.Location = new System.Drawing.Point(15, 71);
            this.dgv_Products.Name = "dgv_Products";
            this.dgv_Products.Size = new System.Drawing.Size(729, 305);
            this.dgv_Products.TabIndex = 6;
            // 
            // ProductCode
            // 
            this.ProductCode.HeaderText = "Product Code";
            this.ProductCode.Name = "ProductCode";
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 388);
            this.Controls.Add(this.dgv_Products);
            this.Controls.Add(this.btn_DeleteProduct);
            this.Controls.Add(this.btn_AddProduct);
            this.Controls.Add(this.cbox_Status);
            this.Controls.Add(this.txb_ProdName);
            this.Controls.Add(this.txb_ProductCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_ProductCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_ProdName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbox_Status;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.Button btn_DeleteProduct;
        private System.Windows.Forms.DataGridView dgv_Products;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}