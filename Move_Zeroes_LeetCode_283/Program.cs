using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Move_Zeroes_LeetCode_283
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] sayilar = { 0, 1, 0, 3, 12 };

            MoveZeroes(sayilar);

            //// Sonucu ekrana yazdıralım
            //Console.WriteLine("Sonuç: " + string.Join(", ", sayilar));
            //Console.ReadLine();






        }
        public static void MoveZeroes(int[] nums)
        {
            int yazici = 0;

            for (int i = 0; i<nums.Length;i++)
            {
                if (nums[i]!=0)
                {
                    nums[yazici] = nums[i];
                    yazici++;
                }
            }
            for ( int i=yazici;i<nums.Length;i++)
            {
                nums[i]= 0;
            }

            foreach (var n in nums) Console.Write(n + " ");
        }
    }
    
}
    