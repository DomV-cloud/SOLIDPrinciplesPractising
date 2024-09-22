namespace SOLIDPrinciplesPractising.UNSOLID.DIP
{
    public class SmtpClient
    {
        public void Send(string message)
        {
            Console.WriteLine($"I am sending email: {message}");
        }
    }

    public class EmailService
    {
        private readonly SmtpClient _smtpClient;

        public EmailService()
        {
            _smtpClient = new SmtpClient();
        }

        public void SendEmail(string message)
        {
            _smtpClient.Send(message);
        }
    }
}
