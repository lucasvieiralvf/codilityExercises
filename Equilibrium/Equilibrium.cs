using System;

namespace Equilibrium
{
    public class Equilibrium
    {
        public int solution(int[] A)
        {
            var b = new int[A.Length + 1];
            var result = Int32.MaxValue;

            for (int i = 0; i < A.Length; i++)
            {
                b[i + 1] = A[i] + b[i];
                Console.WriteLine(b[i + 1]);
            }

            for (int p = 1; p < A.Length; p++)
            {
                var diff = b[p] - (b[b.Length - 1] - b[p]);
                Console.WriteLine(diff);

                if (diff < 0)
                {
                    diff = diff * -1;
                }
                if (diff < result)
                {
                    result = diff;
                }
            }

            return result;
        }
    }
}