using System;
using System.Collections.Generic;

namespace Trainer.Core
{
	public class Player : Person
	{
		private readonly List<Role> _roles;

		public Player(string name, string surname, DateTime dayOfBirth)
			: base(name, surname, dayOfBirth)
		{
			_roles = new List<Role>();
		}



		public List<Role> Roles { get { return _roles; } }

		public void AddRole(Role role)
		{
			_roles.Add(role);
		}

		public override string ToString()
		{
			return base.ToString();
		}
	}
}
