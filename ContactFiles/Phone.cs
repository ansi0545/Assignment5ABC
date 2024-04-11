internal class Phone
{
    public string PrivatePhone { get; set; }
    public string OfficePhone { get; set; }

    public Phone() { }

    public Phone(string privatePhone, string officePhone)
    {
        PrivatePhone = privatePhone;
        OfficePhone = officePhone;
    }

    public Phone(Phone other)
    {
        PrivatePhone = other.PrivatePhone;
        OfficePhone = other.OfficePhone;
    }
}