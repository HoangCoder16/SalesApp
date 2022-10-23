using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;
namespace Databases
{
    public class ConnectionSQL
    {
        public static List<Item> listItem = new List<Item>();
        public void Connection()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var connString = @"Data Source=LAPTOP-N52EILCE;Initial Catalog=SalesApp;Integrated Security=True";
            var conn = DBUtils.GetConnection(connString);
            try
            {
                conn.Open();
                listItem  = FindAll(conn);
               // ShowInfo(people);
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                conn.Close();
            }
        }
        public List<Item> FindAll(SqlConnection conn)
        {
            List<Item> list = new List<Item>();
            string sql = "SELECT * FROM Item";
            var cmd = new SqlCommand(sql, conn);
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //var idColIndex = reader.GetOrdinal("Id");
                        /*     int id = reader.GetInt32(0);
                             string first = reader.GetString(1);
                             string last = reader.GetString(2);
                             string mid = reader.GetString(3);
                             int age = reader.GetInt32(4);
                             string address = reader.GetString(5);*/
                        // list.Add(new Person(id, first, last, mid, age, address));
                        var itemId = reader.GetInt32(0);
                        var itemName = reader.GetString(1);
                        var itemType = reader.GetString(2);          
                        var quantity = reader.GetInt32(3);
                        var brand = reader.GetString(4);
                        var releaseDate = reader.GetString(5);
                        var price = reader.GetInt32(6);
                        var discountId = reader.GetInt32(7);
                        var pathItemPicture = reader.GetString(8);
                        list.Add(new Item(itemId, itemName, itemType, quantity, brand,
                            DateTime.ParseExact(releaseDate, "dd/MM/yyyy", null), price, null, pathItemPicture));
                    }
                }
            }
            return list;
        }
    }
    class DBUtils
    {
        public static SqlConnection GetConnection(string connString)
        {
            return new SqlConnection(connString);
        }
    }
}
