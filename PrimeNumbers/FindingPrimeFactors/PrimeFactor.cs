namespace FindingPrimeFactors;

///<summary>
///     Contains different algorithms that find prime factor(s) of a number.
///</summary>
class PrimeFactor {

    ///<summary>
    ///     The first implementation, straightforward and simple.
    ///</summary>
    ///<param name="number">
    ///     A number to factor.
    ///</param>
    ///<returns>
    ///     Returns a list of prime factors. Or empty list.
    ///</returns>
    public static List<int> FindFactors(int number){
        List<int> factors = new List<int>();
        int possibleFactor = 2;
        
        while(possibleFactor < number){

            while(number % possibleFactor == 0){
                factors.Add(possibleFactor);
                number /= possibleFactor;
            }

            possibleFactor ++;
        }

        if(number > 1){
            factors.Add(number);
        }
        
        return factors;
    }
}