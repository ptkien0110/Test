using System;

class Solution
{
    static void miniMaxSum(int[] arr)
    {
        long minSum = long.MaxValue;
        long maxSum = long.MinValue;
        long totalSum = 0;

        foreach (int num in arr)
        {
            totalSum += num;
            minSum = Math.Min(minSum, num);
            maxSum = Math.Max(maxSum, num);
        }

        long minSumResult = totalSum - maxSum;
        long maxSumResult = totalSum - minSum;

        Console.WriteLine($"{minSumResult} {maxSumResult}");
    }

    static void Main(string[] args)
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        miniMaxSum(arr);
    }
}
