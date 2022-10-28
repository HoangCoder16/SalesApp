using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Item : IComparable<Item>
    {
        static int s_autoId = 100;
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemType { get; set; }
        public int Quantity { get; set; }
        public string Brand { get; set; }
        public DateTime ReleaseDate { get; set; }     
        public int Price { get; set; }
        public Discount Discount { get; set; }
        public string PathItemPicture { get; set; }
        public Item() { }

        public Item(int id)
        {
            ItemId = id > 0 ? id : s_autoId++;
        }

        public Item(int itemID, string itemName, string itemType, int quantity,
            string brand, DateTime releaseDate,
            int price, Discount discount,string pathItemPicture)
        {
            ItemId = itemID;
            ItemName = itemName;
            ItemType = itemType;
            Quantity = quantity;
            Brand = brand;
            ReleaseDate = releaseDate;
            Price = price;
            Discount = discount;
            PathItemPicture = pathItemPicture;
        }

        public Item(int itemID, string itemName, string itemType, int quantity, string brand, DateTime releaseDate, int price, Discount discount)
        {
            ItemId = itemID;
            ItemName = itemName;
            ItemType = itemType;
            Quantity = quantity;
            Brand = brand;
            ReleaseDate = releaseDate;
            Price = price;
            Discount = discount;
        }

        static void  UpdateAutoId (int v)
        {
            s_autoId = v;
        }
        public int CompareTo(Item other)
        {
            return ItemId - other.ItemId;
        }

        public override bool Equals(object obj)
        {
            return obj is Item item &&
                   ItemId == item.ItemId;
        }

        public override int GetHashCode()
        {
            return -1218291565 + ItemId.GetHashCode();
        }
    }
}
