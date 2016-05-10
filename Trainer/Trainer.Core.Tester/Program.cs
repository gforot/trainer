using System;

namespace Trainer.Core.Tester
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var ctx = new TrainerContext())
			{
				foreach(Player p1 in ctx.Players)
				{
					Console.WriteLine(string.Format("Player {0}", p1.ToString()));
				}
			}





			//Player p = new Player("a", "r", new DateTime(1977, 7, 30));
			Player p = new Player();
			p.Name = "a";
			p.Surname = "r";
			p.DayOfBirth = new DateTime(1977,7,30);
			p.AddRole(Role.Trq);
			p.AddRole(Role.ACen);
			p.AddRole(Role.AEst);
			Console.WriteLine(p);
			Console.ReadKey();
		}
	}
}
