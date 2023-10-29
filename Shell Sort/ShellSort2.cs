using SortingAlgorithm;

namespace Shell_Sort;

public class ShellSort2 : ISort{
    public void Sort<T>(T[] unsortedArray) where T : IComparable<T>{
        int n = unsortedArray.Length;
        T temp;
        for(int gap = n / 2; gap > 0; gap = gap / 2){
            for(int i = gap; i < n; i ++){
                for(int j = i; j >= gap && unsortedArray[j].CompareTo(unsortedArray[j - gap]) == -1; j -= gap){
                    temp = unsortedArray[j];
                    unsortedArray[j] = unsortedArray[j - gap];
                    unsortedArray[j - gap] = temp;
                }
            }
        }
    }
}