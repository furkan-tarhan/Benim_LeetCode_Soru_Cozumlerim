using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majority_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 2, 2, 1, 1, 1, 2, 2 };

            int sonuc = MajorityElement(sayilar);

            Console.WriteLine("Dizideki çoğunluk elemanı: " + sonuc);
            Console.ReadLine();
        }
        public static int MajorityElement(int[] nums)
        {
            // 1. Diziyi küçükten büyüğe sırala
            Array.Sort(nums);

            // 2. Madem bu sayı yarısından fazla var, 
            // sıralı dizinin tam ortasındaki eleman kesinlikle odur!
            return nums[nums.Length / 2];
        }
    }
}
