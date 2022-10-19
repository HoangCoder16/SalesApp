namespace SalesApp
{
    partial class AddEditCustomerFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditCustomerFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.datePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.numericPoint = new System.Windows.Forms.NumericUpDown();
            this.comboCustomerType = new System.Windows.Forms.ComboBox();
            this.datePickerCreatedAcc = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBoxCustomer = new System.Windows.Forms.PictureBox();
            this.listPicture = new System.Windows.Forms.ListBox();
            this.richTextBoxAddFoderPicture = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericPoint)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomer)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số điện thoại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(495, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Điểm tích lũy:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(495, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Loại khách hàng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(495, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ngày tạo tài khoản:";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(117, 25);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(135, 37);
            this.btnAddNew.TabIndex = 10;
            this.btnAddNew.Text = "Thêm mới";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.BtnAddUpdateClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(303, 25);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 37);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtCustomerId.Location = new System.Drawing.Point(173, 33);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(300, 26);
            this.txtCustomerId.TabIndex = 1;
            this.txtCustomerId.Text = "CMND/CCCD";
            this.txtCustomerId.Enter += new System.EventHandler(this.TxtIdTakeForcus);
            this.txtCustomerId.Leave += new System.EventHandler(this.TxtIdLeaveFocus);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(173, 75);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(300, 26);
            this.txtFullName.TabIndex = 2;
            // 
            // datePickerBirthDate
            // 
            this.datePickerBirthDate.CustomFormat = "dd/MM/yyyy";
            this.datePickerBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerBirthDate.Location = new System.Drawing.Point(173, 119);
            this.datePickerBirthDate.Name = "datePickerBirthDate";
            this.datePickerBirthDate.Size = new System.Drawing.Size(300, 26);
            this.datePickerBirthDate.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(173, 159);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(300, 26);
            this.txtAddress.TabIndex = 4;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(173, 200);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(300, 26);
            this.txtPhoneNumber.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(675, 33);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 26);
            this.txtEmail.TabIndex = 6;
            // 
            // numericPoint
            // 
            this.numericPoint.Location = new System.Drawing.Point(675, 76);
            this.numericPoint.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericPoint.Name = "numericPoint";
            this.numericPoint.Size = new System.Drawing.Size(300, 26);
            this.numericPoint.TabIndex = 7;
            // 
            // comboCustomerType
            // 
            this.comboCustomerType.FormattingEnabled = true;
            this.comboCustomerType.Items.AddRange(new object[] {
            "Khách mua lẻ",
            "Khách mua buôn"});
            this.comboCustomerType.Location = new System.Drawing.Point(675, 116);
            this.comboCustomerType.Name = "comboCustomerType";
            this.comboCustomerType.Size = new System.Drawing.Size(300, 28);
            this.comboCustomerType.TabIndex = 8;
            // 
            // datePickerCreatedAcc
            // 
            this.datePickerCreatedAcc.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.datePickerCreatedAcc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerCreatedAcc.Location = new System.Drawing.Point(675, 154);
            this.datePickerCreatedAcc.Name = "datePickerCreatedAcc";
            this.datePickerCreatedAcc.Size = new System.Drawing.Size(300, 26);
            this.datePickerCreatedAcc.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox3.Controls.Add(this.pictureBoxCustomer);
            this.groupBox3.Controls.Add(this.listPicture);
            this.groupBox3.Controls.Add(this.richTextBoxAddFoderPicture);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(990, 231);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Picture";
            // 
            // pictureBoxCustomer
            // 
            this.pictureBoxCustomer.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCustomer.Image")));
            this.pictureBoxCustomer.Location = new System.Drawing.Point(6, 25);
            this.pictureBoxCustomer.Name = "pictureBoxCustomer";
            this.pictureBoxCustomer.Size = new System.Drawing.Size(246, 182);
            this.pictureBoxCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCustomer.TabIndex = 18;
            this.pictureBoxCustomer.TabStop = false;
            this.pictureBoxCustomer.Click += new System.EventHandler(this.pictureBoxCustomer_Click);
            // 
            // listPicture
            // 
            this.listPicture.FormattingEnabled = true;
            this.listPicture.ItemHeight = 20;
            this.listPicture.Location = new System.Drawing.Point(285, 25);
            this.listPicture.Name = "listPicture";
            this.listPicture.Size = new System.Drawing.Size(369, 124);
            this.listPicture.TabIndex = 20;
            this.listPicture.SelectedIndexChanged += new System.EventHandler(this.listPicture_SelectedIndexChanged_1);
            // 
            // richTextBoxAddFoderPicture
            // 
            this.richTextBoxAddFoderPicture.Location = new System.Drawing.Point(285, 176);
            this.richTextBoxAddFoderPicture.Name = "richTextBoxAddFoderPicture";
            this.richTextBoxAddFoderPicture.Size = new System.Drawing.Size(369, 31);
            this.richTextBoxAddFoderPicture.TabIndex = 21;
            this.richTextBoxAddFoderPicture.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.datePickerCreatedAcc);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboCustomerType);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numericPoint);
            this.groupBox2.Controls.Add(this.txtCustomerId);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtFullName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtPhoneNumber);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.datePickerBirthDate);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(990, 247);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin mặt hàng";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox4.Controls.Add(this.btnCancel);
            this.groupBox4.Controls.Add(this.btnAddNew);
            this.groupBox4.Location = new System.Drawing.Point(12, 524);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(990, 84);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hành động";
            // 
            // AddEditCustomerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1011, 620);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditCustomerFrm";
            this.Text = "THÊM MỚI KHÁCH HÀNG";
            ((System.ComponentModel.ISupportInitialize)(this.numericPoint)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.DateTimePicker datePickerBirthDate;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.NumericUpDown numericPoint;
        private System.Windows.Forms.ComboBox comboCustomerType;
        private System.Windows.Forms.DateTimePicker datePickerCreatedAcc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBoxCustomer;
        private System.Windows.Forms.ListBox listPicture;
        private System.Windows.Forms.RichTextBox richTextBoxAddFoderPicture;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}