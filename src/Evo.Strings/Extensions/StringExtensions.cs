using Evo.Statics;

namespace System
{
    public static class StringExtensions
    {
        public static string NormalizeNewLines(this string input, string newLine = "\n")
        {
            return StringsRoot.Strings.NormalizeNewLines(input, newLine);
        }
    }
}
