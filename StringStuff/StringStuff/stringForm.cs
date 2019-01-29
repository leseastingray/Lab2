using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace String_Stuff
{
    public partial class stringForm : Form
    {
        public stringForm()
        {
            InitializeComponent();
        }

        private string SwitchCase(string input)
        {
            foreach (char letter in input)
            {
                char letter.ToUpper(input[0]);
            }
            string output = "";
            return output;
        }

        private string Reverse(string input)
        {
            string output = "";
            return output;
        }

        private string PigLatin(string input)
        {
            input.Remove(0);
            string output = "";
            return output;
        }

        // Given a string, shift charactters in the alphabet by an integer value
        // Ex: "abcd" ---> "fghi" (that is a shift by 5)
        private string ShiftCypher(string input, int charsToShift)
        {
            string output = "";
            return output;
        }

        // Substitution cypher: substitute each char in the given string with
        // the proper character based on position in the alphabet.
        private string SubCypher(string input, string charsToSub)
        {
            string output = "";
            return output;
        }

        private void transformButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            switchCaseTextBox.Text = SwitchCase(input);

        }
    }
}
