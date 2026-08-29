namespace Enums;

public class EnumFlags
{
    /// <summary>
    /// Rules for creating flag enums:
    /// <para>• Decorate the enum with the <c>[Flags]</c> attribute.</para>
    /// <para>• Assign powers of two (1, 2, 4, 8, ...) to each member so bitwise combinations remain unique.</para>
    /// <para>• (Optional / Recommended) Define a <c>None = 0</c> member to represent the default state.</para>
    /// <para>• Bitwise Operations <c>(|, &, ~, ^)</c> </para>
    /// <para>(|) "Bitwise OR" Combination flags</para>
    /// <para>(&) "Bitwise AND" Common flags</para>
    /// <para>(~) "Bitwise Except" Combination</para>
    /// <para>(^) "Bitwise Toggle" Combination</para>
    /// </summary>
    [Flags]
    public enum WeekDays
    {
        None = 0,
        Saturday = 1,
        Sunday = 2,
        Monday = 4,
        Tuesday = 8,
        Wednesday = 16,
        Thursday = 32,
        Friday = 64,
    }

    public static void EnumFlag()
    {
        WeekDays weekend = WeekDays.Friday | WeekDays.Saturday;
        Console.WriteLine(weekend);
    }
}