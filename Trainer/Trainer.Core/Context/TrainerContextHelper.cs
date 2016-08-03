using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Trainer.Core.Context
{
	public static class TrainerContextHelper
	{
		public static void AddPlayer(Player p)
		{
			using (TrainerContext db = new TrainerContext())
			{
				db.Players.Add(p);
				db.SaveChanges();
			}
		}

		public static void AddTeam(Team p)
		{
			using (TrainerContext db = new TrainerContext())
			{
				db.Teams.Add(p);
				db.SaveChanges();
			}
		}

		public static Team GetTeam(int id)
		{
			using (TrainerContext db = new TrainerContext())
			{
				return db.Teams.FirstOrDefault(t => t.TeamId == id);
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

		public static void AddTrainingField(TrainingField p)
		{
			using (TrainerContext db = new TrainerContext())
			{
				db.TrainingFields.Add(p);
				db.SaveChanges();
			}
		}

		public static void AddTraining(Training t)
		{
			using (TrainerContext db = new TrainerContext())
			{
				db.Trainings.Add(t);
				db.SaveChanges();
			}
		}
	}
}
