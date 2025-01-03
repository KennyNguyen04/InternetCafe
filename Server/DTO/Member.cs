using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DTO
{
    public class Member
    {
        private int id;
        private string accountName;
        private string password;
        private string groupUser;
        private double currentMoney;
        private string statusAccount;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string AccountName
        {
            get { return accountName; }
            set { accountName = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string GroupUser
        {
            get { return groupUser; }
            set { groupUser = value; }
        }
        
        public double CurrentMoney
        {
            get { return currentMoney; }
            set { currentMoney = value; }
        }
        public string StatusAccount
        {
            get { return statusAccount; }
            set { statusAccount = value; }
        }
        
    }
}
