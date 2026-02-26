



using System;
using System.Collections.Generic;
using System.Text;

namespace Letter_Combinations_of_a_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            string digits = "23";
            IList<string> result = p.LetterCombinations(digits);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public IList<string> LetterCombinations(string digits)
        {
            List<string> result = new List<string>();

            // Eğer input boşsa boş liste döndür
            if (string.IsNullOrEmpty(digits))
                return result;

            // Telefon tuş haritalaması
            string[] phoneMap = new string[]
            {
                "",     // 0
                "",     // 1
                "abc",  // 2
                "def",  // 3
                "ghi",  // 4
                "jkl",  // 5
                "mno",  // 6
                "pqrs", // 7
                "tuv",  // 8
                "wxyz"  // 9
            };

            // Backtracking başlat
            Backtrack(0, new StringBuilder(), digits, phoneMap, result);

            return result;
        }

        private void Backtrack(int index, StringBuilder current, string digits, string[] phoneMap, List<string> result)
        {
            // Tüm rakamlar işlendiğinde kombinasyonu ekle
            if (index == digits.Length)
            {
                result.Add(current.ToString());
                return;
            }

            int digit = digits[index] - '0';
            string letters = phoneMap[digit];

            foreach (char letter in letters)
            {
                current.Append(letter);
                Backtrack(index + 1, current, digits, phoneMap, result);
                current.Length--; // backtrack (geri alma)
            }
        }
    }
}
