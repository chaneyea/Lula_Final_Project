/*
 *File Name: LeetCodeProblem04.cs

* Name: Andrea Forero
* email:  chaneyea@mail.uc.edu
* Assignment Number: Lula_Final_Project
* Due Date:   4/29/2025
* Course #/Section:   IS3050 Section 001
* Semester/Year:   Spring 2025
* Brief Description of the assignment:  Final project, making a website to show leetcode solutions

* Makes a class to solve problem 42 on leetcode
* Citations:
* Anything else that's relevant:
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace leetcode_problem_04
{
    public class Problem4
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)
            {
                // Always binary search the smaller array
                return FindMedianSortedArrays(nums2, nums1);
            }

            int x = nums1.Length;
            int y = nums2.Length;
            int low = 0;
            int high = x;

            while (low <= high)
            {
                int partitionX = (low + high) / 2;
                int partitionY = (x + y + 1) / 2 - partitionX;

                int maxLeftX = (partitionX == 0) ? int.MinValue : nums1[partitionX - 1];
                int minRightX = (partitionX == x) ? int.MaxValue : nums1[partitionX];

                int maxLeftY = (partitionY == 0) ? int.MinValue : nums2[partitionY - 1];
                int minRightY = (partitionY == y) ? int.MaxValue : nums2[partitionY];

                if (maxLeftX <= minRightY && maxLeftY <= minRightX)
                {
                    if ((x + y) % 2 == 0)
                    {
                        return (Math.Max(maxLeftX, maxLeftY) + Math.Min(minRightX, minRightY)) / 2.0;
                    }
                    else
                    {
                        return Math.Max(maxLeftX, maxLeftY);
                    }
                }
                else if (maxLeftX > minRightY)
                {
                    high = partitionX - 1;
                }
                else
                {
                    low = partitionX + 1;
                }
            }

            throw new InvalidOperationException("Input arrays are not sorted properly.");
        }
    }
}