public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string delimiter)
    {
        int idx = str.IndexOf(delimiter[": "]);
        int start = idx + delimiter.Length + 2;
        string end = str[start, delimiter - start];
        return end;
    }
    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string stdelimiter, string eddelimiter )
    {
        int leftidx = stdelimiter.IndexOf(str["["]);
        int contentidx = leftidx + stdelimiter.Length;
        int rightidx = eddelimiter.IndexOf(contentidx["]"]);
        int leth = rightidx - contentidx;
        int result = str[contentidx, leth];
        return result;
    }
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str)
    {
        int message = str.SubstringAfter(": ");
        return message;
    }
    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str)
    {
        int loglevel = SubstringBetween(str, "[", "]");
        return loglevel.ToLower();
    }
}