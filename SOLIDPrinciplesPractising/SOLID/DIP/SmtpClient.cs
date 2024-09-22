namespace SOLIDPrinciplesPractising.SOLID.DIP
{
    public class SmtpClient : ISmtpClientService
    {
        public void Send(string message)
        {
            Console.WriteLine($"I am sending email: {message}");
        }
    }

    public interface ISmtpClientService
    {
        void Send(string message);
    }

    public class EmailService
    {
        private readonly ISmtpClientService _smtpClient;

        public EmailService(ISmtpClientService smtpClient)
        {
            _smtpClient = smtpClient;
        }

        public void SendEmail(string message)
        {
            _smtpClient.Send(message);
        }
    }
}
