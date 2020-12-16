using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestProject1.Unit_test
{
    public class TanuloTest
    {
        [Fact]
        public void TanuloTestSucces()
        {
            string name = "Béla";
            int age = 20;
            string neptun = "B1TM4N";

            Tanulo student = new Tanulo(name, age, neptun);
            Assert.IsTrue(student.Name == "Béla");
            Assert.IsTrue(student.Age == 20);
            Assert.IsTrue(student.NeptunCode == "B1TM4N");

        }
        [Fact]
        public void TanuloTestException()
        {
            Tanulo student;
            Assert.ThrowsException<ArgumentException>(() => student = new Tanulo("Cecil", 42, "Cecil.42"));
        }
    }
}
