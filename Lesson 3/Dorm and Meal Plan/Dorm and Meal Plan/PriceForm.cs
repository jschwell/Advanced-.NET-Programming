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
    public partial class PriceForm : Form
    {
        public PriceForm()
        {
            InitializeComponent();
        }

        private void PriceForm_Load(object sender, EventArgs e)
        {
            // Declare variables
            decimal dormPrice;
            decimal mealPlanPrice;
            decimal totalPrice;

            // Get the dorm price.
            dormPrice = GetDormPrice();

            // Get the meal plan price.
            mealPlanPrice = GetMealPlanPrice();

            // Calculate the total price.
            totalPrice = dormPrice + mealPlanPrice;

            // Display the results.
            DisplayResults(dormPrice, mealPlanPrice, totalPrice);
        }

        private void DisplayResults(decimal dormPrice, decimal mealPlanPrice, decimal totalPrice)
        {
            // Get static variables from main form.
            string dorm = MainForm.dorm;
            string mealPlan = MainForm.mealPlan;

            // Display dorm and meal plan selected.
            lblDorm.Text = dorm;
            lblMealPlan.Text = mealPlan;

            // Display prices.
            lblDormPrice.Text = dormPrice.ToString("c");
            lblMealPrice.Text = mealPlanPrice.ToString("c");
            lblTotal.Text = totalPrice.ToString("c");
        }

        private decimal GetDormPrice()
        {
            // Declare variables
            string dorm = MainForm.dorm;
            decimal dormPrice = 0m;

            // Get dorm price based on the dorm.
            switch (dorm)
            {
                case "Allen Hall":
                    dormPrice = 1500.0m;
                    break;
                case "Pike Hall":
                    dormPrice = 1600.0m;
                    break;
                case "Farthing Hall":
                    dormPrice = 1800.0m;
                    break;
                case "University Suites":
                    dormPrice = 2500.0m;
                    break;
            }

            return dormPrice;
        }

        private decimal GetMealPlanPrice()
        {
            // Declare variables
            string mealPlan = MainForm.mealPlan;
            decimal mealPlanPrice = 0m;

            // Get meal plan price based on the meal plan.
            switch (mealPlan)
            {
                case "7 meals per week":
                    mealPlanPrice = 600.0m;
                    break;
                case "14 meals per week":
                    mealPlanPrice = 1200.0m;
                    break;
                case "Unlimited meals":
                    mealPlanPrice = 1700.0m;
                    break;
            }

            return mealPlanPrice;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
