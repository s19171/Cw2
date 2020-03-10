using System;
namespace Cw2
{

	public class Student
	{
		public string index {get; set;}
		public string fname { get; set; }
		public string lname { get; set; }
		string bdate;
		string email;
		string mother;
		string father;
		string studies;
		string studiesMode;

		public Student(string[] values)
		{
			if (values.Length == 9)
			{
				fname = values[0];
				lname = values[1];
				studies = values[2];
				studiesMode = values[3];
				index = values[4];
				bdate = values[5];
				email = values[6];
				mother = values[7];
				father = values[8];
			}
			else
			{
				Program.writeLog("");
			}
		}

		public bool Equals(Student x, Student y)
		{
			return StringComparer.InvariantCultureIgnoreCase.Equals($"{x.fname} {x.lname} {x.index}", $"{y.fname} {y.lname} {y.index}");
		}
	}
}
