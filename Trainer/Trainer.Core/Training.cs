using System.Collections.Generic;

namespace Trainer.Core
{
	public class Training
	{
		public Training(TrainingField field)
		{

		}

		public TrainingField Field { get; private set; }

		public IEnumerable<Player> PresentPlayers { get; private set; }


	}
}
