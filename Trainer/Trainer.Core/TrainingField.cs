using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

		[Key]
		public int TrainingFieldID { get; set; }

		public string Address { get; private set; }
		
	}
}
