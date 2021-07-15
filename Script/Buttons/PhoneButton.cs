public class PhoneButton : ParentButton
{
    public void OnClickPhone()
    {
        if (PopupOn)
            return;
        if (!popupBuilderDictionary.ContainsKey("Phone"))
            BuildDictionary("전화기", "Phone", true);
        PopupOn = true;
        popupBuilderDictionary["Phone"].Build();

    }
    private void Awake()
    {
        SoundManager.ins.PlayBGM("PhoneScene");
        SoundManager.ins.PlaySFX("BellSound");
    }
    private void OnDisable()
    {
        SoundManager.ins.StopSFX();
    }
}
