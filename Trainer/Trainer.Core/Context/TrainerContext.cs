using System.Data.Entity;

namespace Trainer.Core.Context
{
	public class TrainerContext : DbContext
	{
		public TrainerContext() : base()
		{
			Database.SetInitializer<TrainerContext>(new DropCreateDatabaseIfModelChanges<TrainerContext>());
		}

		public DbSet<Player> Players { get; set; }
		public DbSet<TrainingField> TrainingFields { get; set; }
	}
}
