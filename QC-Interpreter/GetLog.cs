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

namespace QC_Interpreter
{
    public partial class GetLog : Form
    {
        //GetLog variable
        string log_path;

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

                        var results = parser.GetDataSet();
                        List<string> test_list = new List<string> { "Calibrate_Scale", "Calibrate_TV", "Autorun", "Volume", "Analyser_Hardware", "Scale_Check" };
                        int num_rows = results.Tables[0].Rows.Count;
                        var some = test_list.Find(x => x == "Calibrate_Scale");
                        var some2 = test_list.Find(x => x == "Stocazzo");
                        for (int i = 0; i < num_rows; i++)
                            test_list.Find(x => x == results.Tables[0].Rows[0][i].ToString());
                            if (results.Tables[0].Rows[0] != "Export QC Results")
                            {
                                throw new Exception("\nExpecting to find 'Export QC Results' in the first cell of the file but it has not been found.\n" +
                                   "Make sure you are selecting a QC result file for Bod Pod or Pea Pod and try again!");
                            }
                    }
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
