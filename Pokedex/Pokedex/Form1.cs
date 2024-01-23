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
        public string name;
        public string type;
        public string level;
        public attack attacktype;
        public int hp;
        public int exp;
        public bool legendary;
        public bool shiny;
        public int generation;
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
                ReadPokemon(s);
                inFile.Close();
            }
        }
        private void ReadPokemon(string s)
        {
            Pokemon p = new Pokemon();
            String[] fields = s.Split('|');
            p.name = fields[0];
            p.type = fields[1];
            p.level = fields[2];
            p.attacktype =(attack)Enum.Parse(typeof(attack), fields[3]);
            p.hp = int.Parse(fields[4]);
            p.exp = int.Parse(fields[5]);
            if (fields[6] == "true")
            {
                p.legendary = true;
            }
            if (fields[7] == "true")
            {
                p.shiny = true;
            }
            p.generation = int.Parse(fields[8]);

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
            DebugTB.Text += AttackcomboBox.Text;
            DebugTB.Text += " | ";
            DebugTB.Text += HpNumericUpDown.Value;
            DebugTB.Text += " | ";
            DebugTB.Text += ExpNumericUpDown.Value;
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
            DebugTB.Text += " | ";
            DebugTB.Text += GenNumericUpDown.Value;
            DebugTB.Text += " | ";
            StreamWriter outfile = new StreamWriter("Pokemon.txt");
            outfile.WriteLine(DebugTB.Text);
            outfile.Close();
        }
    }
}
