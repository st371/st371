namespace project
{
    public class Tenant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }
        public string Phone {  get; set; }
        public string EmailAddress { get; set; }

        public Tenant(string firstName, string lastName, string id, string creditNumber, string creditValidity, string credit_cvv, string phone, string emailAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Phone = phone;
            EmailAddress = emailAddress;
        }
    }
}
