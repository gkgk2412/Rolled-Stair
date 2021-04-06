using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public GameObject Grid;

    [SerializeField]
    private int rows;
    [SerializeField]
    private int cols;
    [SerializeField]
    private Vector2 gridSize;
    [SerializeField]
    private Vector2 gridOffset;

    [SerializeField]
    private Sprite cellSprite;
    private Vector2 cellSize;
    private Vector2 cellScale;


    // Start is called before the first frame update
    void Start()
    {
        //this.transform.position = new Vector3(499.16f, 374.47f, 0);
            InitCells();
    }

    void Update()
    {
        //if (DragStair.isGridTime)
        //{
        //    Grid.SetActive(true);
        //}

        //if (!DragStair.isGridTime)
        //{
        //    Grid.SetActive(false);
        //}
    }

    void InitCells()
    {
        GameObject cellObject = new GameObject();

        cellObject.AddComponent<SpriteRenderer>().sprite = cellSprite;

        cellSize = cellSprite.bounds.size;

        Vector2 newCellSize = new Vector2(gridSize.x / (float)cols,  gridSize.y / (float)rows);

        cellScale.x = newCellSize.x / cellSize.x;
        cellScale.y = newCellSize.y / cellSize.y;

        cellSize = newCellSize;

        cellObject.transform.localScale = new Vector3(cellScale.x, cellScale.y);

        gridOffset.x = -(gridSize.x / 30) + cellSize.x * 4;
        gridOffset.y = -(gridSize.y / 10) + cellSize.y *2.4f;

        for (int row = 0; row <rows; row++)
        {
            for(int col = 0; col < cols; col++)
            {
                Vector2 pos = new Vector2(col * cellSize.x + gridOffset.x, row * cellSize.y + gridOffset.y);
                GameObject c0 = Instantiate(cellObject, pos, Quaternion.identity) as GameObject;

                c0.transform.parent = transform;
            }
        }

        Destroy(cellObject);

    }


    void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position, gridSize);
    }
}
