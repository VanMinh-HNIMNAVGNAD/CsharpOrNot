static class LogLine
{
    public static string Message(string logLine)
    {
        int idx = logLine.IndexOf(":"); // lấy vị trí kí tự 
        string afterdot = logLine.Substring(idx + 2); // cắt từ kí tự đó và khoảng trắng
        return afterdot.Trim(); // cắt khoảng trắng 2 đầu 
    }

    public static string LogLevel(string logLine)
    {
        int st = logLine.IndexOf('[') + 1; // lấy vị trí bắt đầu từ vị trí + 1 trong chuỗi
        int ed = logLine.IndexOf(']'); // lấy vị trí cuối cùng trong chuỗi cần lấy 
        return logLine.Substring(st, ed - st).ToLower(); // bắt đầu từ +1, lấy cuối trừ đầu ra số lượng text cần in ra, viết thường 

    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})"; 
    }

}
