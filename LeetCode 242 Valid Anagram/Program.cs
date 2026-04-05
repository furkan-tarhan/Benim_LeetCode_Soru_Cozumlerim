using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_242_Valid_Anagram
{
    internal class Program
    {
        static void Main(string[] args) {


            Console.Write("Lüfen anagram olduğunu düşündüğünüz kelmiye giriniz: ");   // kulalnıcıdan iki kelime istedim 

            string word1 = Console.ReadLine();
            Console.Write("Lüfen anagram olduğunu düşündüğünüz 2. kelmiye giriniz: ");

            string word2 = Console.ReadLine(); 

            Console.WriteLine(AnagramTespit(word1, word2)); // method çağırıldı 


            #region


            //{
            //    string kelime1 = "anagram";
            //    string kelime2 = "nagaram";

            //    bool sonuc = IsAnagram(kelime1, kelime2);

            //    Console.WriteLine($"'{kelime1}' ve '{kelime2}' anagram mı? " + sonuc);
            //    Console.ReadLine();
            #endregion
        }
        public static bool AnagramTespit(string a , string b)
        {
            if (a.Length != b.Length) return false;  // eğer string ifadelierin karakter sayısı aynı değilse direk anagram olmadığından false döndürürüz

            Char[] aDizi = a.ToCharArray();         // String ifadeleri char karakterlerine çeviriyoruz ve bunları bir dizi içine alıyoruz ki 
            Char[] bDizi = b.ToCharArray();        // karakterleri daha iyi kontrol edelim 

            Array.Sort(aDizi);                   // char dizisini küçğkten büyüğe veya diziyoruz
            Array.Sort(bDizi);

            for (int i =0; i<bDizi.Length; i++) // for dizisi ile char dizilerini teker teker kontroö edeiyoruz 
                       {                        // Array.Sort ile dizileri alfabetik sırayaddizdik diye 
                if (aDizi[i] != bDizi[i]) return false; // eğer anagram ise dizilerin elemanlarının sırası hepsi için aynıo olur böylelikle dizi1[1]=dizi2[2] aynı olur 
                                                // değilse zaten false döndürür
            }
            return true;

            Console.ReadLine();
        }



             #region


        //public static bool IsAnagram(string s, string t)
        //{
           
            
        //    // 1. Uzunluklar farklıysa uğraşmaya gerek yok
        //    if (s.Length != t.Length) return false;

        //    // 2. String'leri karakter dizisine çeviriyoruz
        //    char[] sDizi = s.ToCharArray();
        //    char[] tDizi = t.ToCharArray();

        //    // 3. İkisini de alfabetik olarak sıralıyoruz
        //    Array.Sort(sDizi);
        //    Array.Sort(tDizi);

        //    // 4. Sıralanmış hallerini tek tek kontrol ediyoruz
        //    for (int i = 0; i < sDizi.Length; i++)
            
        //    {
        //        if (sDizi[i] != tDizi[i])
        //        {
        //            return false; // Bir tane bile farklı harf varsa anagram değildir
        //        }
        //    }

        //    return true; // Her şey aynıysa true!
        //}
        #endregion
    }
}
