using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSearcher
{
    class StringEventArgs : EventArgs
    {
        public string Message { get; }

        public StringEventArgs(string message)
        {
            Message = message;
        }
    }
}
