namespace Shell_Sort;

public static class ShellSort {
    public static void Sort<T>(T[] unsortedArray) where T : IComparable<T>{
        int n = unsortedArray.Length;
        int h = 1;
        while(h < n/3){
            h = 3 * h + 1;
        }
        while(h >= 1){
            T temp;
            for(int i = h; i < n; i ++){
                for(int j = i; j >= h && unsortedArray[j].CompareTo(unsortedArray[j - h]) == -1; j -= h){
                    temp = unsortedArray[j];
                    unsortedArray[j] = unsortedArray[j - h];
                    unsortedArray[j - h] = temp;
                }
            }
            h = h / 3;
        }
    }
}