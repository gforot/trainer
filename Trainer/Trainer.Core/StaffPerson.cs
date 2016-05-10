using System;

namespace Trainer.Core
{
	public class StaffPerson : Person
	{
		public StaffPerson(string name, string surname, DateTime dayOfBirth, StaffRole role) : base(name, surname, dayOfBirth)
		{
			Role = role;
		}

		public StaffRole Role { get; private set; }
		
	}
}
