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
            int onceki = 0;

            int mevcut = 1;

            int sonuc = 0; // sonuç

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                {
                    mevcut++;
                }
                else
                {
                    sonuc += Math.Min(onceki,mevcut);

                    onceki = mevcut;

                    mevcut = 1;
                }
            }

            sonuc += Math.Min(onceki, mevcut);

            return sonuc;
        }
    }
}
