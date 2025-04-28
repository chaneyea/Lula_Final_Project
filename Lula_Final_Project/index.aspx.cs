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
            int[] nums1 = { 1, 3 };
            int[] nums2 = { 2 };

            Problem_4 problem = new Problem_4();
            double median = problem.FindMedianSortedArrays(nums1, nums2);

            lblResult.Text = "Median: " + median.ToString("F5");
        }
    }
}