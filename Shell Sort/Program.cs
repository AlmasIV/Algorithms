namespace Shell_Sort;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 0, 22, 1, 3, 44, 7 };
        Console.WriteLine("Before sorting: ");
        foreach(var v in nums){
            Console.WriteLine(v);
        }
        Console.WriteLine("After sorting: ");
        ShellSort2.Sort<int>(nums);
        foreach(var v in nums){
            Console.WriteLine(v);
        }
    }
}
