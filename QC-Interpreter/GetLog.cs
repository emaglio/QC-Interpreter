using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    // https://www.codeproject.com/Articles/11698/A-Portable-and-Efficient-Generic-Parser-for-Flat-F

                    //validate file
                    var excelApp = new Microsoft.Office.Interop.Excel.Application();
                    excelApp.Visible = false;
                    excelApp.Workbooks.Open(log_path);
                }
                catch (Exception ex)
                {
                    if (ex is System.IO.IOException || ex is ArgumentException)
                    {
                        MessageBox.Show("You have selected the wrong file", "Wrong File!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
