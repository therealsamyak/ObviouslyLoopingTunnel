using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgainMenu : MonoBehaviour
{
    public void TryAgain()
    {
        SceneManager.LoadScene((int)Random.Range(1, 3));
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
