namespace Merge_Sort;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = new int[]{
            1, -2, 22, 1, 23, 999, 0, -456, 23
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
