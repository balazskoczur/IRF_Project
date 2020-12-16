using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project.Unit_test
{
    public class Student
    {
        public string NeptunCode;
        public string Name;
        public int Age;
        public Student(string name, int age, string neptun)
        {
            Name = name;
            Age = age;
            NeptunCode = neptun;

            string pattern = @"[(A-Z)|(0-9)]{6}";
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(neptun) == false)
                throw new ArgumentException();

        }
    }
}
