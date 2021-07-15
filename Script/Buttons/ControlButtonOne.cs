using UnityEngine;
using DG.Tweening;

public class ControlButtonOne : ParentButton
{
    bool ButtonClicked = false;
    [SerializeField]
    SpriteRenderer Bright, Dark;
    bool Played = false, Play = false;
    [SerializeField]
    SpriteRenderer Black;

    private void Awake()
    {
        SoundManager.ins.PlayBGM("ControlScene");
    }
    public void OnClickButton()
    {
        ButtonClicked = true;
        Bright.gameObject.SetActive(true);
        Bright.DOFade(1, 3f).SetEase(Ease.OutCubic);
        Dark.DOFade(0, 2f).SetEase(Ease.OutCubic).OnComplete(() => { Dark.gameObject.SetActive(false); });
    }

    public void OnClickMove()
    {
        if (!ButtonClicked)
            return;

        SManager.ins.MoveScene();
    }

    private void Update()
    {
        if (Play)
            return;

        if (TextManager.ins.data[TextManager.ins.cnt]["Story"] == "Skip")
        {
            TextManager.ins.StopText = true;
        }

        if (TextManager.ins.data[TextManager.ins.cnt]["Story"] == "Start")
        {
            turnOn();
        }

        if (ButtonClicked)
        {
            TextManager.ins.StopText = false;
            TextManager.ins.cnt++;
            TextManager.ins.textPrint();
            Play = true;
        }

    }

    void turnOn()
    {
        if (Played)
            return;

        TextManager.ins.cnt++;
        Black.DOFade(0,1).OnComplete(()=> { Black.gameObject.SetActive(false); });
        Played = true;
    }
}
