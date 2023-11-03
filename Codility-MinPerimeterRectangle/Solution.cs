using System.Runtime.CompilerServices;

namespace Codility_MinPerimeterRectangle
{
    public class Solution
    {
        public const int RANGE_LOWEST_VALUE = 1;
        public const int RANGE_HIGHEST_VALUE = 1000000000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int N)
        {
            int minimalPerimeter = int.MaxValue;
            if(N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE) 
            {
                ;
                for (int A = 1; A * A <= N; A++)
                {
                    if (N % A == 0)
                    {
                        int B = N / A;
                        int currentPerimeter = 2 * (A + B);
                        minimalPerimeter = Math.Min(minimalPerimeter, currentPerimeter);
                    }
                }
            }
            
            return minimalPerimeter;
        }
    }
}
