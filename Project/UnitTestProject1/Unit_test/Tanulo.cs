using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UnitTestProject1.Unit_test
{
    //tanuló osztály, amit tudok Unit testelni
    public class Tanulo
    {
        public string NeptunCode;
        public string Name;
        public int Age;
        public Tanulo(string name, int age, string neptun)
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
