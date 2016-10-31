using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.CustomDataSource;
using Core.DAL;
using Core.WebShop;
using Core.WebShop.ShopHelper;

namespace WebdocOrder
{
    public static class Helper
    {

        public static int[] Prices = new[] { 950, 850, 700, 1100 };

        public static List<IOrder> GenerateOrders()
        {
            var ret = new List<IOrder>();
            foreach (var customerDebRows in dbBase.GetList<NewEntryReport>().GroupBy(d => d.CustomerNr))
            {
                var customer = CustomerHelper.GetCustomerByCustomerId(customerDebRows.FirstOrDefault().CustomerNr);
                Invoice i = new Invoice();
                i.SendDate = DateTime.Now;
                i.CustomerId = customer.Id;
                i.Save();
                foreach (var debRow in customerDebRows)
                {
                    i.AddArticle(ConvertRow(debRow, Prices[customer.PriceList]));
                    debRow.InvoiceId = i.Id;
                    debRow.Save();
                }


            }


            return ret;
        }

        private static IOrderArticle ConvertRow(NewEntryReport debRow, float customerHourPrice)
        {
            var ret = new BaseOrderArticle();
            ret.Title = debRow.Title;
            ret.Price = (int)Math.Max((debRow.EndTime - debRow.EventTime).TotalMinutes, 30) * (customerHourPrice / 60);
            return ret;
        }

        public static void SendOrderAcceptMail(ProjectOrder po)
        {
            ContactPerson cp = new ContactPerson(po.ContactId);
            string body = "För att kontrollera och godkänna denna beställning kan du klicka på denna länk.\n\n" +
                "Länk:\nhttp://webdoc.nu/approveorder?q=" + po.LinkGuid + "\n\nOm du har några frågor finns kontaktformulär och kontaktuppgifter på länken...\n\n" +
                "Med vänliga hälsningar\nWebdoc Systems AB";
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.From = new System.Net.Mail.MailAddress("order@webdoc.nu", "Webdoc ordersystem");
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
