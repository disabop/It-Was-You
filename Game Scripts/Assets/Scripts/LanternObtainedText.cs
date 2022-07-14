using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
                    Instantiate(Lantern, inventory.slots[i].transform, false);
                    break;
                }
            }

        }
    }


}
