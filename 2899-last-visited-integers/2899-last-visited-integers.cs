public class Solution {
    public IList<int> LastVisitedIntegers(IList<string> words) {
        var wordCount = words.Count();
        if (wordCount < 1) return new List<int>();

        var nums = new List<int>();
        var outputInts = new List<int>();
        var k = 0;
        var visitedInts = 0;
        const string prev = "prev";

        for (int i = 0; i < wordCount; i ++) {
            k++;
            if (words[i] == prev) {
                if (wordCount + i + 1 <= wordCount) {
                    if (words[i + 1] == prev) {
                        k++;
                        continue;
                    }
                }
                if (k > visitedInts) {
                    outputInts.Add(-1);
                    continue;
                };
                outputInts.Add(nums[visitedInts - k]);
            }
            else {
                k = 0;
                visitedInts ++;
                nums.Add(int.Parse(words[i]));
            }
        }

        return outputInts;
    }
}