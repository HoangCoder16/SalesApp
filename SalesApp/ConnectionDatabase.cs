using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;
namespace SalesApp
{
    internal class ConnectionDatabase
    {
        SqlConnection conn;
        SqlCommand cmd;
        public ConnectionDatabase()
        {
            conn = new SqlConnection(@"Data Source=LAPTOP-N52EILCE;Initial Catalog=SalesApp;Integrated Security=True");
            conn.Open();
            cmd = conn.CreateCommand();
        }

        public List<Item> ConnectionSQLItem()
        {
            List<Item> listItem = new List<Item>();
            try
            {

                listItem = FindAllItem(conn);
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return listItem;
        }
        public List<Item> FindAllItem(SqlConnection conn)
        {
            List<Item> list = new List<Item>();

            string sql = "SELECT * FROM Item";
            cmd.CommandText = sql;
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        var ItemId = reader.GetInt32(0);
                        var ItemName = reader.GetString(1);
                        var ItemType = reader.GetString(2);
                        var Quantity = reader.GetInt32(3);
                        var Brand = reader.GetString(4);
                        var ReleaseDate = reader.GetDateTime(5);
                        var Price = reader.GetInt32(6);
                        var DiscountId = reader.GetInt32(7);
                  
                        var PathItemPicture = reader.GetString(8);


                        list.Add(new Item(ItemId, ItemName, ItemType, Quantity, Brand, ReleaseDate
                    , Price, new Discount(DiscountId), PathItemPicture));
                        /*if (!DiscountId.Equals("-"))
                        {
                            list.Add(new Item(ItemId, ItemName, ItemType, Quantity, Brand, ReleaseDate
                       , Price, new Discount(DiscountId), PathItemPicture));
                        } else
                        {
                            list.Add(new Item(ItemId, ItemName, ItemType, Quantity, Brand, ReleaseDate
                     , Price, null, PathItemPicture));
                        }*/

                    }
                }
            }
            return list;
        }
        public void AddItem(Item item)
        {
            int Discount;
            if (item.Discount == null)
            {
                Discount = -1;
            }
            else
            {
                Discount = item.Discount.DiscountId;
            }
            string sql = "INSERT INTO Item VALUES('" + item.ItemId.ToString() + "'," +
                "N'" + item.ItemName + "',N'" + item.ItemType + "'," +
                "'" + item.Quantity.ToString() + "',N'" + item.Brand + "'," +
                "'" + item.ReleaseDate.ToString() + "','" + item.Price.ToString() + "'," +
                "" + Discount + ",'" + item.PathItemPicture + "')";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
        public void RemoveItem(Item item)
        {
            string sql = "DELETE FROM  Item WHERE ItemId = '" + item.ItemId.ToString() + "'";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
        public void UpdateItem(Item item)
        {
            // string Discount;
            string sql;
            if (item.Discount == null)
            {
                sql = "UPDATE  Item SET " +
                "ItemName = N'" + item.ItemName + "',ItemType = N'" + item.ItemType + "'," +
                "Quantity = '" + item.Quantity.ToString() + "',Brand = N'" + item.Brand + "'," +
                "ReleaseDate = '" + item.ReleaseDate.ToString() + "',Price = '" + item.Price.ToString() + "'," +
                "PathItemPicture = '" + item.PathItemPicture + "'" +
                " WHERE ItemId = '" + item.ItemId.ToString() + "'";
            }
            else
            {
                sql = "UPDATE  Item SET " +
                "ItemName = N'" + item.ItemName + "',ItemType = N'" + item.ItemType + "'," +
                "Quantity = '" + item.Quantity.ToString() + "',Brand = N'" + item.Brand + "'," +
                "ReleaseDate = '" + item.ReleaseDate.ToString() + "',Price = '" + item.Price.ToString() + "'," +
                "DiscountId = '" + item?.Discount?.DiscountId.ToString() + "',PathItemPicture = '" + item.PathItemPicture + "'" +
                " WHERE ItemId = '" + item.ItemId.ToString() + "'";
            }

            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }


        public List<Discount> ConnectionSQLDiscount()
        {
            List<Discount> listItem = new List<Discount>();
            try
            {
                listItem = FindAllDiscount(conn);
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return listItem;
        }
        public List<Discount> FindAllDiscount(SqlConnection conn)
        {
            List<Discount> list = new List<Discount>();
            string sql = "SELECT * FROM Discount";
            cmd.CommandText = sql;
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        var DiscountId = reader.GetInt32(0);
                        var DiscountName = reader.GetString(1);
                        var StartTime = reader.GetDateTime(2);
                        var EndTime = reader.GetDateTime(3);
                        var DiscounType = reader.GetString(4);
                        var DiscountPriceAmount = reader.GetInt32(5);
                        var DiscountPercent = reader.GetInt32(6);

                        list.Add(new Discount(DiscountId, DiscountName, StartTime, EndTime, DiscounType, DiscountPriceAmount, DiscountPercent));
                    }
                }
            }
            return list;
        }
        public void AddDiscount(Discount discount)
        {
            string sql = "INSERT INTO Discount VALUES('" + discount.DiscountId.ToString() + "'," +
                "N'" + discount.Name + "','" + discount.StartTime.ToString() + "'," +
                "'" + discount.EndTime.ToString() + "',N'" + discount.DiscounType + "'," +
                "'" + discount.DiscountPriceAmount.ToString() + "','" + discount.DiscountPercent.ToString() + "')";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
        public void RemoveDiscount(Discount discount)
        {
            string sql = "DELETE FROM Discount WHERE DiscountId = '" + discount.DiscountId.ToString() + "'";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
        public void UpdateDiscount(Discount discount)
        {
            string sql = "UPDATE  Discount SET " +
                "Name = N'" + discount.Name + "',StartTime = '" + discount.StartTime.ToString() + "'," +
                "EndTime = '" + discount.EndTime.ToString() + "',DiscounType = N'" + discount.DiscounType + "'," +
                "DiscountPriceAmount = '" + discount.DiscountPriceAmount.ToString() + "',DiscountPercent = '" + discount.DiscountPercent.ToString() + "' " +
                "where DiscountId = '" + discount.DiscountId.ToString() + "'";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }


        public List<Customer> ConnectionSQLCustomer()
        {
            List<Customer> listCustomer = new List<Customer>();
            try
            {
                listCustomer = FindAllCustomer(conn);
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return listCustomer;
        }
        public List<Customer> FindAllCustomer(SqlConnection conn)
        {
            List<Customer> list = new List<Customer>();
            string sql = "SELECT * FROM Customer";
            cmd.CommandText = sql;
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        var PersonId = reader.GetString(0);
                        var FullName = reader.GetString(1);
                        var BirthDate = reader.GetDateTime(2);
                        var Address = reader.GetString(3);
                        var PhoneNumber = reader.GetString(4);
                        var CustomerType = reader.GetString(5);
                        var Point = reader.GetInt32(6);
                        var CreateTime = reader.GetDateTime(7);
                        var Email = reader.GetString(8);
                        var PathCustomerPicture = reader.GetString(9);
                        list.Add(new Customer(PersonId, FullName, BirthDate, Address,
                           PhoneNumber, CustomerType, Point, CreateTime, Email, PathCustomerPicture
                            ));
                    }
                }
            }
            return list;
        }
        public void AddCustomer(Customer customer)
        {
            string sql = "INSERT INTO Customer VALUES('" + customer.PersonId + "'," +
                "N'" + customer.FullName + "','" + customer.BirthDate.ToString() + "'," +
                "N'" + customer.Address + "','" + customer.PhoneNumber + "'," +
                "N'" + customer.CustomerType + "','" + customer.Point.ToString() + "'," +
                "'" + customer.CreateTime.ToString() + "','" + customer.Email + "'," +
                "'" + customer.PathCustomerPicture + "')";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
        public void RemoveCustomer(Customer customer)
        {
            string sql = "DELETE FROM Customer WHERE PersonId = '" + customer.PersonId + "'";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
        public void UpdateCustomer(Customer customer)
        {
            string sql = "UPDATE  Customer SET " +
                "FullName = N'" + customer.FullName + "',BirthDate = '" + customer.BirthDate.ToString() + "'," +
                "Address = N'" + customer.Address + "',PhoneNumber = '" + customer.PhoneNumber + "'," +
                "CustomerType = N'" + customer.CustomerType + "',Point = '" + customer.Point.ToString() + "'," +
                "CreateTime = '" + customer.CreateTime.ToString() + "',Email = '" + customer.Email + "'," +
                "PathCustomerPicture = '" + customer.PathCustomerPicture + "'" +
                "WHERE PersonId = '" + customer.PersonId + "'";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }



        public List<BillDetail> ConnectionSQLBillDetail()
        {
            List<BillDetail> listBillDetail = new List<BillDetail>();
            try
            {
                listBillDetail = FindAllBillDetail(conn);
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return listBillDetail;
        }
        public List<BillDetail> FindAllBillDetail(SqlConnection conn)
        {
            List<BillDetail> list = new List<BillDetail>();
            string sql = "SELECT * FROM Bill";
            cmd.CommandText = sql;
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        var BillId = reader.GetInt32(0);
                        var PersonId = reader.GetString(1);
                        Cart cart = new Cart(new Customer(PersonId));
                        var FullNameNV = reader.GetString(2);

                        var CreatedTime = reader.GetDateTime(3);
                        var TotalItem = reader.GetInt32(4);
                        var SubTotal = reader.GetInt32(5);
                        var TotalDiscountAmount = reader.GetInt32(6);
                        var TotalAmount = reader.GetInt32(7);
                        var Status = reader.GetString(8);
                        list.Add(new BillDetail(BillId, cart, CreatedTime, TotalItem,
                            SubTotal, TotalDiscountAmount, TotalAmount, Status, "online", FullNameNV));
                    }
                }
            }
            return list;
        }
        public void AddBillDetail(BillDetail billDetail)
        {
            string sql = "INSERT INTO Bill VALUES('" + billDetail.BillId.ToString() + "'," +
                "'" + billDetail.Cart.Customer.PersonId.ToString() + "',N'" + billDetail.StaffName + "'," +
                "'" + billDetail.CreatedTime.ToString() + "','" + billDetail.TotalItem.ToString() + "'," +
                "'" + billDetail.SubTotal.ToString() + "','" + billDetail.TotalDiscountAmount.ToString() + "'," +
                "'" + billDetail.TotalAmount.ToString() + "',N'" + billDetail.Status + "')";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
        public void RemoveBillDetail(BillDetail billDetail)
        {
            string sql = "DELETE FROM Bill WHERE BillId = '" + billDetail.BillId + "'";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
        public void UpdateBillDetail(BillDetail billDetail)
        {
            string sql = "UPDATE  Bill SET  " +
               "PersonId = '" + billDetail.Cart.Customer.PersonId.ToString() + "',FullNameNV = N'" + billDetail.StaffName + "'," +
               "CreatedTime = '" + billDetail.CreatedTime.ToString() + "',TotalItem = '" + billDetail.TotalItem.ToString() + "'," +
               "SubTotal = '" + billDetail.SubTotal.ToString() + "',TotalDiscountAmount = '" + billDetail.TotalDiscountAmount.ToString() + "'," +
               "TotalAmount = '" + billDetail.TotalAmount.ToString() + "',Status = N'" + billDetail.Status + "' " +
               "WHERE BillId = '" + billDetail.BillId.ToString()+"'";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }


        public List<SelectedItem> ConnectionSQLSelectedItem(BillDetail billDetail)
        {
            List<SelectedItem> listSelectedItem = new List<SelectedItem>();
            try
            {
                listSelectedItem = FindAllSelectedItem(conn, billDetail);
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return listSelectedItem;
        }
        public List<SelectedItem> FindAllSelectedItem(SqlConnection conn, BillDetail billDetail)
        {
            List<SelectedItem> list = new List<SelectedItem>();
            string sql = "SELECT * FROM BillDetail";
            cmd.CommandText = sql;
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        var BillId = reader.GetInt32(0);
                        var ItemId = reader.GetInt32(1);
                        var ItemName = reader.GetString(2);
                        var NumberOfSelectedItem = reader.GetInt32(3);
                        var Price = reader.GetInt32(4);
                        var PriceAfterDiscount = reader.GetInt32(5);
                        var TotalAmount = reader.GetInt32(6);
                        if (BillId.Equals(billDetail.BillId))
                        {
                            list.Add(new SelectedItem(ItemId, ItemName,
                             NumberOfSelectedItem, Price, PriceAfterDiscount,
                            TotalAmount));
                        }

                    }
                }
            }
            return list;
        }
        public void AddBillDetail(BillDetail billDetail, SelectedItem selectedItem)
        {
            string sql = "INSERT INTO BillDetail VALUES('" + billDetail.BillId.ToString() + "'," +
                "'" + selectedItem.ItemId.ToString() + "',N'" + selectedItem.ItemName + "'," +
                "'" + selectedItem.NumberOfSelectedItem.ToString() + "','" + selectedItem.Price.ToString() + "'," +
                "'" + selectedItem.PriceAfterDiscount.ToString() + "'," +
                "'" + (selectedItem.NumberOfSelectedItem * selectedItem.Price) + "')";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
        public void UpdateBillDetail(BillDetail billDetail, SelectedItem selectedItem)
        {
            string sql = "UPDATE  BillDetail SET " +
                "ItemName = N'" + selectedItem.ItemName + "'," +
                "NumberOfSelectedItem = '" + selectedItem.NumberOfSelectedItem.ToString() + "',Price = '" + selectedItem.Price.ToString() + "'," +
                "PriceAfterDiscount = '" + selectedItem.PriceAfterDiscount.ToString() + "'," +
                "TotalAmount = '" + (selectedItem.NumberOfSelectedItem * selectedItem.Price) + "' " +
                "WHERE BillId = '"+ billDetail .BillId.ToString()+ "' AND ItemId = '" + selectedItem.ItemId.ToString() + "'";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
        public void RemoveBillDetail(BillDetail billDetail, SelectedItem selectedItem)
        {
            string sql = "DELETE FROM BillDetail WHERE BillId = '" + billDetail.BillId.ToString() + "' AND ItemId = '" + selectedItem.ItemId.ToString() + "'";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
        public void RemoveTableBillDetail(BillDetail billDetail)
        {
            string sql = "DELETE FROM BillDetail WHERE BillId = '" + billDetail.BillId + "'";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }


        public List<SelectedItem> StatisticalItemOfDay()
        {
            List<SelectedItem> listItem = new List<SelectedItem>();
            try
            {

                listItem = ItemOfDay(conn);
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return listItem;
        }
        public List<SelectedItem> ItemOfDay(SqlConnection conn)
        {
            List<SelectedItem> list = new List<SelectedItem>();

            string sql = "EXEC MH_BAN_TRONG_NGAY";
            cmd.CommandText = sql;
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                      //  var BillId = reader.GetInt32(0);
                        var ItemId = reader.GetInt32(0);
                        var ItemName = reader.GetString(1);
                        var NumberOfSelectedItem = reader.GetInt32(2);
                        var Price = reader.GetInt32(3);
                        var PriceAfterDiscount = reader.GetInt32(4);
                        var TotalAmount = reader.GetInt32(5);
          
                            list.Add(new SelectedItem(ItemId, ItemName,
                             NumberOfSelectedItem, Price, PriceAfterDiscount,
                            TotalAmount));
                    }
                }
            }
            return list;
        }



        public List<Customer> StatisticalCustomerOfDay()
        {
            List<Customer> listCustomer = new List<Customer>();
            try
            {
                listCustomer = CustomerOfDay(conn);
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return listCustomer;
        }
        public List<Customer> CustomerOfDay(SqlConnection conn)
        {
            List<Customer> list = new List<Customer>();
            string sql = "EXEC KH_MUA_TRONG_NGAY";
            cmd.CommandText = sql;
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        var PersonId = reader.GetString(0);
                        var FullName = reader.GetString(1);
                        var BirthDate = reader.GetDateTime(2);
                        var Address = reader.GetString(3);
                        var PhoneNumber = reader.GetString(4);
                        var CustomerType = reader.GetString(5);
                        var Point = reader.GetInt32(6);
                        var CreateTime = reader.GetDateTime(7);
                        var Email = reader.GetString(8);
                        var PathCustomerPicture = reader.GetString(9);
                        list.Add(new Customer(PersonId, FullName, BirthDate, Address,
                           PhoneNumber, CustomerType, Point, CreateTime, Email, PathCustomerPicture
                            ));
                    }
                }
            }
            return list;
        }


        public List<BillDetail> StatisticalBillOfDay()
        {
            List<BillDetail> listBillDetail = new List<BillDetail>();
            try
            {
                listBillDetail = BillOfDay(conn);
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return listBillDetail;
        }
        public List<BillDetail> BillOfDay(SqlConnection conn)
        {
            List<BillDetail> list = new List<BillDetail>();
            string sql = "SELECT * FROM Bill";
            cmd.CommandText = sql;
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        var BillId = reader.GetInt32(0);
                        var PersonId = reader.GetString(1);
                        Cart cart = new Cart(new Customer(PersonId));
                        var FullNameNV = reader.GetString(2);

                        var CreatedTime = reader.GetDateTime(3);
                        var TotalItem = reader.GetInt32(4);
                        var SubTotal = reader.GetInt32(5);
                        var TotalDiscountAmount = reader.GetInt32(6);
                        var TotalAmount = reader.GetInt32(7);
                        var Status = reader.GetString(8);
                        list.Add(new BillDetail(BillId, cart, CreatedTime, TotalItem,
                            SubTotal, TotalDiscountAmount, TotalAmount, Status, "online", FullNameNV));
                    }
                }
            }
            return list;
        }


        public int  NumberItemByDay()
        {
            int number = 0;
            try
            {
                number = NumberItemOfDay(conn);
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return number;
        }
        public int NumberItemOfDay(SqlConnection conn)
        {
            int number = 0;
            string sql = "EXEC Number_Day_Item";
            cmd.CommandText = sql;
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                         number = reader.GetInt32(0);
                    }
                }
            }
            return number;
        }


        public int NumberCustomerByDay()
        {
            int number = 0;
            try
            {
                number = NumberCustomerOfDay(conn);
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return number;
        }
        public int NumberCustomerOfDay(SqlConnection conn)
        {
            int number = 0;
            string sql = "EXEC Number_Day_Customer";
            cmd.CommandText = sql;
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        number = reader.GetInt32(0);
                    }
                }
            }
            return number;
        }


        public int MonneyDay()
        {
            int number = 0;
            try
            {
                number = MonneyOfDay(conn);
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return number;
        }
        public int MonneyOfDay(SqlConnection conn)
        {
            int number = 0;
            string sql = "EXEC Money_Day";
            cmd.CommandText = sql;
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        number = reader.GetInt32(0);
                    }
                }
            }
            return number;
        }
    }
}
