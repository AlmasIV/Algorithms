namespace BinarySearch;

public class BinarySearch
{
    /// <summary>
    ///     Performs binary search on a List of integers.
    /// </summary>
    /// <param name="numbers">
    ///     The List of intergers.
    /// </param>
    /// <param name="key">
    ///     The key to find.
    /// </param>
    /// <returns>
    ///     The index of the key, or -1.
    /// </returns>
    public static int BinarySearch(List<int> numbers, int key){
        if(numbers.Count() > 0){
            int low = 0, high = numbers.Count() - 1, middle;
            while(low <= high){
                middle = (high + low) / 2;
                if(key < numbers[middle]){
                    high = middle - 1;
                }
                else if(key > numbers[middle]){
                    low = middle + 1;
                }
                else{
                    return middle;
                }
            }
        }
        return -1;
    }
}