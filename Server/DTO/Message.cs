using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DTO
{
    public class Message
    {
        private long chatId;
        private int memberName;
        private int userName;
        private int clientName;
        private string messageText;
        private DateTime createAt;
        private string sendBy;
        public long ChatID
        {
            get { return chatId; }
            set { chatId = value; }
        }
        public int MemberName
        {
            get { return memberName; }
            set { memberName = value; }
        }
        public int UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public int ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }
        public string MessageText
        {
            get { return messageText; }
            set { messageText = value; }
        }
        public DateTime CreateAt
        {
            get { return createAt; }
            set { createAt = value; }
        }
        public string SendBy
        {
            get { return sendBy; }
            set { sendBy = value; }
        }
    }
}
