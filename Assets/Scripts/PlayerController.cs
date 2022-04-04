using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyJoystick;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float speed = 10.0f;
    [SerializeField] Joystick joystick;
    private Rigidbody2D rigidBody;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //PC
        //float h = Input.GetAxisRaw("Horizontal");
        //float v = Input.GetAxisRaw("Vertical");

        // Android
        float h = joystick.Horizontal();
        float v = joystick.Vertical();

        Vector2 direction = new Vector2(h, v);

        rigidBody.velocity = direction.normalized * speed;

        animator.SetBool("isMovingLeft", h < 0);
        animator.SetBool("isMovingUp", v > 0);
        animator.SetBool("isMovingDown", v < 0);
        animator.SetBool("isMovingRight", h > 0);


    }
}
