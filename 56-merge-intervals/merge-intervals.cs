public class Solution {
    public int[][] Merge(int[][] intervals) {
        if (intervals.Length == 0) return intervals;

        Array.Sort(intervals, (x, y) => x[0] - y[0]);

        List<int[]> mergedIntervals = new List<int[]>();

        int[] currentInterval = intervals[0];
        mergedIntervals.Add(currentInterval);

        for (int i = 1; i < intervals.Length; i++) {
            int[] nextInterval = intervals[i];

            if (currentInterval[1] >= nextInterval[0]) {
                currentInterval[1] = Math.Max(currentInterval[1], nextInterval[1]);
            } else {
                currentInterval = nextInterval;
                mergedIntervals.Add(currentInterval);
            }
        }
        return mergedIntervals.ToArray();
    }
}