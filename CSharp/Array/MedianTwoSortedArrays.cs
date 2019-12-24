using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.Array
{
    class MedianTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] merged = new int[nums1.Length + nums2.Length];
            double median = 0;
            int index1 = 0;
            int index2 = 0;
            int mergeIdx = 0;
            while (index1 < nums1.Length && index2 < nums2.Length)
            {
                if (nums1[index1] >= nums2[index2])
                {
                    merged[mergeIdx++] = nums2[index2++];
                }
                else
                {
                    merged[mergeIdx++] = nums1[index1++];
                }
            }

            while (index1 < nums1.Length)
            {
                merged[mergeIdx++] = nums1[index1++];
            }

            while (index2 < nums2.Length)
            {
                merged[mergeIdx++] = nums2[index2++];
            }

            if (merged.Length % 2 == 0)
            {
                int midCeiling = (int)Math.Ceiling((double)(merged.Length - 1) / 2);
                int midFloor = (int)Math.Floor((double)(merged.Length - 1) / 2);
                median = (double)(merged[midCeiling] + merged[midFloor]) / 2;

            }
            else
            {
                median = merged[(merged.Length - 1) / 2];
            }

            return median;
        }
    }
}
