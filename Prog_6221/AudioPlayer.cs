using System;
using System.IO;
using System.Media;

namespace CybersecurityBot
{
    public static class AudioPlayer
    {
        private const string GreetingFile = "greeting.wav";

        public static void PlayGreeting()
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, GreetingFile);

                if (!File.Exists(filePath))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n  [Audio] greeting.wav not found. Skipping voice greeting.");
                    Console.ResetColor();
                    return;
                }

                using (SoundPlayer player = new SoundPlayer(filePath))
                {
                    player.PlaySync();
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\n  [Audio] Could not play greeting: " + ex.Message);
                Console.ResetColor();
            }
        }
    }
}