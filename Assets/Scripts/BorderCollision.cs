using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderCollision : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Player" && collision.gameObject.tag != "Wall")
        {
            // collision.gameObject will reference the gameObject that is colliding with the gameObject that holds this script
            Destroy(collision.gameObject);
        }
    }
}
