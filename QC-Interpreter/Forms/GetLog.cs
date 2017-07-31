using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenericParsing;
using System.Collections;

namespace QC_Interpreter
{
    public partial class GetLog : Form
    {
        //GetLog variable
        string log_path;
        DataSet results;
        Hashtable test_list = new Hashtable();

        public GetLog()
        {
            InitializeComponent();
        }

        private void open_file_Click(object sender, EventArgs e)
        {
            DialogResult result = openQCLog.ShowDialog();
            if (result == DialogResult.OK)
            {
                log_path = openQCLog.FileName;

                try
                {
                    using (GenericParserAdapter parser = new GenericParserAdapter(log_path))
                    {
                        parser.ColumnDelimiter = ',';
                        parser.TextQualifier = null;

                        results = parser.GetDataSet();
                        List<string> tests = new List<string> { "Calibrate_Scale", "Calibrate_TV", "Autorun", "Volume", "Analyze_Hardware", "Scale_Check", "Mass" };
                        

                        int num_rows = results.Tables[0].Rows.Count;

                        for (int i = 0; i < num_rows; i++)
                            foreach(string test in tests)
                                if (("Export_QC_Test_" + test) == results.Tables[0].Rows[i][0].ToString()){
                                    test_list.Add(test, i+2);
                                }

                        if(tests.Count != test_list.Count)
                            foreach (string test in tests)
                                if (!test_list.ContainsKey(test))
                                {
                                    throw new Exception("\nExpecting to find '" + test + "' in the file but it has not been found.\n" +
                                       "Make sure you are selecting a QC result file for Bod Pod or Pea Pod and try again!");
                                }
                    }

                    //elaborate data
                    var dataEstrapolation = new Utility.DataEstrapolation(results, test_list);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong while opening the file.\nHere the full error message: " + ex.Message, "Error in opening the file", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
