using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze
{
    private const int MaxBias = 64;
    private const int Bias = 32;

    private int width;                                  
    private int height;                                 

    private List<Set> sets;                           
    private List<Cell> row;                             

    private Cell[,] maze;                               

    public void GenerateMaze(int width, int height)
    {
        this.width = width;                           
        this.height = height;                       

        maze = new Cell[width, height];               
        sets = new List<Set>();                    
        row = new List<Cell>();                      

        for (int i = 0; i < this.width; i++)
        {
            row.Add(new Cell());
        }

        for (int x = 0; x < this.height; x++)
        {

            if (x == this.height - 1)
            {
                InitSets();

                foreach (Cell cell in row)
                {
                    cell.HasBottomWall = true;
                }

                for (int i = 0; i < row.Count - 1; i++)
                {
                    if (row[i].Set != row[i + 1].Set)
                    {
                        row[i].HasRightWall = false;
                    }
                    else
                    {
                        row[i].HasRightWall = true;
                    }

                }

                row[row.Count - 1].HasRightWall = true;

                WriteRowIntoMaze(x);
                continue;
            }

            InitSets();

            for (int i = 0; i < row.Count - 1; i++)
            {
                if (row[i].Set == row[i + 1].Set)
                {
                    row[i].HasRightWall = true;
                }
            }
            CreateRightWalls();
            CreateDownWalls();
            WriteRowIntoMaze(x);
            PrepareNextRow();
        }
    }
    private bool CreateWall
    {
        get
        {
            int x = Random.Range(0, MaxBias + 1);

            if (x > Bias)
            {
                return true;
            }

            return false;
        }
    }
    private void CreateRightWalls()
    {
        for (int i = 0; i < row.Count - 1; i++)
        {

            if (CreateWall)
            {
                row[i].HasRightWall = true;
            }
            else if (row[i].Set == row[i + 1].Set)
            {
                row[i].HasRightWall = true;
            }
            else
            {
                row[i + 1].Set.Cells.Remove(row[i + 1]);
                row[i].Set.Cells.Add(row[i + 1]);
                row[i + 1].Set = row[i].Set;
            }
        }

        row[row.Count - 1].HasRightWall = true;
    }

    private void CreateDownWalls()
    {
        foreach (Set set in sets.ToArray())
        {
            if (set.Cells.Count > 0)
            {
                List<int> cellIndices = new List<int>();

                if (set.Cells.Count == 1)
                {
                    cellIndices.Add(0);
                }
                else
                {
                    int downPaths = Random.Range(1, set.Cells.Count + 1);

                    for (int i = 0; i < downPaths; i++)
                    {
                        int index;

                        do
                        {
                            index = Random.Range(0, set.Cells.Count);

                        } while (cellIndices.Contains(index));

                        cellIndices.Add(index);
                    }
                }

                for (int k = 0; k < set.Cells.Count; k++)
                {
                    if (!cellIndices.Contains(k))
                    {
                        set.Cells[k].HasBottomWall = true;
                    }
                    else
                    {
                        set.Cells[k].HasBottomWall = false;
                    }
                }
            }
            else
            {
                sets.Remove(set);
            }
        }
    }

    private void PrepareNextRow()
    {
        foreach (Cell cell in row)
        {
            cell.HasRightWall = false;

            if (cell.HasBottomWall)
            {
                cell.Set.Cells.Remove(cell);
                cell.Set = null;
                cell.HasBottomWall = false;
            }
        }
    }

    private void InitSets()
    {
        foreach (Cell cell in row)
        {
            if (cell.Set == null)
            {
                Set set = new Set();       
                cell.Set = set;             

                set.Cells.Add(cell);       
                sets.Add(set);              
            }
        }
    }
    private void WriteRowIntoMaze(int h)
    {
        for (int i = 0; i < row.Count; i++)
        {
            Cell cell = new Cell
            {
                HasBottomWall = row[i].HasBottomWall,
                HasRightWall = row[i].HasRightWall
            };

            maze[i, h] = cell;
        }
    }

    public bool[,] TranslateMaze()
    {
        bool[,] mazeTranslation = new bool[height * 2 + 2, width * 2 + 2];

        for (int i = 0; i < height + 1; i++)
        {
            int y = i - 1;

            for (int j = 0; j < width + 1; j++)
            {
                int x = j - 1;
                if (i == 0)
                {
                    mazeTranslation[i * 2, j * 2] = Const.Game.Wall;              
                    mazeTranslation[i * 2, j * 2 + 1] = Const.Game.Wall;             
                    mazeTranslation[i * 2 + 1, j * 2] = Const.Game.Wall;              
                    mazeTranslation[i * 2 + 1, j * 2 + 1] = Const.Game.Wall;         

                    continue;
                }

                if (j == 0)
                {
                    mazeTranslation[i * 2, j * 2] = Const.Game.Wall;                  
                    mazeTranslation[i * 2, j * 2 + 1] = Const.Game.Wall;             
                    mazeTranslation[i * 2 + 1, j * 2] = Const.Game.Wall;             
                    mazeTranslation[i * 2 + 1, j * 2 + 1] = Const.Game.Wall;          

                    continue;
                }

                if (maze[x, y].HasRightWall && maze[x, y].HasBottomWall)
                {
                    mazeTranslation[i * 2, j * 2] = Const.Game.Path;                 
                    mazeTranslation[i * 2, j * 2 + 1] = Const.Game.Wall;               
                    mazeTranslation[i * 2 + 1, j * 2] = Const.Game.Wall;               
                    mazeTranslation[i * 2 + 1, j * 2 + 1] = Const.Game.Wall;           

                    if (i > 1)
                    {
                        mazeTranslation[i * 2 - 1, j * 2 + 1] = Const.Game.Wall;
                    }

                    if (j > 1)
                    {
                        mazeTranslation[i * 2 + 1, j * 2 - 1] = Const.Game.Wall;
                    }
                }
                else if (maze[x, y].HasRightWall && !maze[x, y].HasBottomWall)
                {
                    mazeTranslation[i * 2, j * 2] = Const.Game.Path;                  
                    mazeTranslation[i * 2, j * 2 + 1] = Const.Game.Wall;              
                    mazeTranslation[i * 2 + 1, j * 2] = Const.Game.Path;               
                    mazeTranslation[i * 2 + 1, j * 2 + 1] = Const.Game.Wall;           

                    if (i > 1)
                    {
                        mazeTranslation[i * 2 - 1, j * 2 + 1] = Const.Game.Wall;
                    }
                }
                else if (!maze[x, y].HasRightWall && maze[x, y].HasBottomWall)
                {
                    mazeTranslation[i * 2, j * 2] = Const.Game.Path;                  
                    mazeTranslation[i * 2, j * 2 + 1] = Const.Game.Path;             
                    mazeTranslation[i * 2 + 1, j * 2] = Const.Game.Wall;               
                    mazeTranslation[i * 2 + 1, j * 2 + 1] = Const.Game.Wall;          

                    if (j > 1)
                    {
                        mazeTranslation[i * 2 + 1, j * 2 - 1] = Const.Game.Wall;
                    }
                }
                else
                {
                    mazeTranslation[i * 2, j * 2] = Const.Game.Path;                  
                    mazeTranslation[i * 2, j * 2 + 1] = Const.Game.Path;               
                    mazeTranslation[i * 2 + 1, j * 2] = Const.Game.Path;             
                    mazeTranslation[i * 2 + 1, j * 2 + 1] = Const.Game.Path;           
                }
            }
        }
        return mazeTranslation;
    }
}
