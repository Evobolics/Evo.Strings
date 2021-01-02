using Evo.Statics;

namespace System
{
    public static class StringExtensions
    {
        public static string NormalizeNewLines(this string input, string newLine = "\n")
        {
            return StringsRoot.Strings.NormalizeNewLines(input, newLine);
        }

        public static byte[] GetUtf8Bytes(this string utf8String)
        {
            return StringsRoot.Strings.GetUtf8Bytes(utf8String);
        }
    }
}
