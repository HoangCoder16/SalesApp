using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SelectedItem : Item
    {
        public int NumberOfSelectedItem { get; set; }
        public int PriceAfterDiscount { get; set; }

        public SelectedItem() { }

        public SelectedItem(int numberOfSelectedItem)
        {
            NumberOfSelectedItem = numberOfSelectedItem;
            CalculatePriceAfterDiscount();
        }

        private void CalculatePriceAfterDiscount()
        {
            if (Discount == null)
            {
                PriceAfterDiscount = Price;
            } else
            {
                var currenTime = DateTime.Now;
                if (currenTime >= Discount.StartTime && currenTime <= Discount.EndTime)
                {
                    if (Discount.DiscountPercent > 0)
                    {
                        PriceAfterDiscount = (int)(Price * (1 - 1.0f * Discount.DiscountPercent / 100));
                    }
                    if (Discount.DiscountPriceAmount > 0) 
                    {
                        PriceAfterDiscount = Price - Discount.DiscountPriceAmount;
                    }
                }
            }
        }

        public SelectedItem(int itemID, string itemName, string itemType,
            int quantity, string brand, DateTime releaseDate,
          int price, Discount discount,string pathPictureItem, int numberOfSelectedItem) :
            base(itemID, itemName, itemType, quantity, brand, releaseDate, price, discount,pathPictureItem)

        {

            NumberOfSelectedItem = numberOfSelectedItem;
            PriceAfterDiscount = Price;

        }
    }
}
