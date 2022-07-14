using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenNewspaper : MonoBehaviour
{
    public bool isOpen;
    public bool Newspaper1 = false;
    private Inventory inventory;
    public GameObject Newspaper;
    public GameObject NewspaperPanel;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (NewspaperPanel.activeSelf)
            {
                Newspaper.gameObject.SetActive(false);
            }
        }
    }

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }


    public void ReadNewspaper()
    {
        if (!isOpen)
        {
            isOpen = true;
            Debug.Log("Found Newspaper 1");
            Newspaper1 = true;
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    inventory.slots[i].transform.GetChild(0).GetComponent<Image>().sprite = Newspaper.GetComponent<SpriteRenderer>().sprite;
                    inventory.slots[i].transform.GetChild(0).GetComponent<Image>().color = UnityEngine.Color.white;
                    break;
                }
            }

            NewspaperPanel.gameObject.SetActive(true);
        }
    }
}
