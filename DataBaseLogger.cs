using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellatrixLogger
{
    public class DataBaseLogger : Logger
    {
        string connectionString = string.Empty;

        public override void Log(Message msg)
        {
            lock (lockObj)
            {
                SQLConnect sqlConnect = new SQLConnect();
                sqlConnect.Conectar();
                sqlConnect.Insertar("INSERT INTO LOG VALUES ('" + msg.getMessageType() + "','" + msg.MessageStr + "',GETDATE())");
                sqlConnect.Desconectar();
            }
        }
    }
}
