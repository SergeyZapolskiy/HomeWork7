using System;

namespace PingPong
{
    class Program
    {
        static void Main(string[] args)
        {
            Ping Ping = new Ping();
            Pong Pong = new Pong();
            Ping.Notyfi += Pong.Play;
            Pong.Notyfi += Ping.Play;
            Ping.Play(Ping, new EventArgs());
        }
    }
}
