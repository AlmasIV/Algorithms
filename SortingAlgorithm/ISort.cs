namespace SortingAlgorithm;

public interface ISort{
    void Sort<T>(T[] unsortedArray) where T : IComparable<T>;
}