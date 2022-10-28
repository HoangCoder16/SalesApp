using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;

namespace Controllers
{
    public interface IBillController
    {
        void UpdateBill(BillDetail bill, SelectedItem item);
        void RemoveItem(BillDetail bill, int index);
        bool IsBillDetailIdMatch(BillDetail billDetail, string id);
        bool IsBillDetailIdCustomerMatch(BillDetail billDetail, string id);
    }
}
