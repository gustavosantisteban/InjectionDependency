using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailServices.Services
{
    public class EmailService
    {
        private ILogger logger;
        private SmtpClient client;
        private string sender;

        public EmailService(EmailConfiguration configuration, ILogger logger)
        {
            this.logger = logger;
            InitializerClient(configuration);
            sender = configuration.SenderEmail;
        }

        public void SendEmail(string address, string subject, string body)
        {
            logger.Log("Inicializando");
            var mail = new MailMessage(sender, address);
            mail.Subject = subject;
            mail.Body = body;
            logger.Log("Enviando Mensaje");
            client.Send(mail);
            logger.Log("Mensaje enviado correctamente");
        }

        public void InitializerClient(EmailConfiguration config)
        {
            client = new SmtpClient();
            client.Host = config.SMTPServer;
            client.Port = config.SMTPort;
            client.EnableSsl = true;
            var credentials = new NetworkCredential();
            credentials.UserName = config.SenderEmail;
            credentials.Password = config.SenderPassword;
            client.Credentials = credentials;
        }

    }
}
