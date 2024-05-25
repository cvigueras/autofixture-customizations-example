namespace AutoFixture.Customizations.Example.App
{
    public class User
    {
        public string Name { get; }
        public string LastName { get; }
        public string City { get; }
        public string PhoneNumber { get; }
        public string Gender { get; }
        public string Email { get; }
        public string MobileNumber { get; }
        public int Age { get; }


        private User(string name,
                    string lastName,
                    string city,
                    string phoneNumber,
                    string gender,
                    string email,
                    string mobileNumber,
                    int age)
        {
            Name = name;
            LastName = lastName;
            City = city;
            PhoneNumber = phoneNumber;
            Gender = gender;
            Email = email;
            MobileNumber = mobileNumber;
            Age = age;
        }

        public static User Create(string name,
                    string lastName,
                    string city,
                    string phoneNumber,
                    string gender,
                    string email,
                    string mobileNumber,
                    int age)
        {
            return new User(name, lastName, city, 
                phoneNumber, gender, email, mobileNumber, age);
        }
    }
}