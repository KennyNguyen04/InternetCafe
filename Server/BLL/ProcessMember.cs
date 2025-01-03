using Server.DAL;
using Server.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.BLL
{
    public class ProcessMember
    {
        private DataAccessLayer DAL = new DataAccessLayer();
        public bool checkLoginMember(string username, string password)
        {
            string query = "select * from Member where AccountName = '" + username + "' and Password = '" + password + "'";
            DataTable dt = DAL.getDataTable(query);
            return dt.Rows.Count > 0;
        }
        public double getTotalMoney(string username)
        {
            double totalMoney = 0;
            string query = "select CurrentMoney from Member where AccountName = '" + username + "'";
            DataTable dt = DAL.getDataTable(query);
            if(dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                totalMoney = row.Field<double>("CurrentMoney");
            }            
            return totalMoney;
        }
        public void updateCurrentMoney(string username, double money)
        {
            string query = "update Member set CurrentMoney = '" + money + "' where AccountName = '" + username + "'";
            if (DAL.runQuery(query))
            {
            }
        }

        public bool addMoney(double money, string userName)
        {
            money = money + getTotalMoney(userName);
            string query = "update Member set CurrentMoney = '"+money+"' where AccountName = '"+userName+"'";
            if (DAL.runQuery(query)) return true;
            return false;
        }

        public bool updateNewPass(string userName, string password)
        {
            string query = "update Member set Password = '" + password + "' where AccountName = '" + userName + "'";
            if (DAL.runQuery(query)) return true;
            return false;
        }

        public bool checkValidMember(string username) {
            string query = "select * from Member where AccountName = '" + username + "' and  CurrentMoney > 0";
            DataTable dt = DAL.getDataTable(query);
            return dt.Rows.Count > 0;
        }

        public DataTable getGroupUser()
        {
            string query = "select * from GroupUser";
            return DAL.getDataTable(query);
        }
        public DataTable getMember()
        {
            string query = "select * from Member";
            return DAL.getDataTable(query);
        }
        public DataTable getMemberByGroupUser(string groupName)
        {
            string query = "select * from Member where GroupUser = '" + groupName + "'";
            return DAL.getDataTable(query);
        }
        public void addMember(Member member)
        {
            string sqlQuery = "insert into Member values('" + member.AccountName + "','" + member.Password + "','" + member.GroupUser + "','" + member.CurrentMoney + "', '" + member.StatusAccount + "')";
            if (DAL.runQuery(sqlQuery))
            {
                MessageBox.Show("Thêm thành công thành viên!!", "Thông báo");
            }
        }
        public void updateMember(Member member)
        {
            string sqlQuery = "Update Member set Password='" + member.Password + "', GroupUser = '" + member.GroupUser + "', CurrentMoney = '" + member.CurrentMoney + "', MemberStatus = '" + member.StatusAccount + "'" +
                " where MemberID ='" + member.Id + "'";
            if (DAL.runQuery(sqlQuery))
            {
                MessageBox.Show("Sửa thành công thành viên!!", "Thông báo");
            }
        }
        public void deleteMember(Member member)
        {
            string sqlQuery = "Delete from Member where AccountName ='" + member.AccountName + "'";

            if (DAL.runQuery(sqlQuery))
            {

            }
        }
        public bool checkFieldData(string accountName)
        {
            if (DAL.checkField("Member", "AccountName", accountName)) return true;
            return false;
        }
        public bool checkSave(Member member)
        {

            if (checkFieldData(member.AccountName))
            {
                //Nếu đã tồn tại
                MessageBox.Show("Đã tồn tại hội viên", "Thông báo");
                return false;
            }
            
            if (member.AccountName.Equals(""))
            {
                MessageBox.Show("Tên tài khoản không được để trống ", "Thông báo");
                return false;
            }
            if (member.Password.Equals(""))
            {
                MessageBox.Show("Mật khẩu không được để trống ", "Thông báo");
                return false;
            }
            if (member.CurrentMoney <= 0)
            {
                MessageBox.Show("Số tiền phải lớn hơn 0 ", "Thông báo");
                return false;
            }

            return true;
        }
        public int getMemberID(string memberName)
        {
            int id = -1;
            string query = "select * from Member where AccountName = '" + memberName + "'";
            DataTable dt = DAL.getDataTable(query);
            if(dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return row.Field<int>("MemberID");
            }
            return id;
        }

        public string getMemberName(int id) 
        {
            string query = "select AccountName from Member where MemberID = '" + id.ToString() + "'";
            DataTable dt = DAL.getDataTable(query);
            DataRow row = dt.Rows[0];
            return row.Field<string>("AccountName");
        }
        public DataTable searchMember(string memberName)
        {
            string query = "select * from Member where AccountName LIKE '%" + memberName + "%'";
            return DAL.getDataTable(query);
        }
    }
}
