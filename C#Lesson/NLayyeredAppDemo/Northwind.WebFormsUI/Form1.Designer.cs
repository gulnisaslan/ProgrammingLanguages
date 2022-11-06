
namespace Northwind.WebFormsUI
{
    partial class Form1
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxProduct = new System.Windows.Forms.GroupBox();
            this.tbxProduct = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.cbxCategoryId = new System.Windows.Forms.ComboBox();
            this.tbxQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxStockAmount = new System.Windows.Forms.TextBox();
            this.lblQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblProdıuctName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCategoryAdd = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblProductNameUpdate = new System.Windows.Forms.Label();
            this.lblCategoryUpdate = new System.Windows.Forms.Label();
            this.lblUnitPriceUpdate = new System.Windows.Forms.Label();
            this.tbxProductNameUpdate = new System.Windows.Forms.TextBox();
            this.gbxUpdateProduct = new System.Windows.Forms.GroupBox();
            this.cbxCategoryIdUpdate = new System.Windows.Forms.ComboBox();
            this.tbxOunatityPerUnitUpdate = new System.Windows.Forms.TextBox();
            this.tbxstockAmountUpdate = new System.Windows.Forms.TextBox();
            this.lblQuantityPerUnitUpdate = new System.Windows.Forms.Label();
            this.lbStockAmount = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxProduct.SuspendLayout();
            this.gbxProductAdd.SuspendLayout();
            this.gbxUpdateProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(26, 267);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(781, 296);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Location = new System.Drawing.Point(36, 17);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(292, 89);
            this.gbxCategory.TabIndex = 1;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye göre ara";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(82, 27);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(182, 21);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(11, 27);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(46, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori";
            // 
            // gbxProduct
            // 
            this.gbxProduct.Controls.Add(this.tbxProduct);
            this.gbxProduct.Controls.Add(this.lblProduct);
            this.gbxProduct.Location = new System.Drawing.Point(36, 129);
            this.gbxProduct.Name = "gbxProduct";
            this.gbxProduct.Size = new System.Drawing.Size(285, 114);
            this.gbxProduct.TabIndex = 2;
            this.gbxProduct.TabStop = false;
            this.gbxProduct.Text = "Ürün adına göre ara";
            // 
            // tbxProduct
            // 
            this.tbxProduct.Location = new System.Drawing.Point(82, 44);
            this.tbxProduct.Name = "tbxProduct";
            this.tbxProduct.Size = new System.Drawing.Size(197, 20);
            this.tbxProduct.TabIndex = 1;
            this.tbxProduct.TextChanged += new System.EventHandler(this.tbxProduct_TextChanged);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(11, 51);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(48, 13);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Ürün Adı";
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Controls.Add(this.cbxCategoryId);
            this.gbxProductAdd.Controls.Add(this.tbxQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.tbxStockAmount);
            this.gbxProductAdd.Controls.Add(this.lblQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.lblStock);
            this.gbxProductAdd.Controls.Add(this.lblProdıuctName);
            this.gbxProductAdd.Controls.Add(this.btnAdd);
            this.gbxProductAdd.Controls.Add(this.tbxUnitPrice);
            this.gbxProductAdd.Controls.Add(this.tbxProductName);
            this.gbxProductAdd.Controls.Add(this.label6);
            this.gbxProductAdd.Controls.Add(this.lblCategoryAdd);
            this.gbxProductAdd.Controls.Add(this.lblUnitPrice);
            this.gbxProductAdd.Location = new System.Drawing.Point(12, 569);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Size = new System.Drawing.Size(330, 267);
            this.gbxProductAdd.TabIndex = 3;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Yeni Ürün Ekle";
            // 
            // cbxCategoryId
            // 
            this.cbxCategoryId.FormattingEnabled = true;
            this.cbxCategoryId.Location = new System.Drawing.Point(89, 78);
            this.cbxCategoryId.Name = "cbxCategoryId";
            this.cbxCategoryId.Size = new System.Drawing.Size(218, 21);
            this.cbxCategoryId.TabIndex = 8;
            // 
            // tbxQuantityPerUnit
            // 
            this.tbxQuantityPerUnit.Location = new System.Drawing.Point(89, 164);
            this.tbxQuantityPerUnit.Name = "tbxQuantityPerUnit";
            this.tbxQuantityPerUnit.Size = new System.Drawing.Size(220, 20);
            this.tbxQuantityPerUnit.TabIndex = 12;
            // 
            // tbxStockAmount
            // 
            this.tbxStockAmount.Location = new System.Drawing.Point(89, 134);
            this.tbxStockAmount.Name = "tbxStockAmount";
            this.tbxStockAmount.Size = new System.Drawing.Size(220, 20);
            this.tbxStockAmount.TabIndex = 11;
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.AutoSize = true;
            this.lblQuantityPerUnit.Location = new System.Drawing.Point(21, 164);
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Size = new System.Drawing.Size(59, 13);
            this.lblQuantityPerUnit.TabIndex = 10;
            this.lblQuantityPerUnit.Text = "Birim Adedi";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(21, 134);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(59, 13);
            this.lblStock.TabIndex = 9;
            this.lblStock.Text = "Stok Adedi";
            // 
            // lblProdıuctName
            // 
            this.lblProdıuctName.AutoSize = true;
            this.lblProdıuctName.Location = new System.Drawing.Point(21, 44);
            this.lblProdıuctName.Name = "lblProdıuctName";
            this.lblProdıuctName.Size = new System.Drawing.Size(47, 13);
            this.lblProdıuctName.TabIndex = 8;
            this.lblProdıuctName.Text = "Ürün adı";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(177, 222);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 25);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(89, 105);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(220, 20);
            this.tbxUnitPrice.TabIndex = 7;
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(89, 41);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(218, 20);
            this.tbxProductName.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 3;
            // 
            // lblCategoryAdd
            // 
            this.lblCategoryAdd.AutoSize = true;
            this.lblCategoryAdd.Location = new System.Drawing.Point(21, 78);
            this.lblCategoryAdd.Name = "lblCategoryAdd";
            this.lblCategoryAdd.Size = new System.Drawing.Size(46, 13);
            this.lblCategoryAdd.TabIndex = 2;
            this.lblCategoryAdd.Text = "Kategori";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(21, 105);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(54, 13);
            this.lblUnitPrice.TabIndex = 1;
            this.lblUnitPrice.Text = "Ürün fiyatı";
            // 
            // lblProductNameUpdate
            // 
            this.lblProductNameUpdate.AutoSize = true;
            this.lblProductNameUpdate.Location = new System.Drawing.Point(20, 34);
            this.lblProductNameUpdate.Name = "lblProductNameUpdate";
            this.lblProductNameUpdate.Size = new System.Drawing.Size(47, 13);
            this.lblProductNameUpdate.TabIndex = 0;
            this.lblProductNameUpdate.Text = "Ürün adı";
            // 
            // lblCategoryUpdate
            // 
            this.lblCategoryUpdate.AutoSize = true;
            this.lblCategoryUpdate.Location = new System.Drawing.Point(20, 64);
            this.lblCategoryUpdate.Name = "lblCategoryUpdate";
            this.lblCategoryUpdate.Size = new System.Drawing.Size(46, 13);
            this.lblCategoryUpdate.TabIndex = 1;
            this.lblCategoryUpdate.Text = "Kategori";
            // 
            // lblUnitPriceUpdate
            // 
            this.lblUnitPriceUpdate.AutoSize = true;
            this.lblUnitPriceUpdate.Location = new System.Drawing.Point(20, 96);
            this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            this.lblUnitPriceUpdate.Size = new System.Drawing.Size(54, 13);
            this.lblUnitPriceUpdate.TabIndex = 2;
            this.lblUnitPriceUpdate.Text = "Ürün fiyatı";
            // 
            // tbxProductNameUpdate
            // 
            this.tbxProductNameUpdate.Location = new System.Drawing.Point(79, 27);
            this.tbxProductNameUpdate.Name = "tbxProductNameUpdate";
            this.tbxProductNameUpdate.Size = new System.Drawing.Size(218, 20);
            this.tbxProductNameUpdate.TabIndex = 3;
            // 
            // gbxUpdateProduct
            // 
            this.gbxUpdateProduct.Controls.Add(this.cbxCategoryIdUpdate);
            this.gbxUpdateProduct.Controls.Add(this.tbxOunatityPerUnitUpdate);
            this.gbxUpdateProduct.Controls.Add(this.tbxstockAmountUpdate);
            this.gbxUpdateProduct.Controls.Add(this.lblQuantityPerUnitUpdate);
            this.gbxUpdateProduct.Controls.Add(this.lbStockAmount);
            this.gbxUpdateProduct.Controls.Add(this.btnUpdate);
            this.gbxUpdateProduct.Controls.Add(this.tbxUnitPriceUpdate);
            this.gbxUpdateProduct.Controls.Add(this.tbxProductNameUpdate);
            this.gbxUpdateProduct.Controls.Add(this.lblUnitPriceUpdate);
            this.gbxUpdateProduct.Controls.Add(this.lblCategoryUpdate);
            this.gbxUpdateProduct.Controls.Add(this.lblProductNameUpdate);
            this.gbxUpdateProduct.Location = new System.Drawing.Point(473, 578);
            this.gbxUpdateProduct.Name = "gbxUpdateProduct";
            this.gbxUpdateProduct.Size = new System.Drawing.Size(316, 247);
            this.gbxUpdateProduct.TabIndex = 4;
            this.gbxUpdateProduct.TabStop = false;
            this.gbxUpdateProduct.Text = "Ürün Güncelle";
            // 
            // cbxCategoryIdUpdate
            // 
            this.cbxCategoryIdUpdate.FormattingEnabled = true;
            this.cbxCategoryIdUpdate.Location = new System.Drawing.Point(79, 61);
            this.cbxCategoryIdUpdate.Name = "cbxCategoryIdUpdate";
            this.cbxCategoryIdUpdate.Size = new System.Drawing.Size(218, 21);
            this.cbxCategoryIdUpdate.TabIndex = 11;
            // 
            // tbxOunatityPerUnitUpdate
            // 
            this.tbxOunatityPerUnitUpdate.Location = new System.Drawing.Point(79, 151);
            this.tbxOunatityPerUnitUpdate.Name = "tbxOunatityPerUnitUpdate";
            this.tbxOunatityPerUnitUpdate.Size = new System.Drawing.Size(218, 20);
            this.tbxOunatityPerUnitUpdate.TabIndex = 10;
            // 
            // tbxstockAmountUpdate
            // 
            this.tbxstockAmountUpdate.Location = new System.Drawing.Point(79, 119);
            this.tbxstockAmountUpdate.Name = "tbxstockAmountUpdate";
            this.tbxstockAmountUpdate.Size = new System.Drawing.Size(218, 20);
            this.tbxstockAmountUpdate.TabIndex = 9;
            // 
            // lblQuantityPerUnitUpdate
            // 
            this.lblQuantityPerUnitUpdate.AutoSize = true;
            this.lblQuantityPerUnitUpdate.Location = new System.Drawing.Point(20, 158);
            this.lblQuantityPerUnitUpdate.Name = "lblQuantityPerUnitUpdate";
            this.lblQuantityPerUnitUpdate.Size = new System.Drawing.Size(58, 13);
            this.lblQuantityPerUnitUpdate.TabIndex = 8;
            this.lblQuantityPerUnitUpdate.Text = "Birim adedi";
            // 
            // lbStockAmount
            // 
            this.lbStockAmount.AutoSize = true;
            this.lbStockAmount.Location = new System.Drawing.Point(20, 126);
            this.lbStockAmount.Name = "lbStockAmount";
            this.lbStockAmount.Size = new System.Drawing.Size(59, 13);
            this.lbStockAmount.TabIndex = 7;
            this.lbStockAmount.Text = "Stok Adedi";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(199, 216);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 25);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxUnitPriceUpdate
            // 
            this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(79, 88);
            this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(218, 20);
            this.tbxUnitPriceUpdate.TabIndex = 5;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(698, 44);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(130, 43);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 913);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxUpdateProduct);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.gbxProduct);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxProduct.ResumeLayout(false);
            this.gbxProduct.PerformLayout();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.gbxUpdateProduct.ResumeLayout(false);
            this.gbxUpdateProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxProduct;
        private System.Windows.Forms.TextBox tbxProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCategoryAdd;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblProductNameUpdate;
        private System.Windows.Forms.Label lblCategoryUpdate;
        private System.Windows.Forms.Label lblUnitPriceUpdate;
        private System.Windows.Forms.TextBox tbxProductNameUpdate;
        private System.Windows.Forms.GroupBox gbxUpdateProduct;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox tbxQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxStockAmount;
        private System.Windows.Forms.Label lblQuantityPerUnit;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblProdıuctName;
        private System.Windows.Forms.ComboBox cbxCategoryId;
        private System.Windows.Forms.ComboBox cbxCategoryIdUpdate;
        private System.Windows.Forms.TextBox tbxOunatityPerUnitUpdate;
        private System.Windows.Forms.TextBox tbxstockAmountUpdate;
        private System.Windows.Forms.Label lblQuantityPerUnitUpdate;
        private System.Windows.Forms.Label lbStockAmount;
    }
}

