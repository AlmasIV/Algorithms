namespace Quicksort;

public class Quick<T> where T : IComparable<T>{
    public static void Sort(T[] inputs){
        // Randomly shuffle the array before passing.
        // Need to implement the shuffling method.

        s_Sort(inputs, 0, inputs.Length - 1);
    }
    private static void s_Sort(T[] inputs, int low, int high){
        if(high <= low){
            return;
        }
        int j = s_Partition(inputs, low, high);
        s_Sort(inputs, low, j - 1);
        s_Sort(inputs, j + 1, high);
    }
    private static int s_Partition(T[] inputs, int low, int high){
        int i = low, j = high + 1;
        T pivot = inputs[low];
        T temp;
        while(true){
            while(inputs[++i].CompareTo(pivot) == -1){
                if(i == high){
                    break;
                }
            }
            while(pivot.CompareTo(inputs[--j]) == -1){
                if(j == low){
                    break;
                }
            }
            if(i >= j){
                break;
            }
            temp = inputs[i];
            inputs[i] = inputs[j];
            inputs[j] = temp;
        }
        temp = inputs[low];
        inputs[low] = inputs[j];
        inputs[j] = temp;
        return j;
    }
}