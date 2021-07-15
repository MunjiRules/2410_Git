using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Move
{
    public void update(GameObject gameObject, Rigidbody rigidbody)
    {
        float v = CrossPlatformInputManager.GetAxis("Vertical");
        gameObject.transform.position += gameObject.transform.forward * Const.Player.MoveSpeed * v * Time.deltaTime;
    }
}
