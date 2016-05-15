using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ContactDisplay : System.Web.UI.Page
{
    private CustomerList contacts;

    protected void Page_Load(object sender, EventArgs e)
    {
        // Retrieve customer object from session state on every post back
        contacts = CustomerList.GetCustomers();

        // Add customers to list box on initial page load
        if (!IsPostBack)
        {
            this.DisplayCustomers();
        }
    }

    private void DisplayCustomers()
    {
        // Remove all current items from list box
        lbContacts.Items.Clear();

        // Loop through contact list and add each customer to list box
        for(int i = 0; i < contacts.Count; i++)
        {
            lbContacts.Items.Add(this.contacts[i].ContactDisplay());
        }
    }

    protected void btnRemove_Click(object sender, EventArgs e)
    {
        // Remove selected customer from contact list
        if (contacts.Count > 0)
        {
            if (lbContacts.SelectedIndex > -1)
            {
                contacts.RemoveAt(lbContacts.SelectedIndex);

                this.DisplayCustomers();
            }
            else
            {
                lblMessage.Text = "Please select a customer to remove.";
            }
        }
        else
        {
            lblMessage.Text = "There are no customers to remove.";
        }
    }

    protected void btnEmpty_Click(object sender, EventArgs e)
    {
        // Empty contact list
        if (contacts.Count > 0)
        {
            contacts.Clear();
            this.DisplayCustomers();
        }
        else
        {
            lblMessage.Text = "List is already empty.";
        }
    }
}