using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QC_Interpreter.Utility
{
    class DataEstrapolation
    {
        public DataEstrapolation(DataSet result, Hashtable test_list)
        {
            data = result;
            tests = test_list;
            GetTables();

        }

        DataSet data;
        Hashtable tests;
        Hashtable tables = new Hashtable();

        // for each test in the list get the associated table and add it in the tables hash
        private void GetTables()
        {
            var newData = data.Tables[0].Clone();
            foreach (DictionaryEntry test in tests)
            {
                DataTable temp = new DataTable(test.Key.ToString());
                for(int i=0; i < newData.Rows.Count; i++)
                {
                    if(i > (int)test.Value)
                    {
                        if(newData.Rows[i][0].ToString() == "")
                        {
                            break;
                        }
                        temp.ImportRow(newData.Rows[i]);
                        temp.AcceptChanges();
                    }
                }
                tables.Add((string)test.Key, temp);
            }

        }
    }
}
