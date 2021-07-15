using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupPanel : MonoBehaviour
{
    // 제목 text오브젝트 
    [SerializeField]
    private Text titleText = null;
    // 설명 text오브젝트 
    [SerializeField]
    private Text descriptionText = null;
    // 버튼생성시 버튼들의 부모, 레이아웃을 사용해 생성시마다 위치를 잡아준다. 
    [SerializeField]
    private GameObject buttonsLayout = null;
    // 버튼 프리팹 
    [SerializeField]
    private GameObject buttonPrefab;

    bool YN;

    public void Init()
    {
        // 팝업등장 - 추가적인 초기화 정보는 여기에 구현, 팝업창생성시 확대되는 느낌같은 연출 넣기에 좋다. 
    }

    public void setTitle(string _title)
    {
        YN = true;
        this.titleText.text = _title;
    }

    public void setDescription(string _description)
    {
        this.descriptionText.text = _description;
    }

    public void setButtons(List<PopupButtonInfo> _popupButtonInfos)
    {

        // 버튼 초기화
        foreach (var info in _popupButtonInfos) 
        {
            //버튼 동적생성 

            GameObject buttonObject = Instantiate(this.buttonPrefab);
            buttonObject.transform.SetParent(this.buttonsLayout.transform, false);
            if (_popupButtonInfos.Count > 1)
            {
                if (YN)
                {
                    buttonObject.transform.Translate(new Vector2(-1.5f, 0));
                    YN = false;
                }
                else
                    buttonObject.transform.Translate(new Vector2(1.5f, 0));
            }
            PopupButton popupButton = buttonObject.GetComponent<PopupButton>();
            popupButton.Init(info.spr, info.callback, this.gameObject);
        }
    }
}

