using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Trainer.Core
{
	public class Training
	{
		public Training()
		{

		}

		[Key]
		public int TrainingID { get; set; }

		public virtual TrainingField Field { get; set; }

		public virtual ICollection<Player> PresentPlayers { get; set; }


	}
}
