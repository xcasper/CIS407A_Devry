using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// namespace used to send electronic mail to a SMTP server for delivery
using System.Net.Mail;

/// <summary>
/// Summary description for clsBusinessLayer
/// </summary>
public class clsBusinessLayer
{
    public static bool SendEmail(string Sender, string Recipient, string bcc, string cc,
    string Subject, string Body)
    {
        try 
        {
            //Declares and instantiates new MailMessage 
            MailMessage MyMailMessage = new MailMessage();

            //Sets the from part of the email
            MyMailMessage.From = new MailAddress(Sender);

            //adds a recipient to the message
            MyMailMessage.To.Add(new MailAddress(Recipient));

            //Checks for a bcc
            if (bcc != null && bcc != string.Empty) {
            //adds bcc recipient to the message
            MyMailMessage.Bcc.Add(new MailAddress(bcc));
            }

            //Checks for a cc
            if (cc != null && cc != string.Empty) {
            //adds cc recipient to the message
            MyMailMessage.CC.Add(new MailAddress(cc));
            }

            //Sets the subject of the message
            MyMailMessage.Subject = Subject;

            //Sets the text of the body of the message
            MyMailMessage.Body = Body;

            //Indicates that the message body is in html
            MyMailMessage.IsBodyHtml = true;

            //Sets the message priority level
            MyMailMessage.Priority = MailPriority.Normal;

            //Declares and instantiates a new SMTPClient
            SmtpClient MySmtpClient = new SmtpClient();

            //Sets the SMTP to the used port and host for the SMTP client
            MySmtpClient.Port = 25;
            MySmtpClient.Host = "127.0.0.1";

            //Sends the message to the SMTPClient for delivery
            MySmtpClient.Send(MyMailMessage);

            //returns true showing that the block of code, in the try, worked
            return true;
        } catch (Exception ex) {

        //returns false showing that the block of code, in the try, failed
        return false;
        }

    }
	public clsBusinessLayer()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}