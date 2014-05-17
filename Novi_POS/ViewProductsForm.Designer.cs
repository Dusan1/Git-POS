namespace Novi_POS
{
    partial class ViewProductsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.btnViewAllProducts = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.btnAddNewCategory = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.cmbSelectCategory = new System.Windows.Forms.ComboBox();
            this.lblSelectCategory = new System.Windows.Forms.Label();
            this.gbAddProduct = new System.Windows.Forms.GroupBox();
            this.gbAddCategory = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.gbAddProduct.SuspendLayout();
            this.gbAddCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(490, 387);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(12, 24);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(161, 21);
            this.cmbCategories.TabIndex = 1;
            this.cmbCategories.SelectionChangeCommitted += new System.EventHandler(this.cmbCategories_SelectionChangeCommitted);
            // 
            // btnViewAllProducts
            // 
            this.btnViewAllProducts.Location = new System.Drawing.Point(194, 24);
            this.btnViewAllProducts.Name = "btnViewAllProducts";
            this.btnViewAllProducts.Size = new System.Drawing.Size(75, 23);
            this.btnViewAllProducts.TabIndex = 2;
            this.btnViewAllProducts.Text = "All Products";
            this.btnViewAllProducts.UseVisualStyleBackColor = true;
            this.btnViewAllProducts.Click += new System.EventHandler(this.btnViewAllProducts_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(43, 32);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(80, 13);
            this.lblCategoryName.TabIndex = 15;
            this.lblCategoryName.Text = "Category Name";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(128, 29);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(134, 20);
            this.txtCategoryName.TabIndex = 16;
            // 
            // btnAddNewCategory
            // 
            this.btnAddNewCategory.Location = new System.Drawing.Point(128, 65);
            this.btnAddNewCategory.Name = "btnAddNewCategory";
            this.btnAddNewCategory.Size = new System.Drawing.Size(134, 27);
            this.btnAddNewCategory.TabIndex = 17;
            this.btnAddNewCategory.Text = "Add Category";
            this.btnAddNewCategory.UseVisualStyleBackColor = true;
            this.btnAddNewCategory.Click += new System.EventHandler(this.btnAddNewCategory_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(87, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(128, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(134, 20);
            this.txtName.TabIndex = 4;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(87, 72);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(127, 69);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(134, 20);
            this.txtPrice.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Upload an image";
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(129, 142);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(133, 132);
            this.pbImage.TabIndex = 8;
            this.pbImage.TabStop = false;
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Location = new System.Drawing.Point(128, 290);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(135, 29);
            this.btnAddNewProduct.TabIndex = 10;
            this.btnAddNewProduct.Text = "Add Product";
            this.btnAddNewProduct.UseVisualStyleBackColor = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Location = new System.Drawing.Point(57, 205);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(62, 33);
            this.btnUploadImage.TabIndex = 11;
            this.btnUploadImage.Text = "Upload";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // cmbSelectCategory
            // 
            this.cmbSelectCategory.FormattingEnabled = true;
            this.cmbSelectCategory.Location = new System.Drawing.Point(127, 104);
            this.cmbSelectCategory.Name = "cmbSelectCategory";
            this.cmbSelectCategory.Size = new System.Drawing.Size(136, 21);
            this.cmbSelectCategory.TabIndex = 12;
            // 
            // lblSelectCategory
            // 
            this.lblSelectCategory.AutoSize = true;
            this.lblSelectCategory.Location = new System.Drawing.Point(36, 107);
            this.lblSelectCategory.Name = "lblSelectCategory";
            this.lblSelectCategory.Size = new System.Drawing.Size(82, 13);
            this.lblSelectCategory.TabIndex = 13;
            this.lblSelectCategory.Text = "Select Category";
            // 
            // gbAddProduct
            // 
            this.gbAddProduct.Controls.Add(this.lblSelectCategory);
            this.gbAddProduct.Controls.Add(this.cmbSelectCategory);
            this.gbAddProduct.Controls.Add(this.btnUploadImage);
            this.gbAddProduct.Controls.Add(this.btnAddNewProduct);
            this.gbAddProduct.Controls.Add(this.pbImage);
            this.gbAddProduct.Controls.Add(this.label3);
            this.gbAddProduct.Controls.Add(this.txtPrice);
            this.gbAddProduct.Controls.Add(this.lblPrice);
            this.gbAddProduct.Controls.Add(this.txtName);
            this.gbAddProduct.Controls.Add(this.lblName);
            this.gbAddProduct.Location = new System.Drawing.Point(519, 3);
            this.gbAddProduct.Name = "gbAddProduct";
            this.gbAddProduct.Size = new System.Drawing.Size(280, 331);
            this.gbAddProduct.TabIndex = 18;
            this.gbAddProduct.TabStop = false;
            this.gbAddProduct.Text = "Add New Product";
            // 
            // gbAddCategory
            // 
            this.gbAddCategory.Controls.Add(this.btnAddNewCategory);
            this.gbAddCategory.Controls.Add(this.txtCategoryName);
            this.gbAddCategory.Controls.Add(this.lblCategoryName);
            this.gbAddCategory.Location = new System.Drawing.Point(519, 351);
            this.gbAddCategory.Name = "gbAddCategory";
            this.gbAddCategory.Size = new System.Drawing.Size(280, 101);
            this.gbAddCategory.TabIndex = 19;
            this.gbAddCategory.TabStop = false;
            this.gbAddCategory.Text = "Add New Category";
            // 
            // ViewProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 464);
            this.Controls.Add(this.gbAddCategory);
            this.Controls.Add(this.gbAddProduct);
            this.Controls.Add(this.btnViewAllProducts);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewProductsForm";
            this.Text = "ViewProductsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.gbAddProduct.ResumeLayout(false);
            this.gbAddProduct.PerformLayout();
            this.gbAddCategory.ResumeLayout(false);
            this.gbAddCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Button btnViewAllProducts;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Button btnAddNewCategory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.ComboBox cmbSelectCategory;
        private System.Windows.Forms.Label lblSelectCategory;
        private System.Windows.Forms.GroupBox gbAddProduct;
        private System.Windows.Forms.GroupBox gbAddCategory;
    }
}