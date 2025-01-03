using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DTO
{
    public class Bill_Item
    {
        public int billId;
        public int productId;
        public int quantity;
        public int BillID
        {
            get { return billId; }
            set { billId = value; }
        }
        public int ProductID
        {
            get { return productId; }
            set { productId = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}
