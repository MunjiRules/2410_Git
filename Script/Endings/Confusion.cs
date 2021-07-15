using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Confusion : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer Black, Screens, BedFour, BedNull, TwoDoor, Loading, ConfusonEnd;
    bool Check = false;
    private void Awake()
    {
        SoundManager.ins.PlayBGM("ConfusionScene");
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
            if (TextManager.ins.data[TextManager.ins.cnt]["Story"] == "Bed")
            {
                TextManager.ins.cnt++;
                Screens.gameObject.SetActive(false);
                BedFour.gameObject.SetActive(true);
                Load();
                TextManager.ins.textPrint();
            }
            if (TextManager.ins.data[TextManager.ins.cnt]["Story"] == "Black")
            {
                TextManager.ins.cnt++;
                Black.DOFade(1, 0.3f);
            }
            if (TextManager.ins.data[TextManager.ins.cnt]["Story"] == "BedNull")
            {
                TextManager.ins.cnt++;
                Black.DOFade(0, 0);
                BedFour.gameObject.SetActive(false);
                BedNull.gameObject.SetActive(true);
                Load();
                TextManager.ins.textPrint();
                
            }
            if (TextManager.ins.data[TextManager.ins.cnt]["Story"] == "BedWrong")
            {
                TextManager.ins.cnt++;
                Black.DOFade(0, 0);
                BedNull.gameObject.SetActive(false);
                TwoDoor.gameObject.SetActive(true);
                Load();
                TextManager.ins.textPrint();
            }
            if (TextManager.ins.data[TextManager.ins.cnt]["Story"] == "Ending")
            {
                TextManager.ins.cnt++;
                Black.DOFade(1, 0.1f);
                ConfusonEnd.gameObject.SetActive(true);
            }
        }
    }

    void Load()
    {
        Loading.gameObject.SetActive(true);
        TextManager.ins.StopText = true;
        Black.DOFade(0,0);
        Invoke("LoadOff", 1.6f);
    }

    void LoadOff()
    {
        Loading.gameObject.SetActive(false);
        TextManager.ins.StopText = false;
    }

}
