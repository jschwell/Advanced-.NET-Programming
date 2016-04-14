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
            int guests = Convert.ToInt32(txtGuests.Text);
            decimal dinnerCost = Convert.ToDecimal(txtDinnerCost.Text);
            decimal limousineCost = Convert.ToDecimal(txtLimousineCost.Text);
            decimal musicCost = Convert.ToDecimal(txtMusicCost.Text);
            decimal flowersCost = Convert.ToDecimal(txtFlowersCost.Text);
            decimal openBarCost = Convert.ToDecimal(txtOpenBarCost.Text);

            // Calculate costs for all guests
            decimal totalDinnerCost = dinnerCost * guests;
            decimal totalOpenBarCost = openBarCost * guests;

            // Calculate the total price
            decimal totalPrice = limousineCost + musicCost + flowersCost +
                totalDinnerCost + totalOpenBarCost;

            // Display results
            lblTotalCost.Text = totalPrice.ToString("c");
        }
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        // Clear the textboxes and label
        txtEventName.Text = "";
        txtGuests.Text = "";
        txtDinnerCost.Text = "";
        txtLimousineCost.Text = "";
        txtMusicCost.Text = "";
        txtFlowersCost.Text = "";
        txtOpenBarCost.Text = "";
        lblTotalCost.Text = "";
    }
}