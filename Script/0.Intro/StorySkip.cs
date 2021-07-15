using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StorySkip : MonoBehaviour
{
    [SerializeField]
    Button button;
    public void Skip()
    {
        SManager.ins.MoveScene();
    }
    private void Awake()
    {
        SoundManager.ins.PlayBGM("IntroScene");
    }
    private void Update()
    {
        if (TextManager.ins.cnt >= TextManager.ins.data.Count)
        {
            button.gameObject.SetActive(true);
        }
    }
}
