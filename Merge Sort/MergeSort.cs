namespace Merge_Sort;

public class MergeSort<T> where T : IComparable<T?>{
    public static T?[] temp;
    public static void Sort(T?[] unsortedArray){
        temp = new T?[unsortedArray.Length];
        s_Sort(unsortedArray, 0, unsortedArray.Length - 1);
    }
    private static void s_Sort(T?[] array, int low, int high){
        if(high <= low){
            return;
        }
        int middle = (high + low) / 2;
        s_Sort(array, low, middle);
        s_Sort(array, middle + 1, high);
        s_Merge(array, low, middle, high);
    }
    private static void s_Merge(T?[] array, int low, int middle, int high){
        int i = low, j = middle + 1;
        for(int k = low; k <= high; k ++){
            temp[k] = array[k];
        }

        for(int k = low; k <= high; k ++){
            if(i > middle){
                array[k] = temp[j ++];
            }
            else if(j > high){
                array[k] = temp[i ++];
            }
            else if(temp[i]!.CompareTo(temp[j]) == -1){
                array[k] = temp[i ++];
            }
            else{
                array[k] = temp[j ++];
            }
        }
    }
} 