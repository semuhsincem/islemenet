using Helper.Constants;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Helper
{
    public static class EmailHelper
    {
        public static void SendMail(string to, string Subject , string Body,bool isHtml=true)
        {
            try
            {
                SmtpClient sc = new SmtpClient();
                sc.Port = 587;
                sc.Host = "smtp.gmail.com";
                sc.EnableSsl = true;
                sc.UseDefaultCredentials = false;
                sc.Credentials = new NetworkCredential("se.muhsincem@gmail.com", "05327205477");

                MailMessage mail = new MailMessage();

                mail.From = new MailAddress("support@cncxportal.com", ConstantHelper.PlatformName);

                mail.To.Add(to);

                mail.Subject = Subject;
                mail.IsBodyHtml = isHtml;
                mail.Body = Body;


                sc.Send(mail);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
