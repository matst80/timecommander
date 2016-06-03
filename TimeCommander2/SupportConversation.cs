using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Net.Mail;

namespace TimeCommander2
{
    public partial class SupportConversation : Form
    {

        public int EntryId;

        public TimeApp ParentForm;

        public void enumText()
        {
            List<string> strings = new List<string>();
            foreach (Support.SupportComment cmt in Support.Helper.GetCommentsByEntry(EntryId))
	        {
                strings.Add("\n\r"+cmt.UserName + "("+cmt.Date.ToShortDateString()+") : " + cmt.Entry + "\n\r");
	        }
            richTextBox1.Lines = strings.ToArray();
        }

        public SupportConversation()
        {
            InitializeComponent();
        }

        public Support.SupportEntry Entry;

        protected override void OnShown(EventArgs e)
        {
            if (EntryId > 0)
            {
                //foreach (TimeCommander2.TimeApp.User s in ParentForm.cbCurrentUser.Items)
                //{
                //    lAssign.Items.Add(s.Username);
                //}
                Entry = new Support.SupportEntry(EntryId);
                teUsername.Text = Entry.UserEmail;
                hlSite.Text = Entry.Site;
                hlEmail.Text = Entry.UserEmail;
                teDescription.Text = Entry.Entry;
                lAssign.Text = Entry.AssignTo;
                SetStatus();
                enumText();
            }
            base.OnShown(e);
        }

        private void SetStatus()
        {
            s0.Checked = false;
            s1.Checked = false;
            s2.Checked = false;
            if (Entry.Status == 0)
                s0.Checked = true;
            else if (Entry.Status == 1)
                s1.Checked = true;
            else if (Entry.Status == 2)
                s2.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*SqlConnection conn = new SqlConnection("Data Source=62.20.6.150;Initial Catalog=wdServer;Persist Security Info=True;User ID=sa;Password=kaninbur");

            SqlCommand cmd = conn.CreateCommand();
            conn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM SupportComment WHERE SupportId=" + EntryId + " ORDER BY Date desc";

            string msg = "Hej! \n\n----------------------------------------------\n" + tbMsg.Text + "\n----------------------------------------------\n\nfölj denna länk för mer information http://support.wd6.se/supportList.aspx?UserName=" + ma.AssignTo + "&id=" + ma.Id + "&admin=2%md5salt\n\nHälsningar WebDocs Support";
            MailMessage message = new MailMessage("Support@webdoc.nu", ma.AssignedToEmail, "Kunden har kommenterat supportärendet: " + ma.Title, msg);
            SmtpClient client = new SmtpClient("mailrelay.webdoc.nu");
            //client.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials;
            client.Send(message);
             * */
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bSend_Click(object sender, EventArgs e)
        {
            //Support.SupportComment c = new TimeCommander2.Support.SupportComment();
            //c.SupportId = EntryId;
            //c.Entry = textBox1.Text;
            //c.UserName = ParentForm.cbCurrentUser.Text;
            //c.Date = DateTime.Now;
            //c.Save();
            //enumText();
            //if (cbSendEmail.Checked)
            //{
            //    string msg = "Hi! \n\n----------------------------------------------\n" + textBox1.Text + "\n----------------------------------------------\n\nfollow this link for more information http://support.wd6.se/supportList.aspx?Site=" + Entry.Site + "&UserName=" + Entry.UserName + "&id=" + Entry.Id + "\n\nGreetings from WebDocs Support";
            //    MailMessage message = new MailMessage(ParentForm.cbCurrentUser.Text+ "@webdoc.nu", Entry.UserEmail, "Measures has been done on supportentry: " + Entry.Title, msg);
            //    SmtpClient client = new SmtpClient("mailrelay.webdoc.nu");
            //    //client.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials;
            //    client.Send(message);
                
            //    /*
            //    string msg = "Hej! \n\n----------------------------------------------\n" + textBox1.Text + "\n----------------------------------------------\n\nfölj denna länk för mer information http://support.wd6.se/supportList.aspx?UserName=" + Entry.AssignTo + "&id=" + Entry.Id + "&admin=2%md5salt\n\nHälsningar WebDocs Support";
            //    MailMessage message = new MailMessage("support@webdoc.nu", Entry.UserEmail, "Kunden har kommenterat supportärendet: " + Entry.Title, msg);
            //    SmtpClient client = new SmtpClient("mailrelay.webdoc.nu");
            //    //client.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials;
            //    client.Send(message);*/
            //}
        }

        private void s0_Click(object sender, EventArgs e)
        {
            //Entry.AssignTo = ParentForm.cbCurrentUser.Text;
            //Entry.Status = 0;
            //Entry.Save();
            //SetStatus();
        }

        private void s1_Click(object sender, EventArgs e)
        {
            //Entry.AssignTo = ParentForm.cbCurrentUser.Text;
            //Entry.Status = 1;
            //Entry.Save();
            //SetStatus();
        }

        private void s2_Click(object sender, EventArgs e)
        {
            //Entry.AssignTo = ParentForm.cbCurrentUser.Text;
            //Entry.Status = 2;
            //Entry.Save();
            //SetStatus();
        }

        private void lAssign_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entry.AssignTo = lAssign.Text;
            Entry.Save();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Entry.Site = hlSite.Text;
            Entry.UserEmail = hlEmail.Text;
            Entry.Entry = teDescription.Text;
            Entry.UserName = teUsername.Text;
            Entry.Save();
        }
    }
}
