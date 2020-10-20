using System;
using System.IO;

namespace lab_3
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

            int t=0, n=1,i=1;
            double x=0, y=0,zn=1,ch,A=0;
            t = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());

            if (t == 0)
            {
                for (i = 1; i <= n; i++)
                {
                    zn = i * (i + 2);
                    if (i % 2 == 0)
                        ch = -Math.Tan(y) * (1.0 / Math.Tan(Math.Pow(x, i + 1)));
                    else
                        ch = Math.Tan(x) * (1.0 / Math.Tan(Math.Pow(y, i + 1)));
                    A += ch / zn;
                }
            }

            if (t == 1)
            {
                i = 1;
                while (i <= n)
                {
                    zn = i * (i + 2);
                    if (i % 2 == 0)
                        ch = -Math.Tan(y) * (1.0 / Math.Tan(Math.Pow(x, i + 1)));
                    else
                        ch = Math.Tan(x) * (1.0 / Math.Tan(Math.Pow(y, i + 1)));
                    A += ch / zn;
                    i++;
                }
            }

            if (t == 2)
            {
                i = 1;
                do
                {
                    zn = i * (i + 2);
                    if (i % 2 == 0)
                        ch = -Math.Tan(y) * (1.0 / Math.Tan(Math.Pow(x, i + 1)));
                    else
                        ch = Math.Tan(x) * (1.0 / Math.Tan(Math.Pow(y, i + 1)));
                    A += ch / zn;
                    i++;
                } while (i <= n);
            }

            Console.WriteLine(String.Format("{0:0.00000000}", A));

            Console.SetOut(outFile);
            outFile.Close();
            Console.SetIn(inFile);
            inFile.Close();
        }
    }
}
