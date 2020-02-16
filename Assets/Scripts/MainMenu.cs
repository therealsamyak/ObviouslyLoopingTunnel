using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene((int)Random.Range(1,3));
    }

    public void QuitGame()
    {   
        Application.Quit();
    }
}
