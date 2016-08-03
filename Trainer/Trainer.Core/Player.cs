using System.ComponentModel.DataAnnotations.Schema;

namespace Trainer.Core
{
	public class Player : Person
	{
		public Player() : base()
		{
			
		}

		public Role Role { get; set; }



		public int TeamId { get; set; }

		[ForeignKey("TeamId")]
		public virtual Team Team { get; set; }

		public override string ToString()
		{
			return string.Format("{0};role:{1};", base.ToString(), Role);
		}
	}
}
