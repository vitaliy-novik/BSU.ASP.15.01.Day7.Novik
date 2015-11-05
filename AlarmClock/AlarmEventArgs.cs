using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock
{
    public sealed class AlarmEventArgs : EventArgs
    {
        private string message;

        public string Message { get { return message; } }

        public AlarmEventArgs(string m)
        {
            message = m;
        }
    }
}
