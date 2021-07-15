using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void CallbackEvent();

public class PopupButtonInfo
{
    // 버튼정보를 들고있는 클래스 - Builder에서 popup객체로 정보를 보낼때 사용 
    public Sprite spr = null;
    public CallbackEvent callback = null;

    public PopupButtonInfo(Sprite _text, CallbackEvent _callback)
    {
        this.spr = _text;
        this.callback = _callback == null ? () => { Debug.Log("아무것도 없는"); } : _callback;
    }
}