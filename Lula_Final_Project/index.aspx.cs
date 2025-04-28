using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lula_Final_Project
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /* Gabe's problem 1028 below */
        protected void btnShowSolution1028_Click(object sender, EventArgs e)
        {
            var problem = new Lula_FinalProject.LeetCodeProblem1028();

            lblDescription1028.Text = "LeetCode 1028 - Recover a Tree From Preorder Traversal";
            lblTestCase1028.Text = "Test Case: \"1-2--3--4-5--6--7\"";
            lblResult1028.Text = "Output (In-Order Traversal): " + problem.SolveExample();
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