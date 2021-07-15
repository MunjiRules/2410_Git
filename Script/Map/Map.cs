using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public class Map : MonoBehaviour
{
    CanvasGroup canvas;
    private void Start()
    {
        canvas = FindObjectOfType<Map>().GetComponent<CanvasGroup>();
    }
    public void OnClickOnMap()
    {
        canvas.alpha = 1f;
        canvas.blocksRaycasts = true;
    }
    public void OnClickOffMap()
    {
        canvas.alpha = 0f;
        canvas.blocksRaycasts = false;
    }
}
