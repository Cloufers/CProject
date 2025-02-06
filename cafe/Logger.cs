using System.IO;

namespace cafe;

public static class Logger
{
    private static readonly string InfoLogPath = "info_log.txt";
    private static readonly string ErrorLogPath = "error_log.txt";

    public static void LogInfo(string message)
    {
        LogMessage(InfoLogPath, message);
    }

    public static void LogError(string message)
    {
        LogMessage(ErrorLogPath, message);
    }

    private static void LogMessage(string filePath, string message)
    {
        string logEntry = $"{DateTime.Now}: {message}";
        File.AppendAllText(filePath, logEntry + Environment.NewLine);
    }
}