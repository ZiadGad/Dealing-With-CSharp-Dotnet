namespace ExtensionMethods;

public static class NumberExtension
{
    public static bool isBetween(this int value, int min, int max)
    {
        return value >= min && value <= max;
    }
}