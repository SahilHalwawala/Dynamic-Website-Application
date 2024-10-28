using Microsoft.EntityFrameworkCore;
using StudentGradesApplication.Entities;

namespace StudentGradesApplication.Services
{
    //public class GradeService : IGradeService - This helps link both page
    public class GradeService : IGradeService
    {
        private readonly StudentGradesDbContext _context;

        public GradeService(StudentGradesDbContext context)
        {
            _context = context;
        }

        public List<Course> GetCourses()
        {
            return _context.Courses.ToList();
        }


        public List<Grade> GetAllGrades()
        {
            return _context.Grades.Include(g => g.Course).ToList();
        }

        public int AddGrade(Grade grade)
        {
            _context.Grades.Add(grade);
            _context.SaveChanges();

            return grade.GradeId;
        }

        public Grade GetStudentGrade(int gradeId)
        {
            return _context.Grades.Find(gradeId);
        }

        public int UpdateGrade(Grade grade)
        {
            _context.Grades.Update(grade);
            _context.SaveChanges();

            return grade.GradeId;
        }

        public int DeleteGrade(Grade grade)
        {
            _context.Grades.Remove(grade);
            _context.SaveChanges();

            return grade.GradeId;
        }

    }
}
