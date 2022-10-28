using System;
using System.Collections.Generic;
using Models;

namespace Controllers
{
    public class Utils
    {
        public static List<Item> CreateFakeItems()
        {
            List<Item> items = new List<Item>();
            items.Add(new Item(0, "Monkey D.Luffy", "Mô hình", 20, "Japhan", DateTime.Now, 280, null, ".\\Image\\ImageItem\\luffy.jpg"));
            items.Add(new Item(1, "Roronoa Zoro", "Mô hình", 10, "Japhan", DateTime.Now, 320, null, ".\\Image\\ImageItem\\zoro.png"));
            items.Add(new Item(2, "Brook", "Mô hình", 30, "Apple", DateTime.Now, 350, null, ".\\Image\\ImageItem\\brook.jpg"));
            items.Add(new Item(3, "Monkey D.Dragon", "Mô hình", 30, "Japhan", DateTime.Now, 20, null, ".\\Image\\ImageItem\\dragon.jfif"));
            items.Add(new Item(4, "Dracule Mihawk", "Mô hình", 20, "Japhan", DateTime.Now, 80, null, ".\\Image\\ImageItem\\mihawk.jpg"));
            items.Add(new Item(5, "Portgas D.Ace", "Mô hình", 300, "Japhan", DateTime.Now, 35, null, ".\\Image\\ImageItem\\ace.jpg"));
            items.Add(new Item(6, "Monkey D. Garp", "Mô hình", 1000, "Japhan", DateTime.Now, 135, null, ".\\Image\\ImageItem\\garp.jfif"));
            items.Add(new Item(7, "Kaidou", "Mô hình", 100, "Japhan", DateTime.Now, 125, null, ".\\Image\\kaidou.jfif"));
            items.Add(new Item(8, "Shanks", "Mô hình", 100, "Japhan", DateTime.Now, 125, null, ".\\Image\\ImageItem\\shanks.jpg"));
            items.Add(new Item(9, "Borsalino", "Mô hình", 100, "Japhan", DateTime.Now, 125, null, ".\\Image\\ImageItem\\borsalino.jpg"));
            items.Add(new Item(10, "Sakazuki", "Mô hình", 100, "Japhan", DateTime.Now, 125, null, ".\\Image\\ImageItem\\sakazuki.png"));
            items.Add(new Item(11, "Kuzan", "Mô hình", 100, "Japhan", DateTime.Now, 125, null, ".\\Image\\ImageItem\\kuzan.jfif"));

            return items;
        }

        public static List<Customer> CreateFakeCustomer()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer("0123654789123", "Nguyễn Thị Thu Hằng",
                DateTime.ParseExact("16/11/2002", "dd/MM/yyyy", null), "Hà Nội", "0978123456",
                "Khách mua buôn", 1090, DateTime.Now, "trungdung@xmail.com", ".\\Image\\ImageCustomer\\Hang.jpg"));
            customers.Add(new Customer("0123654789124", "Dương Thanh Túc",
                DateTime.ParseExact("22/09/2007", "dd/MM/yyyy", null), "Hải Dương", "0972183457",
                "Khách mua lẻ", 180, DateTime.Now, "vietluan@xmail.com", ".\\Image\\ImageCustomer\\Tuc.jpg"));
            customers.Add(new Customer("0123654789125", "Mẫn Bá Tuyên",
                DateTime.ParseExact("12/01/2002", "dd/MM/yyyy", null), "Đà Nẵng", "0978143458",
                "Khách mua buôn", 5000, DateTime.Now, "thuha@xmail.com", ".\\Image\\ImageCustomer\\Tuyen.jpg"));
            customers.Add(new Customer("0123654789126", "Hoàng Văn Phong",
                DateTime.ParseExact("16/10/2000", "dd/MM/yyyy", null), "Hồ Chí Minh", "0978173459",
                "Khách mua lẻ", 200, DateTime.Now, "batuan@xmail.com", ".\\Image\\ImageCustomer\\Phong.jpg"));
            customers.Add(new Customer("0123654789120", "Vũ Thế Lực",
                DateTime.ParseExact("19/08/2001", "dd/MM/yyyy", null), "Hòa Bình", "0978623466",
                "Khách mua buôn", 600, DateTime.Now, "anhdunguu@xmail.com", ".\\Image\\ImageCustomer\\Luc.jpg"));
            customers.Add(new Customer("0123654789127", "Nguyễn Thị Thảo",
                DateTime.ParseExact("22/04/1996", "dd/MM/yyyy", null), "Vũng Tàu", "0978123476",
                "Khách mua lẻ", 700, DateTime.Now, "quoccong@xmail.com", ".\\Image\\ImageCustomer\\Thao.jpg"));
            customers.Add(new Customer("0123654789129", "Hà Văn Thắng",
                DateTime.ParseExact("11/05/2000", "dd/MM/yyyy", null), "Đặng Thị Huệ", "0978193851",
                "Khách mua lẻ", 400, DateTime.Now, "vanthangha@xmail.com", ".\\Image\\ImageCustomer\\Hue.jpg"));
            customers.Add(new Customer("0123654789129", "Hà Văn Thắng",
               DateTime.ParseExact("11/05/2000", "dd/MM/yyyy", null), "Nguyễn Thị Ngọc", "0978193851",
               "Khách mua lẻ", 400, DateTime.Now, "vanthangha@xmail.com", ".\\Image\\ImageCustomer\\Ngoc.jpg"));

            return customers;
        }

        public static List<Discount> CreateFakeDiscounts()
        {
            var dateTimeFormat = "dd/MM/yyyy HH:mm:ss";
            List<Discount> discounts = new List<Discount>();
            discounts.Add(new Discount(0, "KM 1/1",
                DateTime.ParseExact("01/01/2022 01:01:01", dateTimeFormat, null),
                DateTime.ParseExact("01/01/2022 23:59:59", dateTimeFormat, null),
                "Giảm giá trực tiếp", 50000, 0));
            discounts.Add(new Discount(1, "KM 15/1",
                DateTime.ParseExact("15/01/2022 15:15:15", dateTimeFormat, null),
                DateTime.ParseExact("15/01/2022 23:59:59", dateTimeFormat, null),
                "Giảm giá trực tiếp", 50000, 0));
            discounts.Add(new Discount(2, "KM 2/2",
                DateTime.ParseExact("02/02/2022 02:02:02", dateTimeFormat, null),
                DateTime.ParseExact("02/02/2022 23:59:59", dateTimeFormat, null),
                "Giảm giá trực tiếp", 150000, 0));
            discounts.Add(new Discount(3, "KM 3/3",
                DateTime.ParseExact("03/03/2022 03:03:03", dateTimeFormat, null),
                DateTime.ParseExact("03/03/2022 23:59:59", dateTimeFormat, null),
                "Khuyến mãi % giá bán", 0, 20));
            discounts.Add(new Discount(4, "KM 4/4",
                DateTime.ParseExact("04/04/2022 04:04:04", dateTimeFormat, null),
                DateTime.ParseExact("04/04/2022 23:59:59", dateTimeFormat, null),
                "Giảm giá trực tiếp", 50000, 0));
            discounts.Add(new Discount(5, "KM 5/5",
                DateTime.ParseExact("05/05/2022 05:05:05", dateTimeFormat, null),
                DateTime.ParseExact("05/05/2022 23:59:59", dateTimeFormat, null),
                "Khuyến mãi % giá bán", 0, 30));
            return discounts;
        }
    }
}
