namespace BORIS.Models
{
    public class Course
    {
        public Guid? ID { get; set; }

        public string Name { get; set; }

        public int DurationInMonths { get; set; }

        string Description { get; set; }
    }
}
