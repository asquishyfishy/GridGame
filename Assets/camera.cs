using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    //Define a light blue color
    Color lightBlue = new Color(0.5f, 0.8f, 1f);
    //define a darke blue color
    Color darkBlue = new Color(0.2f, 0.4f, 0.6f);

    void Start()
    {
        GetComponent<Camera>().backgroundColor = lightBlue;
    }
    
    void Update()
    {
        //if the player presses the spacebar, swap  the background color
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (GetComponent<Camera>().backgroundColor == lightBlue)
            {
                GetComponent<Camera>().backgroundColor = darkBlue;
            }
            else
            {
                GetComponent<Camera>().backgroundColor = lightBlue;
            }
        }
    }

}
