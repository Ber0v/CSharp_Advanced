namespace MailClient
{
    public class MailBox
    {
        private int Capacity { get; set; }
        private List<Mail> Inbox { get; set; }
        private List<Mail> Archive { get; set; }

        public MailBox(int capacity)
        {
            this.Capacity = capacity;
            this.Inbox = new List<Mail>();
            this.Archive = new List<Mail>();
        }

        public void IncomingMail(Mail mail)
        {
            if (Inbox.Count < Capacity)
            {
                Inbox.Add(mail);
            }
        }

        public bool DeleteMail(string sender)
        {
            foreach (var mail in Inbox)
            {
                if (mail.Sender == sender)
                {
                    Inbox.Remove(mail);
                    return true;
                }
            }
            return false;
        }

        public int ArchiveInboxMessages()
        {
            int count = Inbox.Count;
            Archive.AddRange(Inbox);
            Inbox.Clear();
            return count;
        }

        public string GetLongestMessage()
        {
            Mail longestMail = Inbox[0];
            foreach (var mail in Inbox)
            {
                if (mail.Body.Length > longestMail.Body.Length)
                {
                    longestMail = mail;
                }
            }
            return longestMail.ToString();
        }

        public string InboxView()
        {
            string result = "Inbox:\n";
            foreach (var mail in Inbox)
            {
                result += mail.ToString() + "\n";
            }
            return result;
        }
    }
}