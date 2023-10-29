using System.Diagnostics;
using SortingAlgorithAnalyzer.InputData;
using SortingAlgorithAnalyzer;

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
        SortingAnalyzer.Analyze<int>(data, new SelectionSort());
    }  
}
