public class ColorDoorButton : ParentButton
{
    public void OnClickBlueDoor()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("BlueDoor"))
            BuildDictionary("파란색 문", "BlueDoor", true, false);
        PopupOn = true;
        popupBuilderDictionary["BlueDoor"].Build();
    }
    public void OnClickRedDoor()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("RedDoor"))
            BuildDictionary("빨간색 문", "RedDoor", true, true);
        PopupOn = true;
        popupBuilderDictionary["RedDoor"].Build();
    }
    private void Awake()
    {
        if (!(SoundManager.ins.BGMName == "ColorDoorScene"))
            SoundManager.ins.PlayBGM("ColorDoorScene");
    }
}
