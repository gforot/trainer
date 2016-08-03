using System.Collections.Generic;

namespace Trainer.Core
{
	public class Team
	{
		public Team()
		{

		}

		public int TeamId { get; set; }

		public string Name { get; set; }

		public virtual ICollection<StaffPerson> StaffPersons { get; set; }

		public virtual ICollection<Player> Players { get; set; }

		public override string ToString()
		{
			return Name;
		}

	}
}
