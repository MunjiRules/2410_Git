using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    [SerializeField]
    GraphicRaycaster graphic;
    
    void OnEnable()
    {
        OptionActivate.Option = true;
        TextManager.ins.StopText = true;
        graphic.gameObject.SetActive(false);
        Time.timeScale = 0;
    }

    private void OnDisable()
    {
        OptionActivate.Option = false;
        TextManager.ins.StopText = false;
        graphic.gameObject.SetActive(true);
        Time.timeScale = 1;
    }
    
    public void OnClickOffOption()
    {
        gameObject.SetActive(false);
    }
    public void OnClickBackToMain()
    {
        gameObject.SetActive(false);
        SManager.ins.LoadScene();
    }
}
