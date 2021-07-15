using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SoundManager.ins.StopBGM();
        Invoke("BackToMain", 1.6f);
    }

    void BackToMain()
    {
        SceneManager.LoadScene("StartScene");
    }
}
