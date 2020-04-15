namespace TrackerLibrary.Models
{
    public class PersonModel
    {

        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public string MyProperty { get; set; }
        public string EmailAddress { get; set; }
        public string CellPhoneNumber { get; set; }

        

        public string fullName
        {
            get { return $"{FirstName} {LastName}"; }

        }


        public PersonModel()
        {

        }

        public PersonModel(string firstName,string lastName, string emailAddress,string cellPhoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            CellPhoneNumber = cellPhoneNumber;

        }

    }
}