using System;

namespace CybersecurityBot
{
    class Program
    {
        static void Main(string[] args)
        {
            AudioPlayer.PlayGreeting();
            Chatbot bot = new Chatbot();
            bot.Start();
        }
    }
}