using websecuritycore.Repo;

namespace websecuritycore.Models
{
	public class StudentRepository : IStudent
	{
		public List<StudentModel> GetAllStudents()
		{
			return DataSource();
		}

		public StudentModel GetStudentById(int id)
		{
			return DataSource().Where(e=>e.RollNo==id).FirstOrDefault();	
		}
		public List<StudentModel> DataSource()
		{
			return new List<StudentModel>{
				new StudentModel { Gender="male",
				Name="dipankar",RollNo=1,Standard="10"},
				new StudentModel { Gender="male",
				Name="papai",RollNo=2,Standard="12"},
				new StudentModel { Gender="male",
				Name="dipu",RollNo=5,Standard="11"},

			};
		}
	}
}
