/*
 *File Name: {required}

* Name: Nolan Callahan
* email:  callahnp@mail.uc.edu
* Assignment Number: Assignment Final
* Due Date:   4/29/2025
* Course #/Section:   IS3050 Section 001
* Semester/Year:   Spring 2025
* Brief Description of the assignment:  Final project, making a website to show leetcode solutions

* Makes a class to solve problem 65 on leetcode
* Citations: https://chatgpt.com/c/68011a4b-e658-8006-a083-0483fbe093d3
* Anything else that's relevant:
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lula_Final_Project
{
    public class LeetCodeProblem65
    {
        public bool IsNumber(string s)
        {
            s = s.Trim();
            if (s.Length == 0) return false;

            bool seenDigit = false;
            bool seenDot = false;
            bool seenE = false;
            bool digitAfterE = true;

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                if (char.IsDigit(c))
                {
                    seenDigit = true;
                    if (seenE)
                        digitAfterE = true;
                }
                else if (c == '+' || c == '-')
                {
                    // Sign can only appear at the beginning or right after 'e' or 'E'
                    if (i != 0 && s[i - 1] != 'e' && s[i - 1] != 'E')
                        return false;
                }
                else if (c == '.')
                {
                    // Only one dot and it must not come after an 'e'
                    if (seenDot || seenE)
                        return false;
                    seenDot = true;
                }
                else if (c == 'e' || c == 'E')
                {
                    // Only one 'e', must follow a digit, and must be followed by an integer
                    if (seenE || !seenDigit)
                        return false;
                    seenE = true;
                    digitAfterE = false; // we need at least one digit after e
                }
                else
                {
                    // Invalid character
                    return false;
                }
            }

            return seenDigit && digitAfterE;
        }
    }
}