using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellatrixLogger
{
    public abstract class Logger
    {
        protected readonly object lockObj = new object();

        public abstract void Log(Message msg);
    }
}
