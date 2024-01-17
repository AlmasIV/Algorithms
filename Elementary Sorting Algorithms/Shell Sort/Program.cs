using SortingAlgorithAnalyzer.InputData;
using SortingAlgorithAnalyzer;

namespace Shell_Sort;

class Program
{
    static void Main(string[] args)
    {
        // int[] data = RandomData.GetInts_100000();
        // SortingAnalyzer.Analyze<int>(data, new ShellSort());
        // SortingAnalyzer.SaveDataToFile<int>(data);
        int[] data = {
            1, 3, 2, 6, 4, 5, 9, 8, 7, 10
        };
        var sorter = new ShellSort();
        Console.WriteLine("Unsorted array: ");
        foreach(var num in data){
            Console.Write(num + "; ");
        }
        sorter.Sort<int>(data);
        Console.WriteLine("\nAfter sorting: ");
        foreach(var num in data){
            Console.Write(num + "; ");
        }
        Console.Write("\n");
    }
}
