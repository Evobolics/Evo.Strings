using System.Text;
using System.Text.RegularExpressions;

namespace Evo
{
    public class StringService
    {
        public readonly Encoding UTF8 = new UTF8Encoding(false, false);

        public readonly Regex NewLineRegex = new Regex(@"\r\n|\n\r|\n|\r");

        public string NormalizeNewLines(string input, string newLine = "\n")
        {
            return NewLineRegex.Replace(input, newLine);
        }

    }
}
