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

            lblTestCase1.Text = "Test Case 1: [0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1]";
            lblResult1.Text = "Output: " + problem.Solve(test1);
            lblTestCase2.Text = "Test Case 2: [4, 2, 0, 3, 2, 5]";
            lblResult2.Text = "Output: " + problem.Solve(test2);
        }

        /*Nolan's problem 65 */
        protected void btnShowSolution65_Click(object sender, EventArgs e)
        {
            var prob65 = new Lula_Final_Project.LeetCodeProblem65();

            lblTestCase65.Text = "Test Cases: 7e6, e, 28.8, 4.8.1";
            lblResult65.Text = "Output: " + prob65.IsNumber("7e6") + ", " + prob65.IsNumber("e") + ", " + prob65.IsNumber("28.8") + ", " + prob65.IsNumber("4.8.1");
        }

        /* Gabe's Problem 1028 Below */
        protected void btnShowSolution1028_Click(object sender, EventArgs e)
        {
            var problem = new Lula_FinalProject.LeetCodeProblem1028();

            lblTestCase1028.Text = "Test Case: \"1-2--3--4-5--6--7\"";
            lblResult1028.Text = "Output (In-Order Traversal): " + problem.SolveExample();
        }

        /* Andrea's Problem 4 */
        protected void btnProblem4_Click(object sender, EventArgs e)
        {
            var problem = new Lula_Final_Project.Problem4();

            int[] test1_nums1 = { 1, 3 };
            int[] test1_nums2 = { 2 };

            int[] test2_nums1 = { 1, 2 };
            int[] test2_nums2 = { 3, 4 };

            lblTest.Text = "Test Case 2: nums1 = [1, 2], nums2 = [3, 4]";
            lblResult.Text = "Output: " + problem.FindMedianSortedArrays(test2_nums1, test2_nums2).ToString("F5");
        }

        protected void lnkProblem4_Click(object sender, EventArgs e)
        {
            HideAllDivs();
            divProblem4.Visible = true;
        }

        protected void lnkProblem42_Click(object sender, EventArgs e)
        {
            HideAllDivs();
            divProblem42.Visible = true;
        }

        protected void lnkProblem1028_Click(object sender, EventArgs e)
        {
            HideAllDivs();
            divProblem1028.Visible = true;
        }

        protected void lnkProblem65_Click(object sender, EventArgs e)
        {
            HideAllDivs();
            divProblem65.Visible = true;
        }

        private void HideAllDivs()
        {
            divProblem4.Visible = false;
            divProblem42.Visible = false;
            divProblem1028.Visible = false;
            divProblem65.Visible = false;
        }
    }

}
