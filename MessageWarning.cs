using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellatrixLogger
{
    public class MessageWarning : Message
    {
        public static bool shouldLog;

        public MessageWarning(string msg)
        {
            this.MessageStr = msg;
        }

        public override bool checkLog()
        {
            return shouldLog;
        }
        public override string getMessageType()
        {
            return "Warning";
        }
    }
}
