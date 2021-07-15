using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinPoint : MonoBehaviour
{
    [SerializeField] Transform picture;
    [SerializeField] Transform Player;
    [SerializeField] Transform Gpicture;
    [SerializeField] Transform Goal;

    Vector3 vector;
    private void Awake()
    {
        Player = FindObjectOfType<Player>().transform;
        Goal = FindObjectOfType<Goal>().transform;
    }
    private void Start()
    {
        vector = Goal.position;
        vector.y += 100;
        Gpicture.position = vector;
    }
    
    void Update()
    {
        vector = Player.position;
        vector.y += 100;
        picture.position = vector;
    }
}
