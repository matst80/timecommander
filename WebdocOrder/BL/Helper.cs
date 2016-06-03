using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebdocOrder
{
    public static class Helper
    {

        public static void SendOrderAcceptMail(ProjectOrder po)
        {
            ContactPerson cp = new ContactPerson(po.ContactId);
            string body = "För att kontrollera och godkänna denna beställning kan du klicka på denna länk.\n\n" +
                "Länk:\nhttp://webdoc.nu/approveorder?q=" + po.LinkGuid + "\n\nOm du har några frågor finns kontaktformulär och kontaktuppgifter på länken...\n\n" +
                "Med vänliga hälsningar\nWebdoc Systems AB";
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.From = new System.Net.Mail.MailAddress("order@webdoc.nu","Webdoc ordersystem");
            msg.To.Add(new System.Net.Mail.MailAddress(cp.Email)); 
            msg.Subject = "Beställning '" + po.Title + "' från Webdoc";
            msg.Body = body;
            
            msg.IsBodyHtml = false;
            System.Net.Mail.SmtpClient sc = new System.Net.Mail.SmtpClient("mailrelay.webdoc.nu");
            sc.Send(msg);
            //throw new NotImplementedException();
        }
    }
}
