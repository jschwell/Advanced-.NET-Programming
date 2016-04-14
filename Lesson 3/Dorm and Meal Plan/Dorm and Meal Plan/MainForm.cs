using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dorm_and_Meal_Plan
{
    public partial class MainForm : Form
    {
        // Create static fields for the dorm and meal plan.
        public static string dorm;
        public static string mealPlan;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Get the selected dorm.
            if (rbAllenHall.Checked)
            {
                dorm = rbAllenHall.Text;
            }
            else if (rbPikeHall.Checked)
            {
                dorm = rbPikeHall.Text;
            }
            else if (rbFarthingHall.Checked)
            {
                dorm = rbFarthingHall.Text;
            }
            else
            {
                dorm = rbUniversitySuites.Text;
            }

            // Get the selected meal plan.
            if (rb7Meals.Checked)
            {
                mealPlan = rb7Meals.Text;
            }
            else if (rb14Meals.Checked)
            {
                mealPlan = rb14Meals.Text;
            }
            else
            {
                mealPlan = rbUnlimitedMeals.Text;
            }

            // Create an instance of the PriceForm class.
            PriceForm myPriceForm = new PriceForm();

            // Display the form.
            myPriceForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
