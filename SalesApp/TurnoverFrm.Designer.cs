namespace SalesApp
{
    partial class TurnoverFrm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBoxItem = new System.Windows.Forms.RichTextBox();
            this.richTextBoxMoney = new System.Windows.Forms.RichTextBox();
            this.richTextBoxCustomer = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(605, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tổng số khách hàng mua hàng trong ngày (KH) :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(448, 29);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tổng doanh thu ngày hôm nay  (đ) :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(576, 29);
            this.label8.TabIndex = 27;
            this.label8.Text = "Tổng số mặt hàng được bán trong ngày  (SP) :";
            // 
            // richTextBoxItem
            // 
            this.richTextBoxItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.richTextBoxItem.Enabled = false;
            this.richTextBoxItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxItem.Location = new System.Drawing.Point(696, 24);
            this.richTextBoxItem.Name = "richTextBoxItem";
            this.richTextBoxItem.Size = new System.Drawing.Size(123, 35);
            this.richTextBoxItem.TabIndex = 28;
            this.richTextBoxItem.Text = "";
            // 
            // richTextBoxMoney
            // 
            this.richTextBoxMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.richTextBoxMoney.Enabled = false;
            this.richTextBoxMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxMoney.Location = new System.Drawing.Point(696, 166);
            this.richTextBoxMoney.Name = "richTextBoxMoney";
            this.richTextBoxMoney.Size = new System.Drawing.Size(123, 35);
            this.richTextBoxMoney.TabIndex = 29;
            this.richTextBoxMoney.Text = "";
            // 
            // richTextBoxCustomer
            // 
            this.richTextBoxCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.richTextBoxCustomer.Enabled = false;
            this.richTextBoxCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxCustomer.Location = new System.Drawing.Point(696, 91);
            this.richTextBoxCustomer.Name = "richTextBoxCustomer";
            this.richTextBoxCustomer.Size = new System.Drawing.Size(123, 35);
            this.richTextBoxCustomer.TabIndex = 30;
            this.richTextBoxCustomer.Text = "";
            // 
            // TurnoverFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(899, 248);
            this.Controls.Add(this.richTextBoxCustomer);
            this.Controls.Add(this.richTextBoxMoney);
            this.Controls.Add(this.richTextBoxItem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "TurnoverFrm";
            this.Text = "TurnoverFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBoxItem;
        private System.Windows.Forms.RichTextBox richTextBoxMoney;
        private System.Windows.Forms.RichTextBox richTextBoxCustomer;
    }
}