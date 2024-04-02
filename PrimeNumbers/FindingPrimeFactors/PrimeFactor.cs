namespace FindingPrimeFactors;

/// <summary>
///     Contains different algorithms that find prime factor(s) of a number.
/// </summary>
class PrimeFactor {

    /// <summary>
    ///     The first implementation, straightforward and simple. Runtime: O(N^2).
    /// </summary>
    /// <remarks>
    /// <param name="number">
    ///     A number to factor.
    /// </param>
    /// <returns>
    ///     Returns a list of prime factors. Or empty list.
    /// </returns>
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

    /// <summary>
    ///     The second implementation, includes improved algorithm. Run time: O(sqrt(N)).
    /// </summary>
    ///     <remarks>
    ///         The list of improvements:
    ///     <list type="bullet">
    ///         <item>
    ///             <term>Removed unnecessary checking of even numbers</term>
    ///             <description>
    ///                 Don't test if the <c>number</c> is divisible by any other even number, other than two. If the <c>number</c> is divisible by any even number, then it is also divisible by two.
    ///             </description>
    ///         </item>
    ///         <item>
    ///             <term>Check factors up to the square root of the number</term>
    ///             <description>
    ///                 If 'n = p * q', then either 'p' or 'q' must be less than or equal to 'sqrt(n)'. If both are greater than 'sqrt(n)', then their product is greater than 'n'. If you check possible factors up to 'sqrt(n)', you will find the smaller factor, and when you divide 'n' by that factor, you will find the other one. This reduces the runtime to 'O(sqrt(n))'.
    ///             </description>
    ///         </item>
    ///         <item>
    ///             <term>Update the check</term>
    ///             <description>
    ///                 Every time you divide the number by a factor, you can update the upper bound on the possible factors that you need to check.
    ///             </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    /// <param name="number">
    ///     A number to factor.
    /// </param>
    /// <returns>
    ///     Returns a list of prime factors. Or empty list.
    /// </returns>
    public static List<int> FindFactorsImproved(int number){
        List<int> factors = new List<int>();

        // Pull out factors of 2.
        while(number % 2 == 0){
            factors.Add(2);
            number /= 2;
        }

        int possibleFactor = 3;
        int maxFactor = (int)Math.Sqrt(number);
        while(possibleFactor < maxFactor){
            // Pull out factors of 'possibleFactor'.
            while(number % possibleFactor == 0){
                factors.Add(possibleFactor);
                number /= possibleFactor;
                maxFactor = (int)Math.Sqrt(number);
            }
            possibleFactor += 2;
        }

        if(number > 1){
            factors.Add(number);
        }

        return factors;
    }
}