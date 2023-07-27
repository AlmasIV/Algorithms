namespace BinarySearch;

public class BinarySearch
{
    public static int BinarySearch(List<int> numbers, int key){
        if(numbers.Count() > 0){
            int low = 0, high = numbers.Count() - 1, middle;
            while(low <= high){
                middle = (high + low) / 2;
                if(numbers[middle] == key){
                    return middle;
                }
                else if(key > numbers[middle]){
                    low = middle + 1;
                }
                else{
                    high = middle - 1;
                }
            }
        }
        return -1;
    }
}