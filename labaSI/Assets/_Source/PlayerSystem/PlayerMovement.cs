using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerSystem
{
    public class PlayerMovement
    {

        public void Move(Rigidbody2D rb, float speed, Vector2 movement)
        {
            //rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
            Vector2 velocity = movement * speed;
            rb.velocity = new Vector2(velocity.x, 0);
        }


    }
}
