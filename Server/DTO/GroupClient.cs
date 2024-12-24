using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DTO
{
    public class GroupClient
    {
        private string groupName;
        private string description;
        private string price;
        public string GroupName
        {
            get { return groupName; }
            set { groupName = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
