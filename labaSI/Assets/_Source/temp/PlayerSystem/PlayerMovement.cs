using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public void Movement(Rigidbody2D rb, float mvspeed)
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * mvspeed, 0);
    }
}
