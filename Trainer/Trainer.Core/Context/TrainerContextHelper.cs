using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Trainer.Core.Context
{
	public static class TrainerContextHelper
	{
		public static void AddPlayer(Player p)
		{
			using(TrainerContext db = new TrainerContext())
			{
				db.Players.Add(p);
				db.SaveChanges();
			}
		}

		public static List<Player> GetPlayers()
		{
			using (TrainerContext db = new TrainerContext())
			{
				db.Players.Load();
				return db.Players.ToList();
			}
		}
	}
}
