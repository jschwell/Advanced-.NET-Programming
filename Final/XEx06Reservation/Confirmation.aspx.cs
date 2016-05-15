using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Confirmation : System.Web.UI.Page
{
    private Reservation reservation;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Get Reservation object stored in session state
            reservation = (Reservation)Session["Reservation"];
            // Display Reservation object data on form
            this.DisplayReservation();
        }
    }

    private void DisplayReservation()
    {
        // Set labels to Reservation object data 
        lblFirstName.Text = reservation.FirstName;
        lblLastName.Text = reservation.LastName;
        lblEmail.Text = reservation.Email;
        lblPhone.Text = reservation.Phone;
        lblPreferredMethod.Text = reservation.PreferredMethod;
        lblArrivalDate.Text = reservation.ArrivalDate.ToShortDateString();
        lblDepartureDate.Text = reservation.DepartureDate.ToShortDateString();
        lblNumberOfDays.Text = reservation.NumberOfDays.ToString();
        lblNumberOfPeople.Text = reservation.NumberOfPeople.ToString();
        lblBedType.Text = reservation.BedType;
        // Check if any special requests were entered
        if (reservation.SpecialRequests == "")
        {
            lblSpecialRequests.Text = "None";
        }
        else
        {
            lblSpecialRequests.Text = reservation.SpecialRequests;
        }
    }

    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            // Display confirmation message
            lblMessage.Text = "Thank you for your request. <br />" +
            "We will get back to you within 24 hours.";
        }
    }
}