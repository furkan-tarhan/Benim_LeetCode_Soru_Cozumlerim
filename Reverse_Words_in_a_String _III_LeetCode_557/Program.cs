using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Words_in_a_String__III_LeetCode_557
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string cumle = ":ints @omecxzczxczxczrr2 "; //

            string sonuc = ReserveWords(cumle);

            Console.WriteLine("Orijinal: " + cumle);
            Console.WriteLine("Ters Hali: " + sonuc);
            Console.ReadLine();




        }

        public static string ReserveWords(string word)
        {
            string[] kelime = word.Split(' ');
            
            for (int i =0; i<kelime.Length; i++)
            {
                char[] harfler = kelime[i].ToCharArray();

                Array.Reverse(harfler);

                kelime[i] = new string(harfler);

            }



            return string.Join(" ",kelime);


        }









    }
}
