using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class GridCreator : MonoBehaviour
{
    public GameObject grid;
    public int col;
    public int row;
    public RectTransform spawnPos;
    float width;
    float height;
    public Transform leftUp;
    public Transform rightDown;
    float panelXSize;
    float panelYSize;
    public GridController[,] gridArray;
    public Text colText;
    public Text rowText;

    public void CreateGrid()
    {
        col = Convert.ToInt32(colText.text);
        row = Convert.ToInt32(rowText.text);

        ClearGrid();
        GenerateGrid();
    }

    void Start()
    {
        gridArray = new GridController[col, row];
    }

    private void GenerateGrid()
    {
        panelXSize = Mathf.Abs(leftUp.position.x - rightDown.position.x);
        panelYSize = Mathf.Abs(leftUp.position.y - rightDown.position.y);

        float width = panelXSize / row;
        float height = panelYSize / col;

        float defaultGridScaleX = grid.transform.lossyScale.x;
        float defaultGridScaleY = grid.transform.lossyScale.y;

        float defaultWidth = grid.GetComponent<Renderer>().bounds.size.x;
        float defaultHeight = grid.GetComponent<Renderer>().bounds.size.y;

        float scaleX = defaultGridScaleX * width / defaultWidth;
        float scaleY = defaultGridScaleY * height / defaultHeight;

        
        float x = width / 2;
        float y = height / 2;
        Vector3 startPos = spawnPos.position + new Vector3(x, -y);
        Vector3 spawnPosition = startPos;

        for (int i = 0; i < col; i++)
        {
            spawnPosition.y = startPos.y - i * height;
            for (int k = 0; k < row; k++)
            {
                spawnPosition.x = startPos.x + k * width;
                var gridob = Instantiate(grid);
                gridArray[i, k] = gridob.GetComponent<GridController>();         
                gridob.transform.localScale = new Vector3(scaleX, scaleY, gridob.transform.localScale.z);
                gridob.transform.position = spawnPosition;
                
            }
        }
    }

    private void ClearGrid()
    {
        foreach (var item in gridArray)
        {
            if (item != null)
                Destroy(item.gameObject);
        }

        for (int i = 0; i < col; i++)
        {
            for (int k = 0; k < row; k++)
            {
                gridArray[i, k] = null;
            }
        }
    }
}
