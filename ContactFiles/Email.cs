
namespace Assignment5ABC.ContactFiles
{

    internal class Email
    {
        public string Personal { get; set; }
        public string Work { get; set; }

        public Email() { }

        public Email(string workMail, string personalMail)
        {
            Work = workMail;
            Personal = personalMail;
        }

        public Email(Email theOther)
        {
            Personal = theOther.Personal;
            Work = theOther.Work;
        }

        public string GetToStringItemsHeadings
        {
            get { return string.Format("{0,-20} {1, -20}", "Office EmailData", "Private EmailData"); }
        }

        public override string ToString()
        {
            string strOut = "\n" + "Emails" + "\n";

            strOut += string.Format(" {0,-10} {1, -10}\n", "Private", Personal);
            strOut += string.Format(" {0,-10} {1, -10}\n\n", "Office", Work);

            return strOut;
        }
    }
}