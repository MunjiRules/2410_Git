using UnityEngine;
using DG.Tweening;

public class HappyEnd : MonoBehaviour
{
    [SerializeField]
    Sprite[] BackGround;
    [SerializeField]
    SpriteRenderer sprite, Black;

    int scene = 0;
    bool Check = false;
    //TODO Bool같이.. 겹치는 건 좀 상속이나..다르게 바꾸자.
    //TODO 여기서 말할건 아니지만 캔버스 껏다켯다하는 것도 좀 바꾸자. 
    private void Awake()
    {
        SoundManager.ins.StopBGM();
    }
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
            if (TextManager.ins.data[TextManager.ins.cnt]["Story"] == "BGM")
            {
                TextManager.ins.cnt++;
                SoundManager.ins.PlayBGM("HappyEndingScene");
                Black.DOFade(0, 1f);
            }
            if (TextManager.ins.cnt >= 11)
                Black.DOFade(0,2f);
            if (TextManager.ins.cnt >= 11)
                sprite.sprite = BackGround[scene++];
        }
    }
}
