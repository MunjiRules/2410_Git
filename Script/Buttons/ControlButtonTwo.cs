using UnityEngine;
using DG.Tweening;

public class ControlButtonTwo : ParentButton
{
    [SerializeField]
    SpriteRenderer sprite;

    public void OnClickPicture()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("Picture"))
            BuildDictionary("액자", "Picture", false);
        PopupOn = true;
        popupBuilderDictionary["Picture"].Build();
    }
    public void OnClickButtonO()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("ButtonO"))
            BuildDictionary("첫 번째 버튼", "ButtonO", false);
        PopupOn = true;
        popupBuilderDictionary["ButtonO"].Build();
    }
    public void OnClickButtonTw()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("ButtonTw"))
            BuildDictionary("두 번째 버튼", "ButtonTw", false);
        PopupOn = true;
        popupBuilderDictionary["ButtonTw"].Build();
    }
    public void OnClickButtonTr()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("ButtonTr"))
            BuildDictionary("세 번째 버튼", "ButtonTr", false);
        PopupOn = true;
        popupBuilderDictionary["ButtonTr"].Build();
    }
    public void OnClickButtonFo()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("ButtonFo"))
            BuildDictionary("네 번째 버튼", "ButtonFo", false);
        PopupOn = true;
        popupBuilderDictionary["ButtonFo"].Build();
    }
    public void OnClickButtonFi()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("ButtonFi"))
            BuildDictionary("다섯 번째 버튼", "ButtonFi", false);
        PopupOn = true;
        popupBuilderDictionary["ButtonFi"].Build();
    }
    public void OnClickExit()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("Exit"))
            BuildDictionary("탈출구?", "Exit", true);
        PopupOn = true;
        popupBuilderDictionary["Exit"].Build();
    }
    private void Awake()
    {
        sprite.DOFade(0.15f, 0.5f).SetLoops(-1, LoopType.Yoyo);
    }
}
