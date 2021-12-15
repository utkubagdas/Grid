using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GridController : MonoBehaviour
{
    public bool hasX = false;
    GridCreator gridCreator;

    private void OnMouseDown()
    {
        GetComponentInChildren<TextMeshPro>().enabled = true;
        hasX = true;

        int i;
        for (i = 0; i < gridCreator.col; i++)
        {
            for (int k = 0; k < gridCreator.row; k++)
            {
                if(gridCreator.gridArray[i,k + 2] != null)
                if (gridCreator.gridArray[i, k].hasX && gridCreator.gridArray[i, k + 1].hasX && gridCreator.gridArray[i, k + 2].hasX)
                {
                    gridCreator.gridArray[i, k].GetComponentInChildren<TextMeshPro>().enabled = false;
                    gridCreator.gridArray[i, k].hasX = false;
                    gridCreator.gridArray[i, k + 1].GetComponentInChildren<TextMeshPro>().enabled = false;
                    gridCreator.gridArray[i, k + 1].hasX = false;
                    gridCreator.gridArray[i, k + 2].GetComponentInChildren<TextMeshPro>().enabled = false;
                    gridCreator.gridArray[i, k + 2].hasX = false;
                    if (gridCreator.gridArray[i, k + 3].hasX)
                    {
                        gridCreator.gridArray[i, k + 3].GetComponentInChildren<TextMeshPro>().enabled = false;
                        gridCreator.gridArray[i, k + 3].hasX = false;
                    }
                    if (gridCreator.gridArray[i, k + 4].hasX)
                    {
                        gridCreator.gridArray[i, k + 4].GetComponentInChildren<TextMeshPro>().enabled = false;
                        gridCreator.gridArray[i, k + 4].hasX = false;
                    }
                    }
                if (gridCreator.gridArray[i + 2, k] != null)
                if (gridCreator.gridArray[i, k].hasX && gridCreator.gridArray[i + 1, k].hasX && gridCreator.gridArray[i + 2, k].hasX)
                {
                    gridCreator.gridArray[i, k].GetComponentInChildren<TextMeshPro>().enabled = false;
                    gridCreator.gridArray[i, k].hasX = false;
                    gridCreator.gridArray[i + 1, k].GetComponentInChildren<TextMeshPro>().enabled = false;
                    gridCreator.gridArray[i + 1, k].hasX = false;
                    gridCreator.gridArray[i + 2, k].GetComponentInChildren<TextMeshPro>().enabled = false;
                    gridCreator.gridArray[i + 2, k].hasX = false;
                    if(gridCreator.gridArray[i + 3, k].hasX)
                    {
                        gridCreator.gridArray[i + 3, k].GetComponentInChildren<TextMeshPro>().enabled = false;
                        gridCreator.gridArray[i + 3, k].hasX = false;
                    }
                    if (gridCreator.gridArray[i + 4, k].hasX)
                    {
                        gridCreator.gridArray[i + 4, k].GetComponentInChildren<TextMeshPro>().enabled = false;
                        gridCreator.gridArray[i + 4, k].hasX = false;
                    }    
                }
            }
        }
    }

    private void Start()
    {
        gridCreator = FindObjectOfType<GridCreator>();
    }
}
