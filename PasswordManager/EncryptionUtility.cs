using System.Text;

namespace PasswordManager;

public class EncryptionUtility
{
    private static readonly string _originalchars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

    private static readonly string _altchars = "5EjQgMWqOaJsKXeL0HhVUrC9NpioR847IFn1lBkbtdDZuyzfAwv3YSGcm6P2Tx";

    public static string Encrypt(string password)
    {
        var sb = new StringBuilder();
        foreach (var c in password)
        {
            var charIndex = _originalchars.IndexOf(c);
            sb.Append(_altchars[charIndex]);
        }

        return sb.ToString();
    }

    public static string Decrypt(string password)
    {
        var sb = new StringBuilder();
        foreach (var c in password)
        {
            var charIndex = _altchars.IndexOf(c);
            sb.Append(_originalchars[charIndex]);
        }

        return sb.ToString();
    }
}