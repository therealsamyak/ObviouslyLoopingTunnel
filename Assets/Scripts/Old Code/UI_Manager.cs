using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public Text score;
    public Button retry;
    public Canvas canvas;

    public void UpdateScore()
    {
        score.text = "Score: " + Score_manager.score;
    }

    public void InstantiateRetryButton()
    {
        Instantiate(retry.gameObject, canvas.gameObject.transform);
    }
}
