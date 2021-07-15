using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlaySound : MonoBehaviour
{
    void Awake()
    {
        SoundManager.ins.PlayBGM("GamePlayBGM");
    }
    public void OnClickButton()
    {
        SoundManager.ins.PlaySFX("ButtonClick");
    }
}
