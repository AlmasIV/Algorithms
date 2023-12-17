namespace Quicksort;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = {
            1, -1, 2, 3, 44, 7
        };

        Quick<int>.Sort(nums);

        foreach(var v in nums){
            System.Console.WriteLine(v);
        }
    }
}
