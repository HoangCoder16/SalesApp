using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Controllers;
using System.IO;

namespace SalesApp
{
    public partial class AddEditItemFrm : Form
    {
        private List<Discount> _discounts;
        private Item _item;
        private IViewController _controller;

        public AddEditItemFrm()
        {
            InitializeComponent();
            CenterToParent();
            txtId.Text = "Mã tự động";
        }

        public AddEditItemFrm(IViewController masterView, List<Discount> discounts, Item item = null) : this()
        {
            _discounts = discounts;
            _controller = masterView;
            if (item != null)
            {
                Text = "CẬP NHẬT THÔNG TIN MẶT HÀNG";
                btnAddNew.Text = "Cập nhật";
                _item = item;
                ShowItemData();
            }
        }

        private void ShowItemData()
        {
            txtId.Text = $"{_item.ItemId}";
            txtItemName.Text = _item.ItemName;
            txtBrand.Text = _item.Brand;
            numericQuantity.Value = _item.Quantity;
            numericPrice.Value = _item.Price;
            datePickerReleaseDate.Value = _item.ReleaseDate;
            comboItemType.Text = _item.ItemType;
            for (int i = 0; i < comboDiscount.Items.Count; i++)
            {
                if (_item.Discount?.Name.CompareTo(comboDiscount.Items[i]) == 0)
                {
                    comboDiscount.SelectedIndex = i;
                    break;
                }
            }
            pictureBoxItem.Image = new Bitmap(_item.PathItemPicture);
        }

        private void BtnAddItemClick(object sender, EventArgs e)
        {           
          //  var id = int.Parse(txtId.Text);
            var itemName = txtItemName.Text;
            var itemType = comboItemType.Text;
            var itemPrice = (int)numericPrice.Value;
            var quantity = (int)numericQuantity.Value;
            var brand = txtBrand.Text;
            var manufactureDate = datePickerReleaseDate.Value;
            Discount discount = null;
            if (comboDiscount.SelectedIndex > -1)
            {
                discount = _discounts[comboDiscount.SelectedIndex];
            }
            string itemPicture = listPicture.SelectedItem.ToString();
            try
            {
                if (string.IsNullOrEmpty(itemName))
                {
                    var msg = "Tên mặt hàng không được để trống.";
                    throw new InvalidItemNameException(msg);
                }
                if (itemType == null || itemType == "")
                {
                    var msg = "Vui lòng chọn loại mặt hàng trước.";
                    MessageBox.Show(msg, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (btnAddNew.Text.CompareTo("Cập nhật") == 0)
                {
                    _item.ItemName = itemName;
                    _item.Price = itemPrice;
                    _item.Brand = brand;
                    _item.Discount = discount;
                    _item.ReleaseDate = manufactureDate;
                    _item.Quantity = quantity;
                    _item.ItemType = itemType;
                    _item.PathItemPicture = itemPicture;
                    var msg = "Bạn có chắc chắn muốn lưu lại các thay đổi?";
                    var title = "Xác nhận cập nhật";
                    var ans = ShowConfirmMessage(title, msg);
                    if (ans == DialogResult.Yes)
                    {
                        _controller.UpdateItem(_item);
                        Dispose();
                    }
                }
                else // thêm mới mặt hàng
                {
                    Item item = new Item(-1, itemName, itemType, quantity, brand, manufactureDate, itemPrice, discount, itemPicture);
                    _controller.AddNewItem(item);
                }
            }
            catch (InvalidItemNameException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelClick(object sender, EventArgs e)
        {
            var title = "Xác nhận";
            var message = "Bạn có chắc muốn hủy bỏ?";
            var ans = ShowConfirmMessage(title, message);
            if (ans == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private DialogResult ShowConfirmMessage(string title, string message)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

  

        private void listPicture_SelectedIndexChanged(object sender, EventArgs e)
        {
            var bitmapImportPicture = new Bitmap(listPicture.SelectedItem.ToString());
            pictureBoxItem.Image = bitmapImportPicture;
        }

        private void pictureBoxItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog importFoderPicture = new FolderBrowserDialog();
            if (importFoderPicture.ShowDialog() == DialogResult.OK)
            {
                richTextBoxAddFoderPicture.Text = importFoderPicture.SelectedPath;
            }
            foreach (string path in Directory.GetFiles(importFoderPicture.SelectedPath))
            {
                listPicture.Items.Add(path);
            }
        }
    }
}
