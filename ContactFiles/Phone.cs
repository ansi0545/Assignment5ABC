// Phone.cs
namespace Assignment5ABC.ContactFiles
{
    internal class Phone
    {
        private string privatePhone;
        private string officePhone;

        public string PrivatePhone { get => privatePhone; set => privatePhone = value; }
        public string OfficePhone { get => officePhone; set => officePhone = value; }

        // Constructor
        public Phone() { }

        public Phone(string privatePhone, string officePhone)
        {
            PrivatePhone = privatePhone;
            OfficePhone = officePhone;
        }
    }
}
