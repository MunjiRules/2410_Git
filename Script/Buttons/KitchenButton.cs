public class KitchenButton : ParentButton
{
  
    public void OnClickMove()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("Move"))
            BuildDictionary("서고로 가는 복도", "Move", true);
        PopupOn = true;
        popupBuilderDictionary["Move"].Build();
    }
    public void OnClickPot()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("Pot"))
            BuildDictionary("냄비", "Pot", false);
        PopupOn = true;
        popupBuilderDictionary["Pot"].Build();
    }
    public void OnClickBooks()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("Books"))
            BuildDictionary("요리 서적들", "Books", false);
        PopupOn = true;
        popupBuilderDictionary["Books"].Build();
    }
    public void OnClickFireButton()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("FireButton"))
            BuildDictionary("가스렌지 버튼", "FireButton", false);
        PopupOn = true;
        popupBuilderDictionary["FireButton"].Build();
    }
    public void OnClickCookMaterial()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("CookMaterial"))
            BuildDictionary("조리 도구", "CookMaterial", false);
        PopupOn = true;
        popupBuilderDictionary["CookMaterial"].Build();
    }
    public void OnClickEat()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("Eat"))
            BuildDictionary("차려진 식기 도구", "Eat", false);
        PopupOn = true;
        popupBuilderDictionary["Eat"].Build();
    }

}