using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundControler : MonoBehaviour
{
    [SerializeField]
    Slider BGM;
    [SerializeField]
    Slider SFX;

    private void Start()
    {
        BGM.value = PlayerPrefs.GetFloat("BGMVolume");
        SFX.value = PlayerPrefs.GetFloat("SFXVolume");
    }
    public void SliderBGM()
    {
        SoundManager.ins.ChangeVolumeBGM(BGM.value);
    }
    public void SliderSFX()
    {
        SoundManager.ins.ChangeVolumeSFX(SFX.value);
    }
}
