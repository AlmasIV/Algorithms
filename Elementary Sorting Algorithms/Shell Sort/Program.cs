using SortingAlgorithAnalyzer.InputData;
using SortingAlgorithAnalyzer;

namespace Shell_Sort;

class Program
{
    static void Main(string[] args)
    {
        int[] data = RandomData.GetInts_100000();
        SortingAnalyzer.Analyze<int>(data, new ShellSort());
        SortingAnalyzer.SaveDataToFile<int>(data);
    }
}
