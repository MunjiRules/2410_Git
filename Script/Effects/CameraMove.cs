using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    const float MaxRight = 7;
    const float MaxLeft = -7;
    float HorizontalKey;
    Vector2 vector2;
    void Update()
    {
        HorizontalKey = Input.GetAxis("Horizontal");
        
        vector2 = new Vector2(HorizontalKey, 0);
        if (gameObject.transform.position.x > MaxLeft && HorizontalKey < 0)
        {
            transform.Translate(vector2 * Time.deltaTime * 10);

        }
        if (gameObject.transform.position.x < MaxRight && HorizontalKey > 0)
        {
            transform.Translate(vector2 * Time.deltaTime * 10);
        }
    }
    
}
