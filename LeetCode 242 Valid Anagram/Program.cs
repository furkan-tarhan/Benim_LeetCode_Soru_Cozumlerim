using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_242_Valid_Anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kelime1 = "anagram";
            string kelime2 = "nagaram";

            bool sonuc = IsAnagram(kelime1, kelime2);

            Console.WriteLine($"'{kelime1}' ve '{kelime2}' anagram mı? " + sonuc);
            Console.ReadLine();
        }
        public static bool IsAnagram(string s, string t)
        {
            // 1. Uzunluklar farklıysa uğraşmaya gerek yok
            if (s.Length != t.Length) return false;

            // 2. String'leri karakter dizisine çeviriyoruz
            char[] sDizi = s.ToCharArray();
            char[] tDizi = t.ToCharArray();

            // 3. İkisini de alfabetik olarak sıralıyoruz
            Array.Sort(sDizi);
            Array.Sort(tDizi);

            // 4. Sıralanmış hallerini tek tek kontrol ediyoruz
            for (int i = 0; i < sDizi.Length; i++)
            {
                if (sDizi[i] != tDizi[i])
                {
                    return false; // Bir tane bile farklı harf varsa anagram değildir
                }
            }

            return true; // Her şey aynıysa true!
        }
    }
}
