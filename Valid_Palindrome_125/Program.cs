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




        }
        public bool IsPalindrome(string s)
        {
            // İki işaretçi (Two Pointers) yöntemi
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                // Soldaki karakter geçerli bir harf veya rakam değilse ilerle
                if (!char.IsLetterOrDigit(s[left]))
                {
                    left++;
                }
                // Sağdaki karakter geçerli değilse geri gel
                else if (!char.IsLetterOrDigit(s[right]))
                {
                    right--;
                }
                // İkisi de geçerliyse karşılaştır
                else
                {
                    if (char.ToLower(s[left]) != char.ToLower(s[right]))
                    {
                        return false; // Eşleşmiyorsa palindrome değildir
                    }
                    left++;
                    right--;
                }
            }

            return true;
        }
    }
}
