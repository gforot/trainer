using System;
using Trainer.Core.Context;

namespace Trainer.Core.Tester
{
	class Program
	{
		static void Main(string[] args)
		{
			Team team = new Team() { Name = "Galbiatese" };
			Player p1 = new Player() { Name = "Andrea", Surname = "Rota", DayOfBirth = new DateTime(1977, 7, 30), Role = Role.ACen|Role.Trq };
			Player p2 = new Player() { Name = "Emanuele", Surname = "Carzaniga", DayOfBirth = new DateTime(1979, 7, 30), Role = Role.Trq };
			StaffPerson s1 = new StaffPerson() { Name = "Roberto", Surname = "Taderini", Role = StaffRole.HeadCoach, DayOfBirth = new DateTime(1979, 1, 1) };
			StaffPerson s2 = new StaffPerson() { Name = "Stefano", Surname = "Piatti", Role = StaffRole.CoCoach, DayOfBirth = new DateTime(1980, 1, 1) };


			TrainerContextHelper.AddTeam(team);
			p1.Team = team;
			p2.Team = team;

			TrainerContextHelper.AddPlayer(p1);
			TrainerContextHelper.AddPlayer(p2);





			//Player p = new Player()
			//{
			//	Name = "Andrea",
			//	Surname = "Tentori",
			//	DayOfBirth = new DateTime(1994, 7, 12),
			//	Role = Role.DCen | Role.TSin,
			//};
			//TrainerContextHelper.AddPlayer(p);


			foreach (Player p in TrainerContextHelper.GetPlayers())
			{
				Console.WriteLine(string.Format("Player {0}", p.ToString()));
			}


			Console.ReadKey();
		}
	}
}
