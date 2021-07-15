using UnityEngine;

public class FakeEnd : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer Black;
    [SerializeField]
    GameObject[] gameObjects;

    bool Check = false;
    int cnt = 0;
    private void Awake()
    {
        SoundManager.ins.StopBGM();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Check)
                SManager.ins.LoadScene();
            if (TextManager.ins.cnt >= TextManager.ins.data.Count)
            {
                Check = true;
                return;
            }
            if (TextManager.ins.data[TextManager.ins.cnt]["Story"] == "BGM")
            {
                TextManager.ins.cnt++;
                SoundManager.ins.PlayBGM("FakeScene");
            }
            if (TextManager.ins.cnt >= (TextManager.ins.data.Count - gameObjects.Length))
            {
                gameObjects[cnt++].SetActive(true);
            }
        }
    }
}
