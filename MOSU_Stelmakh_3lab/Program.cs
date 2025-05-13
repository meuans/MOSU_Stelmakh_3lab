using MOSU_Stelmakh_3lab;
using System;

namespace MOSU_Stelmakh_3lab
{
    internal class Program
    {
       
            static void Main(string[] args)
            {
                double[] startPoint = new double[] { 1, 1 }; // початкова точка
                double h = 10;
                double eps = 0.01; //точність

                Console.WriteLine("Початкова точка:");
                PrintPoint(startPoint);

                int steps = HookeJeevesOptimizer.HookeJeeves(Function, ref startPoint, h, eps);

                Console.WriteLine("\n=== Результат ===");
                PrintPoint(startPoint, "Точка оптимуму:");
                Console.WriteLine($"Значення функцiї I = {Function(startPoint)}");
                Console.WriteLine($"Кiлькiсть iтерацiй: {steps}");
            }

            static double Function(double[] u)
            {
                double u1 = u[0];
                double u2 = u[1];

                return 4 * Math.Pow(u1, 2) + 3 * Math.Pow(u2, 2) - 4 * u1 * u2 + u1;
            }

            static void PrintPoint(double[] point, string caption = "")
            {
                if (!string.IsNullOrEmpty(caption))
                    Console.Write(caption + " ");
                for (int i = 0; i < point.Length; i++)
                    Console.Write($"u[{i}] = {point[i]:F5} ");
                Console.WriteLine();
            }
     
    }
}


