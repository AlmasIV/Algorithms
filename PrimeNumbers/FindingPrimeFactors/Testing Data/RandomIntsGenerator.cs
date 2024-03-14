
namespace FindingPrimeFactors;

/// <summary>
///     The class that is used to manage random sample data.
/// </summary>
public static class RandomIntsGenerator {
    private static readonly string _path = Directory.GetCurrentDirectory() + "/Testing Data/RandomIntFiles";
    private static int[] _sizes = {
        1000, 5000, 10_000, 25_000, 50_000, 100_000, 250_000, 500_000, 1_000_000
    };

    /// <summary>
    ///     Generates different files, if they don't exist. Otherwise, does nothing.
    /// </summary>
    /// <remarks>
    ///     To regenerate samples call the <c>Regenerate</c> method.
    /// </remarks>
    public static void Generate(){
        if(!Directory.Exists(_path) || Directory.GetFiles(_path).Length == 0){
            Directory.CreateDirectory(_path);
            _GenerateRandomIntFiles();
        }
    }

    private static void _GenerateRandomIntFiles(){
        Random random = new Random();
        int i;
        foreach(int size in _sizes){
            using(StreamWriter sw = File.CreateText(_path + "/RandomInts_" + size + ".txt")){
                for(i = 0; i < size; i ++){
                    sw.WriteLine(random.Next());
                }
            }
        }
    }

    /// <summary>
    ///     Reads numbers from files, and returns them.
    /// </summary>
    /// <remarks>
    ///     For eachs file returns a <c>List<int></c> filled with numbers from that file.
    /// </remarks>
    /// <returns>
    ///     Iterator of <c>List<int></c>.
    /// </returns>
    public static IEnumerable<int[]> GetNumbers(){
        string[] files = Directory.GetFiles(_path);
        int[] output;
        string? line;
        int indexer;
        foreach(int i in _sizes){
            output = new int[i];
            indexer = 0;
            using(StreamReader sr = File.OpenText(files.First(f => f.Contains("_" + i.ToString() + ".txt")))){
                while((line = sr.ReadLine()) is not null && int.TryParse(line, out int num)){
                    output[indexer] = num;
                    indexer ++;
                }
            }
            yield return output;
        }
    }
}