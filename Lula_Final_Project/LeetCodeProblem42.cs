/*
 *File Name: LeetCodeProblem42.cs

* Name: Ethan Chaney
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

namespace Lulu_Final_Project
{
    public class LeetsCodeProblem42
    {
        public string GetDescription()
        {
            return "Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it can trap after raining.";
        }

        public int Solve(int[] height)
        {
            int left = 0, right = height.Length - 1;
            int leftMax = 0, rightMax = 0;
            int waterTrapped = 0;

            while (left < right)
            {
                if (height[left] < height[right])
                {
                    if (height[left] >= leftMax)
                        leftMax = height[left];
                    else
                        waterTrapped += leftMax - height[left];
                    left++;
                }
                else
                {
                    if (height[right] >= rightMax)
                        rightMax = height[right];
                    else
                        waterTrapped += rightMax - height[right];
                    right--;
                }
            }

            return waterTrapped;
        }
    }
}