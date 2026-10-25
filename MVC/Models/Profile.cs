namespace MVC.Models
{
    public class Profile
    {
        public string School { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public List<string> Skills { get; set; }

        public Profile(
            string school,
            string name,
            string phoneNumber,
            string address,
            List<string> skills)
        {
            School = school;
            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;
            Skills = skills;
        }
    }
}