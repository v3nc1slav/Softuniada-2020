namespace SoftUni_Usernames
{
    using System;
    
    class StartUp
    {
        private const int Mod = 1000000007; // prime number

        static void Main(string[] args)
        {

            int N = int.Parse( Console.ReadLine());
            int D = int.Parse( Console.ReadLine());
            int L = int.Parse( Console.ReadLine());
            int U = int.Parse( Console.ReadLine());
            int factN = Factorial(N);
            int factD = Factorial(D);
            int factL = Factorial(L);
            int factU = Factorial(U);

            if (D<0 || L<0 || U<0)
            {
                Console.WriteLine(0);
                return;
            }
            else if(D+L+U>N)
            {
                Console.WriteLine(0);
            }
            else
            {
                var result = (factN / (factD * factL * factU))
                    * Math.Pow(10, D) % Mod
                    * Math.Pow(30, L) % Mod
                    * Math.Pow(30, U) % Mod;

                Console.WriteLine(result);
            }

        }

        private static int Factorial(int f)
        {
            if (f == 0)
                return 1;
            else
                return (f * Factorial(f - 1)) % Mod;
        }
    }
}
