using System.Diagnostics;
using InputData;

namespace Selection_Sort;

class Program
{
    static void Main(string[] args)
    {
        // Person[] people = new Person[]{
        //     new Person("Doe", 21),
        //     new Person("John", 21),
        //     new Person("Alex", 26),
        //     new Person("Jacob", 77),
        //     new Person("Andrew", 12),
        //     new Person("Micheal", 4),
        //     new Person("Zak", 28)
        // };

        // Console.WriteLine("The original order: ");
        // for(int i = 0; i < people.Length; i ++){
        //     Console.WriteLine(i + ". " + people[i] + ". ");
        // }
        // Console.WriteLine("*** Sorting using selection sort. ***");
        // Console.WriteLine("After the selection sort, the order became: ");
        // SelectionSort.Sort(people);
        // for(int i = 0; i < people.Length; i ++){
        //     Console.WriteLine(i + ". " + people[i]);
        // }
        int[] data = RandomData.GetInts_100000();

        Console.WriteLine("Here's the unsorted array: ");
        int indexer = 0;
        foreach(var num in data){
            Console.WriteLine(indexer + ". " + num);
            indexer ++;
        }
        Console.WriteLine("Press enter to start the ordering process.");
        Console.ReadLine();
        Console.WriteLine("Here's the ordered data: ");
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        SelectionSort.Sort<int>(data);
        stopwatch.Stop();
        Console.WriteLine("Here's the sorted array: ");
        indexer = 0;
        foreach(var num in data){
            Console.WriteLine(indexer + ". " + num);
            indexer ++;
        }
        Console.WriteLine("Selection Sort took: " + stopwatch.ElapsedMilliseconds + "ms, or " + (stopwatch.ElapsedMilliseconds / 1000) + "s.");
    }
}
