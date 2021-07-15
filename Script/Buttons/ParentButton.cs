using System.Collections.Generic;
using UnityEngine;

public class ParentButton : MonoBehaviour
{
    [SerializeField]
    protected Sprite Yes, No, Ok;
    protected Dictionary<string, PopupBuilder> popupBuilderDictionary;
    protected List<PopupBuilder> popupBuilder;
    protected int cnt;
    protected bool PopupOn;

    protected void Start()
    {
        cnt = 0;
        popupBuilder = new List<PopupBuilder>();
        popupBuilderDictionary = new Dictionary<string, PopupBuilder>();
    }

    //이동 가능한 Scene이 한개일 때
    protected void BuildDictionary(string Title, string objName, bool scene, bool whichScene)
    {
        popupBuilder.Add(new PopupBuilder(this.transform));
        Build(Title, objName, scene, whichScene);
        popupBuilderDictionary.Add(objName, popupBuilder[cnt++]);
    }
    protected void Build(string Title, string objName, bool scene, bool whichScene)
    {
        popupBuilder[cnt].SetTitle(Title);
        popupBuilder[cnt].SetDescription(TextManager.ins.data[0][objName]);
        if (scene)
        {
            if (whichScene)
            {
                popupBuilder[cnt].SetButton(Yes, SManager.ins.MoveSceneFalse);
                popupBuilder[cnt].SetButton(No, Off);
            }
            else
            {
                popupBuilder[cnt].SetButton(Yes, SManager.ins.MoveSceneTrue);
                popupBuilder[cnt].SetButton(No, Off);
            }
        }
        else
            popupBuilder[cnt].SetButton(Ok, Off);

    }

    //이동 가능한 Scene이 2개일때
    protected void BuildDictionary(string Title, string objName, bool scene)
    {
        popupBuilder.Add(new PopupBuilder(this.transform));
        Build(Title, objName, scene);
        popupBuilderDictionary.Add(objName, popupBuilder[cnt++]);
    }
    protected void Build(string Title, string objName, bool scene)
    {
        popupBuilder[cnt].SetTitle(Title);
        popupBuilder[cnt].SetDescription(TextManager.ins.data[0][objName]);
        if (scene)
        {
            popupBuilder[cnt].SetButton(Yes, SManager.ins.MoveScene);
            popupBuilder[cnt].SetButton(No, Off);
        }
        else
            popupBuilder[cnt].SetButton(Ok, Off);

    }

    protected void Off()
    {
        PopupOn = false;
        Destroy(this.GetComponentInChildren<PopupPanel>().gameObject);
    }
}
