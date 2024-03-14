using System.Diagnostics;

namespace FindingPrimeFactors;

class Program
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();
        TimeSpan timeSpan1, timeSpan2;
        List<int> factors;
        int tempNum;

        List<(int, TimeSpan, TimeSpan)> stats = new List<(int, TimeSpan, TimeSpan)>();

        RandomIntsGenerator.Generate();

        foreach(int[] numbers in RandomIntsGenerator.GetNumbers()){
            Console.WriteLine("Running the first implementation:");
            Console.WriteLine("Amount of numbers: " + numbers.Length);
            stopwatch.Start();
            foreach(int number in numbers){
                factors = PrimeFactor.FindFactors(number);
                tempNum = factors.Aggregate((a, b) => a * b);
                if(tempNum == number){
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Success for: " + number);
                }
                else{
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Failure for: " + number);
                }
            }
            stopwatch.Stop();
            Console.ResetColor();

            timeSpan1 = stopwatch.Elapsed;
            stopwatch.Reset();

            Console.WriteLine("Running the improved implementation:");
            Console.WriteLine("Amount of numbers: " + numbers.Length);
            stopwatch.Start();
            foreach(int number in numbers){
                factors = PrimeFactor.FindFactorsImproved(number);
                tempNum = factors.Aggregate((a, b) => a * b);
                if(tempNum == number){
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Success for: " + number);
                }
                else{
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Failure for: " + number);
                }
            }
            stopwatch.Stop();
            Console.ResetColor();

            timeSpan2 = stopwatch.Elapsed;

            Console.WriteLine("Amount: " + numbers.Length);

            Console.WriteLine("Run time of the first implementation: {0:00}:{1:00}:{2:00}:{3:000}\n", timeSpan1.Hours, timeSpan1.Minutes, timeSpan1.Seconds, timeSpan1.Milliseconds);

            Console.WriteLine("Run time of the improved implementation: {0:00}:{1:00}:{2:00}:{3:000}\n", timeSpan2.Hours, timeSpan2.Minutes, timeSpan2.Seconds, timeSpan2.Milliseconds);

            stopwatch.Reset();

            stats.Add((numbers.Length, timeSpan1, timeSpan2));

            Console.WriteLine("Run the next?");
            Console.ReadLine();
        }

        // Stopwatch stopwatch = new Stopwatch();
        // List<int> result;
        // TimeSpan ts;

        // int temp;
        // Console.WriteLine("Running the first version: ");
        // stopwatch.Start();
        // result = PrimeFactor.FindFactors(number);
        // stopwatch.Stop();

        // ts = stopwatch.Elapsed;

        // temp = result.Aggregate((a, b) => a * b);

        // Console.WriteLine("Result: ");
        // Console.WriteLine(
        //     result.Select(prime => prime.ToString())
        //         .Aggregate((str1, str2) => str1 + " * " + str2)
        // );
        // Console.WriteLine("Correct: " + (temp == number));
        // Console.WriteLine("Run time: {0:00}:{1:00}:{2:00}:{3:000}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);

        //         //PrimeFactor.FindFactorsImproved(number);
                
    }
}
