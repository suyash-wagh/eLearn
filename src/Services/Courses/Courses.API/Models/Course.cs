namespace Courses.API.Models
{
    public class Course
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public List<string> Category { get; set; } = new();
        public string Description { get; set; } = default!;
        public decimal Price { get; set; } 
        public string Banner { get; set; } = default!;
        public Instructor Instructor { get; set; } = new();
    }
}
