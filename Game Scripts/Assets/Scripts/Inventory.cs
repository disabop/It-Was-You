using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool[] isFull;
    public GameObject[] slots;
    public GameObject backpacktoggle;
    private bool backpackopen = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (backpackopen == false)
            {
                backpacktoggle.gameObject.SetActive(true);
                backpackopen = true;
            }
            else if (backpackopen == true)
            {
                backpacktoggle.gameObject.SetActive(false);
                backpackopen = false;
            }
        }
    }
}
