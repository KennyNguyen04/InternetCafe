using Microsoft.SqlServer.Server;
using Server.DAL;
using Server.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.BLL
{
    public class ProcessMessage
    {
        private DataAccessLayer DAL = new DataAccessLayer();
        private ProcessClient ProcessClient = new ProcessClient();
        public List<string> getMessages(string memberName)
        {
            List<string> messages = new List<string>();
            string query = "select * from Chat where MemberName = '"+memberName+"'";
            DataTable dt = DAL.getDataTable(query);
            if (dt != null )
            {
                foreach (DataRow row in dt.Rows)
                {
                    string clientName = row.Field<string>("ClientName");
                    string userName = row.Field<string>("UserName");
                    string message = row.Field<string>("Message");
                    DateTime createdAt = row.Field<DateTime>("CreatedAt");
                    string sendBy = row.Field<string>("SendBy");
                    string str;
                    if (sendBy == "member")
                    {
                        str = "[" + clientName + "][" + memberName + "]: " + message + "     [" + createdAt.ToString() + "][" + userName + "]";
                    }
                    else
                    {
                        str = "[" + userName + "]: " + message + "      [" + createdAt.ToString() +"]";
                    }
                    messages.Add(str);
                }
            }
            else
            {
                return null;
            }
            return messages;
        }
        public bool insertMessage(InfoClient cli, string user, string message, string sendBy)
        {
            DateTime now = DateTime.Now;
            string query = "insert into Chat values(" +
                "'" + cli.memberName + "'," +
                "'" + user + "'," +
                "'" + ProcessClient.getClientName(cli.clientIp) + "'," +
                "N'" + message + "'," +
                "'" + now.ToString() + "'," +
                "'" + sendBy + "')";
            if (DAL.runQuery(query)) return true;
            return false;
        }
        public void deleteMessage(string memberName)
        {
            string query = "delete from Chat where MemberName = '" + memberName + "'";
            if (DAL.runQuery(query)) { }
        }
    }
}
