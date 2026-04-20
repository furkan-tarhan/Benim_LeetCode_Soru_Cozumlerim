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
            
            oyun();



        }
        public static void oyun()
        {
            Random rnd = new Random();
            int bilgisayarSkor = 0;
            int kullanıcıSkor = 0;
            Boolean sart = true;
            while (sart)
            {
        
                Console.Clear();
                Console.WriteLine("TAŞ KAĞIT MAKAS");
                Console.WriteLine("1-Makas");
                Console.WriteLine("2-Kağıt");
                Console.WriteLine("3-Taş");
                Console.WriteLine("Lütfen Seçmek İstediğiniz Hareketin Sayısını Giriniz");
           


                int bilgisayar = rnd.Next(3);
                Console.Write("-");
                int kullanıcı = int.Parse(Console.ReadLine());



                if (kullanıcı > 3)
            {
                Console.WriteLine("Verilen Sayılardan Büyük Tuşlama Yaptınız");
                Console.WriteLine("HATA");
            }
            else if (kullanıcı == 1 & (bilgisayar + 1) == 2)
            {
                Console.WriteLine("***KAZANDINIZ***");
                Console.WriteLine("  ");
                Console.WriteLine("Makas Kağıdı keser");
                    kullanıcıSkor++;
            }
            else if (kullanıcı == 2 & (bilgisayar + 1) == 3) 
            {
                Console.WriteLine("***KAZANDINIZ***");
                Console.WriteLine("  ");
                Console.WriteLine("Kağıt Taşı Yener ");
                    kullanıcıSkor++;

                }
            else if (kullanıcı == 3 & (bilgisayar + 1) == 1)
            {
                Console.WriteLine("***KAZANDINIZ***");
                Console.WriteLine("  ");
                Console.WriteLine("Taş Makası Kırar");
                    kullanıcıSkor++;
                }
            else if (kullanıcı == 1 & (bilgisayar + 1) == 3)
            {
                Console.WriteLine("***KAYBETTİNİZ***");
                Console.WriteLine("  ");
                Console.WriteLine("Taş Makası Kırar");
                    bilgisayarSkor++;
            }
            else if (kullanıcı == 2 & (bilgisayar + 1) == 1)
            {
                Console.WriteLine("***KAYBETTİNİZ***");
                Console.WriteLine("  ");
                Console.WriteLine("Makas Kağıdı Keser");
                    bilgisayarSkor++;
                }
            else if (kullanıcı == 3 & (bilgisayar + 1) == 2)
            {
                Console.WriteLine("***KAYBETTİNİZ***");
                Console.WriteLine("  ");
                Console.WriteLine("Taş Makası Kırar");
                    bilgisayarSkor++;

                }
            else { Console.WriteLine("***Berabere***"); }
            Console.WriteLine("  ");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Bilgisayarın Seçtiği Sayı: " + (bilgisayar + 1));
            Console.WriteLine("  ");
            Console.WriteLine("Bizim Seçtiğimiz Sayı: " + kullanıcı);
                Boolean ikinciSart = true;
                while (ikinciSart)
                {

                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("  ");
                Console.WriteLine("********************************");
                Console.WriteLine("Devam mı ? Tamam mı ?");
                    Console.WriteLine("  ");
                    Console.WriteLine("Devam Etmek İçin 1 ' i Tuşlayınız");
                    Console.WriteLine("  ");
                    Console.WriteLine("Tamam Demek İçin 0 ' ı Tuşlayınız");
                    Console.WriteLine("********************************");

                    Console.WriteLine("SKOR (SEN:BİLGİSAYAR):  " + kullanıcıSkor + " : " + bilgisayarSkor);

                    int secim = int.Parse(Console.ReadLine());

                    if (secim == 1)
                    {
                        sart = true;
                        ikinciSart = false;
                    }
                    else if (secim == 0)
                    {
                        sart = false;
                        ikinciSart = false;
                    }
                    else { Console.WriteLine("Yanlış tuşlama yaptınız");
                        Console.WriteLine("Tekrar deneyiniz!!!");
                        ikinciSart = true;
                    }
                }


            }

        }

    }
}
