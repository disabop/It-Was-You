using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanternObtainedText : MonoBehaviour
{
    public bool isOpen;
    public bool BasementKey = false;
    private Inventory inventory;
    public GameObject Lantern;

    // Update is called once per frame
    void LateUpdate()
    {
        
    }

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }


    public void OpenDrawer()
    {
        if (!isOpen)
        {
            isOpen = true;
            Debug.Log("Drawer is now open");
            BasementKey = true;
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    inventory.slots[i].transform.GetChild(0).GetComponent<Image>().sprite = Lantern.GetComponent<SpriteRenderer>().sprite;
                    inventory.slots[i].transform.GetChild(0).GetComponent<Image>().color = UnityEngine.Color.white;
                    //Instantiate(Lantern, inventory.slots[i].transform, false);
                    break;
                }
            }

        }
    }


}
