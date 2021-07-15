using UnityEngine;
using DG.Tweening;

public class CrazyEnd : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer Black, Sky, Man;

    bool Check = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Check)
            {
                SManager.ins.LoadScene();
            }
            if (TextManager.ins.cnt >= TextManager.ins.data.Count)
            {
                Check = true;
                return;
            }
            if (TextManager.ins.data[TextManager.ins.cnt]["Story"] == "Start")
            {
                TextManager.ins.cnt++;
                Black.DOFade(0, 1f);
            }
            if (TextManager.ins.data[TextManager.ins.cnt]["Story"] == "Sky")
            {
                TextManager.ins.cnt++;
                Sky.DOFade(1, 1f);
            }
            if (TextManager.ins.data[TextManager.ins.cnt]["Story"] == "Black")
            {
                TextManager.ins.cnt++;
                Black.DOFade(1, 0);
                Sky.gameObject.SetActive(false);
            }
            if (TextManager.ins.data[TextManager.ins.cnt]["Story"] == "Stop")
            {
                TextManager.ins.cnt++;
                Black.DOFade(1, 0);
            }
            if (TextManager.ins.data[TextManager.ins.cnt]["Story"] == "Crazy")
            {
                TextManager.ins.cnt++;
                Man.DOFade(1, 2f);
            }
            if (TextManager.ins.data[TextManager.ins.cnt]["Story"] == "StartTwo")
            {
                TextManager.ins.cnt++;
                SoundManager.ins.PlayBGM("HallSceneTwo");
                Black.DOFade(0, 1f);
            }
        }
    }

    private void Awake()
    {
        SoundManager.ins.PlayBGM("HallSceneOne");
    }
}