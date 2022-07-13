using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingRooms : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Door"))
        {
            Vector3 spawnpos = new Vector3(0, 5, 0);
        }
        
    }
}
