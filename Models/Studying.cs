namespace MyMvcApp.Models
{
    public class Studying
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public Course? Course { get; set; }

        public int StudentId { get; set; }
        public int Term { get; set; }
        public int Year { get; set; }
        public int Score { get; set; }
    }
}