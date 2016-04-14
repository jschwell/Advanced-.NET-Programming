using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Email_Address_Book
{
    public partial class MainForm : Form
    {
        // Field to hold a list of PersonEntry objects.
        List<PersonEntry> addressList = new List<PersonEntry>();

        // Static fields
        public static string name;
        public static string email;
        public static string phone;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Read the AddressBook.txt file.
            ReadFile();

            // Display the names.
            DisplayNames();
        }

        private void ReadFile()
        {
            try
            {
                StreamReader inputFile; 
                string line;

                // Create a delimiter array.
                char[] delim = { ',' };

                // Open the AddressBook file.
                inputFile = File.OpenText("Addresses.txt");

                while (!inputFile.EndOfStream)
                {
                    // Read a line from the file.
                    line = inputFile.ReadLine();

                    // Tokenize the line.
                    string[] tokens = line.Split(delim);

                    // Create a PersonEntry object.
                    PersonEntry entry = new PersonEntry();

                    // Store the tokens in the entry object.
                    entry.Name = tokens[0];
                    entry.Email = tokens[1];
                    entry.Phone = tokens[2];

                    // Add the entry to the List.
                    addressList.Add(entry);
                }
            }
            catch (Exception ex)
            {
                // Display an error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayNames()
        {
            // Display each person's name.
            foreach (PersonEntry entry in addressList)
            {
                lbAddressBook.Items.Add(entry.Name);
            }
        }

        private void lbAddressBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the index of the selected item.
            int index = lbAddressBook.SelectedIndex;

            // Get selected object properties.
            name = addressList[index].Name;
            email = addressList[index].Email;
            phone = addressList[index].Phone;

            // Create an instance of the EntryForm class.
            EntryForm myEntryForm = new EntryForm();

            // Display the form.
            myEntryForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
