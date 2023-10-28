using System.Diagnostics;
namespace Insertion_Sort;

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
        // InsertionSort.Sort(people);
        // for(int i = 0; i < people.Length; i ++){
        //     Console.WriteLine(i + ". " + people[i]);
        // }
        Random random = new Random();
        if(!File.Exists("../NumbersToSort.txt")){
            using(var file = File.OpenWrite("../NumbersToSort.txt")){
                using(StreamWriter write = new StreamWriter(file)){
                    for(int i = 0; i < 100000; i ++){
                        write.WriteLine(random.Next(int.MinValue, int.MaxValue));
                    }
                }
            }
        }
        List<int> data = new List<int>();
        string[] rawData;
        using(var file = File.OpenRead("../NumbersToSort.txt")){
            using(StreamReader reader = new StreamReader(file)){
                rawData = reader.ReadToEnd().Split('\n');
                foreach(string str in rawData){
                    if(int.TryParse(str, out int val)){
                        data.Add(val);
                    }
                }
            }
        }
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
        int[] result = data.ToArray();
        stopwatch.Start();
        InsertionSort.Sort<int>(result);
        stopwatch.Stop();
        Console.WriteLine("Here's the sorted array: ");
        indexer = 0;
        foreach(var num in result){
            Console.WriteLine(indexer + ". " + num);
            indexer ++;
        }
        Console.WriteLine("Insertion Sort took: " + stopwatch.ElapsedMilliseconds + "ms, or " + (stopwatch.ElapsedMilliseconds / 1000) + "s.");
    }
}
