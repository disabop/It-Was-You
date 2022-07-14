using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightswitch : MonoBehaviour
{
    public Light houseLights;
    private bool lights = true;

    // Start is called before the first frame update
    void Start()
    {
        houseLights = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (lights == true)
            {
                houseLights.intensity = 0.25f;
                lights = false;
            }
            else if (lights == false)
            {
                houseLights.intensity = 1f;
                lights = true;
            }
        }


    }
}
