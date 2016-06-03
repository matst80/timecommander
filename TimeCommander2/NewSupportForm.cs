using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using TimeCommander2.Support;

namespace TimeCommander2
{
    public partial class NewSupportForm : Form
    {
        public NewSupportForm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Support.SupportEntry se = new TimeCommander2.Support.SupportEntry();
            se.Added = DateTime.Now;
            se.Site = cbSite.Text;
            //se.AssignTo = cbAssignedTo.Text;
            se.UserName = "All";
            se.UserEmail = cbEmail.Text;
            se.Title = tTitle.Text;
            se.Entry = tDescription.Text;
            se.Status = 0;
            se.EntryType = 0;
            se.Id = int.Parse(se.Save().ToString());

            string msg = "Hi! A new support entry has been created from webdoc.\n\n\n\nfollow this link for more information http://support.wd6.se/supportList.aspx?Site=" + se.Site + "&UserName=" + se.UserName + "&id=" + se.Id + "\n\nGreetings from WebDocs Support";
            MailMessage message = new MailMessage("Support@webdoc.nu", se.UserEmail, "New support entry: " + se.Title, msg);
            SmtpClient client = new SmtpClient("mailrelay.webdoc.nu");
            //client.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials;
            client.Send(message);
        }

        public void enumSites()
        {
            cbSite.Properties.Items.Clear();
            foreach (string s in SupportEntry.ListAllSites())
            {
                if (!string.IsNullOrEmpty(s.Trim()))
                    cbSite.Properties.Items.Add(s);
            }
        }

        public void enumEmails(string com)
        {
            cbEmail.Properties.Items.Clear();
            foreach (string s in SupportEntry.ListAllEmailsOnSite(com))
            {
                if (!string.IsNullOrEmpty(s.Trim()))
                    cbEmail.Properties.Items.Add(s);
            }
        }

        private void NewSupportForm_Shown(object sender, EventArgs e)
        {
            enumSites();
        }

        private void cbSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            enumEmails(cbSite.Text);
        }
    }
}
