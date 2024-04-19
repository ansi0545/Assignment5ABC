// Email.cs
namespace Assignment5ABC.ContactFiles
{
    /// <summary>
    /// Represents an email address.
    /// </summary>
    internal class Email
    {
        private string personal;
        private string work;

        /// <summary>
        /// Gets or sets the personal email address.
        /// </summary>
        public string Personal { get => personal; set => personal = value; }

        /// <summary>
        /// Gets or sets the work email address.
        /// </summary>
        public string Work { get => work; set => work = value; }

        // Constructor
        public Email() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Email"/> class with the specified work and personal email addresses.
        /// </summary>
        /// <param name="workMail">The work email address.</param>
        /// <param name="personalMail">The personal email address.</param>
        public Email(string workMail, string personalMail)
        {
            Work = workMail;
            Personal = personalMail;
        }

        // Copy constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Email"/> class by copying the values from another <see cref="Email"/> object.
        /// </summary>
        /// <param name="other">The <see cref="Email"/> object to copy.</param>
        public Email(Email other)
        {
            Personal = other.Personal;
            Work = other.Work;
        }

        // Method to get string headings
        /// <summary>
        /// Gets the string representation of the column headings for the email addresses.
        /// </summary>
        public string GetToStringItemsHeadings
        {
            get { return string.Format("{0,-20} {1, -20}", "Office EmailData", "Private EmailData"); }
        }

        // Override ToString() method
        /// <summary>
        /// Returns a string representation of the email addresses.
        /// </summary>
        /// <returns>A string representation of the email addresses.</returns>
         public override string ToString()
        {
            string strOut = "\n" + "Emails" + "\n";

            strOut += string.Format(" {0,-10} {1, -10}\n", "Private", Personal);
            strOut += string.Format(" {0,-10} {1, -10}\n\n", "Office", Work);

            return strOut;
        }
    }
}
