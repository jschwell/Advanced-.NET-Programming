using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_4
{
    public partial class SupervisorForm : Form
    {
        // List to hold ShiftSupervisor objects
        List<ShiftSupervisor> supervisorList = new List<ShiftSupervisor>();

        public SupervisorForm()
        {
            InitializeComponent();
        }

        private bool IsValidData()
        {
            // Declare variables
            bool isValid = false;
            int number;
            decimal bonus;
            decimal salary;

            // Check if txtName is not empty.
            if (txtName.Text != "")
            {
                // Check if txtNumber is an integer.
                if (int.TryParse(txtNumber.Text, out number))
                {
                    // Check if txtSalary is a decimal.
                    if (decimal.TryParse(txtSalary.Text, out salary))
                    {
                        // Check if salary is a positive number.
                        if (salary > 0)
                        {
                            // Check if txtBonus is a decimal.
                            if (decimal.TryParse(txtBonus.Text, out bonus))
                            {
                                // Check if bonus is greater or equal to 0.
                                if (bonus >= 0)
                                {
                                    isValid = true;
                                }
                                else
                                {
                                    // Display an error message.
                                    MessageBox.Show("Please enter an annual bonus greater than or equal to 0.");
                                    txtBonus.Focus();
                                }
                            }
                            else
                            {
                                // Display an error message.
                                MessageBox.Show("Please enter a valid annual bonus.");
                                txtBonus.Focus();
                            }
                        }
                        else
                        {
                            // Display an error message.
                            MessageBox.Show("Please enter a positive annual salary.");
                            txtSalary.Focus();
                        }
                    }
                    else
                    {
                        // Display an error message.
                        MessageBox.Show("Please enter a valid annual salary.");
                        txtSalary.Focus();
                    }
                }
                else
                {
                    // Display an error message.
                    MessageBox.Show("Please enter a valid employee number.");
                    txtNumber.Focus();
                }
            }
            else
            {
                // Display an error message.
                MessageBox.Show("Please enter a name.");
                txtName.Focus();
            }

            return isValid;
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            // Check if the TextBoxes are filled.
            if (IsValidData())
            {
                // Create ShiftSupervisor object.
                ShiftSupervisor mySupervisor = new ShiftSupervisor();

                // Set properties of mySupervisor.
                mySupervisor.Name = txtName.Text;
                mySupervisor.Number = int.Parse(txtNumber.Text);
                mySupervisor.AnnualSalary = decimal.Parse(txtSalary.Text);
                mySupervisor.Bonus = decimal.Parse(txtBonus.Text);

                // Add the ShiftSupervisor object to the List.
                supervisorList.Add(mySupervisor);

                // Add an entry to the list box.
                lbSupervisors.Items.Add(mySupervisor.Name);

                // Clear the TextBox controls.
                txtName.Clear();
                txtNumber.Clear();
                txtSalary.Clear();
                txtBonus.Clear();

                // Reset the focus.
                txtName.Focus();
            }
        }

        private void lbSupervisors_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the index of the selected item.
            int index = lbSupervisors.SelectedIndex;

            // Create an instance of the EmpForm class.
            EmpForm myEmpForm = new EmpForm();

            // Set the labels of myEmpForm.
            myEmpForm._lblSSName = supervisorList[index].Name;
            myEmpForm._lblSSNumber = supervisorList[index].Number.ToString();
            myEmpForm._lblSSAnnualSalary = supervisorList[index].AnnualSalary.ToString("c");
            myEmpForm._lblSSBonus = supervisorList[index].Bonus.ToString("c");

            // Set the visibility of the Shift Supervisor group box to true.
            myEmpForm._grpTeamLeader = false;
            myEmpForm._grpShiftSupervisor = true;
            myEmpForm._grpProductionWorker = false;

            // Display the form.
            myEmpForm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
