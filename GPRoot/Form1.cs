using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GPRoot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string convertPassword(string pass)
        {
            string[,] lookupTable =
            {
                {"a", "b"}, {"b", "c"}, {"c", "e"}, {"d", "g"}, {"e", "h"}, {"f", "n"}, {"g", "i"}, {"h", "j"}, {"i", "d"}, {"j", "k"}, {"k", "a"}, {"l", "l"}, {"m", "m"},
                {"n", "p"}, {"o", "r"}, {"p", "o"}, {"q", "f"}, {"r", "s"}, {"s", "t"}, {"t", "u"}, {"u", "q"}, {"v", "w"}, {"w", "x"}, {"x", "y"}, {"y", "z"}, {"z", "v"},
                {"A", "B"}, {"B", "C"}, {"C", "E"}, {"D", "G"}, {"E", "H"}, {"F", "N"}, {"G", "I"}, {"H", "J"}, {"I", "D"}, {"J", "K"}, {"K", "A"}, {"L", "L"}, {"M", "M"},
                {"N", "P"}, {"O", "R"}, {"P", "O"}, {"Q", "F"}, {"R", "S"}, {"S", "T"}, {"T", "U"}, {"U", "Q"}, {"V", "W"}, {"W", "X"}, {"X", "Y"}, {"Y", "Z"}, {"Z", "V"},
                {"0", "1"}, {"1", "9"}, {"2", "2"}, {"3", "6"}, {"4", "3"}, {"5", "4"}, {"6", "7"}, {"7", "5"}, {"8", "0"}, {"9", "8"}
            };

            string temp = pass;
            int i, j;

            for (i = 0; i < pass.Length; i++)
            {
                for (j = 0; j < lookupTable.GetLength(0); j++)
                {
                    if (pass[i].ToString().Equals(lookupTable[j, 0]))
                    {
//                        temp[i] = lookupTable[j, 1];
//                        temp = temp.Substring(0, i - 1) + lookupTable[j, 1] + temp.Substring(i + 1, temp.Length - i + 2);
                        temp = temp.Remove(i, 1).Insert(i, lookupTable[j, 1]);
                        break;
                    }
                }
            }

            return temp;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = convertPassword(textBox1.Text);
        }
    }
}
