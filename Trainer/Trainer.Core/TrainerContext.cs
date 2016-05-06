using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainer.Core
{
	public class TrainerContext : DbContext
	{
		public TrainerContext() : base()
		{

		}

		public DbSet<Player> Players { get; set; }
		public DbSet<TrainingField> TrainingFields { get; set; }
	}
}
