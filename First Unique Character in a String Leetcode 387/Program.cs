using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Unique_Character_in_a_String_Leetcode_387
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            Console.WriteLine(EssizKarater("araba")); // dasdasdasd
        }

        public static int EssizKarater(string s)
        {


            char[] harf = s.ToCharArray();
            Console.WriteLine(s);
            for (int i = 0; i < s.Length; i++)
            {
                for (int a = 0; a < s.Length; a++)
                {
                    if (harf[i] == harf[a])
                    {

                        Console.WriteLine(i + " Eşsiz değil");
                       
                    }

                    Console.WriteLine(i + ". eşsiz karakter");
                }

            }


            return -1;
        }
      
    }
}
