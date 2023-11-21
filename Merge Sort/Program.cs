namespace Merge_Sort;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = new int[]{
            1, 2, 1, 2
        };
        Console.WriteLine("Before sorting: ");
        foreach(var v in nums){
            Console.Write(v + " ");
        }
        Console.WriteLine();
        MergeSort<int>.Sort(nums);
        Console.WriteLine("After sorting: ");
        foreach(var v in nums){
            Console.Write(v + " ");
        }
        Console.WriteLine();
    }
}
