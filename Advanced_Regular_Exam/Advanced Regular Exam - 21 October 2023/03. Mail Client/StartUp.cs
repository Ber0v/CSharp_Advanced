namespace MailClient
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            MailBox mailbox = new MailBox(5);

            Mail mail1 = new Mail("John", "Alice", "Hello Alice, How are you?");
            Mail mail2 = new Mail("Alice", "Bob", "Hi Bob, Here's the document you requested.");
            Mail mail3 = new Mail("Bob", "Charlie", "Hey Charlie, Let's meet for lunch.");
            Mail mail4 = new Mail("Charlie", "David", "Hi David, Can you help me with the project?");
            Mail mail5 = new Mail("David", "Eva", "Hello Eva, Don't forget our meeting tomorrow.");
            Mail mail6 = new Mail("Eva", "Frank", "Hi Frank, I found an interesting article for you.");
            Mail mail7 = new Mail("Frank", "Grace", "Hey Grace, How's your day going?");
            Mail mail8 = new Mail("Grace", "Henry", "Hi Henry, Please review the proposal.");
            Mail mail9 = new Mail("Henry", "Isabella", "Hello Isabella, Let's schedule a call.");
            Mail mail10 = new Mail("Isabella", "John", "Hi John, I received your message. Thanks!");

            mailbox.IncomingMail(mail1);
            mailbox.IncomingMail(mail2);
            mailbox.IncomingMail(mail3);
            mailbox.IncomingMail(mail4);
            mailbox.IncomingMail(mail5);
        }
    }
}