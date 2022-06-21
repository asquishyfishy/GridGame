using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiler : MonoBehaviour
{
    public GameObject tilePrefab;

    //define a library of colors
    public Color[] colors = new Color[5];
    
    void Start()
    {
        //fill colors using colorFromHex #f6bd60, #f7ede2, #f5cac3, #84a59d, #f28482
        colors[0] = colorFromHex("#f6bd60");
        colors[1] = colorFromHex("#f7ede2");
        colors[2] = colorFromHex("#f5cac3");
        colors[3] = colorFromHex("#84a59d");
        colors[4] = colorFromHex("#f28482");

        for (int x = -100; x < 100; x++)
        {
            for (int y = -100; y < 100; y++)
            {
                GameObject tile = Instantiate(tilePrefab, new Vector3(x, y, 0), Quaternion.identity);
                tile.transform.parent = transform;
                //set the tile's color to a random color from the library
                tile.GetComponent<Renderer>().material.color = colors[Random.Range(0, colors.Length)];
            }
        }
    }

    private Color colorFromHex(string hex){
        //translate the hex string to a Color
        Color color = new Color();
        ColorUtility.TryParseHtmlString(hex, out color);
        return color;  
    }
}
