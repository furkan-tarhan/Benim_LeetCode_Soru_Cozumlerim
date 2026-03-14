using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid_Palindrome_125
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("Küllük"));

        }
        public static bool IsPalindrome(string s)
        {
            int left = 0; // şimdi ilk başta imleç hareketini kontrol etmek için harflere numara vereceğiz bunun için baştaki harftan başlamak için sol = 0 
            int right = s.Length - 1; // sondaki harften başlamak için dizinin son elamanına atıyoruz ama unutmamak gerek ki bizim dizi elamanı sayısı misal 6 ise 
                                      // s.Lengt =6    right =6 olamaz çünkü dizi elamanları 0 dan başlar yani son elaman 4 olmak zorunda ondan dolayı " -1" olarak elamanı ayarladık

            while (left < right)  // stringi gezmek için while döngüsüne girdik
            {
                if (!char.IsLetterOrDigit(s[left])) // şu "char.IsLetterOrDigit " bize karakterin harf mı yoksa rakam mı olduğunu teyit etmek için gerekli bir methot 
                {                                   // eğer harf ve rakamsa true  diğer semboller ise false döndürür
                    left++;                         // baştaki "! " dikkat harf rakam değilse karakteri bir yana kaydırıyoruz
                }
                else if (!char.IsLetterOrDigit(s[right]))
                {
                    right--;             // aynı işlem burada da tekrar ediyor deilse sağ karakteri bir azalt
                }
                else
                {
                    if (char.ToLower(s[left]) != char.ToLower(s[right]))       // şu "char.ToLower" karekteri küçük harfe çevirmemiz yarar çünkü "Kazak  "bir polindromdur 
                    {                                                          // ama 'K' ve 'k ' farklı karekter olduğundan onun önüne geçmek için kullandığımız bir methoddur
                        return false;
                    }
                    left++;
                    right--;

                }


            }
            return true;
        }
    }
}
