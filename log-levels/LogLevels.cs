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
        int indx = logLine.IndexOf(":");
        string afterhc = logLine.Substring(indx + 2);
        int indx2 = logLine.IndexOf("/r");
        string space = logLine.Substring(indx2 + 1);
        return space.Trim().ToLower();
    }

    public static string Reformat(string logLine)
    {

    }

}
