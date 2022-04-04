using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerScript : MonoBehaviour
{

    public float speed = 15;
    Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        // Find the GameObject with Tag "Player"
        GameObject gameObject = GameObject.FindGameObjectWithTag("Player");

        if (gameObject != null)
        {
            // v3 Player's position (gameObject.transform.position)
            // minus the position of the item holding the script will provide
            // the direction to the Player (transform.postion is the position of the object following)
            //Vector3 v3 = (gameObject.transform.position - transform.position).normalized; -- If we want a 3D Vector
            // Vector2 v2 = new Vector2(v3.x, v3.y); --change 3d vector to 2D

            Vector2 v2 = (gameObject.transform.position - transform.position).normalized;

            // GetComponent<Rigidbody2d>() gives the current object's component named Rigidbody2D.
            GetComponent<Rigidbody2D>().velocity = v2 * speed;
        }
        else
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
