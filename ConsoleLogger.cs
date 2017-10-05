using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellatrixLogger
{

    public class ConsoleLogger : Logger
    {
        public override void Log(Message msg)
        {
            lock (lockObj)
            {
                Console.WriteLine(DateTime.Now + " | " + msg.getMessageType() + " | " + msg.MessageStr);
            }
        }
    }         
}
