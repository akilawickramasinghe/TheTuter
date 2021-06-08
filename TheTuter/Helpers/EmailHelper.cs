using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using TheTuter.DTO;

namespace TheTuter.Helper
{
    public class EmailHelper
    {

        #region properties
        private string _to { get; set; }
        private string _from { get; set; }
        private string _subject { get; set; }
        private string _plainTextMesage { get; set; }
        private string _htmlMessage { get; set; }
        private string _replyTo { get; set; }
        private string _pdf { get; set; }
        #endregion

        /// <summary>
        /// Email send
        /// </summary>
        /// <param name="to"></param>
        /// <param name="from"></param>
        /// <param name="subject"></param>
        /// <param name="plainTextMesage"></param>
        /// <param name="htmlMessage"></param>
        /// <param name="replyTo">Optional</param>   
        public EmailHelper(string to, string from, string subject, string plainTextMesage, string htmlMessage, string replyTo = null, string pdf = null)
        {
            _to = to;
            _from = from;
            _subject = subject;
            _plainTextMesage = plainTextMesage;
            _replyTo = replyTo;
            _pdf = pdf;
            _htmlMessage = htmlMessage;

        }
        public EmailHelper()
        {

        }

        public async Task<bool> SendEmailAsync(EmailDetailsDTO emailDetailsDTO)
        {
            try
            {
                EmailSender objEmailSender = new EmailSender();
                bool result = await objEmailSender.SendEmailAsync(emailDetailsDTO, _to, _from, _subject, _plainTextMesage, _htmlMessage, _replyTo);
                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error:" + ex.Message);
                return false;
            }
        }
    }

    public class EmailSender
    {
        public EmailSender()
        {
        }
        public async Task<bool> SendEmailAsync(EmailDetailsDTO emailDetailsDTO, string to, string from,
                                               string subject, string plainTextMessage, string htmlMessage,
                                               string replyTo = null, string pdf = null)
        {

            bool hasPlainText = !string.IsNullOrWhiteSpace(plainTextMessage);
            bool hasHtml = !string.IsNullOrWhiteSpace(htmlMessage);
            var message = new MimeMessage();

            #region Argument Exceptions
            if (string.IsNullOrWhiteSpace(to))
            {
                throw new ArgumentException("no To address provided");
            }
            if (string.IsNullOrWhiteSpace(from))
            {
                throw new ArgumentException("no from address provided");
            }
            if (string.IsNullOrWhiteSpace(subject))
            {
                throw new ArgumentException("no subject provided");
            }
            if (string.IsNullOrWhiteSpace(to))
            {
                throw new ArgumentException("no message provided");
            }
            #endregion

            message.From.Add(new MailboxAddress("", from));
            if (!string.IsNullOrWhiteSpace(replyTo))
            {
                message.ReplyTo.Add(new MailboxAddress("", replyTo));
            }
            message.To.Add(new MailboxAddress("", to));
            message.Subject = subject;


            BodyBuilder bodyBuilder = new BodyBuilder();
            if (hasPlainText)
            {
                bodyBuilder.TextBody = plainTextMessage;
            }
            if (hasHtml)
            {
                bodyBuilder.HtmlBody = htmlMessage;
            }

            //bodyBuilder.Attachments.Add(pdf);

            message.Body = bodyBuilder.ToMessageBody();

            try
            {
                using (SmtpClient client = new SmtpClient())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                    await client.ConnectAsync(
                        emailDetailsDTO.Server,
                        emailDetailsDTO.Port,
                        SecureSocketOptions.StartTlsWhenAvailable).ConfigureAwait(true);

                    // XOAUTH2 authentication mechanism.
                    client.AuthenticationMechanisms.Remove("XOAUTH2");

                    if (emailDetailsDTO.RequiresAuthentication)
                    {
                        await client.AuthenticateAsync(emailDetailsDTO.User, emailDetailsDTO.Password)
                                    .ConfigureAwait(false);
                    }
                    await client.SendAsync(message).ConfigureAwait(false);
                    await client.DisconnectAsync(true).ConfigureAwait(false);
                    return true;
                }
            }
            catch (Exception ex)
            { 
                throw ex;
            }
        }
    }
}
