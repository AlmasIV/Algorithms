namespace SieveOfEratosthenes;

public static class Primes {
    public static List<int> FindPrimes(long maxNumber){
        // Allocate an array for the numbers.
        bool[] isComposite = new bool[maxNumber + 1];

        // Cross out multiples of 2.
        for(int i = 4; i <= maxNumber; i += 2){
            isComposite[i] = true;
        }

        // Cross out multiples of primes found so far.
        int nextPrime = 3;
        int stopAt = (int)Math.Sqrt(maxNumber);
        while(nextPrime <= stopAt){
            // Cross out multiples of this prime.
            for(int i = nextPrime * 2; i <= maxNumber; i += nextPrime){
                isComposite[i] = true;
            }
            
            // Move to the next prime, skipping the even numbers.
            nextPrime += 2;
            while(nextPrime <= maxNumber && isComposite[nextPrime]){
                nextPrime += 2;
            }
        }

        List<int> primes = new List<int>();
        for(int i = 2; i <= maxNumber; i ++){
            if(!isComposite[i]){
                primes.Add(i);
            }
        }

        return primes;
    }
}