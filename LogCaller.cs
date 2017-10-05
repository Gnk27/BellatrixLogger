using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellatrixLogger
{
    public static class LogCaller
    {

        private static Logger logger = null;

        public static void Log(LogTarget target, Message msg)
        {            
            switch (target)
            {
                case LogTarget.File:
                    if (msg.checkLog())
                    {
                        logger = new FileLogger();
                        logger.Log(msg);
                    }
                    break;
                case LogTarget.DataBase:
                    if (msg.checkLog())
                    {
                        logger = new DataBaseLogger();
                        logger.Log(msg);
                    }
                    break;
                case LogTarget.Console:
                    if (msg.checkLog())
                    {
                        logger = new ConsoleLogger();
                        logger.Log(msg);
                    }
                    break;
                default:
                    return;
            }
        }
    }
}
