namespace ExtensionMethods;

public static class StringExtension
{
    public static string RemoveWhiteSpace(this string value)
    {
        return value.Replace(" ", "");
    }

    public static string Reverse(this string value)
    {
        var charArray = value.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}