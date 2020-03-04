namespace Dream_Car
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
           decimal N = decimal.Parse(Console.ReadLine());
           decimal M = decimal.Parse(Console.ReadLine());
           decimal X = decimal.Parse(Console.ReadLine());
           decimal Y = decimal.Parse(Console.ReadLine());
           var T = int.Parse(Console.ReadLine());

            decimal savedMoney = 0;
            decimal monthlyExpenses = M*T ;

            for (int i = 0; i < T; i++)
            {
                savedMoney += N;
                N += X;
            }

            decimal result = savedMoney - monthlyExpenses;

            if (result < Y)
            {
                Console.WriteLine("Work harder!");
            }
            else
            {
                Console.WriteLine("Have a nice ride!");
            }
        }
    }
}
