using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Structures
{
    internal class Program
    {
        struct pokemon
        {
            public int id;
            public string name;
            public int level;
        }
        struct student
        {
            public string name;
            public int age;
            public int grade;
            public gender gender;
            public decimal GPA;
        }
        struct Holidays
        {
        public string name;
            public day day;
        }
        enum gender  {male,female};
        enum day {Mon, Tues, Wed, Thur, Fri, Sat, Sun}
        static void Main(string[] args)
        {
            pokemon pikachu = new pokemon();
            pikachu.name = "Pikachu";
            pikachu.level = 1;
            pikachu.id = 1;
            student Bob=new student();
            Bob.name = "Bob";
            Bob.age = 261;
            Bob.gender = gender.male;
            Bob.grade = 26;
            Bob.GPA = 4;
            Holidays MLK = new Holidays();
            MLK.day = day.Mon;
            MLK.name = "MLK Day";

        }
    }
}
