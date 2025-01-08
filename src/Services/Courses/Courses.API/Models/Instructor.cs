namespace Courses.API.Models
{
    public class Instructor
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public List<Course> Courses { get; set; } = new();
        public string About { get; set; } = default!;
        public string Description { get; set; } = default!;
        public decimal Rating { get; set; } 
        public string Picture { get; set; } = default!;
    }
}
