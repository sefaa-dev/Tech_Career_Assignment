using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_CustomHtmlHelpers2.Extensions
{
    public static class StringExtension
    {
        public static string ClearTurkishCharacters(this string text)
        {
            string turkish = "çış";
            string english = "cis";

            string result = string.Empty;

            foreach (char item in text)
            {
                if (turkish.Contains(item))
                {
                    int index = turkish.IndexOf(item);
                    result += english[index];
                }
                else
                {
                    result += item;
                }
            }
            return result;
        }
    }
}
