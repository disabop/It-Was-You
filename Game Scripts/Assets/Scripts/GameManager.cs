using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public FloatingTextManager floatingTextManager;

    // Update is called once per frame
    void Update()
    {
 
    }


    // The command needed to show any text on the screen
    public void ShowText(string msg, int fontsize, Color color, Vector3 position, Vector3 motion, float duration)
    {
        floatingTextManager.Show(msg, fontsize, color, position, motion, duration);
    }


}
