using StudentGradesApplication.Entities;

namespace StudentGradesApplication.Models
{
	public class AddGradesViewModel
	{
		public Grade NewStudentGrade { get; set; }
		public List<Course>? Courses { get; set; }
	}
}
