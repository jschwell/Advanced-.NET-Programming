using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alphabetic_Telephone_Number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsValidFormat(string str)
        {
            const int VALID_LENGTH = 12;
            bool valid;

            // Determine whether str is properly formatted
            if (str.Length == VALID_LENGTH && str[3] == '-' &&
                str[7] == '-')
            {
                valid = true;
            }
            else
            {
                valid = false;
            }
            // Return the value of valid
            return valid;
        }

        private void Translate(ref string str)
        {
            for (int index = 0; index < str.Length; index++)
            {
                // If the character is a letter, translate it
                if (char.IsLetter(str[index]))
                {
                    // Save character to a variable and remove the character in the string
                    char letter = str[index];
                    str = str.Remove(index, 1);

                    // Insert the corresponding number in the string
                    switch (char.ToUpper(letter))
                    {
                        case 'A':
                        case 'B':
                        case 'C':
                            str = str.Insert(index, "2");
                            break;
                        case 'D':
                        case 'E':
                        case 'F':
                            str = str.Insert(index, "3");
                            break;
                        case 'G':
                        case 'H':
                        case 'I':
                            str = str.Insert(index, "4");
                            break;
                        case 'J':
                        case 'K':
                        case 'L':
                            str = str.Insert(index, "5");
                            break;
                        case 'M':
                        case 'N':
                        case 'O':
                            str = str.Insert(index, "6");
                            break;
                        case 'P':
                        case 'Q':
                        case 'R':
                        case 'S':
                            str = str.Insert(index, "7");
                            break;
                        case 'T':
                        case 'U':
                        case 'V':
                            str = str.Insert(index, "8");
                            break;
                        case 'W':
                        case 'X':
                        case 'Y':
                        case 'Z':
                            str = str.Insert(index, "9");
                            break;
                    }
                }
            }
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            // Get a trimmed copy of the user's input
            string input = txtPhoneNumber.Text.Trim();

            // If the input is properly formatted, unformat it and display it
            if (IsValidFormat(input))
            {
                Translate(ref input);
                lblTranslated.Text = input;
            }
            else
            {
                // Display an error message
                MessageBox.Show("Invalid input.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear textbox and label
            txtPhoneNumber.Text = "";
            lblTranslated.Text = "";

            // Set focus back to textbox
            txtPhoneNumber.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
