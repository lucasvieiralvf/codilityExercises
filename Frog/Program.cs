using System;

namespace frog
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int[] a = new int[] { 1, 3, 1, 4, 2, 3, 5, 4 };

            var frog = new Frog();
            var result = frog.solution(x, a);
            Console.WriteLine(result);
        }
    }
}
