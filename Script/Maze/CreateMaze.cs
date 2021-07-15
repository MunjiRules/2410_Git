using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMaze : MonoBehaviour
{
    [SerializeField] Transform[] houses;
    [SerializeField] GameObject parent;
    Transform child;

    Maze maze;

    private void Awake()
    {
        maze = new Maze();
            maze.GenerateMaze(Const.Game.Width, Const.Game.Width);

        InstantiateMaze(maze.TranslateMaze());
    }

    private void InstantiateMaze(bool[,] maze)
    {
        Vector3 position = new Vector3();
        for (int i = 1; i < Const.Game.Width * 2 + 2; i++)
        {
            for (int j = 1; j < Const.Game.Width * 2 + 2; j++)
            {
                if (!maze[i, j])
                {
                    position = new Vector3(i * 11, 0.5f, j * 11);
                    child = Instantiate(houses[Random.Range(0, houses.Length)], position, Quaternion.identity);
                    child.transform.parent = parent.transform;
                }
            }
        }
    }
}
