namespace Soft_Jump
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int row = input[0];
            int col = input[1];
            int numberOnJump = 0;
            char[,] pole = new char[row, col];
            row = 0;
            for (int i = 0; i < input[0]; i++)
            {
                col = 0;
                string inputRow = Console.ReadLine();
                for (int j = 0; j < inputRow.Length; j++)
                {
                    pole[row, col] = (char)inputRow[j];
                    col++;
                }
                row++;
            }
            int number = int.Parse(Console.ReadLine());
            if (number > input[0])
            {
                number = input[0];
            }
            for (int i = 0; i < number; i++)
            {

                int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();
                row = command[0];
                int movet = command[1];
                for (int k = 0; k < movet; k++)
                {
                    var bufer = pole[row, pole.GetLength(1) - 1];
                    for (int j = pole.GetLength(1) - 1; j >= 0; j--)
                    {
                        if (pole[row, 0] == 'S' || pole[row, j] == 'S' || bufer == 'S')
                        {
                            goto lose;
                        }
                        if (j == 0)
                        {
                            pole[row, j] = bufer;
                        }
                        else
                        {
                            pole[row, j] = pole[row, j - 1];
                        }
                    }
                }
                for (int ii = 0; ii < pole.GetLength(0); ii++)
                {
                    for (int j = 0; j < pole.GetLength(1); j++)
                    {
                        if (pole[ii, j] == 'S')
                        {
                            pole[ii - 1, j] = 'S';
                            pole[ii, j] = '0';
                            numberOnJump++;
                            if (ii - 1 == 0)
                            {
                                goto win;
                            }
                        }
                    }
                }
            }
        win:
            Console.WriteLine("Win");
            Console.WriteLine($"Total Jumps: {numberOnJump}");
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    Console.Write(pole[i, j]);
                }
                Console.WriteLine();
            }
            return;

        lose:
            Console.WriteLine("Lose");
            Console.WriteLine($"Total Jumps: {numberOnJump}");
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    Console.Write(pole[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
