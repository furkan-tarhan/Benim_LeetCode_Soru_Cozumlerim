using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_268_Missing_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] sayilar = { 3, 0, 1 };

            int eksik = MissingNumber(sayilar);

            Console.WriteLine("Dizideki eksik sayı: " + eksik);
            Console.ReadLine();

        }
        public static int MissingNumber(int[] nums)
        {
            int n = nums.Length;

            // 1. Olması gereken toplam (Gauss Formülü)
            int olmasiGerekenToplam = n * (n + 1) / 2;

            // 2. Dizideki sayıların gerçek toplamı
            int gercekToplam = 0;
            foreach (int sayi in nums)
            {
                gercekToplam += sayi;
            }

            // 3. Aradaki fark eksik sayıdır
            return olmasiGerekenToplam - gercekToplam;
        }
    }
}
