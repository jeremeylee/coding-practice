using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.Array
{
    class FindMinRotated
    {
        public int FindMin(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }

            int end = nums.Length - 1;
            int start = 0;

            if (nums[end] > nums[0])
            {
                return nums[0];
            }

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (nums[mid] > nums[mid + 1])
                {
                    return nums[mid + 1];
                }

                if (nums[mid] < nums[mid - 1])
                {
                    return nums[mid];
                }

                if (nums[mid] > nums[0])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            return 0;
        }
    }
}
