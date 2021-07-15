using UnityEngine;
using DG.Tweening;

public class ControlButtonThree : ParentButton
{
    [SerializeField]
    SpriteRenderer sprite;

    public void OnClickOn()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("On"))
            BuildDictionary("정신 지배 장치 활성화", "On", true, true);
        PopupOn = true;
        popupBuilderDictionary["On"].Build();
    }
    public void OnClickOff()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("Off"))
            BuildDictionary("정신 지배 장치 비활성화", "Off", true, false);
        PopupOn = true;
        popupBuilderDictionary["Off"].Build();
    }

    private void Awake()
    {
        sprite.DOFade(0.2f, 0.3f).SetLoops(-1, LoopType.Yoyo);
    }
}
