using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerSystem
{
	[RequireComponent(typeof(Rigidbody2D))]
	public class Player : MonoBehaviour
	{
		[field: SerializeField] public float speed { get; private set; }
		[field: SerializeField] public Rigidbody2D rb { get; private set; }
	}
}