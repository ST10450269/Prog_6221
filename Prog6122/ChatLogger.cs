using System;
using System.IO;

public class ChatLogger
{
    private static string path = "chatlog.txt";

    public static void Log(string message)
    {
        File.AppendAllText(path, $"{DateTime.Now}: {message}\n");
    }
}