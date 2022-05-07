using System;
using Generic;

class Program
{
    public static void Main(string[] args)
    {
        GeneicProblem problem = new GeneicProblem();
        int[] arr1 = { 15, 20, 18, 47, 68, 61, 5 };
        float[] arr2 = { 10.5f, 14.4f, 19.5f };
        string[] arr3 = { "abc", "ads", "ffgg", "ewd" };
        problem.MaxInt<int>(arr1);
        problem.MaxInt<float>(arr2);
        problem.MaxInt<string>(arr3);
    }
}
