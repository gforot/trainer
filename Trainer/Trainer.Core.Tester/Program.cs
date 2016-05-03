using System;

namespace Trainer.Core.Tester
{
	class Program
	{
		static void Main(string[] args)
		{
			Player p = new Player("n", "s", new System.DateTime(1977, 7, 30));
			Console.WriteLine(p);
			Console.ReadKey();
		}
	}
}
