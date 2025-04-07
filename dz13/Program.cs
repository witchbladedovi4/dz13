namespace dz13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            foreach (int prime in PrimeNumbers.GetPrimes(50))
            {
                Console.Write(prime + " ");
            }
            Console.WriteLine();
            int count = 0;
            foreach (int prime in PrimeNumbers.GetAllPrimes())
            {
                Console.Write(prime + " ");
                count++;
                if (count >= 10) break;
            }
            Console.WriteLine();
            foreach (int prime in PrimeNumbers.SkipPrimes(10))
            {
                Console.Write(prime + " ");
                if (prime > 30) break; 
            }
            Console.WriteLine();
        }
    }
}
