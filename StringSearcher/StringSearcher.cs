using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSearcher
{
    class StringSearcher
    {
        public event EventHandler<StringEventArgs> Notyfi = null;
        public void Search(List<string> s)
        {
            string pattern = "Teacher teaches";
            foreach(var str in s)
            {
                if(str.Contains(pattern))
                {
                    Notyfi?.Invoke(this, new StringEventArgs(pattern));
                }
            }
        }
    }
}
