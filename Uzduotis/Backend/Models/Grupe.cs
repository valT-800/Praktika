using System.Collections.Generic;
namespace Uzduotis.Backend.Models
{
    class Grupe
    {
		public int ID { get; private set; }
		public string Title { get; private set; }
		public List<Student> Students { get; private set; }
		public List<Subject> Subjects { get; private set; }
		public Grupe(int id, string title)
		{
			ID = id;
			Title = title;
		}

		public void SetStudents(List<Student> students)
		{
			Students = students;
		}
		public void SetSubjects(List<Subject> subjects)
		{
			Subjects = subjects;
		}
	}
}
