using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _696.Count_Binary_Substrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "00110011";
            Console.WriteLine(CountBinarySubstrings(s)); // 6
        }
        static int CountBinarySubstrings(string s)
        {
            int prevGroup = 0;
            int currGroup = 1;
            int result = 0;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                {
                    currGroup++;
                }
                else
                {
                    result += Math.Min(prevGroup, currGroup);
                    prevGroup = currGroup;
                    currGroup = 1;
                }
            }

            result += Math.Min(prevGroup, currGroup);

            return result;
        }
    }
}
