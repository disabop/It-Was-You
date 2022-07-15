using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10;
    private float delay = 0;
    private bool BasementKey = false;
    private bool Lantern = false;
    private int interactTime = 400;
    public GameObject BasementText;
    public Pickup BasementKeyCheck;
    public GameObject Camera1;
    public GameObject Camera2;
    public GameObject Camera3;
    public GameObject Camera4;

    public Vector2 velocity;

    private float shiftSpeed = 15.0f;

    Rigidbody2D myRB;

    // Start is called before the first frame update
    private void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        BasementKeyCheck = GetComponent<Pickup>();
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
        Lantern = true;
        Debug.Log("ITWORKED");

        yield return new WaitForSeconds(4);

        lanternObtainedText.gameObject.SetActive(false);

    }

    private IEnumerator eToInteract()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Lantern == false)
            {
                StartCoroutine(LanternMessage());
                Lantern = true;
            }
        }

        yield return new WaitForSeconds(0.01f);

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

    private IEnumerator ShowHideBasementDoorText()
    {
        BasementText.gameObject.SetActive(true);

        yield return new WaitForSeconds(4);
        BasementText.gameObject.SetActive(false);
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
                Camera1.gameObject.SetActive(false);
                Camera2.gameObject.SetActive(true);
            }
        }
        else if (other.CompareTag("FirstFloorStairs"))
        {
            if ((int)delay >= 3)
            {
                transform.position = new Vector2(270, -45);
                delay = 0;
                Camera2.gameObject.SetActive(false);
                Camera1.gameObject.SetActive(true);
            }
        }
        else if (other.CompareTag("DoorLeadingOutside"))
        {
            if ((int)delay >= 3)
            {
                transform.position = new Vector2(212, 248);
                delay = 0;
                Camera2.gameObject.SetActive(false);
                Camera3.gameObject.SetActive(true);
            }
        }
        else if (other.CompareTag("OutsideDoor"))
        {
            if ((int)delay >= 3)
            {
                transform.position = new Vector2(-169, 182);
                delay = 0;
                Camera3.gameObject.SetActive(false);
                Camera2.gameObject.SetActive(true);
            }
        }
        else if (other.CompareTag("BasementDoor") && BasementKeyCheck != null)
        {
            transform.position = new Vector2(-94, -37);
            Camera2.gameObject.SetActive(false);
            Camera4.gameObject.SetActive(true);
        }
        else if (other.CompareTag("BasementDoor") && BasementKeyCheck == null)
        {
            StartCoroutine(ShowHideBasementDoorText());
        }
        
    }
}
