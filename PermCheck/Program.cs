using System;

namespace permCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 4, 1, 3, 2 };
            int[] a2 = new int[] { 4, 1, 3 };
            var permutation = new PermCheck();
            var result = permutation.solution(a);
            var result2 = permutation.solution(a2);
            Console.WriteLine(result);
            Console.WriteLine(result2);
        }
    }
}
