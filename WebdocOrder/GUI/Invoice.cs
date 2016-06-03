using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.DAL;
using System.Diagnostics;
using System.IO;

namespace WebdocOrder.GUI
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            object lastId = DataAdapter.sqlGetSingle("SELECT MAX(Id) FROM Invoice");
            if (lastId is DBNull || lastId == null || (int)lastId == 0)
            {
                NewInvice();
            }
            else
            {
                CurrentInvoiceId = (int)lastId;
                MessageBox.Show("Current invoice ID:" + CurrentInvoiceId);
            }
            EnumData();

        }

        private void NewInvice()
        {
            WebdocOrder.Invoice i = new WebdocOrder.Invoice();
            i.StartTime = DateTime.Now.AddDays(-14);
            i.EndTime = DateTime.Now;
            CurrentInvoiceId = int.Parse(i.Save().ToString());
            MessageBox.Show("Current invoice ID:"+CurrentInvoiceId);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            EnumData();
        }

        private void EnumData()
        {
            this.newEntryTableAdapter.Fill(this.wdintranetDataSet.NewEntry);
        }

        public int CurrentInvoiceId=1;

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            List<string> ids = new List<string>();
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                object o = dr.Cells["doInvoice"].Value;
                if (o!=null && (bool)o)
                    ids.Add(dr.Cells["colId"].Value.ToString());
            }
            MessageBox.Show("Antal rader:"+ids.Count);
            string sql = "UPDATE NewEntry SET InvoiceId=" + CurrentInvoiceId + " WHERE Id in (" + string.Join(",", ids.ToArray()) + ")";
            DataAdapter.sqlExec(sql);
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            SumTotal();
        }

        private void SumTotal()
        {
            double total = 0;
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                if (dr.Cells["HourCost"].Value != null && dr.Cells["DebTime"].Value != null)
                {
                    int hc = (int)dr.Cells["HourCost"].Value;
                    int min = (int)dr.Cells["DebTime"].Value;
                    float h = ((float)min / 60);
                    total += (h * hc);
                }
            }
            tslTotal.Text = "Totalt värde:" + total;
        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {
            SumTotal();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SumTotal();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            string filename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\wd_invoice_"+CurrentInvoiceId+"_"+DateTime.Now.ToShortDateString()+".xls";
            //List<NewEntryReport> rep = NewEntryReport.GetCustomList<NewEntryReport>("SELECT * FROM NewEntryReport WHERE InvoiceId=" + CurrentInvoiceId);
            if (File.Exists(filename))
                if (MessageBox.Show("Faktura för denna dag och detta faktura nummer finns redan!", "Skriva över", MessageBoxButtons.YesNo)== System.Windows.Forms.DialogResult.Yes)
                {
                    File.Delete(filename);
                }
                else
                    return;
            ExcelLibrary.DataSetHelper.CreateWorkbook(filename, DataAdapter.sqlGetDS("SELECT * FROM NewEntryReport WHERE InvoiceId=" + CurrentInvoiceId + " ORDER BY CustomerName,EntryTitle"));
            if (File.Exists(filename))
            {
                Process p = new Process();
                p.StartInfo.FileName = filename;
                p.Start();
            }
            else
                MessageBox.Show("Filen gick inte att generera!");
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            NewInvice();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {

                DataGridViewCheckBoxCell dc = (DataGridViewCheckBoxCell)dr.Cells["doInvoice"];
                object v = dc.Value;
                dc.Value = (v==null || !(bool)v)?true:false;
            }
        }

        private void markeraAllaFrånDennaKundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                
                string orgname = (string)dataGridView1.Rows[cell.RowIndex].Cells["CustomerName"].Value;

                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    string cname = (string)dr.Cells["CustomerName"].Value;

                    DataGridViewCheckBoxCell dc = (DataGridViewCheckBoxCell)dr.Cells["doInvoice"];

                    if (cname == orgname)
                        dc.Value = true;
                }
            }
        }
    }
}
