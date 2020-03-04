using System;

namespace New_SoftUni_Building
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int row = size + size / 2;
            int number = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (number == 0 || number % 4 == 0)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                    number++;
                }
                number = 5+i;
                Console.WriteLine();
            }

        }
    }
}
