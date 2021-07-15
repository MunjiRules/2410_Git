using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndingManager : Singleton<EndingManager>
{
    public void LoadEnding()
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case "1.BedScene":        //엔딩 1: 겁쟁이
                SceneManager.LoadScene("1.CowardEnding");
                break;
            case "3.BookScene":         //엔딩 2: 미치광이
                SceneManager.LoadScene("2.CrazyEnding");

                break;
            case "7.PhoneScene":        //엔딩 5: 가짜
                SceneManager.LoadScene("5.FakeEnding");
                break;
            default:
                break;
        }
    }

    public void MoveScene(bool location) //true > 첫번째 false> 두번째
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case "4.ControlScene":      //엔딩 3: 폭발 or 엔딩 4: 해피엔딩
                if (location)
                    SceneManager.LoadScene("3.BombEnding");
                else
                    SceneManager.LoadScene("4.HappyEnding");
                break;
            case "8.ColorDoorScene":    //엔딩 6: 혼란 or 엔딩 7: 
                if (location)
                    SceneManager.LoadScene("6.ConfusionEnding");
                else
                    SceneManager.LoadScene("7.Ending");
                break;
            default:
                break;
        }
    }
}
