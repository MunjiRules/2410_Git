using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class End : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer Black;
    bool Check = false;
    private void Awake()
    {
        SoundManager.ins.StopBGM();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Check)
                SManager.ins.LoadScene();
            if (TextManager.ins.cnt >= TextManager.ins.data.Count)
            {
                Check = true;
                return;
            }
            if (TextManager.ins.data[TextManager.ins.cnt]["Story"] == "Start")
            {
                TextManager.ins.cnt++;
                Black.DOFade(0, 1f);
            }
            if (TextManager.ins.data[TextManager.ins.cnt]["Story"] == "End")
            {
                TextManager.ins.cnt++;
                Black.DOFade(1, 0.5f);
            }
        }
    }
}
