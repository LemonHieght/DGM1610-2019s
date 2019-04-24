using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveCounter : MonoBehaviour
{
    public SpawnArea spawnArea;
    public Text waveNumber;
    public Text enemyCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        waveNumber.text = "Wave: " + spawnArea.waveCounter;
        enemyCount.text = "enemies left: " + spawnArea.liveEnemys;
    }
}
