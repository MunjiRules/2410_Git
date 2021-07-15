using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButtons : MonoBehaviour
{
    CanvasGroup canvas;
    private void Awake()
    {
        canvas = FindObjectOfType<PauseButtons>().GetComponent<CanvasGroup>();
        canvas.alpha = 0f;
        canvas.blocksRaycasts = false;
    }

    public void OnClickPause()
    {
        canvas.alpha = 1f;
        canvas.blocksRaycasts = true;
    }

    public void OnClickPlay()
    {
        canvas.alpha = 0f;
        canvas.blocksRaycasts = false;
    }


}
