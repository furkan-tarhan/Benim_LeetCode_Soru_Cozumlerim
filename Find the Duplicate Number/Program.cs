using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_Duplicate_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {





        }

        public int FindDuplicate(int[] nums)
        {
            // Önce diziyi küçükten büyüğe sıralıyoruz
            // {1, 3, 4, 2, 2} -> {1, 2, 2, 3, 4} olur
            Array.Sort(nums);

            // Diziyi gezip yandaki elemanla aynı mı diye bakıyoruz
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    return nums[i]; // Bulduğumuz an döndürüyoruz
                }
            }

            return -1; // Normalde buraya hiç gelmez
        }











    }




    }
}
