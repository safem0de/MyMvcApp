using Microsoft.EntityFrameworkCore;
using MyMvcApp.Models;

namespace MyMvcApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentGroup> StudentGroups { get; set; }
        public DbSet<Studying> Studyings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ✅ Seed Data สำหรับ COURSES
            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, CourseName = "ภาษาไทยเพื่ออาชีพ", Credit = 3 },
                new Course { Id = 2, CourseName = "ภาษาอังกฤษฟัง-พูด 1", Credit = 3 },
                new Course { Id = 3, CourseName = "หน้าที่พลเมืองและศีลธรรม", Credit = 3 },
                new Course { Id = 4, CourseName = "ความรู้เกี่ยวกับงานอาชีพ", Credit = 1 },
                new Course { Id = 5, CourseName = "วัสดุงานช่างอุตสาหกรรม", Credit = 2 },
                new Course { Id = 6, CourseName = "งานเชื่อมและโลหะแผ่นเบื้องต้น", Credit = 1 },
                new Course { Id = 7, CourseName = "งานถอดประกอบเครื่องกลเบื้องต้น", Credit = 2 },
                new Course { Id = 8, CourseName = "เขียนแบบเครื่องมือกล", Credit = 3 },
                new Course { Id = 9, CourseName = "กรรมวิธีการผลิต", Credit = 3 },
                new Course { Id = 10, CourseName = "ผลิตชิ้นส่วนด้วยเครื่องมือกล", Credit = 1 },
                new Course { Id = 11, CourseName = "กิจกรรมลูกเสือวิสามัญ", Credit = 1 },
                new Course { Id = 12, CourseName = "English conversation", Credit = 1 }
            );

            // ✅ Seed Data สำหรับ STUDENT_GROUPS
            modelBuilder.Entity<StudentGroup>().HasData(
                new StudentGroup { Id = 1, GroupCode = "2/1" },
                new StudentGroup { Id = 2, GroupCode = "2/2" },
                new StudentGroup { Id = 3, GroupCode = "2/3" },
                new StudentGroup { Id = 4, GroupCode = "2/4" }
            );

            // ✅ Seed Data สำหรับ STUDYING (ข้อมูลการลงทะเบียนเรียน)
            modelBuilder.Entity<Studying>().HasData(
                new Studying { Id = 1, CourseId = 1, StudentId = 1, Term = 1, Year = 2017, Score = 3 },
                new Studying { Id = 2, CourseId = 1, StudentId = 2, Term = 2, Year = 2016, Score = 3 },
                new Studying { Id = 3, CourseId = 1, StudentId = 3, Term = 2, Year = 2017, Score = 4 },
                new Studying { Id = 4, CourseId = 2, StudentId = 4, Term = 2, Year = 2016, Score = 2 },
                new Studying { Id = 5, CourseId = 2, StudentId = 5, Term = 1, Year = 2017, Score = 4 }
            );
        }

    }
}