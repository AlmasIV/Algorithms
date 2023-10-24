namespace Insertion_Sort;

public static class InsertionSort{
    public static void Sort<T>(T[] unsortedArray) where T : IComparable<T>{
        int n = unsortedArray.Length;
        T temp;
        for(int i = 1; i < n; i ++){
            for(int j = i; j > 0 && unsortedArray[j].CompareTo(unsortedArray[j - 1]) < 0; j --){
                temp = unsortedArray[j - 1];
                unsortedArray[j - 1] = unsortedArray[j];
                unsortedArray[j] = temp;
            }
        }
    }
}