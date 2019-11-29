using System;

namespace Equilibrium
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 1, 2, 4, 3 };
            var equilibrium = new Equilibrium();
            var result = equilibrium.solution(numbers);
            Console.WriteLine(result);
        }
    }
}
