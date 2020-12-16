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
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 5000;
            timer1.Enabled = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("C:/Users/balaz/source/repos/IRF_Project/Project/Project/xml/dataDec-15-2020.xml");
            ds.WriteXml("test.xml");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.database1DataSet1.Table);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(rnd.Next(1, 256), rnd.Next(1, 256), rnd.Next(1, 256));
        }
    }
}
