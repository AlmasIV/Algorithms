namespace GreatestCommonDivisor;

public static class GCD{
    private static int s_remainder = 0;
    public static int FindGCDOfTwoNumbers(int a, int b){
        while(b != 0){
            s_remainder = a % b;
            a = b;
            b = s_remainder;
        }
        return a;
    }
}