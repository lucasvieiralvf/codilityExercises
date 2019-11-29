using System;

namespace permCheck
{
    class PermCheck
    {
        public int solution(int[] A)
        {
            int[] copy = new int[A.Length + 1];

            try
            {
                for (int i = 0; i < A.Length; i++)
                {
                    var copyIndex = A[i];
                    copy[copyIndex]++;

                    if (copy[copyIndex] > 1)
                    {
                        return 0;
                    }
                }

                for (int i = 1; i < copy.Length; i++)
                {
                    if (copy[i] == 0)
                    {
                        return 0;
                    }
                }
            }
            catch (IndexOutOfRangeException e)
            {
                return 0;
            }
            return 1;
        }
    }
}