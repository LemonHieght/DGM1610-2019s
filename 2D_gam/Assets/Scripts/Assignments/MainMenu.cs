using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Indexed Level to load
    public int levelToLoad;

//this function loads the level in the levelToLoad var after button in pressed
    public void LoadLevel()
    {
        SceneManager.LoadScene(levelToLoad);
    }
    //this fuction quits game after the button is pressed
    public void LevelExit()
    {
        Application.Quit();
    }

}
