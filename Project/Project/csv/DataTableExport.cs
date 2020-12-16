using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.csv
{
    //egy adattábla létrehozása
    public static class OperationsUtility
    {
        public static DataTable CreateDataTable()
        {
            DataTable table = new DataTable();
            //columns  
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("City", typeof(string));

            //data  
            table.Rows.Add(1, "Feri", "Budapest");
            table.Rows.Add(2, "Jenci", "Budapest");
            table.Rows.Add(3, "Roli", "Budapest");
            table.Rows.Add(4, "Csani", "Budapest");
            table.Rows.Add(5, "Karcsi", "Budapest");
            table.Rows.Add(6, "Bence", "Budapest");
            table.Rows.Add(7, "Bazsi", "Budapest");
            table.Rows.Add(8, "Cecil", "Budapest");

            return table;
        }
    }
}
