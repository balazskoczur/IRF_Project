using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.csv
{
    public static class OperationsUtility
    {
        public static DataTable CreateDataTable()
        {
            DataTable table = new DataTable();
            //columns  
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Név", typeof(string));
            table.Columns.Add("Város", typeof(string));

            //data  
            table.Rows.Add(111, "Feri", "Budapest");
            table.Rows.Add(222, "Józsi", "Budapest");
            table.Rows.Add(102, "Roli", "Budapest");
            table.Rows.Add(212, "Csanád", "Budapest");
            table.Rows.Add(102, "Károly", "Budapest");
            table.Rows.Add(212, "Bence", "Budapest");
            table.Rows.Add(102, "Balázs", "Budapest");
            table.Rows.Add(212, "Bálint", "Budapest");

            return table;
        }
    }
}
