using System;
using Generic;

class Program
{
    public static void Main(string[] args)
    {
        GeneicProblem problem = new GeneicProblem();
        int[] arr = { 15, 20, 18, 47, 68, 61, 5 };
        problem.MaxInt(arr);
    }
}
