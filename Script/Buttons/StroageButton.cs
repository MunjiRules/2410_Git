using UnityEngine;

public class StroageButton : ParentButton
{
    [SerializeField]
    GameObject cloth;
    public void OnClickCalander()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("Calander"))
            BuildDictionary("찢어진 달력", "Calander", false);
        PopupOn = true;
        popupBuilderDictionary["Calander"].Build();

    }
    public void OnClickKeyPad()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("KeyPad"))
        {
            if (TextManager.ins.cnt >= 7)
                BuildDictionary("키패드", "KeyPad", true, false);
            else
                BuildDictionary("키패드", "KeyPad", true, true);
        }
        PopupOn = true;
        popupBuilderDictionary["KeyPad"].Build();

    }
    public void OnClickCloth()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("Cloth"))
        {
            popupBuilder.Add(new PopupBuilder(this.transform));
            popupBuilder[cnt].SetTitle("천");
            popupBuilder[cnt].SetDescription(TextManager.ins.data[0]["Cloth"]);
            popupBuilder[cnt].SetButton(Yes, SetOff);
            popupBuilder[cnt].SetButton(No, Off);
            popupBuilderDictionary.Add("Cloth", popupBuilder[cnt++]);
        }
        PopupOn = true;
        popupBuilderDictionary["Cloth"].Build();

    }
    public void OnClickClothes()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("Clothes"))
            BuildDictionary("옷들", "Clothes", false);
        PopupOn = true;
        popupBuilderDictionary["Clothes"].Build();

    }
    public void OnClickDrawer()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("Drawer"))
            BuildDictionary("서랍", "Drawer", false);
        PopupOn = true;
        popupBuilderDictionary["Drawer"].Build();

    }
    public void OnClickPapers()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("Papers"))
            BuildDictionary("서류", "Papers", false);
        PopupOn = true;
        popupBuilderDictionary["Papers"].Build();

    }
    public void OnClickToolBox()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("ToolBox"))
            BuildDictionary("공구상자", "ToolBox", false);
        PopupOn = true;
        popupBuilderDictionary["ToolBox"].Build();

    }

    void SetOff()
    {
        cloth.gameObject.SetActive(false);
        Off();
    }
}
