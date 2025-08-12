using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp.TwoSumSolution
{
    internal class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {

            int[] result = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {

                for (int j = 0; j < nums.Length; j++)
                {

                    if (i != j)
                    {
                        int n1 = nums[i];
                        int n2 = nums[j];

                        if (n1 + n2 == target)
                        {
                            result[0] = i;
                            result[1] = j;
                        }
                    }
                }
            }

            return result;
        }
    }
}
