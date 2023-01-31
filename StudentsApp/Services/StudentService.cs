using StudentsApp.Models;
using StudentsApp.Pages;

namespace StudentsApp.Services
{
	public interface IStudentService
	{
        public Task<List<Student>> GetStudents();
        public Task<Student> GetStudent(int id);
        public Task RemoveStudent(int id);
    }
	
	public class StudentService : IStudentService
	{
		private List<Student> students;

		public StudentService()
		{
			students = new List<Student>
		{
			new Student { Id = 1, FirstName = "Jan", LastName = "Kowalski", Birthdate = new DateTime(2000, 1, 1), Studies = "Informatyka" },
			new Student { Id = 2, FirstName = "Anna", LastName = "Nowak", Birthdate = new DateTime(2001, 2, 2), Studies = "Matematyka" },
			new Student { Id = 3, FirstName = "Tomasz", LastName = "Wiśniewski", Birthdate = new DateTime(2002, 3, 3), Studies = "Fizyka" },
			new Student { Id = 4, FirstName = "Katarzyna", LastName = "Wojciechowska", Birthdate = new DateTime(2003, 4, 4), Studies = "Biologia" },
			new Student { Id = 5, FirstName = "Piotr", LastName = "Kowalczyk", Birthdate = new DateTime(2004, 5, 5), Studies = "Chemia" },
			new Student { Id = 6, FirstName = "Agnieszka", LastName = "Mazur", Birthdate = new DateTime(2005, 6, 6), Studies = "Historia" },
			new Student { Id = 7, FirstName = "Marcin", LastName = "Kaczmarek", Birthdate = new DateTime(2006, 7, 7), Studies = "Geografia" },
			new Student { Id = 8, FirstName = "Magdalena", LastName = "Wieczorek", Birthdate = new DateTime(2007, 8, 8), Studies = "Ekonomia" },
			new Student { Id = 9, FirstName = "Michał", LastName = "Jankowski", Birthdate = new DateTime(2008, 9, 9), Studies = "Nauki Polityczne" },
			new Student { Id = 10, FirstName = "Monika", LastName = "Król", Birthdate = new DateTime(2009, 10, 10), Studies = "Literatura" }
		};
		}

		public Task<List<Student>> GetStudents()
		{
			return Task.FromResult(students);
		}

		public Task<Student> GetStudent(int id)
		{
			return Task.FromResult(students.FirstOrDefault(s => s.Id == id));	
		}

		public Task RemoveStudent(int id)
		{
			return Task.FromResult(students.Remove(students.FirstOrDefault(s => s.Id == id)));
		}
	}
}
