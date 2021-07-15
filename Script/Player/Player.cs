using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Transform))]
public class Player : MonoBehaviour
{
    Move move;
    Rotate rotate;
    Rigidbody rigidbody;

    private void Start()
    {
        rigidbody = FindObjectOfType<Player>().GetComponent<Rigidbody>();
        move = new Move();
        rotate = new Rotate();
    }
    private void FixedUpdate()
    {
        
        move.update(gameObject, rigidbody);
        rotate.update(gameObject);
    }
}
