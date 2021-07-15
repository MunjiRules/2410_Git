using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishButton : MonoBehaviour
{
    public void OnClickRePlay()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void OnClickBackToMain()
    {
        SceneManager.LoadScene("Main");
    }
}
