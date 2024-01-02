public class Solution {
    public bool IsAlienSorted(string[] words, string order) {
        if (words.Length < 2) return true;
        
        int[] numArray = new int[26];
        
        // Create new array of ints to display the value of the letter in the word 
        // char -a gets the elements 'position' in the alphabet. 
        for (int i = 0; i < order.Length; i++) {
            numArray[order.ElementAt(i) - 'a'] = i;
        }
        
        //
        for (int i = 0; i < words.Length -1; i++)
        {
            var cur = words[i];
            var next = words[i+1];
            
            if (!IsSorted(cur, next, numArray)) {
                return false;
            }
        }

        return true;

    }   
    
    // Check cur and next word are in order
    public bool IsSorted(string cur, string next, int[] numArray)
    {
        int len = Math.Min(cur.Length, next.Length);

        for (var i = 0; i < len; i++)
        {
            int l1 = numArray[ cur.ElementAt(i)-'a' ];
            int l2 = numArray[ next.ElementAt(i)-'a' ];
            if (l1 > l2) return false;
            if (l1 < l2) return true;
        }
        return cur.Length <= next.Length;
    }
}