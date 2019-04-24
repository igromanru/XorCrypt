
using System;

namespace Crypt
{
    public class Xor
    {
        private static readonly Random random = new Random();
        public static readonly int XorKey = random.Next(short.MaxValue) ^ random.Next(short.MaxValue);

        public static string XorString(string text, int xorKey)
        {
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                var charValue = Convert.ToInt32(text[i]);
                charValue ^= i + xorKey;
                result += char.ConvertFromUtf32(charValue);
            }
            return result;
        }

        public static string XorString(string text)
        {
            return XorString(text, XorKey);
        }
    }
}
