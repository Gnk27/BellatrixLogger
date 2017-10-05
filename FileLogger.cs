using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellatrixLogger
{
    public class FileLogger : Logger
    {
        public string filePath = @"E:\Bellatrix_Log.txt";

        public override void Log(Message msg)
        {
            lock (lockObj)
            {
                string aux = string.Empty;
                using (StreamReader streamReader = new StreamReader(filePath))
                {
                    aux = streamReader.ReadToEnd();
                    streamReader.Close();
                }
                using (StreamWriter streamWriter = new StreamWriter(filePath))
                {
                    streamWriter.WriteLine(aux + DateTime.Now + " | " + msg.getMessageType() + " | " + msg.MessageStr);
                    streamWriter.Close();
                }
            }
        }
    }
}
