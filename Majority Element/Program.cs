using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majority_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Dizide eleman sayısının yarısından fazla sayıda bulunan eleman:"+ DizininModu(5)  );
           
           #region
         
            //int[] sayilar = { 2, 2, 1, 1, 1, 2, 2 };

            //int sonuc = MajorityElement(sayilar);

            //Console.WriteLine("Dizideki çoğunluk elemanı: " + sonuc);
            //Console.ReadLine();
            #endregion
        }
        public static int DizininModu(int mod)
        {
            int[] eleman = {1,3,4,5,32,43,12,1,12,2,12,3,4,44,4,4,4,4,4,4,4,4,4,4,4,4 };

            Array.Sort(eleman);
             mod = eleman[eleman.Length / 2];



            return mod;
        }




        #region
        //public static int MajorityElement(int[] nums)
        //{
        //    // 1. Diziyi küçükten büyüğe sırala
        //    Array.Sort(nums);

        //    // 2. Madem bu sayı yarısından fazla var, 
        //    // sıralı dizinin tam ortasındaki eleman kesinlikle odur!
        //    return nums[nums.Length / 2];
        //}
        #endregion
    }
}
