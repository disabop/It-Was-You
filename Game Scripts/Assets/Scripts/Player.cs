using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10;

    public Vector2 velocity;


    Rigidbody2D myRB;

    // Start is called before the first frame update
    private void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        velocity = myRB.velocity;

        velocity.x = Input.GetAxisRaw("Horizontal") * speed;
        velocity.y = Input.GetAxisRaw("Vertical") * speed;

        myRB.velocity = velocity;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Door"))
        {
            transform.position = new Vector2(-93, 248);
        }
        else if (other.CompareTag("Door2"))
        {
            transform.position = new Vector2(270, -45);
        }
        else if (other.CompareTag("Door3"))
        {
            transform.position = new Vector2(-93, 248);
        }
        else if (other.CompareTag("Door4"))
        {
            transform.position = new Vector2(-93, 248);
        }
        else if (other.CompareTag("Door5"))
        {
            transform.position = new Vector2(-93, 248);
        }
        else if (other.CompareTag("Door6"))
        {
            transform.position = new Vector2(-93, 248);
        }
    }
}
