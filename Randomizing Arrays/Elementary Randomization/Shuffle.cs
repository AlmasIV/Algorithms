namespace Elementary_Randomization;

// Don't call the method multiple times for the same array, it's unnecessary (it completely randomizes an array in a single run).
public static class Shuffler{
    private static Random s_random = new Random(Guid.NewGuid().GetHashCode());
    private static int s_pos = 0;
    // O(N) - each index in the array is visited only once.
    public static void Shuffle<T>(T?[] array) where T : IComparable<T> {
        if(array is null || array.Length < 2){
            return;
        }
        T? temp = default(T);
        for(int i = 0, n = array.Length; i < n; i ++){
            s_pos = s_random.Next(i, n);
            temp = array[i];
            array[i] = array[s_pos];
            array[s_pos] = temp;
        }
    }
}