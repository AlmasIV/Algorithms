namespace GreatestCommonDivisor;

class Program
{
    static void Main(string[] args)
    {
        int a, b;
        mainLoop:
        Console.WriteLine("Enter two numbers: ");
        if(int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out b)){
            Console.WriteLine("The greatest common divisor of " + a + " and " + b + " is " + GCD.FindGCDOfTwoNumbers(a, b));
        }
        goto mainLoop;
    }
}
