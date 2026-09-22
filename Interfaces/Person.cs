namespace Interfaces;

public class Person : IEnglishSpeaker, IArabicSpeaker
{
    void IEnglishSpeaker.Speak()
    {
        Console.WriteLine("Hello!");
    }

    void IArabicSpeaker.Speak()
    {
        Console.WriteLine("اهلاً...");
    }
}