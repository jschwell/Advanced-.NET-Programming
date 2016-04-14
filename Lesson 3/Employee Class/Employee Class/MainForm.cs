using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Class
{
    public partial class MainForm : Form
    {
        // List to hold Employee objects
        List<Employee> empList = new List<Employee>();

        // Static fields
        public static string staticName;
        public static int staticId;
        public static string staticDept;
        public static string staticPosition;

        public MainForm()
        {
            InitializeComponent();
        }

        private bool IsValidData()
        {
            // Declare variables
            bool isValid = false;
            int id;

            // Check if txtName is not empty.
            if (txtName.Text != "")
            {
                // Check if txtId is an integer.
                if (int.TryParse(txtId.Text, out id))
                {
                    // Check if txtDepartment is not empty.
                    if (txtDepartment.Text != "")
                    {
                        // Check if txtPosition is not empty.
                        if (txtPosition.Text != "")
                        {
                       
                            isValid = true;
                        }
                        else
                        {
                            // Display that a position was not entered and set the focus to txtPosition.
                            MessageBox.Show("Please enter a position.");
                            txtPosition.Focus();
                        }
                    }
                    else
                    {
                        // Display that a department was not entered and set the focus to txtDepartment.
                        MessageBox.Show("Please enter a department.");
                        txtDepartment.Focus();
                    }
                }
                else
                {
                    // Display that the ID is invalid and set the focus to txtID.
                    MessageBox.Show("Please enter a valid ID Number.");
                    txtId.Focus();
                }
            }
            else
            {
                // Display that a name was not entered and set the focus to txtName.
                MessageBox.Show("Please enter a name.");
                txtName.Focus();
            }

            return isValid;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check if the TextBoxes are filled.
            if (IsValidData())
            {
                // Declare variables
                string name = txtName.Text;
                int id = int.Parse(txtId.Text);
                string department = txtDepartment.Text;
                string position = txtPosition.Text;

                // Create Employee object.
                Employee myEmp = new Employee(name, id, department, position);

                // Add the Employee object to the List.
                empList.Add(myEmp);

                // Add an entry to the list box.
                lbEmployee.Items.Add(myEmp.Name);

                // Clear the TextBox controls.
                txtName.Clear();
                txtId.Clear();
                txtDepartment.Clear();
                txtPosition.Clear();

                // Reset the focus.
                txtName.Focus();
            }
        }

        private void lbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the index of the selected item.
            int index = lbEmployee.SelectedIndex;

            // Get selected object properties.
            staticName = empList[index].Name;
            staticId = empList[index].Id;
            staticDept = empList[index].Department;
            staticPosition = empList[index].Position;

            // Create an instance of the EntryForm class.
            EmpForm myEmpForm = new EmpForm();

            // Display the form.
            myEmpForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }        
    }
}
