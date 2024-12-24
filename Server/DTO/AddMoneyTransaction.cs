using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DTO
{
    public class AddMoneyTransaction
    {
        private int _id;
        private string clientIp;
        private string userName;
        private string memberName;
        private DateTime transacDate;
        private double addMoney;
        private string status;

        public int TransactionID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string ClientIP
        {
            get
            {
                return clientIp;
            }
            set
            {
                clientIp = value;
            }
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public string MemberName
        {
            get { return memberName; }
            set { memberName = value; }
        }
        public DateTime TransacDate
        {
            get
            {
                return transacDate;
            }
            set
            {
                transacDate = value;
            }
        }
        public double AddMoney
        {
            get
            {
                return addMoney;
            }
            set
            {
                addMoney = value;
            }
        }
        public string Status
        {
            get
            {
                return status;
            }
            set { status = value; }
        }
    }
}
