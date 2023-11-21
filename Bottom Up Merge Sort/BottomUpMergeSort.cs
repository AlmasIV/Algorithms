namespace Bottom_Up_Merge_Sort;

public static class BottomUpMergeSort<T> where T : IComparable<T>{
    private static T[] tempArray;
    public static void Sort(T[] unsortedArray){
        tempArray = new T[unsortedArray.Length];
        int N = unsortedArray.Length;
        for(int sz = 1; sz < N; sz = sz + sz){
            for(int lo = 0; lo < N -sz; lo += sz + sz){
                s_Merge(unsortedArray, lo, lo + sz - 1, Math.Min(lo + sz + sz - 1, N - 1));
            }
        }
    }
    private static void s_Merge(T[] unsortedArray, int low, int middle, int high){
        int i = low, j = middle + 1;
        for(int k = low; k <= high; k ++){
            tempArray[k] = unsortedArray[k];
        }
        for(int k = low; k <= high; k ++){
            if(i > middle){
                unsortedArray[k] = tempArray[j ++];
            }
            else if(j > high){
                unsortedArray[k] = tempArray[i ++];
            }
            else if(tempArray[i].CompareTo(tempArray[j]) != -1){
                unsortedArray[k] = tempArray[j ++];
            }
            else{
                unsortedArray[k] = tempArray[i ++];
            }
        }
    }
}