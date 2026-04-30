public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string areaCode = phoneNumber.Substring(0, 3);
        string pre = phoneNumber.Substring(4, 3);
        string localNum = phoneNumber.Substring(8, 4);

        bool isNY = areaCode == "212";
        bool isFake = pre == "555";

        return (isNY, isFake, localNum);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
