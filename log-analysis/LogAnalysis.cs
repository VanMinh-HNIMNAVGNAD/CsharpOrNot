public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string delimiter)
    {
        int idx = str.IndexOf(delimiter);
        int start = idx + delimiter.Length;
        return start;
    }
    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str )
    {
        
    }
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str)
    {
        
    }
    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str)
    {
        
    }
}