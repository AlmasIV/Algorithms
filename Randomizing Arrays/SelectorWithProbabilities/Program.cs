namespace SelectorWithProbabilities;

class Program
{
    static void Main(string[] args)
    {
        string[] movies = { "Titanic", "Transformers", "Interstaller", "Terminator" };
        int[] probabilities = { 25, 30, 10, 35 };
        string? chosenMovie = Selector.PickWithProbabilities<string>(movies, probabilities);
        Console.WriteLine("Chosen movie: " + chosenMovie);
    }
}