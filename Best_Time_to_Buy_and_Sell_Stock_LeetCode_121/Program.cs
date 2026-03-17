using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Best_Time_to_Buy_and_Sell_Stock_LeetCode_121
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    int[] fiyatlar = {1,4,3,1,5,9,7 };

            //    int sonuc = yatırım(fiyatlar);

            //    Console.WriteLine(sonuc);
            int[] fiyatlar = { 7, 1, 5, 3, 6, 4 };

            int maxKar = MaxProfit(fiyatlar);

            Console.WriteLine("Elde edilebilecek maksimum kar: " + maxKar);
            Console.ReadLine();

        }
        public static int MaxProfit(int[] prices)
        {
            if (prices.Length == 0) return 0;

            int minPrice = prices[0]; // İlk günün fiyatını en düşük kabul et
            int maxProfit = 0;        // Başlangıçta kar sıfır

            for (int i = 1; i < prices.Length; i++)
            {
                // Eğer bugünkü fiyat, şu ana kadar gördüğümüzden düşükse en düşüğü güncelle
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
                // Değilse, bugünkü fiyattan satsaydık ne kadar kar ederdik?
                else if (prices[i] - minPrice > maxProfit)
                {
                    maxProfit = prices[i] - minPrice;
                }
            }

            return maxProfit;
        }
        //public static int yatırım(int[] prices)
        //{
        //    int minPrice = 0;
        //    int maxPrice = 0;
        //    for (int i =0; i<prices.Length;i++)
        //    {

        //        if (maxPrice < prices[i])
        //        {
        //            maxPrice = prices[i];
        //        }
        //        else
        //        {
        //            minPrice = prices[i];
        //        }

        //    }
        //    Console.WriteLine(maxPrice);
        //    Console.WriteLine(minPrice);




        //    return prices[0];
        //}




    }
}
