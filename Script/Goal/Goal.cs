using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Transform))]
public class Goal : MonoBehaviour
{
    CanvasGroup canvas;
    private void Start()
    {
        canvas = FindObjectOfType<FinishButton>().GetComponent<CanvasGroup>();
    }

    void EnterGoal()
    {
        canvas.alpha = 1;
        canvas.blocksRaycasts = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            EnterGoal();
        }
    }
}
