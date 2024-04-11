// Email.cs
namespace Assignment5ABC.ContactFiles
{
    internal class Email
    {
        private string personal;
        private string work;

        public string Personal { get => personal; set => personal = value; }
        public string Work { get => work; set => work = value; }

        // Constructor
        public Email() { }

        public Email(string workMail, string personalMail)
        {
            Work = workMail;
            Personal = personalMail;
        }

        // Copy constructor
        public Email(Email other)
        {
            Personal = other.Personal;
            Work = other.Work;
        }

        // Method to get string headings
        public string GetToStringItemsHeadings
        {
            get { return string.Format("{0,-20} {1, -20}", "Office EmailData", "Private EmailData"); }
        }

        // Override ToString() method
        public override string ToString()
        {
            string strOut = "\n" + "Emails" + "\n";

            strOut += string.Format(" {0,-10} {1, -10}\n", "Private", Personal);
            strOut += string.Format(" {0,-10} {1, -10}\n\n", "Office", Work);

            return strOut;
        }
    }
}
