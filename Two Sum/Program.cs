using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Sum
{
    internal class Program
    {
        static void Main(string[] args) // Soruyu çözmeye methodan başla
        {
            int[] dizin = {1,2,3,4,5,6,7,8,9 };  // bu soruda verilen dizi
            int hedef = 15; // bu istenen sayıların toplamı
            int[] sonuc  = TwoSum(dizin, hedef); // işte aşağıda dödürdüğümüz dizin burda sonuc dizisine atadık
                                                // bu işlemde aslında dönen elemanın 2 elemanlı olmasını istendiğinden dolayı böyle yapmam durumunda kaldık
            if (sonuc.Length==2) // teyit ediyoruz iki elemanlı mı diye
            {
                Console.WriteLine("İstenen sonucun bulunduğu dizin yeri [" + sonuc[0] + "," + sonuc[1]+"]"); // ve sonucu yazdırıyoruz 
            }
            else { Console.WriteLine("Sonuç dizinde bulunmuyor"); } // sonuç yoksa bunu yazdırıyoruz



                Console.Read();
        }

        public static int[] TwoSum(int[] nums , int toplam)
        {
            for (int i = 0;i<nums.Length; i++ )   // iç içe for ile bu işlemi yaptık bu işlem diğer çözümlere nazaran daha uzun ve işlemciyi yoracak şekilde bir çözümdür
            {
                for (int j = i+1; j<nums.Length;j++)
                {
                    if (nums[i] + nums[j] ==toplam) // işte burada döngü içinde i=0 işlemi j nin tüm elamanları denenerek sonuç bulmaya çalışılır 
                    {                               // Bulunmasa i=1 den devam eder ve bu işlem ilk nerede bulunacaksa devam eder bundan dolayı işlemciyi yorar dedik 
                        return new int[] { i, j };  // Şurda return ü dizi olarak döndürdük ki yukarıda da bir dizinin elamanı gibi olsun 


                    }




                }

            }

            return new int[0]; // boş dönsün diye var bu

        }






    }
}
