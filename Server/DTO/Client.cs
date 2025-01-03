using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DTO
{
    public class Client
    {
        private string clientIp;
        private string clientName;
        private string groupClientName;
        private string statusClient;
        private string note;
        public string ClientIP
        {
            get { return clientIp; }
            set { clientIp = value; }
        }
        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }
        public string GroupClientName
        {
            get { return groupClientName; }
            set { groupClientName = value; }
        }
        public string StatusClient
        {
            get { return statusClient; }
            set { statusClient = value; }
        }
        public string Note
        {
            get { return note; }
            set { note = value; }
        }
    }
}
