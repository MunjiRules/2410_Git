using UnityEngine;
using UnityEngine.SceneManagement;

public class SManager : Singleton<SManager>
{
    public void MoveScene()
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case "0.IntroScene":
                SceneManager.LoadScene("1.BedScene");
                break;
            case "2.KitchenScene":
                SceneManager.LoadScene("3.BookScene");
                break;
            case "4.ControlScene1":
                SceneManager.LoadScene("4.ControlScene2");
                break;
            case "4.ControlScene2":
                SceneManager.LoadScene("4.ControlScene3");
                break;
            case "7.PhoneScene":
                SceneManager.LoadScene("5.FakeEnding");
                break;
            default:
                Debug.LogError("Unfined Scene : " + SceneManager.GetActiveScene().name);
                break;
        }
    }

    public void MoveSceneFalse() //true > 오른쪽 false> 왼쪽
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case "1.BedScene":
            case "5.MainDoorScene":
                SceneManager.LoadScene("2.KitchenScene");
                break;
            case "3.BookScene":
                    SceneManager.LoadScene("4.ControlScene1");
                break;
            case "4.ControlScene3":
                SceneManager.LoadScene("3.BombEnding");
                break;
            case "6.StorageScene":
                    SceneManager.LoadScene("7.PhoneScene");
                break;
            case "8.ColorDoorScene":
                SceneManager.LoadScene("8.ColorDoorScene2");
                break;
            case "8.ColorDoorScene2":
                SceneManager.LoadScene("8.ColorDoorScene3");
                break;
            case "8.ColorDoorScene3":
                SceneManager.LoadScene("7.Ending");
                break;
            default:
                Debug.LogError("Unfined Scene : " + SceneManager.GetActiveScene().name);
                break;
        }
    }
    public void MoveSceneTrue() //true > 오른쪽 false> 왼쪽
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case "1.BedScene":
                    SceneManager.LoadScene("5.MainDoorScene");
                break;
            case "3.BookScene":
                SceneManager.LoadScene("2.CrazyEnding");
                break;
            case "4.ControlScene3":
                SceneManager.LoadScene("4.HappyEnding");
                break;
            case "5.MainDoorScene":
                    SceneManager.LoadScene("6.StorageScene");
                break;
            case "6.StorageScene":
                    SceneManager.LoadScene("8.ColorDoorScene");
                break;
            case "8.ColorDoorScene":
            case "8.ColorDoorScene2":
            case "8.ColorDoorScene3":
                SceneManager.LoadScene("6.ConfusionEnding");
                break;
            default:
                Debug.LogError("Unfined Scene : " + SceneManager.GetActiveScene().name);
                break;
        }
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("LoadingScene");
    }
}
