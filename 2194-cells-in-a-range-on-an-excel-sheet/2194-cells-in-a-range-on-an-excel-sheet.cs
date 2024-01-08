public class Solution {
    public IList<string> CellsInRange(string s) {
        var alphabet = new string[] {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};

        // Split, get alphabet position - 'A' then count rows
        var gridArray = s.Split(":");

        var firstCol = gridArray[0].ToCharArray();        
        var secondCol = gridArray[1].ToCharArray();

        // Convert uppercase letters to index
        int firstColIndex = firstCol[0] - 'A';
        int secondColIndex = secondCol[0] - 'A';

        var res = new List<string>();
        for (int i = firstColIndex; i <= secondColIndex; i++) {
            for (int j = int.Parse(firstCol[1].ToString()); j <= int.Parse(secondCol[1].ToString()); j++) {
                res.Add(alphabet[i].ToUpper() + j.ToString());
            }
        }

        return res;
    }
}
