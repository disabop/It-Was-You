using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private PlayerController playerControllerScript;
    public GameObject player;
    public Vector3 offset = new Vector3(4, 5, 0);


    // Update is called once per frame
    void Update()
    {
        
        transform.position = player.transform.position + offset;
    }
}
