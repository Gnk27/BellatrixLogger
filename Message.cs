using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellatrixLogger
{
    public abstract class Message
    {
        protected static string messageStr;

        public string MessageStr
        {
            get { return Message.messageStr; }
            set { Message.messageStr = value; }
        }

        public abstract bool checkLog();
        public abstract string getMessageType();
    }
}
