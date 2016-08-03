using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trainer.Core;

namespace Trainer.WpfApp.DesignTime
{
	public static class DesignTimeDataContext
	{
		public static PlayerDetailModel PlayerDetailData
		{
			get
			{
				var result = new PlayerDetailModel(CreateSamplePlayer());
				return result;
			}
		}

		public class PlayerDetailModel
		{
			private Player _player;
			public PlayerDetailModel(Player player)
			{
				_player = player;
			}
			
			public string Name { get { return _player.Name; } }
			public string Surname { get { return _player.Surname; } }
			public Team Team { get { return _player.Team; } }

			public string PH { get { return "my Placeholder"; } }
		}

		public static Player CreateSamplePlayer()
		{
			return new Player() { Name = "Gonzalo", Surname="Higuain", Team = new Team() { Name = "Juventus"} };
		}
	}
}
