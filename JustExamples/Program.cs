using System;

namespace JustExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            const double pi = 3.1415926535897932;
            Console.Write("Radiusi: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double face = Math.Pow(radius, 2) * pi;
            double LengthRing = 2 * pi * radius;

            Console.WriteLine($"Aylananing yuzi: {face}");
            Console.WriteLine($"Aylananing radiusi: {LengthRing}");

            // Task 2
            double dollarkurs = 12400;

            Console.Write("Qiymat kiriting: ");
            int summ = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Valyuta hisobida: {dollarkurs* summ}");

            // Task 3

            Console.Write("year of birth: ");
            int dateofbirth = Convert.ToInt32(Console.ReadLine());

            int daysdiff = 2023 - dateofbirth;

            Console.WriteLine($"Kun hisobida {365 * daysdiff}");
        }
    }
}
