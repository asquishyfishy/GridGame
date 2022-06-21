using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    //Define a light blue color
    Color lightBlue = new Color(0.5f, 0.8f, 1f);

    void Start()
    {
        GetComponent<Camera>().backgroundColor = lightBlue;
    }

}
