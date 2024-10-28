using StudentGradesApplication.Entities;
namespace StudentGradesApplication.Services
{
    public interface IGradeService
    {
        public List<Course> GetCourses();
        public List<Grade> GetAllGrades();

        public Grade GetStudentGrade(int gradeId);

        public int AddGrade(Grade grade);

        public int UpdateGrade(Grade grade);

        public int DeleteGrade(Grade gradeId);


    }
}
