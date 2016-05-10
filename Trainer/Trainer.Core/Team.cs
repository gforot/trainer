using System.Collections.Generic;
using System.Linq;

namespace Trainer.Core
{
	public class Team
	{
		private readonly List<Player> _players;

		public Team(Staff staff)
		{
			Staff = staff;

			_players = new List<Player>();
		}

		public Staff Staff { get; private set; }

		public List<Player> Players { get { return _players; } }

		public void AddPlayer(Player player)
		{
			_players.Add(player);
		}

		public void AddPlayers(IEnumerable<Player> players)
		{
			_players.AddRange(players);
		}

		public Player GetPlayer(int id)
		{
			return _players.FirstOrDefault(p => p.Id == id);
		}

	}
}
