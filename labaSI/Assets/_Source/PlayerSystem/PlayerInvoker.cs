using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerSystem
{
	public class PlayerInvoker
	{
		private PlayerMovement _playerMovement;
		private Player _player;

		public PlayerInvoker(Player player)
		{
			_player = player;
			_playerMovement = new PlayerMovement();
		}

		public void Move(Vector2 movementD)
		{
			_playerMovement.Move(_player.rb, _player.speed, movementD);
		}
	}
}