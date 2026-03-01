using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Container_With_Most_Water
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1️. Diziyi burada tanımlıyoruz
            int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

            // 2️. Class nesnesi oluştur
            Program p = new Program();

            // 3️. Methodu çağır ve sonucu al
            int result = p.MaxArea(height);

            // 4️. Ekrana yazdır
            Console.WriteLine("Max Area: " + result);
        }

        public int MaxArea(int[] height)                        // commit 
        {
            int left = 0;
            int right = height.Length - 1;
            int maxArea = 0;

            while (left < right)
            {
                int h = Math.Min(height[left], height[right]);
                int width = right - left;
                int area = h * width;

                if (area > maxArea)
                    maxArea = area;

                // küçük olanı hareket ettir
                if (height[left] < height[right])
                    left++;
                else
                    right--;
            }

            return maxArea;
        }
    }



}

