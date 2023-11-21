namespace Bottom_Up_Merge_Sort;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = {
            4, 3, 2, 1
        };

        Console.WriteLine("Before merge sort: ");
        foreach(var num in nums){
            Console.WriteLine(num);
        }
        BottomUpMergeSort<int>.Sort(nums);
        Console.WriteLine();
        Console.WriteLine("After merge sort: ");
        foreach(var num in nums){
            Console.WriteLine(num);
        }
    }
}
