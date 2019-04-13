using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGeneration : MonoBehaviour
{
    public int tileCountX, tileCountY;
    public GameObject tileSpriteFullGrass, tileSpriteLeftCoast, tileSpriteRightCoast, tileSpriteTopCoast, tileSpriteBottomCoast;


    // Start is called before the first frame update
    void Start()
    {
        TileBuild();
    }
    public void TileBuild()
    {
        tileSpriteTopCoast = tileSpriteLeftCoast;
        tileSpriteRightCoast = tileSpriteLeftCoast;
        tileSpriteBottomCoast = tileSpriteLeftCoast;
        
        tileCountX = 0;
        tileCountY = 0;
              
        float lastTileX = 0;
        float lastTileY = 0;    
         GameObject firstEdge =Instantiate(tileSpriteLeftCoast, new Vector3 (lastTileX + 1, lastTileY, 0), gameObject.transform.rotation);
        lastTileX=firstEdge.transform.position.x;
        lastTileY=firstEdge.transform.position.y;
        do
        {
            do
            {
                GameObject lastTile = Instantiate(tileSpriteFullGrass, new Vector3 (lastTileX + 1, lastTileY, 0), gameObject.transform.rotation);
                lastTileX = lastTile.transform.position.x;
                lastTileY = lastTile.transform.position.y;
                tileCountX++;
            }

            while(tileCountX < 20);
            tileCountY++;
            Instantiate(tileSpriteFullGrass, new Vector3 (lastTileX, lastTileY + 1, 0), gameObject.transform.rotation);
        }
        while(tileCountY < 20);
        GameObject endEdge =Instantiate(tileSpriteLeftCoast, new Vector3 (lastTileX + 1, lastTileY, 0), gameObject.transform.rotation);
    }
}
