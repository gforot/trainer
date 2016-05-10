namespace Trainer.Core
{
	public class Person
	{
		public Person()
		{

		}
		public Person(string name, string surname, System.DateTime dayOfBirth)
		{
			Name = name;
			Surname = surname;
			DayOfBirth = dayOfBirth;
		}

		public int Id { get; set; }

		public string Name { get; set; }

		public string Surname { get; set; }

		public System.DateTime DayOfBirth { get; set; }

		public override string ToString()
		{
			return string.Format("ID = {3}; {0} {1} ({2})", Name, Surname, DayOfBirth.Year, Id);
		}
	}
}
