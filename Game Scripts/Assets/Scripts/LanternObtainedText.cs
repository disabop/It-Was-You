using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanternObtainedText : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0,4,0);
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
