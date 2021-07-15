using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField]
    Canvas Option;
    public void OnClickNextScene()
    {
        SceneManager.LoadScene("0.IntroScene");
    }
    public void OnClickOption()
    {
        Option.gameObject.SetActive(true);
    }
    public void OnClickCredit()
    {
        SceneManager.LoadScene("Credits");
    }
    public void OnClickExit()
    {
        Application.Quit();
    }
    private void Awake()
    {
        SoundManager.ins.PlayBGM("MainScene");
    }
}
