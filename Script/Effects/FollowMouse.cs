using UnityEngine;
using System.Collections;


public class FollowMouse : MonoBehaviour
{
    Vector2 newPosition;

    void Update()
    {
        newPosition = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        gameObject.transform.position = new Vector2(newPosition.x, newPosition.y);

    }
}
