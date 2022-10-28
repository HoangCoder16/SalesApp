using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Controllers
{
    public class CommonController : ICommonController
    {
        public void AddNewItem<T>(List<T> items, T item)
        {
            items.Add(item);
            
        }

        public int DeleteItem<T>(List<T> items, T item)
        {
            int index = IndexOfItem(items, item);
            items.RemoveAt(index);
            return index;
        }

        public int IndexOfItem<T>(List<T> items, T item)
        {
            return items.IndexOf(item);
        }

        public List<T> Search<T, V>(List<T> items, FindItemDelegate1<T, V> del, V value)
        {
            List<T> result = new List<T>();
            foreach (var item in items)
            {
                if (del(item, value))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public List<T> Search<T, V>(List<T> items, FindItemDelegate2<T, V> del, V from, V to)
        {
            List<T> result = new List<T>();
            foreach (var item in items)
            {
                if (del(item, from, to))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public void Sort<T>(List<T> items, Comparison<T> comparer)
        {
            items.Sort(comparer);
        }

        public int UpdateItem<T>(List<T> values, T item)
        {
            int index = IndexOfItem(values, item);
            values.RemoveAt(index);
            values.Insert(index, item);
            return index;
        }


    }
}
