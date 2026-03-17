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
            int[] fiyatlar = { 1, 4, 3, 1, 5, 9, 7 };  

            int sonuc = yatırım(fiyatlar);

            Console.WriteLine("Elde edilebilecek max kar: "+sonuc);
            
        }
    
        public static int yatırım(int[] prices)
        {
            int minPrice = prices[0];
            int maxPrice = 0;
            int kar = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (minPrice > prices[i])
                {
                    minPrice = prices[i];
                }
                else if (maxPrice < prices[i])
                {
                    maxPrice = prices[i];
                    
                } 
            }

            kar = maxPrice - minPrice;

            return kar;
        }




    }
}
