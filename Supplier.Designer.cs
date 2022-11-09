namespace Inventry_management_system
{
    partial class Supplier
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
            this.grpSuplier = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gvSupplierList = new System.Windows.Forms.DataGridView();
            this.grpSupplierList = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpSupplierDetail = new System.Windows.Forms.GroupBox();
            this.textRemarks = new System.Windows.Forms.TextBox();
            this.textTelephone = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textSuppliersName = new System.Windows.Forms.TextBox();
            this.textSupplierId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpSuplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSupplierList)).BeginInit();
            this.grpSupplierList.SuspendLayout();
            this.grpSupplierDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSuplier
            // 
            this.grpSuplier.Controls.Add(this.button5);
            this.grpSuplier.Controls.Add(this.button4);
            this.grpSuplier.Controls.Add(this.button3);
            this.grpSuplier.Controls.Add(this.button2);
            this.grpSuplier.Controls.Add(this.button1);
            this.grpSuplier.Controls.Add(this.label1);
            this.grpSuplier.Location = new System.Drawing.Point(12, 12);
            this.grpSuplier.Name = "grpSuplier";
            this.grpSuplier.Size = new System.Drawing.Size(733, 108);
            this.grpSuplier.TabIndex = 0;
            this.grpSuplier.TabStop = false;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(638, 26);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 40);
            this.button5.TabIndex = 5;
            this.button5.Text = "Reset";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnReset);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(519, 26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 40);
            this.button4.TabIndex = 4;
            this.button4.Text = "Export";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(411, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Print";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(291, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnEdit);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(181, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnNew);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier";
            // 
            // gvSupplierList
            // 
            this.gvSupplierList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSupplierList.Location = new System.Drawing.Point(45, 56);
            this.gvSupplierList.Name = "gvSupplierList";
            this.gvSupplierList.RowTemplate.Height = 28;
            this.gvSupplierList.Size = new System.Drawing.Size(542, 150);
            this.gvSupplierList.TabIndex = 0;
            this.gvSupplierList.RowDividerDoubleClick += new System.Windows.Forms.DataGridViewRowDividerDoubleClickEventHandler(this.gvSupplierList_RowDividerDoubleClick);
            this.gvSupplierList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvSupplierList_RowHeaderMouseClick);
            // 
            // grpSupplierList
            // 
            this.grpSupplierList.Controls.Add(this.btnDelete);
            this.grpSupplierList.Controls.Add(this.btnSave);
            this.grpSupplierList.Controls.Add(this.grpSupplierDetail);
            this.grpSupplierList.Controls.Add(this.gvSupplierList);
            this.grpSupplierList.Location = new System.Drawing.Point(29, 160);
            this.grpSupplierList.Name = "grpSupplierList";
            this.grpSupplierList.Size = new System.Drawing.Size(1043, 392);
            this.grpSupplierList.TabIndex = 1;
            this.grpSupplierList.TabStop = false;
            this.grpSupplierList.Text = "Supplier\'s List";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(482, 327);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 45);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(299, 327);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 45);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpSupplierDetail
            // 
            this.grpSupplierDetail.Controls.Add(this.textRemarks);
            this.grpSupplierDetail.Controls.Add(this.textTelephone);
            this.grpSupplierDetail.Controls.Add(this.textAddress);
            this.grpSupplierDetail.Controls.Add(this.textSuppliersName);
            this.grpSupplierDetail.Controls.Add(this.textSupplierId);
            this.grpSupplierDetail.Controls.Add(this.label6);
            this.grpSupplierDetail.Controls.Add(this.label5);
            this.grpSupplierDetail.Controls.Add(this.label4);
            this.grpSupplierDetail.Controls.Add(this.label3);
            this.grpSupplierDetail.Controls.Add(this.label2);
            this.grpSupplierDetail.Location = new System.Drawing.Point(684, 15);
            this.grpSupplierDetail.Name = "grpSupplierDetail";
            this.grpSupplierDetail.Size = new System.Drawing.Size(342, 301);
            this.grpSupplierDetail.TabIndex = 2;
            this.grpSupplierDetail.TabStop = false;
            this.grpSupplierDetail.Text = "Supplier\'s Detail";
            // 
            // textRemarks
            // 
            this.textRemarks.Location = new System.Drawing.Point(217, 245);
            this.textRemarks.Name = "textRemarks";
            this.textRemarks.Size = new System.Drawing.Size(100, 26);
            this.textRemarks.TabIndex = 9;
            // 
            // textTelephone
            // 
            this.textTelephone.Location = new System.Drawing.Point(217, 191);
            this.textTelephone.Name = "textTelephone";
            this.textTelephone.Size = new System.Drawing.Size(100, 26);
            this.textTelephone.TabIndex = 8;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(217, 142);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(100, 26);
            this.textAddress.TabIndex = 7;
            // 
            // textSuppliersName
            // 
            this.textSuppliersName.Location = new System.Drawing.Point(217, 89);
            this.textSuppliersName.Name = "textSuppliersName";
            this.textSuppliersName.Size = new System.Drawing.Size(100, 26);
            this.textSuppliersName.TabIndex = 6;
            // 
            // textSupplierId
            // 
            this.textSupplierId.Location = new System.Drawing.Point(217, 46);
            this.textSupplierId.Name = "textSupplierId";
            this.textSupplierId.Size = new System.Drawing.Size(100, 26);
            this.textSupplierId.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Remarks:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Telephone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Supplier\'s Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "SupplierID:";
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 633);
            this.Controls.Add(this.grpSupplierList);
            this.Controls.Add(this.grpSuplier);
            this.Name = "Supplier";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Supplier_Load);
            this.grpSuplier.ResumeLayout(false);
            this.grpSuplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSupplierList)).EndInit();
            this.grpSupplierList.ResumeLayout(false);
            this.grpSupplierDetail.ResumeLayout(false);
            this.grpSupplierDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSuplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gvSupplierList;
        private System.Windows.Forms.GroupBox grpSupplierList;
        private System.Windows.Forms.GroupBox grpSupplierDetail;
        private System.Windows.Forms.TextBox textRemarks;
        private System.Windows.Forms.TextBox textTelephone;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textSuppliersName;
        private System.Windows.Forms.TextBox textSupplierId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
    }
}