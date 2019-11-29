using System;
using System.Collections.Generic;

namespace frog
{
    public class Frog
    {
        public int solution(int X, int[] A)
        {
            var dic = new Dictionary<int, bool>();

            for (int time = 0; time < A.Length; time++)
            {
                int position = A[time];

                if (!dic.ContainsKey(position))
                {
                    dic.Add(position, true);
                    if (dic.Count == X)
                    {
                        return time;
                    }
                }
            }
            return -1;
        }
    }
}