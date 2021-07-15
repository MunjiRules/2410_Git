using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class Rotate
{
    public void update(GameObject gameObject)
    {
        float h = CrossPlatformInputManager.GetAxis("Horizontal");
        gameObject.transform.Rotate(new Vector3(0, h, 0), Const.Player.RotateSpeed * Time.deltaTime);
    }
}
