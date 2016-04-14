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
    public partial class TeamLeaderForm : Form
    {
        // List to hold TeamLeader objects
        List<TeamLeader> leaderList = new List<TeamLeader>();

        public TeamLeaderForm()
        {
            InitializeComponent();
        }

        private bool IsValidData()
        {
            // Declare variables
            bool isValid = false;
            int number;
            decimal hourlyPayRate;
            decimal bonus;
            int requiredHours;
            int attendedHours;

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
                            // Check if txtBonus is a decimal.
                            if (decimal.TryParse(txtBonus.Text, out bonus))
                            {
                                // Check if bonus is greater than or equal to 0.
                                if (bonus >= 0)
                                {
                                    // Check if txtRequiredHours is an integer.
                                    if (int.TryParse(txtRequiredHours.Text, out requiredHours))
                                    {
                                        // Check if requiredHours is greater than or equal to 0.
                                        if (requiredHours >= 0)
                                        {
                                            // Check if txtAttendedHours is an integer.
                                            if (int.TryParse(txtAttendedHours.Text, out attendedHours))
                                            {
                                                // Check if txtAttendedHours is greater than or equal to 0.
                                                if (attendedHours >= 0)
                                                {
                                                    isValid = true;
                                                }
                                                else
                                                {
                                                    // Display an error message.
                                                    MessageBox.Show("Please enter a number of hours attended greater than or equal to 0.");
                                                    txtAttendedHours.Focus();
                                                }
                                            }
                                            else
                                            {
                                                // Display an error message.
                                                MessageBox.Show("Please enter a valid number of hours attended.");
                                                txtAttendedHours.Focus();
                                            }
                                        }
                                        else
                                        {
                                            // Display an error message.
                                            MessageBox.Show("Please enter a number of required hours greater than or equal to 0.");
                                            txtRequiredHours.Focus();
                                        }
                                        
                                    }
                                    else
                                    {
                                        // Display an error message.
                                        MessageBox.Show("Please enter a valid number of required hours.");
                                        txtRequiredHours.Focus();
                                    }
                                }
                                else
                                {
                                    // Display an error message.
                                    MessageBox.Show("Please enter a monthly bonus greater than or equal to 0.");
                                    txtBonus.Focus();
                                }
                            }
                            else
                            {
                                // Display an error message.
                                MessageBox.Show("Please enter a valid monthly bonus.");
                                txtBonus.Focus();
                            }
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
                // Create TeamLeader object.
                TeamLeader myLeader = new TeamLeader();

                // Set properties of myLeader.
                myLeader.Name = txtName.Text;
                myLeader.Number = int.Parse(txtNumber.Text);
                myLeader.ShiftNumber = GetRadioButton();
                myLeader.HourlyPayRate = decimal.Parse(txtHourlyPayRate.Text);
                myLeader.Bonus = decimal.Parse(txtBonus.Text);
                myLeader.RequiredHours = int.Parse(txtRequiredHours.Text);
                myLeader.AttendedHours = int.Parse(txtAttendedHours.Text);

                // Add the TeamLeader object to the List.
                leaderList.Add(myLeader);

                // Add an entry to the list box.
                lbTeamLeaders.Items.Add(myLeader.Name);

                // Clear the TextBox controls.
                txtName.Clear();
                txtNumber.Clear();
                txtHourlyPayRate.Clear();
                txtBonus.Clear();
                txtRequiredHours.Clear();
                txtAttendedHours.Clear();

                // Reset the focus.
                txtName.Focus();
            }
        }

        private void lbTeamLeaders_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the index of the selected item.
            int index = lbTeamLeaders.SelectedIndex;

            // Create an instance of the EmpForm class.
            EmpForm myEmpForm = new EmpForm();

            // Set the labels of myEmpForm.
            myEmpForm._lblTLName = leaderList[index].Name;
            myEmpForm._lblTLNumber = leaderList[index].Number.ToString();
            myEmpForm._lblTLShift = leaderList[index].ShiftNumber.ToString();
            myEmpForm._lblTLPayRate = leaderList[index].HourlyPayRate.ToString("c");
            myEmpForm._lblTLBonus = leaderList[index].Bonus.ToString("c");
            myEmpForm._lblTLRequiredHours = leaderList[index].RequiredHours.ToString();
            myEmpForm._lblTLAttendedHours = leaderList[index].AttendedHours.ToString();

            // Set the visibility of the Team Leader group box to true.
            myEmpForm._grpTeamLeader = true;
            myEmpForm._grpShiftSupervisor = false;
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
