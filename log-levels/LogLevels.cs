static class LogLine
{
    public static string Message(string logLine)
    {
        int idx = logLine.IndexOf(":");
        string afterdot = logLine.Substring(idx + 2);
        return afterdot.Trim();
    }

    public static string LogLevel(string logLine)
    {
        int st = logLine.IndexOf('[') + 1;
        int ed = logLine.IndexOf(']');
        return logLine.Substring(st, ed - st).ToLower();

    }

    public static string Reformat(string logLine)
    {
        return $"{Message(LogLine)} ({LogLevel(logLine)})";
    }

}
