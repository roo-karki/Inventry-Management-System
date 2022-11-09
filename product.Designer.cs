namespace Inventry_management_system
{
    partial class product
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
            this.groupProduct = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowHideDetails = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupProductList = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupStock = new System.Windows.Forms.GroupBox();
            this.textDamagedQuantity = new System.Windows.Forms.TextBox();
            this.textFreshQuantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupProductDetails = new System.Windows.Forms.GroupBox();
            this.textStock = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textCostPrice = new System.Windows.Forms.TextBox();
            this.textSellingPrice = new System.Windows.Forms.TextBox();
            this.textUnit = new System.Windows.Forms.TextBox();
            this.textProductName = new System.Windows.Forms.TextBox();
            this.textProductId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GvProductList = new System.Windows.Forms.DataGridView();
            this.groupProduct.SuspendLayout();
            this.groupProductList.SuspendLayout();
            this.groupStock.SuspendLayout();
            this.groupProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupProduct
            // 
            this.groupProduct.Controls.Add(this.label1);
            this.groupProduct.Controls.Add(this.btnShowHideDetails);
            this.groupProduct.Controls.Add(this.btnReset);
            this.groupProduct.Controls.Add(this.btnExport);
            this.groupProduct.Controls.Add(this.btnPrint);
            this.groupProduct.Controls.Add(this.btnEdit);
            this.groupProduct.Controls.Add(this.btnNew);
            this.groupProduct.Location = new System.Drawing.Point(12, 4);
            this.groupProduct.Name = "groupProduct";
            this.groupProduct.Size = new System.Drawing.Size(878, 121);
            this.groupProduct.TabIndex = 0;
            this.groupProduct.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Products";
            // 
            // btnShowHideDetails
            // 
            this.btnShowHideDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowHideDetails.Location = new System.Drawing.Point(676, 39);
            this.btnShowHideDetails.Name = "btnShowHideDetails";
            this.btnShowHideDetails.Size = new System.Drawing.Size(162, 73);
            this.btnShowHideDetails.TabIndex = 5;
            this.btnShowHideDetails.Text = "ShowHide Details";
            this.btnShowHideDetails.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(580, 39);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 43);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(479, 39);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(82, 43);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(372, 39);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 43);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(272, 41);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 41);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(169, 39);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 43);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // groupProductList
            // 
            this.groupProductList.Controls.Add(this.btnDelete);
            this.groupProductList.Controls.Add(this.btnSave);
            this.groupProductList.Controls.Add(this.groupStock);
            this.groupProductList.Controls.Add(this.groupProductDetails);
            this.groupProductList.Controls.Add(this.GvProductList);
            this.groupProductList.Location = new System.Drawing.Point(12, 143);
            this.groupProductList.Name = "groupProductList";
            this.groupProductList.Size = new System.Drawing.Size(1131, 413);
            this.groupProductList.TabIndex = 1;
            this.groupProductList.TabStop = false;
            this.groupProductList.Text = "Product List";
            this.groupProductList.Enter += new System.EventHandler(this.groupProductList_Enter);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(297, 285);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 63);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(87, 285);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 63);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupStock
            // 
            this.groupStock.Controls.Add(this.textDamagedQuantity);
            this.groupStock.Controls.Add(this.textFreshQuantity);
            this.groupStock.Controls.Add(this.label8);
            this.groupStock.Controls.Add(this.label7);
            this.groupStock.Location = new System.Drawing.Point(723, 285);
            this.groupStock.Name = "groupStock";
            this.groupStock.Size = new System.Drawing.Size(369, 107);
            this.groupStock.TabIndex = 2;
            this.groupStock.TabStop = false;
            this.groupStock.Text = "Stock";
            // 
            // textDamagedQuantity
            // 
            this.textDamagedQuantity.Location = new System.Drawing.Point(224, 65);
            this.textDamagedQuantity.Name = "textDamagedQuantity";
            this.textDamagedQuantity.Size = new System.Drawing.Size(145, 26);
            this.textDamagedQuantity.TabIndex = 1;
            // 
            // textFreshQuantity
            // 
            this.textFreshQuantity.Location = new System.Drawing.Point(204, 24);
            this.textFreshQuantity.Name = "textFreshQuantity";
            this.textFreshQuantity.Size = new System.Drawing.Size(145, 26);
            this.textFreshQuantity.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Damaged Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fresh Quantity";
            // 
            // groupProductDetails
            // 
            this.groupProductDetails.Controls.Add(this.textStock);
            this.groupProductDetails.Controls.Add(this.label9);
            this.groupProductDetails.Controls.Add(this.textCostPrice);
            this.groupProductDetails.Controls.Add(this.textSellingPrice);
            this.groupProductDetails.Controls.Add(this.textUnit);
            this.groupProductDetails.Controls.Add(this.textProductName);
            this.groupProductDetails.Controls.Add(this.textProductId);
            this.groupProductDetails.Controls.Add(this.label6);
            this.groupProductDetails.Controls.Add(this.label5);
            this.groupProductDetails.Controls.Add(this.label4);
            this.groupProductDetails.Controls.Add(this.label3);
            this.groupProductDetails.Controls.Add(this.label2);
            this.groupProductDetails.Location = new System.Drawing.Point(793, 14);
            this.groupProductDetails.Name = "groupProductDetails";
            this.groupProductDetails.Size = new System.Drawing.Size(345, 265);
            this.groupProductDetails.TabIndex = 1;
            this.groupProductDetails.TabStop = false;
            this.groupProductDetails.Text = "Product Details";
            // 
            // textStock
            // 
            this.textStock.Location = new System.Drawing.Point(191, 222);
            this.textStock.Name = "textStock";
            this.textStock.Size = new System.Drawing.Size(127, 26);
            this.textStock.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Stock:";
            // 
            // textCostPrice
            // 
            this.textCostPrice.Location = new System.Drawing.Point(191, 185);
            this.textCostPrice.Name = "textCostPrice";
            this.textCostPrice.Size = new System.Drawing.Size(127, 26);
            this.textCostPrice.TabIndex = 9;
            // 
            // textSellingPrice
            // 
            this.textSellingPrice.Location = new System.Drawing.Point(191, 139);
            this.textSellingPrice.Name = "textSellingPrice";
            this.textSellingPrice.Size = new System.Drawing.Size(127, 26);
            this.textSellingPrice.TabIndex = 8;
            // 
            // textUnit
            // 
            this.textUnit.Location = new System.Drawing.Point(191, 99);
            this.textUnit.Name = "textUnit";
            this.textUnit.Size = new System.Drawing.Size(127, 26);
            this.textUnit.TabIndex = 7;
            // 
            // textProductName
            // 
            this.textProductName.Location = new System.Drawing.Point(191, 60);
            this.textProductName.Name = "textProductName";
            this.textProductName.Size = new System.Drawing.Size(127, 26);
            this.textProductName.TabIndex = 6;
            // 
            // textProductId
            // 
            this.textProductId.Location = new System.Drawing.Point(191, 22);
            this.textProductId.Name = "textProductId";
            this.textProductId.Size = new System.Drawing.Size(127, 26);
            this.textProductId.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cost Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Selling Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Unit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Product Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product Id:";
            // 
            // GvProductList
            // 
            this.GvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvProductList.Location = new System.Drawing.Point(21, 34);
            this.GvProductList.Name = "GvProductList";
            this.GvProductList.RowTemplate.Height = 28;
            this.GvProductList.Size = new System.Drawing.Size(746, 193);
            this.GvProductList.TabIndex = 0;

            product product = this;
            product.GvProductList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GvProductList_RowHeaderMouseClick);
            // 
            // product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 613);
            this.Controls.Add(this.groupProductList);
            this.Controls.Add(this.groupProduct);
            this.Name = "product";
            this.Text = "product";
            this.Load += new System.EventHandler(this.product_Load);
            this.groupProduct.ResumeLayout(false);
            this.groupProduct.PerformLayout();
            this.groupProductList.ResumeLayout(false);
            this.groupStock.ResumeLayout(false);
            this.groupStock.PerformLayout();
            this.groupProductDetails.ResumeLayout(false);
            this.groupProductDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvProductList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowHideDetails;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox groupProductList;
        private System.Windows.Forms.DataGridView GvProductList;
        private System.Windows.Forms.GroupBox groupProductDetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupStock;
        private System.Windows.Forms.TextBox textCostPrice;
        private System.Windows.Forms.TextBox textSellingPrice;
        private System.Windows.Forms.TextBox textUnit;
        private System.Windows.Forms.TextBox textProductName;
        private System.Windows.Forms.TextBox textProductId;
        private System.Windows.Forms.TextBox textDamagedQuantity;
        private System.Windows.Forms.TextBox textFreshQuantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textStock;
        private System.Windows.Forms.Label label9;
    }
}