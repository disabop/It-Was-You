using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10;
    private float delay = 0;
    private bool BasementKey = false;
    private bool Lantern = false;


    public Vector2 velocity;

    private float shiftSpeed = 15.0f;

    Rigidbody2D myRB;

    // Start is called before the first frame update
    private void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
    }

    private IEnumerator DrawerMessageDisappears()
    {
        drawerText.gameObject.SetActive(true);

        yield return new WaitForSeconds(4);

        drawerText.gameObject.SetActive(false);

    }

    private IEnumerator LanternMessage()
    {

        lanternObtainedText.gameObject.SetActive(true);

        yield return new WaitForSeconds(4);

        lanternObtainedText.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        velocity = myRB.velocity;

        velocity.x = Input.GetAxisRaw("Horizontal") * speed;
        velocity.y = Input.GetAxisRaw("Vertical") * speed;

        myRB.velocity = velocity;
        delay += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = shiftSpeed;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 10;
        }
    }


    public GameObject drawerText;
    public GameObject lanternObtainedText;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("SecondFloorStairs"))
        {
            if ((int)delay >= 3)
            {
                transform.position = new Vector2(-93, 248);
                delay = 0;
            }
        }
        else if (other.CompareTag("FirstFloorStairs"))
        {
            if ((int)delay >= 3)
            {
                transform.position = new Vector2(270, -45);
                delay = 0;
            }
        }
        else if (other.CompareTag("Drawer"))
        {
            StartCoroutine(DrawerMessageDisappears());
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (Lantern == false)
                {
                    StartCoroutine(LanternMessage());
                }
                Lantern = true;
            }
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
