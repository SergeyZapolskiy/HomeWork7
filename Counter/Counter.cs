using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Counter
    {
        public event EventHandler Notyfi = null;
        public void CountNumbers()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i == 77)
                {
                    Notyfi?.Invoke(this, new EventArgs());
                }
            }
        }
       
    }
}
