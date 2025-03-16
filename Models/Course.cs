namespace MyMvcApp.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; } = string.Empty;
        public int Credit { get; set; }
        public ICollection<Studying> Studyings { get; set; } = new List<Studying>();
    }
}