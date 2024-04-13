namespace Bubble_Sort;

class Program
{
    static void Main(string[] args)
    {
        int[] myArray = {
            0, -2, 1, 22, 3, 555, 9, -99, 2
        };
        Console.WriteLine("The array before sorting: ");
        foreach(int num in myArray){
            Console.WriteLine(num);
        }
        Bubble.Sort<int>(myArray);
        Console.WriteLine("The array after sorting: ");
        foreach(int num in myArray){
            Console.WriteLine(num);
        }
    }
}
