using System;
using System.Collections.Generic;

namespace Trainer.Core
{
	public class Player : Person
	{
		public Player() : base()
		{
			
		}

		public Role Role { get; set; }

		public override string ToString()
		{
			return string.Format("{0};role:{1};", base.ToString(), Role);
		}
	}
}
