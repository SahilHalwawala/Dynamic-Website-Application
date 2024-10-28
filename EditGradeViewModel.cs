using StudentGradesApplication.Entities;

namespace StudentGradesApplication.Models
{
    public class EditGradeViewModel
    {
        public Grade CurrentStudentGrade { get; set; }
        public List<Course>? Courses { get; set; }

    }
}
