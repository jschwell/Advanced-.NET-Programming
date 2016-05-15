using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class CustomerDisplay : System.Web.UI.Page
{
    private Customer selectedCustomer;

    protected void Page_Load(object sender, EventArgs e)
    {
        // Bind drop-down list on first load
        if (!IsPostBack)
        {
            ddlCustomer.DataBind();
        }
        // Get and show Customer on every load
        selectedCustomer = this.GetSelectedCustomer();
        lblAddress.Text = selectedCustomer.Address;
        lblAddress2.Text = selectedCustomer.AddressDisplay();
        lblPhone.Text = selectedCustomer.Phone;
        
        if (selectedCustomer.Email == "")
        {
            lblEmail.Text = "N/A";
        }
        else
        {
            lblEmail.Text = selectedCustomer.Email;
        }
    }

    private Customer GetSelectedCustomer()
    {
        // Get row from SqlDataSource based on value in dropdown list
        DataView customerTable = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
        customerTable.RowFilter = string.Format("CustomerID = '{0}'", ddlCustomer.SelectedValue);
        DataRowView row = (DataRowView)customerTable[0];

        // Create a new customer object and load with data from row
        Customer c = new Customer();
        c.CustomerID = row["CustomerID"].ToString();
        c.Name = row["Name"].ToString();
        c.Address = row["Address"].ToString();
        c.City = row["City"].ToString();
        c.State = row["State"].ToString();
        c.ZipCode = row["ZipCode"].ToString();
        c.Phone = row["Phone"].ToString();
        c.Email = row["Email"].ToString();
        return c;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            // Get contacts from sessions state and selected customer
            CustomerList contacts = CustomerList.GetCustomers();
            Customer customer = contacts[selectedCustomer.Name];

            // If customer isn't in contact list, add them
            if (customer == null)
            {
                contacts.AddItem(selectedCustomer);
                Response.Redirect("ContactDisplay.aspx");
            }
            else
            {
                lblMessage.Text = "Customer has already been added.";
            }
        }
    }
}