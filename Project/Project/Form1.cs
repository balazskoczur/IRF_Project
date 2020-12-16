using Project.csv;
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
            this.BackColor = Color.FromArgb(18, 176, 176);
            //datagrid forrás beállítás
            DataTable dt = OperationsUtility.CreateDataTable();
            dataGridView1.DataSource = dt;

            //TIMER beállítások
            timer1.Interval = 5000;
            timer1.Enabled = true;


        }




        //XML olvasó
        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("C:/Users/balaz/source/repos/IRF_Project/Project/Project/xml/dataDec-15-2020.xml");
            ds.WriteXml("test.xlsx");
        }


        //CSV Export
        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = OperationsUtility.CreateDataTable();
            dt.ToCSV("test2.csv");
        }




        //TIMER
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(rnd.Next(1, 256), rnd.Next(1, 256), rnd.Next(1, 256));
        }
    }
}
