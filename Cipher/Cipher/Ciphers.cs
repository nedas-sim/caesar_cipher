using System.Linq;
using System.Text;

namespace Cipher
{
    public static class Ciphers
    {
        private static char Shift(char c, int shiftValue)
        {
            if (!char.IsLetter(c)) // If character is not a letter, return it.
            {
                return c;
            }

            int val = (int)c % 32; // Getting value of letter, ignoring if it's uppercase or lowercase. a, A - 1 ; b, B - 2 and so on.
            val += shiftValue; // Adding shift value.
            val %= 26; // Mod 26, because a value could be more than 26.
            val = val <= 0 ? val + 26 : val; // Value could be negative after doing Mod 26, if it is, add 26.
            val += (char.IsUpper(c)) ? 64 : 96; // Add 64 to make it an uppercase letter, 96 to make it lowercase.

            return (char)val;
        }

        // Going over each character and appending the value to StringBuilder.
        public static string WithStringBuilder(string input, int shiftValue)
        {
            var builder = new StringBuilder();

            foreach (var ch in input)
            {
                builder.Append(Shift(ch, shiftValue));
            }

            return builder.ToString();
        }

        // Going over each character and appending the value to "".
        public static string AppendToString(string input, int shiftValue)
        {
            var result = "";

            foreach (var ch in input)
            {
                result += Shift(ch, shiftValue);
            }

            return result;
        }

        // Going over each character and appending the value to empty string.
        public static string AppendToEmptyString(string input, int shiftValue)
        {
            var result = string.Empty;

            foreach (var ch in input)
            {
                result += Shift(ch, shiftValue);
            }

            return result;
        }

        // Using linq to get IEnumerable<char>, then joining values with no spaces in between.
        public static string WithLinq(string input, int shiftValue)
        {
            var value = string.Join("",
                input
                    .ToList()
                    .Select(ch => Shift(ch, shiftValue)));

            return value;
        }

        // Using linq to get char array, then calling string constructor.
        public static string WithLinqStringConstructor(string input, int shiftValue)
        {
            var value = new string(input.Select(ch => Shift(ch, shiftValue)).ToArray());

            return value;
        }

        // Using linq to get char array, then putting array to StringBuilder.
        public static string StringBuilderLinqToArray(string input, int shiftValue)
        {
            var builder = new StringBuilder();
            builder.Append(input.Select(ch => Shift(ch, shiftValue)).ToArray());
            return builder.ToString();
        }
    }
}
