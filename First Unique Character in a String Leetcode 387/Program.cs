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
            Random rnd = new Random();

            int bilgisayar = rnd.Next(3);

            Console.WriteLine("TAŞ KAĞIT MAKAS");  
            Console.WriteLine("1-Makas");
            Console.WriteLine("2-Kağıt");
            Console.WriteLine("3-Taş");
            Console.WriteLine("Lütfen Seçmek İstediğiniz Hareketin Sayısını Giriniz");
            Console.Write("-");
            int kullanıcı = int.Parse(Console.ReadLine());
            if (kullanıcı>3)
            {
                Console.WriteLine("Verilen Sayılardan Büyük Tuşlama Yaptınız");
                Console.WriteLine("HATA");
            }
            else if (kullanıcı==1 & (bilgisayar+1)==2)
            {
                Console.WriteLine("KAZANDINIZ");
                Console.WriteLine("Makas Kağıdı keser");
            }
            else if (kullanıcı==2 & (bilgisayar + 1) == 3)
            {
                Console.WriteLine("KAZANDINIZ");
                Console.WriteLine("Kağıt Taşı Yener ");

            }else if (kullanıcı==3 & (bilgisayar + 1) == 1)
            {
                Console.WriteLine("KAZANDINIZ");
                Console.WriteLine("Taş Makası Kırar");
            }
            else if (kullanıcı == 1 & (bilgisayar + 1) == 3)
            {
                Console.WriteLine("KAYBETTİNİZ");
                Console.WriteLine("Taş Makası Kırar");
            }else if (kullanıcı == 2 & (bilgisayar + 1) == 1)
            {
                Console.WriteLine("KAYBETTİNİZ");
                Console.WriteLine("Makas Kağıdı Keser");
            }
            else if (kullanıcı == 3 & (bilgisayar + 1) == 2)
            {
                Console.WriteLine("KAYBETTİNİZ");
                Console.WriteLine("Taş Makası Kırar");
               
            }
          Console.WriteLine("HATA VAR AMINA KOYİM");
            Console.Read();

        }

    }
}
