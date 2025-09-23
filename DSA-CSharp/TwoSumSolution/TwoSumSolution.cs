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
            Dictionary<int, int> indexTracker = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++) {
                
                int supplement = target - nums[i];

                if (indexTracker.ContainsKey(supplement))
                {
                    return [indexTracker[supplement], i];
                }
                else
                {
                    indexTracker[nums[i]] = i;
                }
            }

            return [];
        }
    }
}


