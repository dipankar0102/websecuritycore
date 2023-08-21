using websecuritycore.Models;

namespace websecuritycore.Repo
{
	public interface IStudent
	{
		List<StudentModel> GetAllStudents();
		StudentModel GetStudentById(int id);
	}
}
