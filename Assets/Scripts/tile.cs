using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tile : MonoBehaviour
{
    //define a color as purple
    public Color purple = new Color(0.5f, 0f, 0.5f);

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //set the tile's color to purple
            GetComponent<Renderer>().material.color = purple;
        }
    }
}
