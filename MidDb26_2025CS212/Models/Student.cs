namespace MidDb26_2025CS212.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string RegistrationNumber { get; set; }
        public int Status { get; set; }
        public string StatusName { get; set; }

        public string FullName => FirstName + " " + LastName;

        public override string ToString() => FullName;
    }
}