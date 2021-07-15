using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

public class TextManager : Singleton<TextManager>
{
    [SerializeField]
    Text text1;
    [SerializeField]
    Text text2;
    [SerializeField]
    Animator anim1, anim2;

    bool CText;   //0 > txt1 1 > txt 2
    public bool StopText = false;
    public int cnt = 0;
    public List<Dictionary<string, string>> data;
    void Start()
    {
        StopText = false;
        data = CSVReader.Read(SceneManager.GetActiveScene().name);
        CText = false;
        textPrint();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (StopText)
                return;

            if (cnt >= data.Count)
                return;

            textPrint();
        }
    }

    private void initText(Text text)
    {
        text.text = data[cnt++]["Story"];
        text.DOFade(0, 0);
        text.gameObject.SetActive(true);
    }

    public void textPrint()
    {   
        if (CText)           //txt 1의 차례일 때
        {
            PrintDetail(text1, text2);
        }
        else                //txt 2의 차례일 때
        {
            PrintDetail(text2, text1);
        }

        if (CText)
            CText = false;
        else
            CText = true;
    }

    void PrintDetail(Text CurruntText, Text BeforeText)
    {
        BeforeText.DOFade(0, 0);
        BeforeText.gameObject.SetActive(false);
        initText(CurruntText);
        CurruntText.DOFade(1, 0.5f);
    }
}
