using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DTO
{
   public class Bill
    {
        private int id;
        private int userId;
        private int memberId;
        private DateTime createdAt;
        private double totalPrice;
        private string status;
        public int BillID
        {
            get { return id; }
            set { id = value; }
        }
        public int UserID
        {
            get { return userId; }
            set { userId = value; }
        }
        public int MemberID
        {
            get { return memberId; }
            set { memberId = value; }
        }
        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }
        public double TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
