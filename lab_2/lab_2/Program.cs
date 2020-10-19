using System;
using System.IO;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter saveout = Console.Out;
            TextReader sevein = Console.In;
            var outFile = new StreamWriter(@"output.txt");
            var inFile = new StreamReader(@"input.txt");

            Console.SetOut(outFile);
            Console.SetIn(inFile);

            double a, b, c, d, e, s, k;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            d = Convert.ToDouble(Console.ReadLine());
            e = Convert.ToDouble(Console.ReadLine());

            if ((d > 1) || (b - e + a > 0))
            {
                s = (Math.Sqrt(b - e + a)) / (Math.Sqrt(d - 1));
                Console.WriteLine(String.Format("{0:0.000}", s));
            }
            else Console.WriteLine("Error");

            if ((c - 11 * b > 0) || (b - e + a > 0))
            {
                k = (Math.Sqrt(c - 11 * b)) / (Math.Sqrt(b - e + a));
                Console.WriteLine(String.Format("{0:0.000}", k));
            }
            else Console.WriteLine("Error");

            Console.SetOut(outFile);
            outFile.Close();
            Console.SetIn(inFile);
            inFile.Close();
        }
    }
}
