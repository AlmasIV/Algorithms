namespace FindingPrimeFactors;

class Program
{
    static void Main(string[] args)
    {
        string? possibleNumber;
        bool isContinue = true;
        while(isContinue){
            Console.WriteLine("Enter a positive number: ");
            possibleNumber = Console.ReadLine();
            if(possibleNumber is not null && int.TryParse(possibleNumber, out int number)){

                Console.WriteLine(
                    PrimeFactor.FindFactors(number)
                        .Select(prime => prime.ToString())
                        .Aggregate((str1, str2) => str1 + " * " + str2)
                );
                
            }
        }
    }
}
