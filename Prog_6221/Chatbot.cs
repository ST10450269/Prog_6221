using System;
using System.Collections.Generic;
using System.Threading;

namespace CybersecurityBot
{
    public class Chatbot
    {
        private User _user = new User("temp");

        private readonly Dictionary<string, string> _responses = new Dictionary<string, string>
        {
            { "how are you",           "I am fully operational and ready to help you stay safe online!" },
            { "what is your purpose",  "I am the Cybersecurity Awareness Bot. I educate users about online safety, threats, and best practices." },
            { "hello",                 "Hey there! Ask me anything about cybersecurity." },
            { "help",                  "I can answer questions about: passwords, phishing, malware, firewalls, vpn, ransomware, 2fa, and more!" },
            { "bye",                   "Stay safe online! Goodbye." },
            { "password",              "Use strong passwords with at least 12 characters, mixing uppercase, lowercase, numbers, and symbols. Never reuse passwords!" },
            { "phishing",              "Phishing tricks you into revealing sensitive info via fake emails or websites. Never click suspicious links." },
            { "malware",               "Malware is malicious software. Keep your antivirus updated and avoid downloading files from untrusted sources." },
            { "firewall",              "A firewall monitors and controls network traffic. Always keep your firewall enabled!" },
            { "vpn",                   "A VPN encrypts your internet traffic, protecting your privacy especially on public Wi-Fi." },
            { "ransomware",            "Ransomware encrypts your files and demands payment. Back up your data regularly!" },
            { "2fa",                   "Two-Factor Authentication adds an extra security layer. Enable it on every account that supports it!" },
            { "two-factor",            "2FA requires a second form of verification. Even if your password is stolen, 2FA protects you." },
            { "encryption",            "Encryption converts data into an unreadable format. Use encrypted apps for sensitive conversations." },
            { "wifi",                  "Avoid public Wi-Fi for sensitive activities. Use a VPN if you must connect to public networks." },
            { "backup",                "Regular backups protect you from ransomware. Follow the 3-2-1 rule: 3 copies, 2 media types, 1 offsite." },
            { "antivirus",             "Antivirus software detects and removes malware. Keep it updated and run regular scans." },
        };

        public void Start()
        {
            Console.Clear();
            DisplayBanner();
            DisplayAsciiArt();

            _user = new User();

            Console.WriteLine();
            PrintBotLine("Hello, " + _user.Name + "! Welcome to the Cybersecurity Awareness Bot.");
            PrintBotLine("Type 'help' to see what I can discuss, or 'bye' to exit.");
            DrawDivider();

            RunLoop();
        }

        private void RunLoop()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n  [" + _user.Name + "] > ");
                Console.ResetColor();

                string rawInput = Console.ReadLine() ?? string.Empty;

                if (string.IsNullOrWhiteSpace(rawInput))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n  [!] Please enter something. Type 'help' for available topics.");
                    Console.ResetColor();
                    continue;
                }

                string input = rawInput.ToLower().Trim();

                if (input == "bye" || input == "exit" || input == "quit")
                {
                    PrintBotLine(_responses["bye"]);
                    DrawDivider();
                    break;
                }

                PrintBotLine(GetResponse(input));
            }
        }

        private string GetResponse(string input)
        {
            foreach (KeyValuePair<string, string> pair in _responses)
            {
                if (input.Contains(pair.Key))
                    return pair.Value;
            }

            return "I am not sure about that, " + _user.Name + ". Try asking about: passwords, phishing, malware, VPN, or type 'help'.";
        }

        private static void DisplayBanner()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("  " + new string('=', 58));
            Console.WriteLine("           CYBERSECURITY AWARENESS CHATBOT");
            Console.WriteLine("  " + new string('=', 58));
            Console.ResetColor();
        }

        private static void DisplayAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
    _______ __         __              _______         __
   |   _   |__|.----.|__|.-----.----.|   _   |.-----.|  |_
   |.  1___|  ||  __||  ||  -__|   _||.  1   ||  _  ||   _|
   |.  __)_|__||____||__||_____|__|  |.  _   ||_____||____|
   |:  1   |                         |:  1    |
   |::.. . |                         |::.. .  |
   `-------'                         `-------'
    ");
            Console.ResetColor();
        }

        private static void PrintBotLine(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n  [Bot] ");
            Console.ResetColor();

            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(18);
            }
            Console.WriteLine();
        }

        private static void DrawDivider()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n  " + new string('-', 58));
            Console.ResetColor();
        }
    }
}