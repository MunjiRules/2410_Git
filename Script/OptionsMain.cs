using UnityEngine;
using UnityEngine.UI;

public class OptionsMain : MonoBehaviour
{
    [SerializeField]
    GraphicRaycaster graphic;

    void OnEnable()
    {
        OptionActivate.Option = true;
        graphic.gameObject.SetActive(false);
        Time.timeScale = 0;
    }
   
    private void OnDisable()
    {
        OptionActivate.Option = false;
        graphic.gameObject.SetActive(true);
        Time.timeScale = 1;
    }

    public void OnClickOffOption()
    {
        gameObject.SetActive(false);
    }
    public void OnClickBackToMain()
    {
        SManager.ins.LoadScene();
    }
}
