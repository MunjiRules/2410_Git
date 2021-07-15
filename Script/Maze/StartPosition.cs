using UnityEngine;

public class StartPosition : MonoBehaviour
{
    Transform Player;
    Transform Goal;
    float playerX;
    int playerZ;
    int GoalX;
    int GoalZ;


    public Vector3 InitStartPositionCar()
    {
        playerX = Random.Range(1, (Const.Game.Width + 1)) * 2;
        playerZ = 2;
        Vector3 PlayerPosition = new Vector3();

        PlayerPosition.x = playerX * 11f + 5;
        PlayerPosition.z = playerZ * 13.5f;   
        PlayerPosition.y = 2;
        return PlayerPosition;
        //20//1~10*2
    }
    public Vector3 InitStartPositionGoal()
    {
        GoalX = Random.Range(1, (Const.Game.Width + 1)) * 2;
        GoalZ = (Random.Range(Const.Game.Width, Const.Game.Width - 2)) * 2;
        Vector3 GoalPosition = new Vector3();

        GoalPosition.x = GoalX * 11f + 6;
        GoalPosition.z = GoalZ * 11.2f;
        GoalPosition.y = 0.5f;
        return GoalPosition;
    }

    private void Awake()
    {
        Player = FindObjectOfType<Player>().transform;
        Goal = FindObjectOfType<Goal>().transform;
    }
    private void Start()
    {
        Player.position = InitStartPositionCar();
        Goal.position = InitStartPositionGoal();
    }
}
    