using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance {
            get { if (instance == null) instance = new BillDAO(); return instance; } 
            private set => instance = value; 
        }

        private BillDAO() { }
        //Thàng công ra bill ID
        //Thất bại ra -1
        public int GetUnCheckBill(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from Bill Where idTable = " + id + " And status = 0");

            if(data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }
    }
}
