using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using Core.DAL;

namespace TimeCommander2
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        public Helpers.Configuration CurrentConfig;

        private void Settings_Load(object sender, EventArgs e)
        {
            CurrentConfig = new TimeCommander2.Helpers.Configuration();

            cbWindows7.Checked = CurrentConfig.UseWindows7;
            int userid = CurrentConfig.UserId;
            /*
            string suserid = ConfigurationManager.AppSettings["userid"];
            string sw7 = ConfigurationManager.AppSettings["w7"];
            int userid = 8;
            if (!string.IsNullOrEmpty(sw7))
                cbWindows7.Checked = bool.Parse(sw7);
            if (!string.IsNullOrEmpty(suserid))
                userid = int.Parse(suserid);
            */
            cbUser.Items.Clear();
            DataSet sqlGetUsers = DataAdapter.sqlGetDS("SELECT * FROM EntryUsers");
            foreach (DataRow dr in sqlGetUsers.Tables[0].Rows)
            {
                TimeCommander2.TimeApp.User u = new TimeCommander2.TimeApp.User(dr);
                cbUser.Items.Add(u);
                //cbCurrentUser.
                if (userid == u.UserId)
                    cbUser.SelectedItem = u;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings["userid"].Value = ((TimeCommander2.TimeApp.User)cbUser.SelectedItem).UserId.ToString();
            config.AppSettings.Settings["w7"].Value = cbWindows7.Checked.ToString(); 
            config.Save();*/
            CurrentConfig.Save();
        }
    }
}
