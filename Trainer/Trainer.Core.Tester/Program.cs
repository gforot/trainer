using System;
using Trainer.Core.Context;

namespace Trainer.Core.Tester
{
	class Program
	{
		static void Main(string[] args)
		{
			Player p = new Player()
			{
				Name = "Andrea",
				Surname = "Tentori",
				DayOfBirth = new DateTime(1994, 7, 12),
				Role = Role.DCen | Role.TSin,
			};
			TrainerContextHelper.AddPlayer(p);


			foreach(Player p1 in TrainerContextHelper.GetPlayers())
			{
				Console.WriteLine(string.Format("Player {0}", p1.ToString()));
			}


			Console.ReadKey();
		}
	}
}
