using System;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            Handler1 handler1 = new Handler1();
            Handler2 handler2 = new Handler2();
            counter.Notyfi += handler1.Handler;
            counter.Notyfi += handler2.Handler;
            counter.CountNumbers();
        }
    }
}
