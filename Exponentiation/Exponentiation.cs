namespace Exponentiation;

public static class Exponentiation {
    public static int Exponentiate(int value, int exponent){
        int result = 1;
        int factor = value;
        while(exponent != 0){
            if(exponent % 2 == 1){
                result *= factor;
            }
            factor *= factor;
            exponent /= 2;
        }
        return result;
    }
}