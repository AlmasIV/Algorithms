namespace SieveOfEratosthenes;

class Program
{
    static void Main(string[] args)
    {
        List<int> result = SieveOfEratosthenes.Primes.FindPrimes(100);
        foreach(int i in result){
            Console.WriteLine(i);
        }
    }
}
