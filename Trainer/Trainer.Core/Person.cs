namespace Trainer.Core
{
	public class Person
	{
		public Person(string name, string surname, System.DateTime dayOfBirth)
		{
			Name = name;
			Surname = surname;
			DayOfBirth = dayOfBirth;
		}

		public int Id { get; set; }

		public string Name { get; private set; }

		public string Surname { get; private set; }

		public System.DateTime DayOfBirth { get; private set; }

		public override string ToString()
		{
			return string.Format("{0} {1} ({2})", Name, Surname, DayOfBirth.Year);
		}
	}
}
