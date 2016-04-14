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
    public partial class WorkerForm : Form
    {
        // List to hold ProductionWorker objects
        List<ProductionWorker> workerList = new List<ProductionWorker>();

        public WorkerForm()
        {
            InitializeComponent();
        }

        private bool IsValidData()
        {
            // Declare variables
            bool isValid = false;
            int number;
            decimal hourlyPayRate;

            // Check if txtName is not empty.
            if (txtName.Text != "")
            {
                // Check if txtNumber is an integer.
                if (int.TryParse(txtNumber.Text, out number))
                {
                    // Check if txtHourlyPayRate is a decimal.
                    if (decimal.TryParse(txtHourlyPayRate.Text, out hourlyPayRate))
                    {
                        // Check if hourlyPayRate is a positive number.
                        if (hourlyPayRate > 0)
                        {
                            isValid = true;
                        }
                        else
                        {
                            // Display an error message.
                            MessageBox.Show("Please enter a positive hourly pay rate.");
                            txtHourlyPayRate.Focus();
                        }
                    }
                    else
                    {
                        // Display an error message.
                        MessageBox.Show("Please enter a valid hourly pay rate.");
                        txtHourlyPayRate.Focus();
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

        private int GetRadioButton()
        {
            int number;

            if (rbShift1.Checked)
            {
                number = 1;
            }
            else
            {
                number = 2;
            }

            return number;
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            // Check if the TextBoxes are filled.
            if (IsValidData())
            {
                // Create ProductionWorker object.
                ProductionWorker myWorker = new ProductionWorker();

                // Set properties of myWorker.
                myWorker.Name = txtName.Text;
                myWorker.Number = int.Parse(txtNumber.Text);
                myWorker.ShiftNumber = GetRadioButton();
                myWorker.HourlyPayRate = decimal.Parse(txtHourlyPayRate.Text);

                // Add the ProductionWorker object to the List.
                workerList.Add(myWorker);

                // Add an entry to the list box.
                lbProductionWorkers.Items.Add(myWorker.Name);

                // Clear the TextBox controls.
                txtName.Clear();
                txtNumber.Clear();
                txtHourlyPayRate.Clear();

                // Reset the focus.
                txtName.Focus();
            }
        }

        private void lbProductionWorkers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the index of the selected item.
            int index = lbProductionWorkers.SelectedIndex;

            // Create an instance of the EmpForm class.
            EmpForm myEmpForm = new EmpForm();

            // Set the labels of myEmpForm.
            myEmpForm._lblPWName = workerList[index].Name;
            myEmpForm._lblPWNumber = workerList[index].Number.ToString();
            myEmpForm._lblPWShift = workerList[index].ShiftNumber.ToString();
            myEmpForm._lblPWPayRate = workerList[index].HourlyPayRate.ToString("c");

            // Set the visibility of the Production Worker group box to true.
            myEmpForm._grpTeamLeader = false;
            myEmpForm._grpShiftSupervisor = false;
            myEmpForm._grpProductionWorker = true;

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
