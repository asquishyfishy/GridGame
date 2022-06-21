using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiler : MonoBehaviour
{
    public GameObject tilePrefab;

    //Create a 100x100 grid of tiles
    void Start()
    {
        for (int x = 0; x < 100; x++)
        {
            for (int y = 0; y < 100; y++)
            {
                GameObject tile = Instantiate(tilePrefab, new Vector3(x, y, 0), Quaternion.identity);
                tile.transform.parent = transform;
            }
        }
    }
}
