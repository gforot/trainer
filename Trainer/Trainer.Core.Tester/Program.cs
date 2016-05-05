using System;

namespace Trainer.Core.Tester
{
	class Program
	{
		static void Main(string[] args)
		{
			Player p = new Player("a", "r", new System.DateTime(1977, 7, 30), Role.Trq);
			Console.WriteLine(p);
			Console.ReadKey();
		}
	}
}
