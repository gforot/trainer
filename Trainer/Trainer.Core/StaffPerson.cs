using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trainer.Core
{
	public class StaffPerson : Person
	{


		public StaffRole Role { get; set; }

		public int TeamId { get; set; }

		[ForeignKey("TeamId")]
		public virtual Team Team { get; set; }
	}
}
