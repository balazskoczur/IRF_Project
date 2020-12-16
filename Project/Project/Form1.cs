using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            XmlTextReader reader = new XmlTextReader("dataDec-15-2020.xml");
            while (reader.Read())
            {
                Console.WriteLine(reader.Name);
            }
            Console.ReadLine();
        }
    }
}
