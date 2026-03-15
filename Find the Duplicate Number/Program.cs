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
    int[]  kola ={1, 2, 3, 4, 5, 56, 65, 656,2, 2, 3, 4, 1,5};


            
            FindDuplicate(kola);



            Console.Read();
        }

        public static void FindDuplicate(int[] nums)
        {



            //for (int i = 0; i<nums.Length;i++)          //// 1. yöntem    
            //{                                             //// bu yöntem iç içe for ile yapılıyor ve bu yöntem çok kaba taslak eğer dizi olarak bir 100 elamanlı verilse  
                                                            //// 100 ^2 kadar işlem gerçekleştirir ondan mütevellit bu yöntem tavsiye edilmez
            //    int kontrolEdilenSayı= nums[i];

            //    for (int a =i+1;a<nums.Length; a++ )
            //    {
            //        if (kontrolEdilenSayı == nums[a])
            //        {
            //            Console.WriteLine("Tekrar eden sayı : " + nums[a]);


            //        }


            //    }


            //}


            Array.Sort(nums);                        // 2. yöntem 

            for (int i = 0; i<nums.Length-1; i++)    // bu yöntem daha basit ve kolay yolludur  Belirttiğimiz Array.Sort metodu içinde yazılan diziyi küçükten büyüğe yazar 
            {
                if (nums[i] == nums[i+1])            // Bizde böylece 1 elemanı yukardaki gibi tüm elamanlar ile kontrol etmeyiz direkt yanındaki elamanla kıyaslarız
                {
                    Console.WriteLine("Tekrar eden sayı : " + nums[i]);
                }

                while (i<nums.Length -1 && nums[i]== nums[i+1] )    // Böyle yapıncada eğer bir eleman 2 den fazla kez yazılınca o elemanı 2 kere ekrana yazdırırız 
                {                                                   // Bunun önüne geçmek içinde while döngüsüne alırız eğer 3. elemnan da aynıysa sayıyı bir arttır ve diğer elemana geç deriz 
                    i++;
                }


            }



          
        }











    }




    
}
