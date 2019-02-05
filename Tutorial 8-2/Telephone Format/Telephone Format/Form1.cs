using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Telephone_Format
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The NumberDigits method accepts a string argument
        // and returns the number of numeric digits it contains.
        private int NumberDigits(string str)
        {
            int digits = 0;  // The number of digits

            // Count the digits in str.

            // Return the number of digits.
            return digits;
        }

        // The IsValidNumber method accepts a string and
        // returns true if it contains 10 digits, or false
        // otherwise.
        private bool IsValidNumber(string str)
        {
            const int VALID_LENGTH = 10;  // Length of a valid string
            bool valid = true;   // Flag to indicate validity

            // Check length of string to see if it is valid length
            if (str.Length == VALID_LENGTH)
            {
                // Check each character to see if it is a digit
                //     if character is not a digit
                //          not valid
                foreach (char ch in str)
                {
                    if (!char.IsDigit(ch))
                    {
                        valid = false;
                    }
                }
            }
            else
            {
                // Incorrect length, not valid
                valid = false;
            }

            // Return the status.
            return valid;
        }

        // The TelephoneFormat method accepts a string argument
        // by reference and formats it as a telephone number.
        // phone number format is ###-###-####
        private void TelephoneFormat(ref string str)
        {
            // Insert first hyphen
            str = str.Insert(4, "-");
            // Insert second hyphen
            str = str.Insert(8, "-");
        }

        private void formatButton_Click(object sender, EventArgs e)
        {
            // Get a trimmed copy of the user's input.
            string input = numberTextBox.Text.Trim();

            // If the input is a valid number, format it
            // and display it.
            if (IsValidNumber(input))
            {
                TelephoneFormat(ref input);
                MessageBox.Show(input);
            }
            else
            {
                // Display an error message.
                MessageBox.Show("Invalid input");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
