using UnityEngine;
using DG.Tweening;

public class IntroEffect : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer spr;
    void Start()
    {
        OnOff();
    }

    void OnOff()
    {
        spr.DOFade(Random.Range(0.00f, 1.00f), Random.Range(0.00f, 0.45f)).OnComplete(OnOff);
    }
}
