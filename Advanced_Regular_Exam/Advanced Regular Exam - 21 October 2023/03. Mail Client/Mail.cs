namespace MailClient
{
    public class Mail
    {
        public string Sender { get; private set; }
        public string Receiver { get; private set; }
        public string Body { get; private set; }

        public Mail(string sender, string receiver, string body)
        {
            this.Sender = sender;
            this.Receiver = receiver;
            this.Body = body;
        }

        public override string ToString()
        {
            return $"From: {Sender} / To: {Receiver}\nMessage: {Body}";
        }
    }
}
