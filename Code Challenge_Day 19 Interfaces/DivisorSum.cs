using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Challenge_Day_19_Interfaces
{
    class DivisorSum : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            int maxSum = 0;
            for (int index = 1; index <= n; index++)
            {
                maxSum = (n % index == 0) ? maxSum + index : maxSum;
            }

            return maxSum;
        }
    }
}
