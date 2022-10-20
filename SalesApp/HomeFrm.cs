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

namespace SalesApp
{
    public enum ActionType
    {
        NORMAL, SEARCH
    }

    public interface IViewController
    {
        void AddNewItem<T>(T item);
        void UpdateItem<T>(T updatedItem);
    }

    public partial class HomeFrm : Form, IViewController
    {
        private static string DATE_FORMAT = "dd/MM/yyyy";
        private static string DATE_TIME_FORMAT = "dd/MM/yyyy HH:mm:ss";

        private List<Item> _items;
        private List<Discount> _discounts;
        private List<Customer> _customers;
        private CommonController _commonController;
        private ItemController _itemController;
        private List<Item> _searchItemResults;
        private List<Customer> _searchCustomerResults;
        private ActionType _actionType;
        private CustomerController _customerController;
        private List<Discount> _searchDiscountResults;
        private IDiscountController _discountController;

        public HomeFrm()
        {
            InitializeComponent();
            CenterToScreen();     
            _items = new List<Item>();
            _discounts = new List<Discount>();
            _customers = new List<Customer>();
            _commonController = new CommonController();
            _customerController = new CustomerController();
            _discountController = new DiscountController();
            _itemController = new ItemController();
            _searchItemResults = new List<Item>();
            _searchCustomerResults = new List<Customer>();
            _searchDiscountResults = new List<Discount>();
            _actionType = ActionType.NORMAL;
            // nạp dữ liệu
            _items.AddRange(Utils.CreateFakeItems());
            _customers.AddRange(Utils.CreateFakeCustomer());
            _discounts.AddRange(Utils.CreateFakeDiscounts());
            // hiển thị dữ liệu
            ShowItems(_items);
            ShowCustomers(_customers);
            ShowDiscounts(_discounts);
        }

        private void ShowDiscounts(List<Discount> discounts)
        {
            tblDiscount.Rows.Clear();
            foreach (var discount in discounts)
            {
                tblDiscount.Rows.Add(
                    new object[] {
                        discount.DiscountId, discount.Name, discount.StartTime.ToString(DATE_TIME_FORMAT),
                        discount.EndTime.ToString(DATE_TIME_FORMAT), discount.DiscounType,
                        discount.DiscountPercent, $"{discount.DiscountPriceAmount:N0}"
                    }
                );
            }
        }

        private void ShowCustomers(List<Customer> customers)
        {
            tblCustomer.Rows.Clear();
            foreach (var customer in customers)
            {
                tblCustomer.Rows.Add(new object[] {
                        customer.PersonId, customer.FullName?.ToString(), customer.BirthDate.ToString(DATE_FORMAT),
                        customer.Address, customer.PhoneNumber, customer.CustomerType, $"{customer.Point:N0}",
                        customer.CreateTime.ToString(DATE_TIME_FORMAT), customer.Email
                    });
            }
        }

        public void AddNewItem<T>(T item)
        {
            if (typeof(T) == typeof(Item))
            {
                var newItem = item as Item;
                newItem.ItemId = _items.Count;
                _commonController.AddNewItem(_items, newItem);
                /*          tblItem.Rows.Add(new object[]
                          {
                                      newItem.ItemId, newItem.ItemName, newItem.ItemType, newItem.Quantity,
                                      newItem.Brand, newItem.ReleaseDate.ToString("dd/MM/yyyy"), $"{newItem.Price:N0}",
                                      newItem.Discount == null ? "-" : newItem.Discount.Name
                          });*/


                tblItem.Rows.Add(new object[]
                    {
                           newItem.ItemId, newItem.ItemName, newItem.ItemType, newItem.Quantity,
                           newItem.Brand, newItem.ReleaseDate.ToString("dd/MM/yyyy"), $"{newItem.Price:N0}",
                           newItem.Discount == null ? "-" : newItem.Discount.Name
                    });
            }
            else if (typeof(T) == typeof(Customer))
            {
                var customer = item as Customer;
                int indexOfCustomer = _commonController.IndexOfItem(_customers, customer);
                if (indexOfCustomer >= 0)
                {
                    var title = "Lỗi trùng lặp";
                    var msg = "Thông tin khách hàng này đã tồn tại!";
                    MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    _commonController.AddNewItem(_customers, customer);
                    tblCustomer.Rows.Add(new object[] {
                        customer.PersonId, customer.FullName?.ToString(), customer.BirthDate.ToString(DATE_FORMAT),
                        customer.Address, customer.PhoneNumber, customer.CustomerType, $"{customer.Point:N0}",
                        customer.CreateTime.ToString(DATE_TIME_FORMAT), customer.Email
                    });
                }
            }
            else if (typeof(T) == typeof(Discount))
            {
                var discount = item as Discount;
                _commonController.AddNewItem(_discounts, discount);
                tblDiscount.Rows.Add(
                    new object[] {
                        discount.DiscountId, discount.Name, discount.StartTime.ToString(DATE_TIME_FORMAT),
                        discount.EndTime.ToString(DATE_TIME_FORMAT), discount.DiscounType,
                        discount.DiscountPercent, $"{discount.DiscountPriceAmount:N0}"
                    }
                );
            }
        }

        public void UpdateItem<T>(T updatedItem)
        {
            if (typeof(T) == typeof(Item))
            {
                var newItem = updatedItem as Item;
                int updatedIndex = -1;
                if (_actionType == ActionType.NORMAL)
                {
                    updatedIndex = _commonController.UpdateItem(_items, newItem);
                }
                else
                {
                    updatedIndex = _commonController.UpdateItem(_searchItemResults, newItem);
                    _commonController.UpdateItem(_items, newItem);
                }
                tblItem.Rows.RemoveAt(updatedIndex);
                tblItem.Rows.Insert(updatedIndex,
                    new object[] {
                            newItem.ItemId, newItem.ItemName, newItem.ItemType, newItem.Quantity,
                            newItem.Brand, newItem.ReleaseDate.ToString("dd/MM/yyyy"), $"{newItem.Price:N0}",
                            newItem.Discount == null ? "-" : newItem.Discount.Name
                        }
                );
            }
            else if (typeof(T) == typeof(Customer))
            {
                var customer = updatedItem as Customer;
                int updatedIndex = -1;
                if (_actionType == ActionType.NORMAL)
                {
                    updatedIndex = _commonController.UpdateItem(_customers, customer);
                }
                else
                {
                    updatedIndex = _commonController.UpdateItem(_searchCustomerResults, customer);
                    _commonController.UpdateItem(_customers, customer);
                }
                tblCustomer.Rows.RemoveAt(updatedIndex);
                tblCustomer.Rows.Insert(updatedIndex,
                    new object[] {
                        customer.PersonId, customer.FullName?.ToString(), customer.BirthDate.ToString(DATE_FORMAT),
                        customer.Address, customer.PhoneNumber, customer.CustomerType, $"{customer.Point:N0}",
                        customer.CreateTime.ToString(DATE_TIME_FORMAT), customer.Email
                    }
                );
            }
            else if (typeof(T) == typeof(Discount))
            {
                var discount = updatedItem as Discount;
                int updatedIndex = -1;
                if (_actionType == ActionType.NORMAL)
                {
                    updatedIndex = _commonController.UpdateItem(_discounts, discount);
                }
                else
                {
                    updatedIndex = _commonController.UpdateItem(_searchDiscountResults, discount);
                    _commonController.UpdateItem(_discounts, discount);
                }
                tblDiscount.Rows.RemoveAt(updatedIndex);
                tblDiscount.Rows.Insert(updatedIndex,
                    new object[] {
                        discount.DiscountId, discount.Name, discount.StartTime.ToString(DATE_TIME_FORMAT),
                        discount.EndTime.ToString(DATE_TIME_FORMAT), discount.DiscounType,
                        discount.DiscountPercent, $"{discount.DiscountPriceAmount:N0}"
                    }
                );
            }
        }

        private void BtnAddNewClick(object sender, EventArgs e)
        {
            if (sender.Equals(btnAddNewItem))
            {
                var childView = new AddEditItemFrm(this, _discounts);
                childView.Show();
            }
        }

        private void TblItemCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == tblItem.Columns["tblItemEdit"].Index)
            {
                Item item = _items[e.RowIndex];
                if (_actionType == ActionType.SEARCH)
                {
                    item = _searchItemResults[e.RowIndex];
                }
                var updateItemView = new AddEditItemFrm(this, _discounts, item);
                updateItemView.Show();
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == tblItem.Columns["tblItemRemove"].Index)
            {
                var title = "Xác nhận xóa";
                var msg = "Bạn có chắc chắn muốn xóa bản ghi này không?";
                var ans = ShowConfirmDialog(msg, title);
                if (ans == DialogResult.Yes)
                {
                    int removedItemIndex = -1;
                    if (_actionType == ActionType.NORMAL)
                    {
                        Item item = _items[e.RowIndex];
                        removedItemIndex = _commonController.DeleteItem(_items, item);
                    }
                    else if (_actionType == ActionType.SEARCH)
                    {
                        Item item = _searchItemResults[e.RowIndex];
                        removedItemIndex = _commonController.DeleteItem(_searchItemResults, item);
                        _commonController.DeleteItem(_items, item);
                    }
                    tblItem.Rows.RemoveAt(removedItemIndex);
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            // tblItemRemove
        }

        private DialogResult ShowConfirmDialog(string msg, string title)
        {
            return MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void SortItemHandler(object sender, EventArgs e)
        {
            //if (radioSortItemByPriceASC.Checked)
            //{
            //    _commonController.Sort(_items, _itemController.CompareItemByPriceASC);
            //}
            //else if (radioSortItemByPriceDESC.Checked)
            //{
            //    _commonController.Sort(_items, _itemController.CompareItemByPriceDESC);
            //}
            //else if (radioSortItemByQuantity.Checked)
            //{
            //    _commonController.Sort(_items, _itemController.CompareItemByQuantity);
            //}
            //else if (radioSortItemByProductDate.Checked)
            //{
            //    _commonController.Sort(_items, _itemController.CompareItemByDate);
            //}
            //else if (radioSortItemByName.Checked)
            //{
            //    _commonController.Sort(_items, _itemController.CompareItemByName);
            //}

            if (radioSortItemByPriceASC.Equals(sender))
            {
                _commonController.Sort(_items, _itemController.CompareItemByPriceASC);
            }
            else if (radioSortItemByPriceDESC.Equals(sender))
            {
                _commonController.Sort(_items, _itemController.CompareItemByPriceDESC);
            }
            else if (radioSortItemByQuantity.Equals(sender))
            {
                _commonController.Sort(_items, _itemController.CompareItemByQuantity);
            }
            else if (radioSortItemByProductDate.Equals(sender))
            {
                _commonController.Sort(_items, _itemController.CompareItemByDate);
            }
            else if (radioSortItemByName.Equals(sender))
            {
                _commonController.Sort(_items, _itemController.CompareItemByName);
            }
            ShowItems(_items);
        }

        private void ShowItems(List<Item> items)
        {
            tblItem.Rows.Clear();
            foreach (var item in items)
            {
                tblItem.Rows.Add(new object[]
                {
                    item.ItemId, item.ItemName, item.ItemType, item.Quantity,
                    item.Brand, item.ReleaseDate.ToString("dd/MM/yyyy"), $"{item.Price:N0}",
                    item.Discount == null ? "-" : item.Discount.Name
                });
            }
        }

        private void ComboSearchItemSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboSearchItem.SelectedIndex)
            {
                case 0:
                case 2:
                case 3:
                    txtSearchItem.Enabled = true;
                    numericItemFrom.Enabled = false;
                    numericItemTo.Enabled = false;
                    break;
                case 1:
                case 4:
                    txtSearchItem.Enabled = false;
                    numericItemFrom.Enabled = true;
                    numericItemTo.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void BtnSearchItemClick(object sender, EventArgs e)
        {
            tblItem.Rows.Clear();
            _actionType = ActionType.SEARCH;
            if (comboSearchItem.SelectedIndex == -1)
            {
                var msg = "Vui lòng chọn tiêu chí tìm kiếm để tiếp tục";
                var title = "Lỗi dữ liệu";
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboSearchItem.SelectedIndex == 0)
            {
                var key = txtSearchItem.Text;
                _searchItemResults = _commonController.Search(_items, _itemController.IsItemNameMatch, key);
                if (_searchItemResults.Count == 0)
                {
                    var msg = "Không tìm thấy kết quả nào.";
                    var title = "Kết quả tìm kiếm";
                    MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ShowItems(_searchItemResults);
                }
            }
            else if (comboSearchItem.SelectedIndex == 1)
            {
                int from = (int)numericItemFrom.Value;
                int to = (int)numericItemTo.Value;
                _searchItemResults = _commonController.Search(_items, _itemController.IsItemPriceMatch, from, to);
                if (_searchItemResults.Count == 0)
                {
                    var msg = "Không tìm thấy kết quả nào.";
                    var title = "Kết quả tìm kiếm";
                    MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ShowItems(_searchItemResults);
                }
            }
            else if (comboSearchItem.SelectedIndex == 2) // loại mặt hàng
            {
                var key = txtSearchItem.Text;
                _searchItemResults = _commonController.Search(_items, _itemController.IsItemTypeMatch, key);
                if (_searchItemResults.Count == 0)
                {
                    var msg = "Không tìm thấy kết quả nào.";
                    var title = "Kết quả tìm kiếm";
                    MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ShowItems(_searchItemResults);
                }
            }
            else if (comboSearchItem.SelectedIndex == 3) // hãng
            {
                var key = txtSearchItem.Text;
                _searchItemResults = _commonController.Search(_items, _itemController.IsItemBrandMatch, key);
                if (_searchItemResults.Count == 0)
                {
                    var msg = "Không tìm thấy kết quả nào.";
                    var title = "Kết quả tìm kiếm";
                    MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ShowItems(_searchItemResults);
                }
            }
            else if (comboSearchItem.SelectedIndex == 4)
            {
                int from = (int)numericItemFrom.Value;
                int to = (int)numericItemTo.Value;
                _searchItemResults = _commonController.Search(_items, _itemController.IsItemQuantityMatch, from, to);
                if (_searchItemResults.Count == 0)
                {
                    var msg = "Không tìm thấy kết quả nào.";
                    var title = "Kết quả tìm kiếm";
                    MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ShowItems(_searchItemResults);
                }
            }
        }

        private void BtnRefreshClick(object sender, EventArgs e)
        {
            radioSortItemByPriceASC.Checked = false;
            radioSortItemByPriceDESC.Checked = false;
            radioSortItemByQuantity.Checked = false;
            radioSortItemByProductDate.Checked = false;
            radioSortItemByName.Checked = false;
            _actionType = ActionType.NORMAL;
            if (sender.Equals(btnRefreshItem))
            {
                ShowItems(_items);
            }
            else if (sender.Equals(btnRefreshCustomer))
            {
                ShowCustomers(_customers);
            }
            else if (sender.Equals(btnRefreshDiscount))
            {
                ShowDiscounts(_discounts);
            }
        }

        private void BtnAddNewCustomerClick(object sender, EventArgs e)
        {
            var childView = new AddEditCustomerFrm(this, null);
            childView.Show();
        }

        private void TblCustomerCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == tblCustomer.Columns["tblCustomerColEdit"].Index)
            {
                Customer customer = _customers[e.RowIndex];
                if (_actionType == ActionType.SEARCH)
                {
                    customer = _searchCustomerResults[e.RowIndex];
                }
                var updateItemView = new AddEditCustomerFrm(this, customer);
                updateItemView.Show();
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == tblCustomer.Columns["tblCustomerColRemove"].Index)
            {
                var title = "Xác nhận xóa";
                var msg = "Bạn có chắc chắn muốn xóa bản ghi này không?";
                var ans = ShowConfirmDialog(msg, title);
                if (ans == DialogResult.Yes)
                {
                    int removedItemIndex = -1;
                    if (_actionType == ActionType.NORMAL)
                    {
                        Customer customer = _customers[e.RowIndex];
                        removedItemIndex = _commonController.DeleteItem(_customers, customer);
                    }
                    else if (_actionType == ActionType.SEARCH)
                    {
                        Customer customer = _searchCustomerResults[e.RowIndex];
                        removedItemIndex = _commonController.DeleteItem(_searchCustomerResults, customer);
                        _commonController.DeleteItem(_customers, customer);
                    }
                    tblCustomer.Rows.RemoveAt(removedItemIndex);
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void RadioSortCustomerCheckedChanged(object sender, EventArgs e)
        {
            if (radioSortCustomerById.Checked)
            {
                _commonController.Sort(_customers, _customerController.CompareCustomerById);
            }
            else if (radioSortCustomerByName.Checked)
            {
                _commonController.Sort(_customers, _customerController.CompareCustomerByName);
            }
            else if (radioSortCustomerByPoint.Checked)
            {
                _commonController.Sort(_customers, _customerController.CompareCustomerByPointDESC);
            }
            else if (radioSortCustomerByCreatedDate.Checked)
            {
                _commonController.Sort(_customers, _customerController.CompareCustomerByCreatedDate);
            }
            else if (radioSortCustomerByBirthDate.Checked)
            {
                _commonController.Sort(_customers, _customerController.CompareCustomerByBirthDate);
            }
            ShowCustomers(_customers);
        }

        private void BtnSearchCustomerClick(object sender, EventArgs e)
        {
            if (comboSearchCustomer.SelectedIndex == -1)
            {
                var title = "Lỗi dữ liệu";
                var msg = "Vui lòng chọn tiêu chí tìm kiếm trước.";
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtSearchCustomer.Text))
            {
                var title = "Lỗi dữ liệu";
                var msg = "Vui lòng nhập từ khóa cần tìm kiếm trước.";
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _actionType = ActionType.SEARCH;
                _searchCustomerResults.Clear();
                switch (comboSearchCustomer.SelectedIndex)
                {
                    case 0:
                        _searchCustomerResults.AddRange(
                            _commonController.Search(
                                _customers,
                                _customerController.IsCustomerNameMatch,
                                txtSearchCustomer.Text
                                )
                            );
                        break;
                    case 1:
                        _searchCustomerResults.AddRange(
                           _commonController.Search(
                               _customers,
                               _customerController.IsCustomerIdMatch,
                               txtSearchCustomer.Text
                               )
                           );
                        break;
                    case 2:
                        _searchCustomerResults.AddRange(
                           _commonController.Search(
                               _customers,
                               _customerController.IsCustomerTypeMatch,
                               txtSearchCustomer.Text
                               )
                           );
                        break;
                    case 3:
                        _searchCustomerResults.AddRange(
                           _commonController.Search(
                               _customers,
                               _customerController.IsCustomerAddressMatch,
                               txtSearchCustomer.Text
                               )
                           );
                        break;
                    case 4:
                        _searchCustomerResults.AddRange(
                           _commonController.Search(
                               _customers,
                               _customerController.IsCustomerPhoneNumberMatch,
                               txtSearchCustomer.Text
                               )
                           );
                        break;
                    default:
                        break;
                }
                ShowCustomers(_searchCustomerResults);
                if (_searchCustomerResults.Count == 0)
                {
                    var title = "Kết quả tìm kiếm";
                    var msg = "Không tìm thấy kết quả nào.";
                    MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnAddNewDiscountClick(object sender, EventArgs e)
        {
            var childView = new AddEditDiscountFrm(this);
            childView.Show();
        }

        private void BtnDiscountCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == tblDiscount.Columns["tblDiscountColEdit"].Index)
            {
                Discount discount = _discounts[e.RowIndex];
                if (_actionType == ActionType.SEARCH)
                {
                    discount = _searchDiscountResults[e.RowIndex];
                }
                var updateItemView = new AddEditDiscountFrm(this, discount);
                updateItemView.Show();
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == tblDiscount.Columns["tblDiscountColRemove"].Index)
            {
                var title = "Xác nhận xóa";
                var msg = "Bạn có chắc chắn muốn xóa bản ghi này không?";
                var ans = ShowConfirmDialog(msg, title);
                if (ans == DialogResult.Yes)
                {
                    int removedItemIndex = -1;
                    if (_actionType == ActionType.NORMAL)
                    {
                        Discount discount = _discounts[e.RowIndex];
                        removedItemIndex = _commonController.DeleteItem(_discounts, discount);
                    }
                    else if (_actionType == ActionType.SEARCH)
                    {
                        Discount discount = _searchDiscountResults[e.RowIndex];
                        removedItemIndex = _commonController.DeleteItem(_searchDiscountResults, discount);
                        _commonController.DeleteItem(_discounts, discount);
                    }
                    tblDiscount.Rows.RemoveAt(removedItemIndex);
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnSearchDiscountClick(object sender, EventArgs e)
        {
            if (comboSearchDiscount.SelectedIndex == -1)
            {
                var title = "Lỗi tìm kiếm";
                var message = "Vui lòng chọn tiêu chí tìm kiếm trước.";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtSearchDiscount.Text))
            {
                var title = "Lỗi tìm kiếm";
                var message = "Vui lòng nhập giá trị cần tìm trước.";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var key = txtSearchDiscount.Text;
                _actionType = ActionType.SEARCH;
                _searchDiscountResults.Clear();
                switch (comboSearchDiscount.SelectedIndex)
                {
                    case 0:
                        _searchDiscountResults.AddRange(
                            _commonController.Search(
                                _discounts,
                                _discountController.IsStartTimeMatch,
                                key
                                )
                            );
                        break;
                    case 1:
                        _searchDiscountResults.AddRange(
                            _commonController.Search(
                                _discounts,
                                _discountController.IsEndTimeMatch,
                                key
                                )
                            );
                        break;
                    case 2:
                        _searchDiscountResults.AddRange(
                             _commonController.Search(
                                 _discounts,
                                 _discountController.IsDiscountNameMatch,
                                 key
                                 )
                             );
                        break;
                }
            }
            ShowDiscounts(_searchDiscountResults);
            if (_searchDiscountResults.Count == 0)
            {
                var title = "Kết quả tìm kiếm";
                var msg = "Không tìm thấy kết quả nào.";
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TblItemCellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Item item = _items[e.RowIndex];
                if (_actionType == ActionType.SEARCH)
                {
                    item = _searchItemResults[e.RowIndex];
                }
                var bitmap = new Bitmap(item.PathItemPicture.ToString());
                pictureBox_Hang.Image = bitmap;
                richTextBox_MaMH.Text = item.ItemId.ToString();
                richTextBox_TenMH.Text = item.ItemName.ToString();
                richTextBox_LoaiMH.Text = item.ItemType.ToString();
                richTextBox_SoLuong.Text = item.Quantity.ToString();
                richTextBox_HangSX.Text = item.Brand.ToString();
                richTextBox_NgaySX.Text = item.ReleaseDate.ToString();
                richTextBox_GiaBan.Text = item.Price.ToString();
                richTextBox_KhuyenMai.Text = "";

            }

        }

        private void TblICusomerCellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Customer customer = _customers[e.RowIndex];
                if (_actionType == ActionType.SEARCH)
                {
                    customer = _searchCustomerResults[e.RowIndex];
                }
                var bitmap = new Bitmap(customer.PathCustomerPicture.ToString());
                pictureBox_KH.Image = bitmap;
                richTextBox_MaKH.Text = customer.PersonId.ToString();
                richTextBox_TenKH.Text = customer.FullName.ToString();
                richTextBox_NgaySinh.Text = customer.BirthDate.ToString();
                richTextBox_DiaChi.Text = customer.Address.ToString();
                richTextBox_Email.Text = customer.Email.ToString();
                richTextBox_SoDT.Text = customer.PhoneNumber.ToString();
                richTextBox_LoaiKH.Text = customer.CustomerType.ToString();
                richTextBox_DiemTL.Text = customer.Point.ToString();
                richTextBox_NgayTaoTK.Text = customer.CreateTime.ToString();
            }
        }
    }
}
