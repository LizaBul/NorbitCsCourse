using System;

namespace ex
{
    class program1
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
        }
    }
}

