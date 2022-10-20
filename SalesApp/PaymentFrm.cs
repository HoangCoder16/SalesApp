using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesApp
{
    public partial class PaymentFrm : Form
    {
        private IViewController _controller;
        private BillDetail _bill;

        public PaymentFrm()
        {
            InitializeComponent();
            CenterToParent();
        }

        public PaymentFrm(IViewController controller, BillDetail bill) : this()
        {
            _controller = controller;
            _bill = bill;
            ShowData();
        }

        private void ShowData()
        {
            txtBillId.Text = _bill.BillId + "";
            txtCustomerName.Text = _bill.Cart.Customer.FullName.ToString();
            txtStaffName.Text = _bill.StaffName;
            txtCreatedTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            txtTotalItem.Text = $"{_bill.TotalItem}sp";
            txtTotalDiscount.Text = $"{_bill.TotalDiscountAmount}đ";
            txtTotalAmount.Text = $"{_bill.TotalAmount}đ";
            if(_bill.Status.Trim().Equals("Đã thanh toán"))
            {
                comboPaymentMethod.Text = _bill.PaymentMethod.ToString();
            }
        }

        private void BtnFinishClick(object sender, EventArgs e)
        {
            if (comboPaymentMethod.SelectedIndex == -1)
            {
                var title = "Lỗi thanh toán";
                var msg = "Chọn hình thức thanh toán trước!";
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _bill.Status = "Đã thanh toán";
                _bill.PaymentMethod = comboPaymentMethod.Text;
                _controller.UpdateItem(_bill);
                Dispose();
            }
        }
    }
}
