using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Turn off unobtrusive validation
        UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
    }

    protected void btnCalculate_Click(object sender, EventArgs e)
    {
        if (IsValid)
        {
            // Declare variables
            decimal salesPrice = Convert.ToDecimal(txtSalesPrice.Text);
            decimal discountPercent = Convert.ToDecimal(txtDiscountPercent.Text);
            decimal discountAmount;
            decimal totalPrice;

            // Check if the discount percent is already divided by 100
            if (discountPercent > 0 && discountPercent < 1)
            {
                // Calculate the discount amount
                discountAmount = salesPrice * discountPercent;
            }
            else
            {
                // Calculate the discount amount
                discountAmount = salesPrice * discountPercent / 100;
            }

            // Calculate the total price
            totalPrice = salesPrice - discountAmount;

            // Display the results
            lblDiscountAmount.Text = discountAmount.ToString("c");
            lblTotalPrice.Text = totalPrice.ToString("c");
        }
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        // Clear textboxes and labels
        txtSalesPrice.Text = "";
        txtDiscountPercent.Text = "";
        lblDiscountAmount.Text = "";
        lblTotalPrice.Text = "";
    }
}