using System;
using System.IO;

namespace lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            do
            {
                Console.Write("1 - create file\n2 - work with file\n0 - exit\nYour choise -->> ");
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                    Input();
                if (a == 2)
                {
                    String fileName1, fileName2;
                    Console.Write("Inter file name (output) (with out ext) -->> ");
                    fileName1 = Console.ReadLine();
                    fileName1 += ".txt";
                    Console.Write("Inter file name (input) (with out ext) -->> ");
                    fileName2 = Console.ReadLine();
                    fileName2 += ".txt";
                    TextWriter saveout = Console.Out;
                    TextReader savein = Console.In;
                    var outFile = new StreamWriter(fileName1);
                    var inFile = new StreamReader(fileName2);
                    Console.SetOut(outFile);
                    Console.SetIn(inFile);

                    int n = Convert.ToInt32(Console.ReadLine());
                    String strall = Console.ReadLine();
                    string[] strelem = strall.Split(' ');

                    int[] mas = new int[n];
                    for(int i = 0; i < n; i++)
                    {
                        mas[i] = Convert.ToInt32(strelem[i]);
                    }

                    int sum = 0, pr = 1;
                    for(int i = 0; i < n; i++)
                    {
                        if (mas[i] % 10 == 0)
                            sum += mas[i];
                        if (mas[i] > 0 & mas[i] < 1000)
                            pr *= mas[i];
                    }

                    Console.WriteLine("Sum -->> {0}\nPr -->>{1}", sum, pr);
                    for(int i = 0; i < n; i++)
                    {
                        if (mas[i] % 11 == 0)
                            Console.WriteLine(mas[i] + " ");
                    }

                    Console.SetOut(saveout);
                    outFile.Close();
                    Console.SetIn(savein);
                    inFile.Close();

                }

            } while (a != 0);
        }

        static void Input()
        {
            int n;
            String fileName;

            Console.Write("Inter N -->> ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inter file name (with out ext) -->> ");
            fileName = Console.ReadLine();
            fileName += ".txt";

            TextWriter saveout = Console.Out;
            var outFile = new StreamWriter(fileName);
            Console.SetOut(outFile);
            Console.WriteLine(n);

            Random r = new Random(DateTime.Now.Millisecond);
            int x = 0;
            for (int i =0; i < n; i++)
            {
                x = r.Next(1000);
                Console.Write(x + " ");
            }

            Console.SetOut(saveout);
            outFile.Close();
            Console.WriteLine("File "+ fileName +" was created!!!");
            Console.ReadKey();
            }
    }
}
