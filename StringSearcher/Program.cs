using System;
using System.Collections.Generic;

namespace StringSearcher
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "Hello", "Teacher teaches", "Cat", "Dog" };
            StringSearcher stringSearcher = new StringSearcher();
            stringSearcher.Notyfi += MessageDisplay;
            stringSearcher.Search(list);
        }

        static void MessageDisplay(object sender, StringEventArgs e)
        {
            if (e != null)
            {
                Console.WriteLine($"{e.Message}");
            }
            
        }

    }
}
