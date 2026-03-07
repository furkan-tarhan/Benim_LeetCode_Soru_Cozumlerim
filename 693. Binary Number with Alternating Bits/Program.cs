using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _693.Binary_Number_with_Alternating_Bits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 11;

            Console.WriteLine(SonBitKontrol(n));
        }

        static bool SonBitKontrol(int n) {

            int sonBit = n & 1; //son biti buluruz burada
            n = n >> 1;    // n sayısını 2 lik tabandaki halinden son basamağı atılır ve sayı küçülür  111 >> 1 ; 011 yapar n sayısını 
 
            while (n>0)
            {
                int ikinciSonBit = n & 1; // üst satırda sayıyı 1 basamak şağa kaydırdık ve oluşşan yeni sayının son bitini öğrenmeye çaılışıyoryuz
                if (sonBit==ikinciSonBit) 
                {
                    return false;  // şu if le sayının bir  önce ki bit ile aynıysa false döndürmesini istedik
                }
                else {
                 sonBit=ikinciSonBit ;  // son bit ile ikinci bit farklı olunca biz ikinci bitin değerini son bite aktardık ve işlemi while ile döngüye girmesini sağladık

                    n = n >> 1;  // şu sağa kaydırma işlemi aslında ilk sağa kaydırma işleminin yerini aldı sayı küçüldü ve yukardaki 2. bit bulma işlemine girdi
                                 // böylece sayıda tekrar bit kontrol yapabileceğiz 

                }

            }

        return true;  // return da methodun boolean döndürmesi için true (false olsa while döngüsünden çıkmaz)
        }


    }
}
