using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Class
{
    public partial class Form1 : Form
    {
        // List to hold Car objects
        List<Car> carList = new List<Car>();

        public Form1()
        {
            InitializeComponent();
        }

        private bool IsValidData()
        {
            // Declare variables
            bool isValid = false;
            int year;

            // Check if txtMake is not empty.
            if (txtMake.Text != "")
            {
                // Check if txtYear is an integer.
                if (int.TryParse(txtYear.Text, out year))
                {
                    isValid = true;
                }
                else
                {
                    // Display that year was invalid.
                    MessageBox.Show("Please enter a valid year.");
                    txtYear.Focus();
                }
            }
            else
            {
                // Display that the make was not entered.
                MessageBox.Show("Please enter a make.");
                txtMake.Focus();
            }

            return isValid;
        }

        private bool IsSelected(int index)
        {
            bool isValid = false;
            
            // Check if an item is selected from the list box.
            if (index != -1)
            {
                isValid = true;
            }
            else
            {
                // Display that no car was selected.
                MessageBox.Show("Please select a car.");
            }         

            return isValid;
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            // Check if the TextBoxes are filled.
            if (IsValidData())
            {
                // Declare variables
                string make = txtMake.Text;
                int year = int.Parse(txtYear.Text);

                // Create car object.
                Car myCar = new Car(make, year);

                // Add the Car object to the List.
                carList.Add(myCar);

                // Add an entry to the list box.
                lbCarList.Items.Add(myCar.Year + " " + myCar.Make);

                // Clear the TextBox controls.
                txtMake.Clear();
                txtYear.Clear();

                // Reset the focus.
                txtMake.Focus();
            }

        }

        private void btnAccelerate_Click(object sender, EventArgs e)
        {
            // Get the index of the selected item.
            int index = lbCarList.SelectedIndex;

            // Check if car was selected.
            if (IsSelected(index))
            {
                // Accelerate the car.
                carList[index].Accelerate();

                // Display the car's speed.
                lblSpeed.Text = carList[index].Speed.ToString();
            }
        }

        private void btnBrake_Click(object sender, EventArgs e)
        {
            // Get the index of the selected item.
            int index = lbCarList.SelectedIndex;

            // Check if car was selected.
            if (IsSelected(index))
            {
                if (carList[index].Speed > 0)
                {
                    // Hit the car's brakes.
                    carList[index].Brake();

                    // Display the car's speed.
                    lblSpeed.Text = carList[index].Speed.ToString();
                }
                else
                {
                    // Display that the car can not go any slower.
                    MessageBox.Show("The car has already stopped.");
                }
            }
        }

        private void lbCarList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the index of the selected item.
            int index = lbCarList.SelectedIndex;

            // Display the car's speed.
            lblSpeed.Text = carList[index].Speed.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
