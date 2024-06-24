using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MailKit.Search;
using MimeKit;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Runtime.Caching;

namespace MyPaint
{
    public class MailRepository
    {
        public string email, password;
        private string imapServer, smtpServer;
        private int imapPort, smtpPort;
        private bool imapSsl, smtpSsl;

        ImapClient imapClient;
        SmtpClient smtpClient;

        IMailFolder inbox;
        List<MimeMessage> messageList;
        ObjectCache cache = MemoryCache.Default;

        public MailRepository()
        {
            this.imapServer = "imap.gmail.com";
            this.imapPort = 993;
            this.imapSsl = true;
            this.email = "nguyenthanhthaos2004@gmail.com";
            this.password = "pmehdmrxslzduqsh";

            try
            {
                imapClient = new ImapClient();
                imapClient.Connect(imapServer, imapPort, imapSsl);
                imapClient.AuthenticationMechanisms.Remove("XOAUTH2");
                imapClient.Authenticate(email, this.password);

                inbox = imapClient.GetFolder(SpecialFolder.Drafts);
                inbox.Open(FolderAccess.ReadOnly);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void ConnectStmpServer(string smtpServer, int smtpPort, bool smtpSsl)
        {
            if (this.smtpServer != smtpServer || this.smtpPort != smtpPort || this.smtpSsl != smtpSsl)
            {
                this.smtpServer = smtpServer;
                this.smtpPort = smtpPort;
                this.smtpSsl = smtpSsl;

                try
                {
                    if (smtpClient != null && smtpClient.IsConnected) smtpClient.Disconnect(true);
                    smtpClient = new SmtpClient();
                    smtpClient.Connect(smtpServer, smtpPort, imapSsl);
                    smtpClient.Authenticate(email, password);
                }
                catch (Exception error) { MessageBox.Show(error.Message); }
            }
        }

        public void SendMail(string subject, string body, string to)
        {
            MimeMessage message = new MimeMessage();
            message.From.Add(MailboxAddress.Parse(email));
            message.To.Add(MailboxAddress.Parse(to));
            message.Subject = subject;

            TextPart textPart = new TextPart(MimeKit.Text.TextFormat.Html);
            textPart.Text = body;
            message.Body = textPart;

            smtpClient.Send(message);
        }
    }
}
