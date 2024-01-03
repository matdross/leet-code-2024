public class Solution {
    public int[] ClosestDivisors(int num) {
        
        // Loop checks for potential divisors starting from the largest possible and going downwards.
         for (var i = (int)Math.Sqrt(num + 2); i > 0; --i) {
             
            // Checks if i is a divisor of num + 1
            if ((num + 1) % i == 0) {
                return new int[] {i, (num + 1) / i};
            }
            
            // Checks if i is a divisor of num + 2
            if ((num + 2) % i == 0) {
                return new int[] {i, (num + 2) / i};
            }
        }
        
        // No divisors found
        return new int[]{};
    }
}