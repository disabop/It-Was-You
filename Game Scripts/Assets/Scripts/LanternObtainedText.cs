using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanternObtainedText : MonoBehaviour
{
    public bool isOpen;
    public bool BasementKey = false;

    // Update is called once per frame
    void LateUpdate()
    {
        
    }


    public void OpenDrawer()
    {
        if (!isOpen)
        {
            isOpen = true;
            Debug.Log("Drawer is now open");
            BasementKey = true;

        }
    }


}
