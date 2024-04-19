// Phone.cs
namespace Assignment5ABC.ContactFiles
{
    /// <summary>
    /// Represents a phone object with private and office phone numbers.
    /// </summary>
    internal class Phone
    {
        private string privatePhone;
        private string officePhone;

        /// <summary>
        /// Gets or sets the private phone number.
        /// </summary>
        public string PrivatePhone { get => privatePhone; set => privatePhone = value; }

        /// <summary>
        /// Gets or sets the office phone number.
        /// </summary>
        public string OfficePhone { get => officePhone; set => officePhone = value; }

        // Constructor
        public Phone() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Phone"/> class with the specified private and office phone numbers.
        /// </summary>
        /// <param name="privatePhone">The private phone number.</param>
        /// <param name="officePhone">The office phone number.</param>
        public Phone(string privatePhone, string officePhone)
        {
            PrivatePhone = privatePhone;
            OfficePhone = officePhone;
        }
    }
}
