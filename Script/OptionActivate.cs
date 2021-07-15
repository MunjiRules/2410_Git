using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionActivate : MonoBehaviour
{
    static public bool Option = false;
    [SerializeField]
    Canvas options;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Option)
            {
                options.gameObject.SetActive(false);
                Option = false;
            }
            else
            {
                options.gameObject.SetActive(true);
                Option = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            SoundManager.ins.PlaySFX("ClickSound");
        }
    }
}
