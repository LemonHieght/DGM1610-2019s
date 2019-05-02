using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    //public SpawnArea spawnArea;
    public int levelLoader;
    //public Text score;

    public void LoadLevel()
    {
        SceneManager.LoadScene(levelLoader);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    //void Update()
    //{
        //score.text = "You Lasted " + spawnArea.waveCounter +"Waves";
    //}
}
