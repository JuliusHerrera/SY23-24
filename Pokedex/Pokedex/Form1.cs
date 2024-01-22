using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex
{
    enum attack
    {
        Special_Attack, Special_Defense, Attack, Defense
    }
    struct Pokemon
    {
        string name;
        string type;
        string level;
        attack attacktype;
        int hp;
        int exp;
        bool legendary;
        bool shiny;
        int generation;
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Pokemon.txt")) ;
            {
                StreamReader inFile = new StreamReader("Pokemon.txt");
                string s = inFile.ReadToEnd();
                inFile.Close();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DebugTB.Clear();
            DebugTB.Text += NameTB.Text;
            DebugTB.Text += " | ";
            DebugTB.Text += TypeTB.Text;
            DebugTB.Text += " | ";
            DebugTB.Text += LevelTB.Text;
            DebugTB.Text += " | ";
            DebugTB.Text += GenNumericUpDown.Value;
            DebugTB.Text += " | ";
            DebugTB.Text += HpNumericUpDown.Value;
            DebugTB.Text += " | ";
            DebugTB.Text += ExpNumericUpDown.Value;
            DebugTB.Text += " | ";
            DebugTB.Text += AttackcomboBox.Text;
            DebugTB.Text += " | ";
            if (LegendaryCheckBox.Checked == true)
            {
                DebugTB.Text += LegendaryCheckBox.Text;
            }
            DebugTB.Text += " | ";
            if (ShinyCheckBox.Checked == true)
            {
                DebugTB.Text += ShinyCheckBox.Text;
            }
            StreamWriter outfile = new StreamWriter("Pokemon.txt");
            outfile.WriteLine(DebugTB.Text);
            outfile.Close();
        }
    }
}
