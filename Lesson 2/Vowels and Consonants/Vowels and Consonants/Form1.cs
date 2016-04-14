using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vowels_and_Consonants
{
    public partial class Form1 : Form
    {
        // Constant fields 
        private const string VOWELS = "aeiou";
        private const string CONSONANTS = "bcdfghjklmnpqrstvwxyz";

        public Form1()
        {
            InitializeComponent();
        }


        private int CountVowels(string str)
        {
            // Declare variable to hold the number of vowels
            int numberOfVowels = 0;

            // For every character in the string, check if it is a vowel
            foreach (char ch in str)
            {
                if (VOWELS.Contains(ch))
                {
                    numberOfVowels++;
                }
            }
            // Return the total number of vowels in the string
            return numberOfVowels;
        }

        private int CountConsonants(string str)
        {
            // Declare variable to hold the number of consonants
            int numberOfConsonants = 0;

            // For every character in the string, check if it is a consonant
            foreach (char ch in str)
            {
                if (CONSONANTS.Contains(ch))
                {
                    numberOfConsonants++;
                }
            }
            // Return the total number of consonants in the string
            return numberOfConsonants;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Declare variables
            string input;
            int numberOfVowels;
            int numberOfConsonants;

            // Get user input
            input = txtWords.Text;

            if (input != "")
            {
                // Convert input to lowercase
                input = input.ToLower();

                // Get the number of vowels and consonants from the input
                numberOfVowels = CountVowels(input);
                numberOfConsonants = CountConsonants(input);

                // Display the results
                lblVowels.Text = numberOfVowels.ToString();
                lblConsonants.Text = numberOfConsonants.ToString();
            }
            else
            {
                // Display error message
                MessageBox.Show("Please enter a word or sentence.");
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear textboxes and labels
            txtWords.Text = "";
            lblConsonants.Text = "";
            lblVowels.Text = "";

            // Set the focus back to the textbox
            txtWords.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
