using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSound : MonoBehaviour
{
    void Awake()
    {
        SoundManager.ins.PlayBGM("MainBGM");
        Application.targetFrameRate = 60;
    }
    public void OnClickButton()
    {
        SoundManager.ins.PlaySFX("ButtonClick");
    }
}
