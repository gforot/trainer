using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Trainer.Core
{
	public class Training
	{
		public Training()
		{
            PresentPlayers = new List<Player>();
		}

		[Key]
		public int TrainingID { get; set; }

        public System.DateTime Date { get; set; }

		public virtual TrainingField Field { get; set; }

		public virtual ICollection<Player> PresentPlayers { get; set; }


        public void AddPresentPlayer(Player p)
        {
            PresentPlayers.Add(p);
        }

	}
}
