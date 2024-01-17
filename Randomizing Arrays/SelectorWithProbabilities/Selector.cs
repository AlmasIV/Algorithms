namespace SelectorWithProbabilities;

public static class Selector{
    private static Random s_random = new Random(Guid.NewGuid().GetHashCode());
    private static int s_randomValue = 0;
    public static T? PickWithProbabilities<T>(T?[] items, int[] probabilities){
        if(items.Length < 2){
            throw new ArgumentException(
                message: "Items must have more than 1 element",
                paramName: nameof(items)
            );
        }

        if(items.Length != probabilities.Length){
            throw new ArgumentException(
                message: "Items and probabilities must be pairs to each other. Not enough corresponding pairs."
            );
        }

        if(probabilities.Sum() != 100){
            throw new ArgumentException(
                message: "Probabilities must sum up to 100.",
                paramName: nameof(probabilities)
            );
        }

        T? selectedItem = default(T);
        s_randomValue = s_random.Next(1, 101);

        for(int i = 0, n = items.Length; i < n; i ++){
            s_randomValue -= probabilities[i];
            if(s_randomValue <= 0){
                selectedItem = items[i];
                break;
            }
        }

        return selectedItem;
    }
}