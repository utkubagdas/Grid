using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    bool control = false;

    public void CreateGrid()
    {

    }

    void Start()
    {
        gridArray = new GridController[col, row];
        GenerateGrid();
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
                Debug.Log(gridArray[i, k]);
                gridob.transform.localScale = new Vector3(scaleX, scaleY, gridob.transform.localScale.z);
                gridob.transform.position = spawnPosition;
                
            }
        }
    }

    private void Update()
    {
        if(Input.GetMouseButton(0))
        {
            
        }
    }
}
