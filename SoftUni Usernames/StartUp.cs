namespace SoftUni_Usernames
{
    using System;
    using System.Numerics;

    class StartUp
    {
        private const int Mod = 1000000007; // prime number

        static void Main(string[] args)
        {

            int N = int.Parse( Console.ReadLine());
            int D = int.Parse( Console.ReadLine());
            int L = int.Parse( Console.ReadLine());
            int U = int.Parse( Console.ReadLine());
            BigInteger factN = Factorial(N);
            BigInteger factD = Factorial(D);
            BigInteger factL = Factorial(L);
            BigInteger factU = Factorial(U);
            BigInteger rowD = ModuloPower(10, D);
            BigInteger rowL = ModuloPower(30, L);
            BigInteger  rowU = ModuloPower(30, U);

            if (D<0 || L<0 || U<0)
            {
                Console.WriteLine(0);
            }
            else if(D+L+U>N || D+L+U<U)
            {
                Console.WriteLine(0);
            }
            else
            {
                var combo = rowD * rowL % Mod * rowU % Mod ;
                var facturiel = factN / (factD * factL % Mod * factU % Mod);
                var result = facturiel * combo % Mod;

                Console.WriteLine(result);
            }

        }
        private static BigInteger ModuloPower(long x, long y)
        {
            long result = 1;
            while (y > 0)
            {
                if ((y & 1) != 0)
                {
                    result = (result * x) % Mod;
                }

                x = (x * x) % Mod;
                y /= 2;
            }

            return result;
        }
        private static BigInteger Factorial(int f)
        {
            if (f == 0)
                return 1;
            else
                return ((f * Factorial(f - 1)) %Mod);
        }
    }
}
