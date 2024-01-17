namespace Elementary_Randomization;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Shuffler.Shuffle<int>(array);
        foreach(int i in array){
            Console.Write(i + " ");
        }
        Console.Write("\n");
    }
}
