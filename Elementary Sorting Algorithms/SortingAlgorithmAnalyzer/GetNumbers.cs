namespace SortingAlgorithAnalyzer.InputData;

public class RandomData {
    public static int[] GetInts_100000(){

        // Randomly generate numbers if the file doesn't exist.
        if(!File.Exists("../NumbersToSort.txt")){
            using(var file = File.OpenWrite("../NumbersToSort.txt")){
                using(StreamWriter write = new StreamWriter(file)){
                    Random random = new Random();
                    for(int i = 0; i < 100000; i ++){
                        write.WriteLine(random.Next(int.MinValue, int.MaxValue));
                    }
                }
            }
        }


        List<int> data = new List<int>();
        string[] rawData;

        // Try to parse strings into numbers.
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

        return data.ToArray();
    }
}