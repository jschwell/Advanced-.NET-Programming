using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Request : System.Web.UI.Page
{
    private Reservation reservation;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            reservation = (Reservation)Session["Reservation"];

            // Check if a Reservation object is stored in session state
            if (reservation != null)
            {
                // Display Reservation object data on form
                this.DisplayReservation();
            }
            else
            {
                // Set starting value for arrival date to current date
                txtArrivalDate.Text = DateTime.Today.ToShortDateString();
                // Select the first radio button (King)
                rblBedType.SelectedIndex = 0;
            }
        }
    }

    private void DisplayReservation()
    {
        // Set controls to Reservation object data
        txtFirstName.Text = reservation.FirstName;
        txtLastName.Text = reservation.LastName;
        txtEmail.Text = reservation.Email;
        txtPhone.Text = reservation.Phone;
        ddlPreferredMethod.SelectedValue = reservation.PreferredMethod;
        txtArrivalDate.Text = reservation.ArrivalDate.ToShortDateString();
        txtDepartureDate.Text = reservation.DepartureDate.ToShortDateString();
        ddlNumberOfPeople.SelectedValue = reservation.NumberOfPeople.ToString(); ;
        rblBedType.SelectedValue = reservation.BedType;
        txtRequests.Text = reservation.SpecialRequests;
    }

    private void GetReservationData()
    {
        if (reservation == null)
        {
            reservation = new Reservation();
        }

        // Saves data from controls into the properties of the Reservation object
        reservation.FirstName = txtFirstName.Text;
        reservation.LastName = txtLastName.Text;
        reservation.Email = txtEmail.Text;
        reservation.Phone = txtPhone.Text;
        reservation.PreferredMethod = ddlPreferredMethod.SelectedValue;
        reservation.ArrivalDate = Convert.ToDateTime(txtArrivalDate.Text);
        reservation.DepartureDate = Convert.ToDateTime(txtDepartureDate.Text);
        reservation.NumberOfDays = reservation.CalculateDays();
        reservation.NumberOfPeople = Convert.ToInt32(ddlNumberOfPeople.SelectedValue);
        reservation.BedType = rblBedType.SelectedValue;
        reservation.SpecialRequests = txtRequests.Text;

        // Save Reservation object in session state
        Session["Reservation"] = reservation;
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            // Save form data into Reservation object
            this.GetReservationData();
            // Redirect to the Confirmation page
            Response.Redirect("~/Confirmation.aspx");
        }
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        // Return all of the control values to their defaults
        txtArrivalDate.Text = DateTime.Today.ToShortDateString();
        txtDepartureDate.Text = "";
        ddlNumberOfPeople.SelectedIndex = 0;
        rblBedType.SelectedIndex = 0;
        txtRequests.Text = "";
        txtFirstName.Text = "";
        txtLastName.Text = "";
        txtEmail.Text = "";
        txtPhone.Text = "";
        ddlPreferredMethod.SelectedIndex = 0;
        lblMessage.Text = "";

        // Remove Reservation object from session
        Session.Remove("Reservation");
    }
}