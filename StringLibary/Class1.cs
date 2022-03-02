using System;

namespace StringLibary
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительное число");
            int Num = Convert.ToInt32(Console.ReadLine());
            if (Num < 0)
            {
                Console.WriteLine("Это не положительное число");

            }
            if (Num >= 0)
            {
                Console.Write("N = " + Num + ":");
                for (int i = 0; i <= Num; i++)
                {

                    if (i == Num)
                    {
                        Console.Write(i + ".");
                    }
                    if (i < Num)
                    {
                        Console.Write(i + ",");
                    }

                }

            }
            Console.WriteLine("Введите сторону квадрата");
            int N = Convert.ToInt32(Console.ReadLine());
            Square(N);
            Console.ReadKey();
        }
        static void Square(int N)
        {
            N += 1;


            for (int i = 1; i < N; i++)
            {
                for (int n = 1; n < N; n++)
                {

                    Console.SetCursorPosition(n, i);
                    Console.WriteLine("*");
                    Console.SetCursorPosition(i, n);
                    Console.WriteLine("*");
                    Console.SetCursorPosition(N - 2, i);
                    Console.WriteLine("*");
                    Console.SetCursorPosition(i, N - 2);
                    Console.WriteLine("*");
                    Console.SetCursorPosition(N / 2, N / 2);
                    Console.WriteLine(" ");

                }
            }
        }
    }


    
}

