namespace Bubble_Sort;

public static class Bubble {
    public static void Sort<T>(T[] array) where T : IComparable<T> {
        bool isSorted = false;
        int i;
        T? temp = default(T);
        while(!isSorted){
            // Assume that the array is sorted.
            isSorted = true;

            for(i = 1; i < array.Length; i ++){
                if(array[i].CompareTo(array[i - 1]) == -1){
                    temp = array[i];
                    array[i] = array[i - 1];
                    array[i - 1] = temp;

                    // We found a pair that is not sorted, we might find others, so assume that the array is not sorted.
                    isSorted = false;
                }
            }
        }
    }
}