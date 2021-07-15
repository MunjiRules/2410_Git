using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class Credits : MonoBehaviour
{

    void Start()
    {
        SoundManager.ins.PlayBGM("Credits");
        gameObject.GetComponent<SpriteRenderer>().DOFade(1, 1f).SetEase(Ease.Linear).OnComplete(()=> 
        { 
            gameObject.transform.DOMoveY(21, 35f).SetEase(Ease.Linear).OnComplete(()=> {
                gameObject.GetComponent<SpriteRenderer>().DOFade(0, 0.5f).SetEase(Ease.Linear).OnComplete(() =>
                {
                    SceneManager.LoadScene("StartScene");
                });
            }); 
        });
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("StartScene");
        }
    }
}
