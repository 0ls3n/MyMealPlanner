namespace WMP.Helpers;

public class FriendlyNameHelper
{
    public static string FriendlyNameMethod(string name)
    {
        string result = name.Replace("_", " ");

        return result;
    }
    
    public static string GetNameCredentials(string name)
    {
        var split = name.Split("_");

        char[] firstSideCharacters = split[0].ToArray();
        char[] lastSideCharacters = split[split.Length - 1].ToArray();

        return $"{firstSideCharacters[0]}{lastSideCharacters[0]}".ToUpper();
    }
}