using Server.DAL;
using Server.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.BLL
{
    public class ProcessBill
    {
        private DataAccessLayer DAL = new DataAccessLayer();
        ProcessMember ProcessMember = new ProcessMember();
        private double sum;
        public int insertBill(Bill bill)
        {
            string query = "insert into Bill values('" + bill.UserID.ToString() + "','" + bill.MemberID.ToString() + "','" + bill.CreatedAt.ToString() + "','" + bill.TotalPrice.ToString() + "','WAITING');" +
                "select BillID from Bill where BillID = SCOPE_IDENTITY()";
            DataTable dt = DAL.getDataTable(query);
            DataRow dr = dt.Rows[0];
            return dr.Field<int>("BillID");
        }
        public bool updateBill(Bill bill, string status)
        {
            string query = "update Bill set Status = '" + status + "' where BillID = '" + bill.BillID + "'";
            if (DAL.runQuery(query)) return true;
            return false;
        }
        public bool insertBillItem(int billId, List<Bill_Item> itemsList)
        {
            foreach(Bill_Item item in itemsList)
            {
                string query = "insert into Bill_Item values('" + billId.ToString() + "','" + item.ProductID + "','" + item.Quantity.ToString() + "')";
                if (!DAL.runQuery(query)) return false;
            }
            return true;
        }
        public List<Bill> getBillListByMemberName(string memberName)
        {
            int id = ProcessMember.getMemberID(memberName);
            string query = "select * from Bill where MemberID = '" + id + "'";
            DataTable dt = DAL.getDataTable(query);
            List<DTO.Bill> billList = dt.AsEnumerable()
                .Select(row => new Bill
                {
                    BillID = row.Field<int>("BillID"),
                    UserID = row.Field<int>("UserID"),
                    MemberID = row.Field<int>("MemberID"),
                    Status = row.Field<string>("Status"),
                    CreatedAt = row.Field<DateTime>("CreatedAt"),
                    TotalPrice = row.Field<double>("TotalPrice")
                }).ToList();
            return billList;
        }
        public List<Bill> getBillList()
        {
            string query = "select * from Bill where Status = 'WAITING'";
            DataTable dt = DAL.getDataTable(query);
            List<DTO.Bill> billList = dt.AsEnumerable()
                .Select(row => new Bill
                {
                    BillID = row.Field<int>("BillID"),
                    UserID = row.Field<int>("UserID"),
                    MemberID = row.Field<int>("MemberID"),
                    Status = row.Field<string>("Status"),
                    CreatedAt = row.Field<DateTime>("CreatedAt"),
                    TotalPrice = row.Field<double>("TotalPrice")
                }).ToList();
            return billList;
        }
        public List<Bill_Item> getBillItemsList(int billId)
        {
            string query = "select * from Bill_Item where BillID = '"+billId+"'";
            DataTable dt = DAL.getDataTable(query);
            List<DTO.Bill_Item> billItemsList = dt.AsEnumerable()
                .Select(row => new Bill_Item
                {
                    BillID = row.Field<int>("BillID"),
                    ProductID = row.Field<int>("ProductID"),
                    Quantity = row.Field<int>("Quantity")
                }).ToList();
            return billItemsList;
        }

        public void deleteBillItem(int billId)
        {
            string query = "delete from Bill_Item where BillID = '" + billId + "'";
            if (DAL.runQuery(query))
            {

            }
        }

        public void deleteBill(string memberName)
        {
            int memberId = ProcessMember.getMemberID(memberName);
            List<Bill> billList = getBillListByMemberName(memberName);
            foreach (Bill bill in billList)
            {
                deleteBillItem(bill.BillID);
            }
            string query = "delete from Bill where MemberID = '" + memberId + "'";
            if (DAL.runQuery(query)) { }
        }

        public DataTable getAllBillbyWeek()
        {
            string strquery = "SELECT * FROM Bill " +
                              "WHERE Status = 'SUCCESS' " +
                              "AND CreatedAt >= DATEADD(DAY, -((DATEPART(WEEKDAY, GETDATE()) + @@DATEFIRST - 2) % 7), CAST(GETDATE() AS DATE)) -- Ngày đầu tuần (Thứ Hai) " +
                              "AND CreatedAt < DATEADD(DAY, 7 - ((DATEPART(WEEKDAY, GETDATE()) + @@DATEFIRST - 2) % 7), CAST(GETDATE() AS DATE)) -- Ngày cuối tuần (Chủ Nhật)";
            return DAL.getDataTable(strquery);
        }

        public DataTable getAllBillbyMonth()
        {
            string strquery = "SELECT * FROM Bill " +
                              "WHERE Status = 'SUCCESS' " +
                              "AND YEAR(CreatedAt) = YEAR(GETDATE())  -- Năm hiện tại " +
                              "AND MONTH(CreatedAt) = MONTH(GETDATE())  -- Tháng hiện tại";
            return DAL.getDataTable(strquery);
        }
        public double getTotalPricebyWeek()
        {
            sum = 0;
            string strquery = "SELECT TotalPrice FROM Bill " +
                              "WHERE Status = 'SUCCESS' " +
                              "AND CreatedAt >= DATEADD(DAY, -((DATEPART(WEEKDAY, GETDATE()) + @@DATEFIRST - 2) % 7), CAST(GETDATE() AS DATE)) -- Ngày đầu tuần (Thứ Hai) " +
                              "AND CreatedAt < DATEADD(DAY, 7 - ((DATEPART(WEEKDAY, GETDATE()) + @@DATEFIRST - 2) % 7), CAST(GETDATE() AS DATE)) -- Ngày cuối tuần (Chủ Nhật)";
            DataTable dt = DAL.getDataTable(strquery);
            foreach (DataRow row in dt.Rows)
            {
                sum += Convert.ToInt32(row["TotalPrice"]);
            }
            return sum;
        }

        public double getTotalPricebyMonth()
        {
            sum = 0;
            string strquery = "SELECT TotalPrice FROM Bill " +
                              "WHERE Status = 'SUCCESS' " +
                              "AND YEAR(CreatedAt) = YEAR(GETDATE())  -- Năm hiện tại " +
                              "AND MONTH(CreatedAt) = MONTH(GETDATE())  -- Tháng hiện tại";
            DataTable dt = DAL.getDataTable(strquery);
            foreach (DataRow row in dt.Rows)
            {
                sum += Convert.ToInt32(row["TotalPrice"]);
            }
            return sum;
        }
    }
}
