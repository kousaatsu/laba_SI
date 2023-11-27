using PlayerSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InputSystem
{

	public class InputListener : MonoBehaviour
	{
		[SerializeField] private Player player;
		private PlayerInvoker _playerInvoker;

		private void Awake()
		{
			_playerInvoker = new PlayerInvoker(player);
		}

		private void Update()
		{
			InputMove();
		}

		private void InputMove()
		{
			float horiz = Input.GetAxisRaw("Horizontal");
			Vector2 movement = new Vector2(horiz, 0f);
			_playerInvoker.Move(movement);
		}
	}
}