using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lulu_Final_Project;

namespace Final_Project
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /* Ethan's problem 42 below */
        protected void btnShowSolution_Click(object sender, EventArgs e)
        {
            var problem = new LeetsCodeProblem42();

            int[] test1 = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            int[] test2 = { 4, 2, 0, 3, 2, 5 };

            lblDescription.Text = problem.GetDescription();
            lblTestCase1.Text = "Test Case 1: [0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1]";
            lblResult1.Text = "Output: " + problem.Solve(test1);
            lblTestCase2.Text = "Test Case 2: [4, 2, 0, 3, 2, 5]";
            lblResult2.Text = "Output: " + problem.Solve(test2);
        }

        /*Nolan's problem 65 */
        protected void btnShowSolution65_Click(object sender, EventArgs e)
        {
            var prob65 = new Lula_Final_Project.LeetCodeProblem65();

            lblDescription65.Text = "Leetcode 65 - Valid Number Checker";
            lblTestCase65.Text = "Test Cases: 7e6, e, 28.8, 4.8.1";
            lblResult65.Text = "Output: " + prob65.IsNumber("7e6") + ", " + prob65.IsNumber("e") + ", " + prob65.IsNumber("28.8") + ", " + prob65.IsNumber("4.8.1");
        }
    }
}