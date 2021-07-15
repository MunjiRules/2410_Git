using UnityEngine;
using DG.Tweening;

public class BombEnd : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer sprite, RedScene, Black;
    bool Check = false;
    private void Awake()
    {
        SoundManager.ins.PlayBGM("BombScene");
        sprite.DOFade(0.3f, 0.3f).SetLoops(-1, LoopType.Yoyo);
        RedScene.DOFade(0.8f, 0.15f).SetLoops(-1, LoopType.Yoyo);
    }
    private void Update()
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

            if (TextManager.ins.data[TextManager.ins.cnt]["Story"] == "Start")
            {
                TextManager.ins.cnt++;
                Black.DOFade(0, 1f);
            }
        }
    }
}
