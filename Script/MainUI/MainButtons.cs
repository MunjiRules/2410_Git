using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainButtons : MonoBehaviour
{
    CanvasGroup canvas;
    private void Awake()
    {
        canvas = FindObjectOfType<CanvasGroup>();
    }
    public void OnClickGameStart()
    {
        SceneManager.LoadScene("GamePlay");
    }
    public void OnClickHowToPlay()
    {
        canvas.alpha = 1f;
        canvas.blocksRaycasts = true;
    }
    public void OnClickGameQuit()
    {
        Application.Quit();
    }
}
