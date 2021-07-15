public class BedroomButton : ParentButton
{
    public void OnClickDoll()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("Doll"))
            BuildDictionary("토끼인형", "Doll", false, false);
        PopupOn = true;
        popupBuilderDictionary["Doll"].Build();
    }

    public void OnClickCloth()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("Cloth"))
            BuildDictionary("널브러진 옷", "Cloth", false, false);
        PopupOn = true;
        popupBuilderDictionary["Cloth"].Build();
    }
    public void OnClickBooks()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("Books"))
            BuildDictionary("책들", "Books", false, false);
        PopupOn = true;
        popupBuilderDictionary["Books"].Build();
    }
    public void OnClickBag()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("Bag"))
            BuildDictionary("가방", "Bag", false, false);
        PopupOn = true;
        popupBuilderDictionary["Bag"].Build();
    }
    public void OnClickLowerStair()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("DownStairs"))
            BuildDictionary("아래로 내려가는 계단", "DownStairs", true, true);
        PopupOn = true;
        popupBuilderDictionary["DownStairs"].Build();

    }
    public void OnClickUpperStair()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("UpStairs"))
            BuildDictionary("위로 올라가는 계단", "UpStairs", true, false);
        PopupOn = true;
        popupBuilderDictionary["UpStairs"].Build();
    }
    private void Awake()
    {
        SoundManager.ins.PlayBGM("BedScene");
    }
}
