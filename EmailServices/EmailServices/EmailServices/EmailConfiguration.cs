using System;
using System.Configuration;

namespace EmailServices
{
    public class EmailConfiguration
    {
        public string SMTPServer
        {
            get { return ConfigurationManager.AppSettings["SmtpServer"]; }
        }
        public int SMTPort
        {
            get {
                var puerto = ConfigurationManager.AppSettings["SmtpPort"];
                return Convert.ToInt32(puerto);
            }
        }
        public string SenderEmail
        {
            get { return ConfigurationManager.AppSettings["SenderEmail"]; }
        }
        public string SenderPassword
        {
            get { return ConfigurationManager.AppSettings["SenderPassword"]; }
        }
    }
}
