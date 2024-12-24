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
    internal class ProcessUser
    {
        DataAccessLayer DAL = new DataAccessLayer();
        public bool checkLoginServer(string username, string password)
        {
            string query = "select * from Users where Username = '" + username + "' and Password = '" + password + "'";
            DataTable dt = DAL.getDataTable(query);
            if (dt.Rows.Count > 0) return true;
            return false;
        }

        public List<DTO.User> getAllUser()
        {
            string query = "select * from Users";
            DataTable dt = DAL.getDataTable(query);
            List<DTO.User> usersList = dt.AsEnumerable()
                .Select(row => new User
                {
                    UserName = row.Field<string>("UserName"),
                    FullName = row.Field<string>("FullName"),
                    GroupUser = row.Field<string>("GroupUser"),
                    Password = row.Field<string>("Password"),
                    PhoneNumber = row.Field<string>("PhoneNumber"),
                    Email = row.Field<string>("Email")

                }).ToList();
            return usersList;
        }
        public bool checkIsAdmin(string username)
        {
            string query = "select GroupUser from Users where UserName = '" + username + "'";
            DataTable dt = DAL.getDataTable(query);
            if(dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                string groupUser = row.Field<string>("GroupUser");
                if (groupUser == "Manager") return true;
            }
            return false;
        }
        public int getUserId(string username)
        {
            string query = "select UserID from Users where UserName = '" + username + "'";
            DataTable dt = DAL.getDataTable(query);
            if (dt == null) return 0;
            DataRow row = dt.Rows[0];
            int id = row.Field<int>("UserID");
            return id;
        }
        public DataTable getUsers()
        {
            string query = "select * from Users";
            return DAL.getDataTable(query);
        }
        public DataTable getUseryGroupName(string groupName) {
            string query = "select * from Users where GroupUser = '"+groupName+"'";
            return DAL.getDataTable(query);
        }
        public void addUser(User user)
        {
            string sqlQuery = "insert into Users values('" + user.UserName + "',N'" + user.FullName + "','" + user.GroupUser + "','" + user.PhoneNumber + "', '" + user.Email + "','"+user.Password+"')";
            if (DAL.runQuery(sqlQuery))
            {
                MessageBox.Show("Thêm thành công !!", "Thông báo");
            }
        }
        public void updateUser(User user)
        {
            string sqlQuery = "Update Users set FullName='" + user.FullName + "', GroupUser = '" + user.GroupUser + "', PhoneNumber = '" + user.PhoneNumber + "', Email = '" + user.Email + "', Password = '"+user.Password+"'" +
                " where UserID ='" + user.Id + "'";
            if (DAL.runQuery(sqlQuery))
            {
                MessageBox.Show("Sửa thành công!!", "Thông báo");
            }
        }
        public void deleteUser(User user)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sqlQuery = "Delete from Users where UserID ='" + user.Id + "'";

                if (DAL.runQuery(sqlQuery))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Lỗi", "Thông báo");
                }
            }

        }
        public string getUserFullName(string userName)
        {
            string query = "select FullName from Users where Username = '" + userName + "'";
            DataTable dt = DAL.getDataTable(query);
            DataRow row = dt.Rows[0];
            return row.Field<string>("FullName");
        }
        public bool checkFieldData(string username)
        {
            if (DAL.checkField("Users", "UserName", username)) return true;
            return false;
        }
        public bool checkSave(User user)
        {

            if (checkFieldData(user.UserName))
            {
                //Nếu đã tồn tại
                MessageBox.Show("Đã tồn tại nhân viên", "Thông báo");
                return false;
            }

            if (user.UserName.Equals(""))
            {
                MessageBox.Show("Tên tài khoản không được để trống ", "Thông báo");
                return false;
            }
            if (user.FullName.Equals(""))
            {
                MessageBox.Show("Tên không được để trống ", "Thông báo");
                return false;
            }
            if (user.PhoneNumber.Equals(""))
            {
                MessageBox.Show("Số điện thoại không được để trống ", "Thông báo");
                return false;
            }
            if (user.Email.Equals(""))
            {
                MessageBox.Show("Email không được để trống ", "Thông báo");
                return false;
            }
            if (user.Password.Equals(""))
            {
                MessageBox.Show("Mật khẩu không được để trống ", "Thông báo");
                return false;
            }
            return true;
        }
    }
}
