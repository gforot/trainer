using System;

namespace Trainer.Core.Tester
{
	class Program
	{
		static void Main(string[] args)
		{
			Player p = new Player("a", "r", new DateTime(1977, 7, 30));
			p.AddRole(Role.Trq);
			p.AddRole(Role.ACen);
			p.AddRole(Role.AEst);
			Console.WriteLine(p);
			Console.ReadKey();
		}
	}
}
