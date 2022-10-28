using Models;
using System;
using System.Text.RegularExpressions;

namespace Controllers
{
    public class BillController : IBillController
    {
        public bool IsBillDetailIdCustomerMatch(BillDetail billDetail, string id)
        {
            var pattern = $".*{id}.*";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(billDetail.Cart.Customer.PersonId.ToString());
        }

        public bool IsBillDetailIdMatch(BillDetail billDetail, string id)
        {
            var pattern = $".*{id}.*";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(billDetail.BillId.ToString());
        }

        public void RemoveItem(BillDetail bill, int index)
        {
            var item = bill.Cart.SelectedItems[index];
            bill.TotalItem -= item.NumberOfSelectedItem;
            bill.SubTotal -= item.NumberOfSelectedItem * item.Price;
            if (item.Discount != null)
            {
               
                    bill.TotalDiscountAmount -= (int)(item.NumberOfSelectedItem *
                item.Price * (1.0f * item.Discount.DiscountPercent / 100)) +
                item.NumberOfSelectedItem * item.Discount.DiscountPriceAmount;
            }
            bill.TotalAmount = bill.SubTotal - bill.TotalDiscountAmount;
            bill.Cart.SelectedItems.Remove(item);
        }
        public void UpdateBill(BillDetail bill, SelectedItem item)
        {
            int index = bill.Cart.SelectedItems.IndexOf(item);
            if (index >= 0)
            {
                var items = bill.Cart.SelectedItems;
                bill.TotalItem = 0;
                bill.TotalAmount = 0;
                bill.SubTotal = 0;
                bill.TotalDiscountAmount = 0;
                foreach (var it in items)
                {
                    bill.TotalItem += it.NumberOfSelectedItem;
                   bill.SubTotal += it.NumberOfSelectedItem * it.Price;
                   if (it.Discount != null)
                    {
                        var currentTime = DateTime.Now;
                        if (currentTime >= item.Discount.StartTime && currentTime <= item.Discount.EndTime)
                        {
                            bill.TotalDiscountAmount += (int)(it.NumberOfSelectedItem *
                        it.Price * (1.0f * it.Discount.DiscountPercent / 100)) +
                        it.NumberOfSelectedItem * it.Discount.DiscountPriceAmount;
                        }
                    }
                }
                bill.TotalAmount = bill.SubTotal - bill.TotalDiscountAmount;

            }
            else
            {
                bill.Cart.SelectedItems.Add(item);
                bill.TotalItem += item.NumberOfSelectedItem;
                bill.SubTotal += item.NumberOfSelectedItem * item.Price;
                if (item.Discount != null)
                {
                    var currentTime = DateTime.Now;
                    if (currentTime >= item.Discount.StartTime && currentTime <= item.Discount.EndTime)
                    {
                        bill.TotalDiscountAmount += (int)(item.NumberOfSelectedItem *
                    item.Price * (1.0f * item.Discount.DiscountPercent / 100)) +
                    item.NumberOfSelectedItem * item.Discount.DiscountPriceAmount;
                    }
                }
                bill.TotalAmount = bill.SubTotal - bill.TotalDiscountAmount;
            }
        }
    }
}
