using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using wd.Time.Tables;
using Core.DAL;
using TimeCommander2.Helpers;

namespace TimeCommander2
{
    public partial class ExportForm : Form
    {
        public ExportForm()
        {
            InitializeComponent();
            deStart.DateTime = DateTime.Now.AddDays(-30);
            deEnd.DateTime = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog()== DialogResult.OK)
            {
                if (DataAdapter.ExportToExcel<ReportEntry>(saveFileDialog1.FileName, "Data", ReportEntry.GetList(deStart.DateTime, deEnd.DateTime)))
                    MessageBox.Show("Filen har skapats...");
                else
                    MessageBox.Show("Något gick fel och filen kan vara korrupt");
            }
            
        }
    }
}
