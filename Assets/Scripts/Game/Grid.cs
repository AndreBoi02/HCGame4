using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    #region Vars
    private ObjectPooling objectPooling;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private Color primaryColor;
    [SerializeField] private Color secondaryColor;
    #endregion

    void Start()
    {
        objectPooling = GameObject.Find("Level").GetComponent<ObjectPooling>();
        generateGrid();
    }

    void generateGrid()
    {
        float offSetX = 0;
        float offSetY = 0;
        bool reverse = false;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                GameObject boxTest = objectPooling.RequestObject();
                setColor(boxTest, j, reverse);
                boxTest.transform.position = new Vector2(spawnPoint.transform.position.x + j + offSetX,
                                                        spawnPoint.transform.position.y - i - offSetY);
                offSetX += .5f;
            }
            if (i % 2 != 0)
            {
                reverse = false; 
            }
            else
            {
                reverse = true; 
            }
            offSetX = 0;
            offSetY += .5f;
        }
    }

    void setColor(GameObject prefab, int color, bool reverse){
        if (!reverse)
        {
            if (color % 2 == 0)
            {
                prefab.GetComponent<SpriteRenderer>().color = primaryColor;
            }
            else
            {
                prefab.GetComponent<SpriteRenderer>().color = secondaryColor;
            }
        }
        else
        {
            if (color % 2 == 0)
            {
                prefab.GetComponent<SpriteRenderer>().color = secondaryColor;
            }
            else
            {
                prefab.GetComponent<SpriteRenderer>().color = primaryColor;
            }
        }
    }
}
