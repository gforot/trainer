using System;

namespace Trainer.Core
{
	public class Player : Person
	{
		public Player(string name, string surname, DateTime dayOfBirth, Role role)
			: base(name, surname, dayOfBirth)
		{
			Role = role;
		}

		public Role Role { get; private set; }

		public override string ToString()
		{
			return string.Format("{0} Role:{1}",base.ToString(), Role);
		}
	}
}
