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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBoxItem = new System.Windows.Forms.PictureBox();
            this.listPicture = new System.Windows.Forms.ListBox();
            this.richTextBoxAddFoderPicture = new System.Windows.Forms.RichTextBox();
            this.txtId = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboDiscount = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericPrice = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.datePickerReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.comboItemType = new System.Windows.Forms.ComboBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(771, 539);
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
            this.btnAddNew.Location = new System.Drawing.Point(517, 539);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(132, 52);
            this.btnAddNew.TabIndex = 8;
            this.btnAddNew.Text = "Thêm mới";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.BtnAddItemClick);
            // 
            // pictureBoxItem
            // 
            this.pictureBoxItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxItem.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxItem.Image")));
            this.pictureBoxItem.Location = new System.Drawing.Point(314, 126);
            this.pictureBoxItem.Name = "pictureBoxItem";
            this.pictureBoxItem.Size = new System.Drawing.Size(246, 182);
            this.pictureBoxItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxItem.TabIndex = 24;
            this.pictureBoxItem.TabStop = false;
            this.pictureBoxItem.Click += new System.EventHandler(this.pictureBoxItem_Click);
            // 
            // listPicture
            // 
            this.listPicture.FormattingEnabled = true;
            this.listPicture.ItemHeight = 20;
            this.listPicture.Location = new System.Drawing.Point(621, 126);
            this.listPicture.Name = "listPicture";
            this.listPicture.Size = new System.Drawing.Size(548, 124);
            this.listPicture.TabIndex = 25;
            this.listPicture.SelectedIndexChanged += new System.EventHandler(this.listPicture_SelectedIndexChanged);
            // 
            // richTextBoxAddFoderPicture
            // 
            this.richTextBoxAddFoderPicture.Location = new System.Drawing.Point(621, 277);
            this.richTextBoxAddFoderPicture.Name = "richTextBoxAddFoderPicture";
            this.richTextBoxAddFoderPicture.Size = new System.Drawing.Size(548, 31);
            this.richTextBoxAddFoderPicture.TabIndex = 26;
            this.richTextBoxAddFoderPicture.Text = "";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(449, 345);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(286, 30);
            this.txtId.TabIndex = 42;
            this.txtId.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(781, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Ngày sản xuất:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mã mặt hàng: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tên mặt hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Loại mặt hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Số lượng:";
            // 
            // comboDiscount
            // 
            this.comboDiscount.FormattingEnabled = true;
            this.comboDiscount.Location = new System.Drawing.Point(918, 452);
            this.comboDiscount.Name = "comboDiscount";
            this.comboDiscount.Size = new System.Drawing.Size(251, 28);
            this.comboDiscount.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(781, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Hãng sản xuất:";
            // 
            // numericPrice
            // 
            this.numericPrice.Location = new System.Drawing.Point(918, 420);
            this.numericPrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericPrice.Name = "numericPrice";
            this.numericPrice.Size = new System.Drawing.Size(251, 26);
            this.numericPrice.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(781, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Giá bán:";
            // 
            // datePickerReleaseDate
            // 
            this.datePickerReleaseDate.CustomFormat = "dd/MM/yyyy";
            this.datePickerReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerReleaseDate.Location = new System.Drawing.Point(918, 385);
            this.datePickerReleaseDate.Name = "datePickerReleaseDate";
            this.datePickerReleaseDate.Size = new System.Drawing.Size(251, 26);
            this.datePickerReleaseDate.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(781, 455);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Khuyến mãi:";
            // 
            // numericQuantity
            // 
            this.numericQuantity.Location = new System.Drawing.Point(450, 458);
            this.numericQuantity.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(285, 26);
            this.numericQuantity.TabIndex = 38;
            // 
            // comboItemType
            // 
            this.comboItemType.FormattingEnabled = true;
            this.comboItemType.Location = new System.Drawing.Point(450, 417);
            this.comboItemType.Name = "comboItemType";
            this.comboItemType.Size = new System.Drawing.Size(285, 28);
            this.comboItemType.TabIndex = 37;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(918, 345);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(251, 26);
            this.txtBrand.TabIndex = 35;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(450, 381);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(285, 26);
            this.txtItemName.TabIndex = 36;
            // 
            // AddEditItemFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1374, 765);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboDiscount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.datePickerReleaseDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericQuantity);
            this.Controls.Add(this.comboItemType);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.pictureBoxItem);
            this.Controls.Add(this.listPicture);
            this.Controls.Add(this.richTextBoxAddFoderPicture);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditItemFrm";
            this.Text = "THÊM MỚI MẶT HÀNG";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnCancel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBoxItem;
        private System.Windows.Forms.ListBox listPicture;
        private System.Windows.Forms.RichTextBox richTextBoxAddFoderPicture;
        private System.Windows.Forms.RichTextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboDiscount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker datePickerReleaseDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.ComboBox comboItemType;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtItemName;
    }
}