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

        Debug.Log(gridCreator);

        int i;
        for (i = 0; i < gridCreator.col; i++)
        {
            for (int k = 0; k < gridCreator.row; k++)
            {
                Debug.Log(gridCreator.gridArray[i + 1, k]);
                Debug.Log(gridCreator.gridArray[i, k + 1]);

                if(gridCreator.gridArray[i,k + 2] != null)
                if (gridCreator.gridArray[i, k].hasX && gridCreator.gridArray[i, k + 1].hasX && gridCreator.gridArray[i, k + 2].hasX)
                {
                    gridCreator.gridArray[i, k].GetComponentInChildren<TextMeshPro>().enabled = false;
                    gridCreator.gridArray[i, k].hasX = false;
                    gridCreator.gridArray[i, k + 1].GetComponentInChildren<TextMeshPro>().enabled = false;
                    gridCreator.gridArray[i, k + 1].hasX = false;
                    gridCreator.gridArray[i, k + 2].GetComponentInChildren<TextMeshPro>().enabled = false;
                    gridCreator.gridArray[i, k + 2].hasX = false;
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
                }
            }
        }
    }

    private void Start()
    {
        gridCreator = FindObjectOfType<GridCreator>();
    }
}
