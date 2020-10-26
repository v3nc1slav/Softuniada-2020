using System;

namespace SoftUni_Usernames
{
    class StartUp
    {
        static void Main(string[] args)
        {

            int N = int.Parse( Console.ReadLine());
            int D = int.Parse( Console.ReadLine());
            int L = int.Parse( Console.ReadLine());
            int U = int.Parse( Console.ReadLine());
            double result = 0;

            if (D+L+U>N)
            {
                Console.WriteLine(result);
                return;
            }

            if (D>0)
            {
                result = result + Math.Pow(10, D);
            }

            if (L>0)
            {
                result = result * Math.Pow(30, L);
            }

            if (U>0)
            {
                result = result * Math.Pow(30, U);
            }

            Console.WriteLine(result);
        }
    }
}
