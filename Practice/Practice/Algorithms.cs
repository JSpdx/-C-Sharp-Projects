using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Practice
{
    public static class Algorithms
    {
        public static List<int> QuickSort(List<int> nums)
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

       

        static List<int> getPrimesInRange(int min, int max)
        {
            List<int> primes = new List<int>();
            for(int i = min; i < max; i++)
            {
                if (isPrime(i, min))
                {
                    primes.Add(i);
                }
            }
            return primes;
        }

         private static bool isPrime (int num, int min)
        {
            for (int i = min; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        public static int[] QuickSortArray(int[] nums)
        {
            // 2,5,2,5,2,1,643,2
            if (nums.Length < 2)
            {
                return nums;
            }
            
            int pivot = nums[0];
            int[] result = new int[nums.Length];
            int[] lower = QuickSortArray(nums.Where(x => x < pivot).ToArray());
            int[] higher = QuickSortArray(nums.Where(x => x > pivot).ToArray());
            if(lower.Length > 0)
            {
                Array.Copy(lower, result, lower.Length);
            }
            result.Append(pivot);
            if(higher.Length > 0)
            {
                Array.Copy(higher, 0, result, higher.Length, lower.Length);
            }
            return result;
        }



}
}
