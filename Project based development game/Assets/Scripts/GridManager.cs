using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public List<List<GameObject>> grid = new List<List<GameObject>>();
    public int rows;
    public int columns;
    public int scale = 1;
    public GameObject gridPrefab;
    public Vector2 leftBottomLocation = new Vector2(0,0); // this is where it will start generating the tile

    public GameObject[,] gridArray;
    public int startX = 0;
    public int startY = 0;
    public int endX = 2;
    public int endY = 2;
    public List<GameObject> path = new List<GameObject>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        gridArray = new GameObject[columns, rows];


        if (gridPrefab)
        {
            GenerateGrid();
        }
        else print("missing GridPrefab, please assing");
    }


    void GenerateGrid()
    {
        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                GameObject obj = Instantiate(gridPrefab, new Vector2(leftBottomLocation.x + scale * i, leftBottomLocation.y + scale * j), Quaternion.identity);
                obj.transform.SetParent(gameObject.transform);

                gridArray[i, j] = obj;
            }
        }
    }
}
