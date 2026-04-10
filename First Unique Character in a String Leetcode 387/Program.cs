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
            string metin = "loveleetcode";

            int sonuc = FirstUniqChar(metin);

            Console.WriteLine("İlk benzersiz karakterin indexi: " + sonuc);
            Console.ReadLine();


            // Console.WriteLine(EssizKarater("araba"));
        }
        public static int FirstUniqChar(string s)
        {
            // Alfabedeki 26 harf için bir sayaç dizisi oluşturuyoruz
            int[] sayac = new int[26];

            // 1. TUR: Her harfin kaç kere geçtiğini hesapla
            foreach (char c in s)
            {
                sayac[c - 'a']++;
            }

            // 2. TUR: Metni baştan sona tekrar tara
            // Sayacı 1 olan ilk harfi bulduğumuzda indexini dön
            for (int i = 0; i < s.Length; i++)
            {
                if (sayac[s[i] - 'a'] == 1)
                {
                    return i;
                }
            }

            return -1; // Hiç benzersiz yoksa
        }
        #region

        //public static int EssizKarater(string s)
        //{


        //    char[] harf = s.ToCharArray();
        //    Console.WriteLine(s);
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        for (int a = 0; a < s.Length; a++)
        //        {
        //            if (harf[i] == harf[a])
        //            {

        //                Console.WriteLine(i+" Eşsiz değil");
        //                return false ;
        //            }

        //            Console.WriteLine(i + ". eşsiz karakter");
        //        }

        //    }


        //    return -1;
        // }
        #endregion
    }
}
