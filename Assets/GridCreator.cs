using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridCreator : MonoBehaviour
{
    public GameObject grid;
    public int rows;
    public int cols;
    float tileSize = 1.35f;

    public void CreateGrid()
    {
        var gridObject = Instantiate(grid);
        gridObject.transform.position = Vector3.zero;

    }

    void Start()
    {
        GenerateGrid();
    }

    private void GenerateGrid()
    {
        transform.position = Vector2.zero;
        GameObject gridObject = Instantiate(grid);

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                GameObject tile = Instantiate(gridObject);
                float posX = col * tileSize;
                float posY = row * -tileSize;

                tile.transform.position = new Vector2(posX, posY);
            }
        }

        Destroy(gridObject);
        float gridW = cols * tileSize;
        float gridH = rows * tileSize;
        transform.position = new Vector2(-gridW / 2 + tileSize / 2, gridH / 2 - tileSize / 2);
    }
}
