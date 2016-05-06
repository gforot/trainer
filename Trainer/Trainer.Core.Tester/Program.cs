using System;

namespace Trainer.Core.Tester
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var ctx = new TrainerContext())
			{
				Player stud = new Player("a", "r", new DateTime(1977, 7, 30));
				stud.AddRole(Role.ACen);
				stud.AddRole(Role.Trq);
				ctx.Players.Add(stud);
				ctx.SaveChanges();
			}
	



		Player p = new Player("a", "r", new DateTime(1977, 7, 30));
			p.AddRole(Role.Trq);
			p.AddRole(Role.ACen);
			p.AddRole(Role.AEst);
			Console.WriteLine(p);
			Console.ReadKey();
		}
	}
}
