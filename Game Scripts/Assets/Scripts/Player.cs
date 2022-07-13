using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10;

    public Vector2 velocity;

    Animator myAnim;

    Rigidbody2D myRB;

    // Start is called before the first frame update
    private void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        velocity = myRB.velocity;

        velocity.x = Input.GetAxisRaw("Horizontal") * speed;
        velocity.y = Input.GetAxisRaw("Vertical") * speed;

        if (velocity != Vector2.zero)
            myAnim.SetBool("isWalking", true);

        else
            myAnim.SetBool("isWalking", false);

        myRB.velocity = velocity;
    }
}
