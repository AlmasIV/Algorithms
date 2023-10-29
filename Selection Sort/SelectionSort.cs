using SortingAlgorithm;
namespace Selection_Sort;

public class SelectionSort : ISort{
    public void Sort<T>(T[] unorderedArray) where T : IComparable<T>{
        int smallest;
        int n = unorderedArray.Length;
        T temp;

        for(int i = 0; i < n; i ++){
            smallest = i;
            for(int j = i + 1; j < n; j ++){
                if(unorderedArray[smallest].CompareTo(unorderedArray[j]) > 0){
                    smallest = j;
                }
            }
            temp = unorderedArray[i];
            unorderedArray[i] = unorderedArray[smallest];
            unorderedArray[smallest] = temp;
        }
    }
}