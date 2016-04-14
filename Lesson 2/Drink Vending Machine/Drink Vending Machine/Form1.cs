using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drink_Vending_Machine
{
    struct Drink
    {
        public string name;
        public decimal cost;
        public int numberOfDrinks;
    }

    public partial class Form1 : Form
    {
        // Declare private field to hold the total sales
        private decimal totalSales = 0m;

        // Create an array of 5 Drink objects
        private Drink[] drinks = new Drink[5];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Fill drink objects
            CreateDrinks();
            // Display prices
            DisplayPrices();
            // Display drinks left and total sales
            UpdateInfo();
        }

        private void CreateDrinks()
        {
            drinks[0].name = "Cola";
            drinks[0].cost = 1.00m;
            drinks[0].numberOfDrinks = 20;

            drinks[1].name = "Root Beer";
            drinks[1].cost = 1.00m;
            drinks[1].numberOfDrinks = 20;

            drinks[2].name = "Lemon Lime";
            drinks[2].cost = 1.00m;
            drinks[2].numberOfDrinks = 20;

            drinks[3].name = "Grape Soda";
            drinks[3].cost = 1.50m;
            drinks[3].numberOfDrinks = 20;

            drinks[4].name = "Cream Soda";
            drinks[4].cost = 1.50m;
            drinks[4].numberOfDrinks = 20;
        }
        private void DisplayPrices()
        {
            // Display drink prices
            lblColaPrice.Text = drinks[0].cost.ToString("c");
            lblRootBeerPrice.Text = drinks[1].cost.ToString("c");
            lblLemonLimePrice.Text = drinks[2].cost.ToString("c");
            lblGrapeSodaPrice.Text = drinks[3].cost.ToString("c");
            lblCreamSodaPrice.Text = drinks[4].cost.ToString("c");
        }
        private void UpdateInfo()
        {
            // Display number of drinks
            lblCola.Text = drinks[0].numberOfDrinks.ToString();
            lblRootBeer.Text = drinks[1].numberOfDrinks.ToString();
            lblLemonLime.Text = drinks[2].numberOfDrinks.ToString();
            lblGrapeSoda.Text = drinks[3].numberOfDrinks.ToString();
            lblCreamSoda.Text = drinks[4].numberOfDrinks.ToString();

            // Display total sales
            lblTotalSales.Text = totalSales.ToString("c");
        }

        private void picCola_Click(object sender, EventArgs e)
        {
            if (drinks[0].numberOfDrinks > 0)
            {
                // Add cost to total sales
                totalSales += drinks[0].cost;
                // Subtract 1 from number of drinks
                drinks[0].numberOfDrinks--;
                // Display updated info
                UpdateInfo();
            }
            else
            {
                // Display message that drink is sold out
                MessageBox.Show(drinks[0].name + " is sold out.");
            }
        }

        private void picRootBeer_Click(object sender, EventArgs e)
        {
            if (drinks[1].numberOfDrinks > 0)
            {
                // Add cost to total sales
                totalSales += drinks[1].cost;
                // Subtract 1 from number of drinks
                drinks[1].numberOfDrinks--;
                // Display updated info
                UpdateInfo();
            }
            else
            {
                // Display message that drink is sold out
                MessageBox.Show(drinks[1].name + " is sold out.");
            }
        }

        private void picLemonLime_Click(object sender, EventArgs e)
        {
            if (drinks[2].numberOfDrinks > 0)
            {
                // Add cost to total sales
                totalSales += drinks[2].cost;
                // Subtract 1 from number of drinks
                drinks[2].numberOfDrinks--;
                // Display updated info
                UpdateInfo();
            }
            else
            {
                // Display message that drink is sold out
                MessageBox.Show(drinks[2].name + " is sold out.");
            }
        }

        private void picGrapeSoda_Click(object sender, EventArgs e)
        {
            if (drinks[3].numberOfDrinks > 0)
            {
                // Add cost to total sales
                totalSales += drinks[3].cost;
                // Subtract 1 from number of drinks
                drinks[3].numberOfDrinks--;
                // Display updated info
                UpdateInfo();
            }
            else
            {
                // Display message that drink is sold out
                MessageBox.Show(drinks[3].name + " is sold out.");
            }
        }

        private void picCreamSoda_Click(object sender, EventArgs e)
        {
            if (drinks[4].numberOfDrinks > 0)
            {
                // Add cost to total sales
                totalSales += drinks[4].cost;
                // Subtract 1 from number of drinks
                drinks[4].numberOfDrinks--;
                // Display updated info
                UpdateInfo();
            }
            else
            {
                // Display message that drink is sold out
                MessageBox.Show(drinks[4].name + " is sold out.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset total sales back to 0
            totalSales = 0m;
            // Reset drink information
            CreateDrinks();
            // Display prices
            DisplayPrices();
            // Display drinks left and total sales
            UpdateInfo();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
