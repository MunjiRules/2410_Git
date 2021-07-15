public class MainDoorButton : ParentButton
{
    public void OnClickHandle()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("Handle"))
            BuildDictionary("현관", "Handle", false);
        PopupOn = true;
        popupBuilderDictionary["Handle"].Build();
    }
    public void OnClickToStorage()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("ToStorage"))
            BuildDictionary("이곳은 주방으로 가는 길이 아닙니다.", "ToStorage", true, false);
        PopupOn = true;
        popupBuilderDictionary["ToStorage"].Build();
    }
    public void OnClickToKitchen()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("ToKitchen"))
            BuildDictionary("주방으로 가는 길", "ToKitchen", true, true);
        PopupOn = true;
        popupBuilderDictionary["ToKitchen"].Build();
    }

  
}
