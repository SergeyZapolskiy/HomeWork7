using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    class Ping
    {
        public event EventHandler Notyfi = null;

        //delegate void Notifier(Notifier notifier);
        public void Play(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 10);
            string s = randomNumber > 1 ? "Ping gets Pong" : "Pong missed! Ping win";
            if(randomNumber > 1)
            {
                Console.WriteLine(s);
                Notyfi?.Invoke(this, new EventArgs());
            }
            else
            {
                Console.WriteLine(s);
            }
        }
    }
}
