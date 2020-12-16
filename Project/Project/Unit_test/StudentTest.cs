using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Project.Unit_test
{
    public class StudentTest
    {
        [Fact]
        public void StudentTestSucces()
        {
            //Megadom a Unit testnek, hogy milyen értékeket vehet fel (jelen esetben Béla, 20, B1TM4N)
            string name = "Béla";
            int age = 20;
            string neptun = "B1TM4N";
            Student student = new Student(name, age, neptun);
            Assert.True(student.Name == "Béla");
            Assert.True(student.Age == 20);
            Assert.True(student.NeptunCode == "B1TM4N");
        }
        [Fact]
        public void StudentTestException()
        {
            //megnézem, hogy a student osztályban megadott szabályok alapján hibát dob-e, hogyha rossz a neptunkód
            Student student;
            Assert.Throws<ArgumentException>(() => student = new Student("Cecil", 42, "Cecil.42"));
        }
    }
}
