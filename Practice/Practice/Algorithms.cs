using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Practice
{
    class Algorithms
    {
        List<int> QuickSort(List<int> nums)
        {
            if (nums.Count < 2)
            {
                return nums;
            }
            int pivot = nums[0];
            List<int> lower = QuickSort(nums.Where(x => x < pivot).ToList());
            List<int> higher = QuickSort(nums.Where(x => x > pivot).ToList());
            lower.Add(pivot);
            return lower.Concat(higher).ToList();
        }

}
}
