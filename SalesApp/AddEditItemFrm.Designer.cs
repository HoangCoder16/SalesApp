namespace SalesApp
{
    partial class AddEditItemFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditItemFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.comboItemType = new System.Windows.Forms.ComboBox();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.datePickerReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.numericPrice = new System.Windows.Forms.NumericUpDown();
            this.comboDiscount = new System.Windows.Forms.ComboBox();
            this.pictureBoxItem = new System.Windows.Forms.PictureBox();
            this.listPicture = new System.Windows.Forms.ListBox();
            this.richTextBoxAddFoderPicture = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã mặt hàng: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên mặt hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại mặt hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sản xuất:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(525, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hãng sản xuất:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(525, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Giá bán:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(525, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Khuyến mãi:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(320, 22);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 52);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNew.Location = new System.Drawing.Point(114, 20);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(132, 52);
            this.btnAddNew.TabIndex = 8;
            this.btnAddNew.Text = "Thêm mới";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.BtnAddItemClick);
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(662, 66);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(251, 26);
            this.txtBrand.TabIndex = 11;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(166, 100);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(285, 26);
            this.txtItemName.TabIndex = 12;
            // 
            // comboItemType
            // 
            this.comboItemType.FormattingEnabled = true;
            this.comboItemType.Location = new System.Drawing.Point(166, 133);
            this.comboItemType.Name = "comboItemType";
            this.comboItemType.Size = new System.Drawing.Size(285, 28);
            this.comboItemType.TabIndex = 13;
            // 
            // numericQuantity
            // 
            this.numericQuantity.Location = new System.Drawing.Point(166, 173);
            this.numericQuantity.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(285, 26);
            this.numericQuantity.TabIndex = 14;
            // 
            // datePickerReleaseDate
            // 
            this.datePickerReleaseDate.CustomFormat = "dd/MM/yyyy";
            this.datePickerReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerReleaseDate.Location = new System.Drawing.Point(662, 106);
            this.datePickerReleaseDate.Name = "datePickerReleaseDate";
            this.datePickerReleaseDate.Size = new System.Drawing.Size(251, 26);
            this.datePickerReleaseDate.TabIndex = 15;
            // 
            // numericPrice
            // 
            this.numericPrice.Location = new System.Drawing.Point(662, 141);
            this.numericPrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericPrice.Name = "numericPrice";
            this.numericPrice.Size = new System.Drawing.Size(251, 26);
            this.numericPrice.TabIndex = 16;
            // 
            // comboDiscount
            // 
            this.comboDiscount.FormattingEnabled = true;
            this.comboDiscount.Location = new System.Drawing.Point(662, 173);
            this.comboDiscount.Name = "comboDiscount";
            this.comboDiscount.Size = new System.Drawing.Size(251, 28);
            this.comboDiscount.TabIndex = 17;
            // 
            // pictureBoxItem
            // 
            this.pictureBoxItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxItem.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxItem.Image")));
            this.pictureBoxItem.Location = new System.Drawing.Point(6, 25);
            this.pictureBoxItem.Name = "pictureBoxItem";
            this.pictureBoxItem.Size = new System.Drawing.Size(246, 182);
            this.pictureBoxItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxItem.TabIndex = 18;
            this.pictureBoxItem.TabStop = false;
            this.pictureBoxItem.Click += new System.EventHandler(this.pictureBoxItem_Click);
            // 
            // listPicture
            // 
            this.listPicture.FormattingEnabled = true;
            this.listPicture.ItemHeight = 20;
            this.listPicture.Location = new System.Drawing.Point(285, 25);
            this.listPicture.Name = "listPicture";
            this.listPicture.Size = new System.Drawing.Size(369, 124);
            this.listPicture.TabIndex = 20;
            this.listPicture.SelectedIndexChanged += new System.EventHandler(this.listPicture_SelectedIndexChanged);
            // 
            // richTextBoxAddFoderPicture
            // 
            this.richTextBoxAddFoderPicture.Location = new System.Drawing.Point(285, 176);
            this.richTextBoxAddFoderPicture.Name = "richTextBoxAddFoderPicture";
            this.richTextBoxAddFoderPicture.Size = new System.Drawing.Size(369, 31);
            this.richTextBoxAddFoderPicture.TabIndex = 21;
            this.richTextBoxAddFoderPicture.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.btnAddNew);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Location = new System.Drawing.Point(12, 522);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(944, 92);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hành động";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboDiscount);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numericPrice);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.datePickerReleaseDate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.numericQuantity);
            this.groupBox2.Controls.Add(this.comboItemType);
            this.groupBox2.Controls.Add(this.txtBrand);
            this.groupBox2.Controls.Add(this.txtItemName);
            this.groupBox2.Location = new System.Drawing.Point(12, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(944, 242);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin mặt hàng";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(166, 62);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(286, 30);
            this.txtId.TabIndex = 18;
            this.txtId.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox3.Controls.Add(this.pictureBoxItem);
            this.groupBox3.Controls.Add(this.listPicture);
            this.groupBox3.Controls.Add(this.richTextBoxAddFoderPicture);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(944, 231);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Picture";
            // 
            // AddEditItemFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(965, 621);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditItemFrm";
            this.Text = "THÊM MỚI MẶT HÀNG";
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.ComboBox comboItemType;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.DateTimePicker datePickerReleaseDate;
        private System.Windows.Forms.NumericUpDown numericPrice;
        private System.Windows.Forms.ComboBox comboDiscount;
        private System.Windows.Forms.PictureBox pictureBoxItem;
        private System.Windows.Forms.ListBox listPicture;
        private System.Windows.Forms.RichTextBox richTextBoxAddFoderPicture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RichTextBox txtId;
    }
}