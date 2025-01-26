using System;
namespace Task_04_07
{

    class Program
    {
        static void Main()
        {
            int[] heights = { -150, 160, -165, 170, -175, 155, 162, 158, -180, 154, 168, -160, 175, 145, 173, 157, 159, -165, 164, 156, -170, 169, -180, 147, 150, 161, -172, 144, -155, 159, -167 };

            int boysCount = 0;
            int girlsCount = 0;
            int boysHeightSum = 0;
            int girlsHeightSum = 0;
            foreach (var height in heights)
            {
                if (height < 0)
                {
                    boysCount++;
                    boysHeightSum += Math.Abs(height);
                }
                else
                {
                    girlsCount++;
                    girlsHeightSum += height;
                }
            }

            double boysAverageHeight = boysCount > 0 ? (double)boysHeightSum / boysCount : 0;
            double girlsAverageHeight = girlsCount > 0 ? (double)girlsHeightSum / girlsCount : 0;

            Console.WriteLine($"Количество мальчиков: {boysCount}");
            Console.WriteLine($"Количество девочек: {girlsCount}");
            Console.WriteLine($"Средний рост мальчиков: {boysAverageHeight:F2}");
            Console.WriteLine($"Средний рост девочек: {girlsAverageHeight:F2}");
        }
    }
}
