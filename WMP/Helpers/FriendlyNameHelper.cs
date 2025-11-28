namespace WMP.Helpers;

public class FriendlyNameHelper
{
    public static string FriendlyNameMethod(string name)
    {
        string result = name.Replace("_", " ");

        return result;
    }
}