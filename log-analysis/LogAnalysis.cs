public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string delimiter)
    {
        int idx = str.IndexOf(delimiter);
        int start = idx + delimiter.Length;
        string end = str.Substring(start);
        return end;
    }
    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string stdelimiter, string eddelimiter )
    {
        int leftidx = str.IndexOf(stdelimiter);
        int contentidx = leftidx + stdelimiter.Length;
        int rightidx = str.IndexOf(eddelimiter, contentidx);
        int leth = rightidx - contentidx;
        string result = str.Substring(contentidx, leth);
        return result;
    }
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str)
    {
        string message = str.SubstringAfter(": ");
        return message;
    }
    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str)
    {
        string loglevel = SubstringBetween(str, "[", "]");
        return loglevel;
    }
}