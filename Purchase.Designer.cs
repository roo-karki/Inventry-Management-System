namespace Inventry_management_system
{
    partial class Purchase
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
            this.groupPurchase = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupbox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxSupplierID = new System.Windows.Forms.ComboBox();
            this.comboBoxPuchaseID = new System.Windows.Forms.ComboBox();
            this.grpPurchaseID = new System.Windows.Forms.GroupBox();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textProductName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textPurchaseRate = new System.Windows.Forms.TextBox();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textRemarks = new System.Windows.Forms.TextBox();
            this.textAmountofInvoice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dt = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textInvoiceNo = new System.Windows.Forms.TextBox();
            this.dataGridViewPurchase = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPurchase.SuspendLayout();
            this.groupbox2.SuspendLayout();
            this.grpPurchaseID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPurchase
            // 
            this.groupPurchase.Controls.Add(this.btnReset);
            this.groupPurchase.Controls.Add(this.btnDelete);
            this.groupPurchase.Controls.Add(this.btnSave);
            this.groupPurchase.Controls.Add(this.btnEdit);
            this.groupPurchase.Controls.Add(this.btnNew);
            this.groupPurchase.Controls.Add(this.label1);
            this.groupPurchase.Location = new System.Drawing.Point(12, 12);
            this.groupPurchase.Name = "groupPurchase";
            this.groupPurchase.Size = new System.Drawing.Size(798, 100);
            this.groupPurchase.TabIndex = 0;
            this.groupPurchase.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(642, 45);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 35);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(498, 45);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 35);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(375, 48);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 32);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(258, 45);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 39);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(161, 45);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 35);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purchase";
            // 
            // groupbox2
            // 
            this.groupbox2.Controls.Add(this.comboBoxSupplierID);
            this.groupbox2.Controls.Add(this.comboBoxPuchaseID);
            this.groupbox2.Controls.Add(this.grpPurchaseID);
            this.groupbox2.Controls.Add(this.textRemarks);
            this.groupbox2.Controls.Add(this.textAmountofInvoice);
            this.groupbox2.Controls.Add(this.label7);
            this.groupbox2.Controls.Add(this.label6);
            this.groupbox2.Controls.Add(this.label5);
            this.groupbox2.Controls.Add(this.btnAdd);
            this.groupbox2.Controls.Add(this.btnSearch);
            this.groupbox2.Controls.Add(this.dt);
            this.groupbox2.Controls.Add(this.label4);
            this.groupbox2.Controls.Add(this.label3);
            this.groupbox2.Controls.Add(this.label2);
            this.groupbox2.Controls.Add(this.textInvoiceNo);
            this.groupbox2.Location = new System.Drawing.Point(12, 168);
            this.groupbox2.Name = "groupbox2";
            this.groupbox2.Size = new System.Drawing.Size(1289, 255);
            this.groupbox2.TabIndex = 1;
            this.groupbox2.TabStop = false;
            // 
            // comboBoxSupplierID
            // 
            this.comboBoxSupplierID.FormattingEnabled = true;
            this.comboBoxSupplierID.Location = new System.Drawing.Point(763, 23);
            this.comboBoxSupplierID.Name = "comboBoxSupplierID";
            this.comboBoxSupplierID.Size = new System.Drawing.Size(121, 28);
            this.comboBoxSupplierID.TabIndex = 16;
            // 
            // comboBoxPuchaseID
            // 
            this.comboBoxPuchaseID.FormattingEnabled = true;
            this.comboBoxPuchaseID.Location = new System.Drawing.Point(200, 27);
            this.comboBoxPuchaseID.Name = "comboBoxPuchaseID";
            this.comboBoxPuchaseID.Size = new System.Drawing.Size(121, 28);
            this.comboBoxPuchaseID.TabIndex = 15;
            // 
            // grpPurchaseID
            // 
            this.grpPurchaseID.Controls.Add(this.textTotal);
            this.grpPurchaseID.Controls.Add(this.label12);
            this.grpPurchaseID.Controls.Add(this.textProductName);
            this.grpPurchaseID.Controls.Add(this.label11);
            this.grpPurchaseID.Controls.Add(this.textPurchaseRate);
            this.grpPurchaseID.Controls.Add(this.textQuantity);
            this.grpPurchaseID.Controls.Add(this.label10);
            this.grpPurchaseID.Controls.Add(this.label9);
            this.grpPurchaseID.Location = new System.Drawing.Point(31, 169);
            this.grpPurchaseID.Name = "grpPurchaseID";
            this.grpPurchaseID.Size = new System.Drawing.Size(1252, 80);
            this.grpPurchaseID.TabIndex = 14;
            this.grpPurchaseID.TabStop = false;
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(1052, 36);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(100, 26);
            this.textTotal.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(978, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Total";
            // 
            // textProductName
            // 
            this.textProductName.Location = new System.Drawing.Point(817, 45);
            this.textProductName.Name = "textProductName";
            this.textProductName.Size = new System.Drawing.Size(100, 26);
            this.textProductName.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(643, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Product Name";
            // 
            // textPurchaseRate
            // 
            this.textPurchaseRate.Location = new System.Drawing.Point(467, 45);
            this.textPurchaseRate.Name = "textPurchaseRate";
            this.textPurchaseRate.Size = new System.Drawing.Size(100, 26);
            this.textPurchaseRate.TabIndex = 5;
            // 
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(147, 39);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(100, 26);
            this.textQuantity.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(291, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Purchase Rate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Quantity";
            // 
            // textRemarks
            // 
            this.textRemarks.Location = new System.Drawing.Point(816, 113);
            this.textRemarks.Name = "textRemarks";
            this.textRemarks.Size = new System.Drawing.Size(100, 26);
            this.textRemarks.TabIndex = 13;
            // 
            // textAmountofInvoice
            // 
            this.textAmountofInvoice.Location = new System.Drawing.Point(816, 67);
            this.textAmountofInvoice.Name = "textAmountofInvoice";
            this.textAmountofInvoice.Size = new System.Drawing.Size(100, 26);
            this.textAmountofInvoice.TabIndex = 12;
            this.textAmountofInvoice.TextChanged += new System.EventHandler(this.TextAmountofInvoice_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(592, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Remarks:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(592, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Amount of Invoice:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(592, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Supplier ID:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(431, 99);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 40);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(431, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 40);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dt
            // 
            this.dt.Location = new System.Drawing.Point(213, 66);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(200, 26);
            this.dt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Invoice No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date of Puchase:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Purchase ID:";
            // 
            // textInvoiceNo
            // 
            this.textInvoiceNo.Location = new System.Drawing.Point(200, 113);
            this.textInvoiceNo.Name = "textInvoiceNo";
            this.textInvoiceNo.Size = new System.Drawing.Size(100, 26);
            this.textInvoiceNo.TabIndex = 1;
            this.textInvoiceNo.TextChanged += new System.EventHandler(this.TextInvoiceNo_TextChanged);
            // 
            // dataGridViewPurchase
            // 
            this.dataGridViewPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPurchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewPurchase.Location = new System.Drawing.Point(82, 444);
            this.dataGridViewPurchase.Name = "dataGridViewPurchase";
            this.dataGridViewPurchase.RowTemplate.Height = 28;
            this.dataGridViewPurchase.Size = new System.Drawing.Size(641, 150);
            this.dataGridViewPurchase.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Purchase Rate";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 636);
            this.Controls.Add(this.dataGridViewPurchase);
            this.Controls.Add(this.groupbox2);
            this.Controls.Add(this.groupPurchase);
            this.Name = "Purchase";
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.Purchase_Load);
            this.groupPurchase.ResumeLayout(false);
            this.groupPurchase.PerformLayout();
            this.groupbox2.ResumeLayout(false);
            this.groupbox2.PerformLayout();
            this.grpPurchaseID.ResumeLayout(false);
            this.grpPurchaseID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupPurchase;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox groupbox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textInvoiceNo;
        private System.Windows.Forms.DateTimePicker dt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textRemarks;
        private System.Windows.Forms.TextBox textAmountofInvoice;
        private System.Windows.Forms.GroupBox grpPurchaseID;
        private System.Windows.Forms.TextBox textPurchaseRate;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewPurchase;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textProductName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxSupplierID;
        private System.Windows.Forms.ComboBox comboBoxPuchaseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}