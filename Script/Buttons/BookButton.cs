public class BookButton : ParentButton
{
    public void OnClickBook()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("Book"))
            BuildDictionary("책 한 권", "Book", false, false);
        PopupOn = true;
        popupBuilderDictionary["Book"].Build();
    }
    public void OnClickBookCase()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("BookCase"))
            BuildDictionary("책장...?", "BookCase", true, true);
        PopupOn = true;
        popupBuilderDictionary["BookCase"].Build();
    }
    public void OnClickMessage()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("Message"))
            BuildDictionary("수상한 쪽지", "Message", false, false);
        PopupOn = true;
        popupBuilderDictionary["Message"].Build();
    }
    public void OnClickMove()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("Move"))
            BuildDictionary("통로", "Move", true, false);
        PopupOn = true;
        popupBuilderDictionary["Move"].Build();
    }
}
