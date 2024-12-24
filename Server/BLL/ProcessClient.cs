using Server.DAL;
using Server.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.BLL
{
    public class ProcessClient
    {
        DataAccessLayer DAL =  new DataAccessLayer();
        public void changeStateClient(InfoClient cli)
        {
            string query = "update Client set StatusClient = '" + cli.stateClient + "' where ClientIP = '" + cli.clientIp + "'";
            if(DAL.runQuery(query))
            {}
        }
        public string getGroupName(InfoClient cli)
        {
            string groupName;
            string query = "select GroupClientName from Client where ClientIP = '"+cli.clientIp+"'";
            DataTable dt = DAL.getDataTable(query);
            DataRow dr = dt.Rows[0];
            groupName = dr.Field<string>("GroupClientName");
            return groupName;
        }

        public List<DTO.Client> getAllClient()
        {
            string query = "select * from Client";
            DataTable dt = DAL.getDataTable(query);
            List<DTO.Client> clientList = dt.AsEnumerable()
                .Select(row => new Client
                {
                    ClientIP = row.Field<string>("ClientIP"),
                    ClientName = row.Field<string>("ClientName"),
                    GroupClientName = row.Field<string>("GroupClientName"),
                    StatusClient = row.Field<string>("StatusClient"),
                }).ToList();
            return clientList;
        }
        public string getClientName(string clientIp)
        {
            string query = "select ClientName from Client where ClientIP = '" + clientIp + "'";
            DataTable dt = DAL.getDataTable(query);
            DataRow row = dt.Rows[0];
            return row.Field<string>("ClientName");
        }

        public void addClient(Client client)
        {
            string strquery = "INSERT INTO Client VALUES('" + client.ClientIP + "', '" + client.ClientName + "', '" +
                              client.GroupClientName + "', '" + client.StatusClient + "')";
            if (DAL.runQuery(strquery))
            {
                MessageBox.Show("Thêm thành công!");
            }
        }

        public void DeleteClient(Client client)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa Client này không?", "Thông báo!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string strquery = "DELETE FROM Client WHERE ClientIP='" + client.ClientIP + "'";
                string strquery2 = "DELETE FORM AddMoneyTransaction WHERE ClientIP='" + client.ClientIP + "'";
                string strquery3 = "DELETE FROM Chat WHERE ClientName='" + client.ClientName + "'";
                if (DAL.runQuery(strquery) && DAL.runQuery(strquery2) && DAL.runQuery(strquery3))
                {
                    MessageBox.Show("Đã xóa thành công Client!!", "Thông báo!!");
                }
            }
        }

        public void UpdateClient(Client client)
        {
            string strquery = "UPDATE Client SET ClientName='" + client.ClientName + "', GroupClientName='" + client.GroupClientName + "' WHERE ClientIP='" + client.ClientIP + "'";
            if (DAL.runQuery(strquery))
            {
                MessageBox.Show("Cập nhật dữ liệu thành công!");
            }
        }

        public DataTable GetAllClient()
        {
            string strquery = "SELECT * FROM Client";
            return DAL.getDataTable(strquery);
        }

        public bool checkFieldData(string ip)
        {
            if (DAL.checkField("Client", "ClientIp", ip)) return true;
            return false;
        }
        public bool checkSave(Client client)
        {

            if (checkFieldData(client.ClientIP))
            {
                //Nếu đã tồn tại
                MessageBox.Show("Đã tồn tại Client này!", "Thông báo");
                return false;
            }
            if (client.ClientName.Equals(""))
            {
                MessageBox.Show("Tên Client không được để trống ", "Thông báo");
                return false;
            }

            return true;
        }
    }
}
