using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainer.Core
{
	public class TrainingField
	{
		public TrainingField(string address)
		{
			Address = address;
		}

		public string Address { get; private set; }
		
	}
}
