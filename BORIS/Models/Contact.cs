namespace BORIS.Models
{
    public class Contact
    {
        public string Name { get; set; }
        public string EMail { get; set; }
        public string PreferredLocation { get; set; }
        public Specialisation? PreferredSpecialisation { get; set; }

    }
}
