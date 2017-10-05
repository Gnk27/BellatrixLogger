using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellatrixLogger
{
    class Program
    {

        static void Main(string[] args)
        {
            //INTIAL SET UP
            MessageError.shouldLog = true;
            MessageMsg.shouldLog = true;
            MessageWarning.shouldLog = true;

            //LOG TESTS
            LogCaller.Log(LogTarget.Console, new MessageMsg("Log de tipo mensaje en consola"));
            LogCaller.Log(LogTarget.Console, new MessageWarning("Log de tipo warning en consola"));
            LogCaller.Log(LogTarget.Console, new MessageError("Log de tipo error en consola"));

            LogCaller.Log(LogTarget.File, new MessageMsg("Log de tipo mensaje en txt"));
            LogCaller.Log(LogTarget.File, new MessageWarning("Log de tipo warning en txt"));
            LogCaller.Log(LogTarget.File, new MessageError("Log de tipo error en txt"));

            LogCaller.Log(LogTarget.DataBase, new MessageMsg("Log de tipo mensaje en txt"));
            LogCaller.Log(LogTarget.DataBase, new MessageWarning("Log de tipo warning en txt"));
            LogCaller.Log(LogTarget.DataBase, new MessageError("Log de tipo error en txt"));

            Console.ReadLine();
        }
    }
}
