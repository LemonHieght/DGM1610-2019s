using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGen : MonoBehaviour
{
    public int width, height;
    public GameObject tileGrass;
    public int tileOffSet = 1;

    // Start is called before the first frame update
    void Start()
    {
        GenMap();
    }
    void GenMap()
    {
        for(int x = -1; x < width; x++)
        {
            for(int y = -1; y < height ; y++)
            {
                Vector3 position = new Vector3(x + tileOffSet, y + tileOffSet, 0);
                Instantiate(tileGrass, position, Quaternion.identity);
            }
            
        }
        for(int x = 1; x > width; x++)
        {
            for(int y = 1; y > height ; y++)
            {
                Vector3 position = new Vector3(x - tileOffSet, y - tileOffSet, 0);
                Instantiate(tileGrass, position, Quaternion.identity);
            }
            
        }

    }
}
