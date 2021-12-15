using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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
                if (gridCreator.gridArray[i, k].hasX && gridCreator.gridArray[i, k + 1].hasX && gridCreator.gridArray[i, k + 2].hasX)
                {
                    Debug.Log("KAZANDIN");
                }
            }

        }
    }

    private void Start()
    {
        gridCreator = FindObjectOfType<GridCreator>();
    }
}
