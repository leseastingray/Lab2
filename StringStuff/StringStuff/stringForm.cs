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
            // Declare array.
            char[] switched = new char[input.Length];

            // For each letter in the array, less than the length of the array
            // and incremented
            //    if char is lowercase
            //          change to uppercase
            //    else if char is uppercase
            //          change to lowercase
            // return as string output
            for (int letter = 0; letter < input.Length; letter++)
            {
                if (char.IsLower(input[letter]))
                {
                    switched[letter] = char.ToUpper(input[letter]);
                }
                else if (char.IsUpper(input[letter]))
                {
                    switched[letter] = char.ToLower(input[letter]);
                }
            }
            string output = new string(switched);
            return output;
        }

        private string Reverse(string input)
        {
            // Declare variables and array
            int i, j;
            int inLen = input.Length;
            char[] reversed = new char[inLen];

            // Beginning at index i (array length minus 1) and index j(array[0],
            // less than inLen, i decremented and j incrememented
            //     assign input decremented to reversed array
            // return as string output
            for (i = inLen - 1, j = 0; j < inLen; i--, j++)
            {
                reversed[j] = input[i];
            }
            string output = new string(reversed);
            return output;
        }

        private string PigLatin(string input)
        {
            // Declare variables
            string pigLatin;
            char letter;

            // Assign value of first element(letter) to variable
            letter = input[0];

            // Remove the first letter
            pigLatin = input.Remove(0, 1);

            // Add removed letter to the end of the string
            pigLatin = pigLatin + letter.ToString();

            // Add "ay" to the end of that string and return output
            string output = pigLatin.Insert(input.Length, "ay");
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
            reverseTextBox.Text = Reverse(input);
            pigLatinTextBox.Text = PigLatin(input);

        }
    }
}
