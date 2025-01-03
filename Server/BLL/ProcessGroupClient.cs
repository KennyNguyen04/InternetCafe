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
    
    public class ProcessGroupClient
    {
        DataAccessLayer DAL = new DataAccessLayer();
        public double getClientPrice(string groupName)
        {
            double price = 0;
            string query = "select Price from GroupClient where GroupName = '"+groupName+"'";
            DataTable dt = DAL.getDataTable(query);
            DataRow dr = dt.Rows[0];
            price = dr.Field<double>("Price");
            return price;
        }

        public DataTable getAllGroupClient()
        {
            string strquery = "SELECT * FROM GroupClient";
            return DAL.getDataTable(strquery);
        }

        public void addGroupClient(GroupClient groupclient)
        {
            string strquery = "INSERT INTO GroupClient VALUES(GroupName='" + groupclient.GroupName +
                              "', Description=N'" + groupclient.Description + "', Price='" + groupclient.Price + "')";
            if (DAL.runQuery(strquery))
            {
                MessageBox.Show("Thêm thành công!");
            }
        }

        public void deleteGroupClient(GroupClient groupclient)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhóm máy này? Việc này bao gồm xóa các máy trong nhóm!!",
                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string strquery_1 = "DELETE FROM Client WHERE GroupClientName='" + groupclient.GroupName + "'";
                string strquery_2 = "DELETE FROM GroupClient WHERE GroupName='" + groupclient.GroupName + "'";
                if (DAL.runQuery(strquery_1) && DAL.runQuery(strquery_2))
                {
                    MessageBox.Show("Đã xóa nhóm máy và các máy thành công!");
                }
            }
        }

        public void updateGroupClient(GroupClient groupclient)
        {
            string strquery = "UPDATE GroupClient SET Description='" + groupclient.Description + "', Price='" + groupclient.Price + "' WHERE GroupName='" + groupclient.GroupName + "'";
            if (DAL.runQuery(strquery))
            {
                MessageBox.Show("Cập nhật dữ liệu thành công!");
            }
        }
        public bool checkFieldData(string name)
        {
            if (DAL.checkField("GroupClient", "GroupName", name)) return true;
            return false;
        }
        public bool checkSave(GroupClient groupclient)
        {

            if (checkFieldData(groupclient.GroupName))
            {
                //Nếu đã tồn tại
                MessageBox.Show("Đã tồn tại nhóm máy này!", "Thông báo");
                return false;
            }
            if (groupclient.Description.Equals(""))
            {
                MessageBox.Show("Mô tả không được để trống ", "Thông báo");
                return false;
            }
            if (groupclient.Price.Equals(""))
            {
                MessageBox.Show("Giá không được để trống ", "Thông báo");
                return false;
            }
            if (double.Parse(groupclient.Price) <= 0)
            {
                MessageBox.Show("Giá không được nhỏ hơn 0 ", "Thông báo");
                return false;
            }

            return true;
        }
    }
}
