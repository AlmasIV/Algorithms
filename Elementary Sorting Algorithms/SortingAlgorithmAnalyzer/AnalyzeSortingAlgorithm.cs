using System.Diagnostics;
using SortingAlgorithm;

namespace SortingAlgorithAnalyzer;

public class SortingAnalyzer{
    public static void Analyze<T>(T[] unsortedArray, ISort algorithm) where T : IComparable<T>{
        Console.WriteLine($"Analyzing {algorithm.GetType().FullName}.");
        Console.WriteLine($"The data length is {unsortedArray.Length}.");
        Console.WriteLine("Starting to sort...");
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        algorithm.Sort<T>(unsortedArray);
        stopwatch.Stop();
        Console.WriteLine($"Sorting process completed. Sorting took: {stopwatch.ElapsedMilliseconds} ms, or {stopwatch.ElapsedMilliseconds / 1000} s.");
    }
    public static void SaveDataToFile<T>(T[] dataArray) where T : IComparable<T> {
        bool isFileCreated = false;
        while(true){
            Console.WriteLine("Where do you want to save the results?\nPath to the existing directory: ");
            string? path = Console.ReadLine();
            if(Directory.Exists(path)){
                while(true){
                    Console.WriteLine("File name: ");
                    string? name = Console.ReadLine();
                    if(name is not null){
                        try{
                            using(FileStream fileStream = File.Create(path + "/" + name)){
                                using(StreamWriter writer = new StreamWriter(fileStream)){
                                    foreach(T temp in dataArray){
                                        writer.WriteLine(temp);
                                    }
                                }
                            }
                            Console.WriteLine("File was successfully saved.");
                            isFileCreated = true;
                            break;
                        }
                        catch(Exception exception){
                            Console.WriteLine("Something went wrong!");
                            Console.WriteLine(exception.Message);
                        }
                    }
                }
                if(isFileCreated){
                    break;
                }
            }
        }
    }
}