using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            label2.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'a':
                    label1.Text += "j";
                    break;
                case 'b':
                    label1.Text += "g";
                    break;
                case 'c':
                    label1.Text += "-";
                    break;
                case 'd':
                    label1.Text += "0";
                    break;
                case 'e':
                    label1.Text += "9";
                    break;
                case 'f':
                    label1.Text += "8";
                    break;
                case 'g':
                    label1.Text += "7";
                    break;
                case 'h':
                    label1.Text += "6";
                    break;
                case 'i':
                    label1.Text += "5";
                    break;
                case 'j':
                    label1.Text += "4";
                    break;
                case 'k':
                    label1.Text += "3";
                    break;
                case 'l':
                    label1.Text += "2";
                    break;
                case 'm':
                    label1.Text += "e";
                    break;
                case 'n':
                    label1.Text += "w";
                    break;
                case 'o':
                    label1.Text += "q";
                    break;
                case 'p':
                    label1.Text += "'";
                    break;
                case 'q':
                    label1.Text += "/";
                    break;
                case 'r':
                    label1.Text += ".";
                    break;
                case 's':
                    label1.Text += "`";
                    break;
                case 't':
                    label1.Text += "m";
                    break;
                case 'u':
                    label1.Text += "n";
                    break;
                case 'v':
                    label1.Text += "b";
                    break;
                case 'w':
                    label1.Text += "v";
                    break;
                case 'x':
                    label1.Text += "c";
                    break;
                case 'y':
                    label1.Text += "x";
                    break;
                case 'z':
                    label1.Text += "z";
                    break;
                default:
                    break;
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'j':
                    label1.Text += "a";
                    break;
                case 'g':
                    label1.Text += "b";
                    break;
                case '-':
                    label1.Text += "c";
                    break;
                case '0':
                    label1.Text += "d";
                    break;
                case '9':
                    label1.Text += "e";
                    break;
                case '8':
                    label1.Text += "f";
                    break;
                case '7':
                    label1.Text += "g";
                    break;
                case '6':
                    label1.Text += "h";
                    break;
                case '5':
                    label1.Text += "i";
                    break;
                case '4':
                    label1.Text += "j";
                    break;
                case '3':
                    label1.Text += "k";
                    break;
                case '2':
                    label1.Text += "l";
                    break;
                case 'e':
                    label1.Text += "m";
                    break;
                case 'w':
                    label1.Text += "n";
                    break;
                case 'q':
                    label1.Text += "o";
                    break;
                case '`':
                    label1.Text += "p";
                    break;
                case '/':
                    label1.Text += "q";
                    break;
                case 'r':
                    label1.Text += "r";
                    break;
                case '.':
                    label1.Text += "s";
                    break;
                case 'm':
                    label1.Text += "t";
                    break;
                case 'n':
                    label1.Text += "u";
                    break;
                case 'b':
                    label1.Text += "v";
                    break;
                case 'v':
                    label1.Text += "w";
                    break;
                case 'c':
                    label1.Text += "x";
                    break;
                case 'x':
                    label1.Text += "y";
                    break;
                case 'z':
                    label1.Text += "z";
                    break;
                default:
                    break;
            }
        }
    }
}
