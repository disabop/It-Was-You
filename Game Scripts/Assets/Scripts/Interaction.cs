using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interaction : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;
    public GameObject drawerText;
    public GameObject newspaperText;

    private IEnumerator DrawerMessageDisappears()
    {
        drawerText.gameObject.SetActive(true);

        yield return new WaitForSeconds(4);

        drawerText.gameObject.SetActive(false);

    }

    private IEnumerator NewspaperMessageDisappears()
    {
        newspaperText.gameObject.SetActive(true);

        yield return new WaitForSeconds(4);

        newspaperText.gameObject.SetActive(false);

    }

    private void Update()
    {
        if (isInRange)
        {
            drawerText.gameObject.SetActive(true);
            newspaperText.gameObject.SetActive(true);
            if (Input.GetKeyDown(interactKey))
            {
                interactAction.Invoke();
            }
        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            Debug.Log("Player is now in range");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            drawerText.gameObject.SetActive(false);
            newspaperText.gameObject.SetActive(false);
            isInRange = false;
            Debug.Log("Player is no longer in range");
        }
    }

}
