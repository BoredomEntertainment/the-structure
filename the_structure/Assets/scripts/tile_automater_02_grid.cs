using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tile_automater_02_grid : MonoBehaviour
{
    public int size = 100;

    tile_automater_02_cell[,] grid;
    // Start is called before the first frame update
    void Start()
    {
        grid = new tile_automater_02_cell[size, size];
        for(int y = 0; y < size; y++)
        {
            for(int x = 0; x < size; x++)
            {
                tile_automater_02_cell cell = new tile_automater_02_cell();
                cell.isWater = true;
                grid[x, y] = cell;
            }
        }
    }

    void OnDrawGizmos()
    {
        if (!Application.isPlaying) return;
        for(int y = 0; y < size; y++)
        {
            for(int x = 0; x < size; x++)
            {
                tile_automater_02_cell cell = grid[x, y];
                if(cell.isWater)
                {
                    Gizmos.color = Color.blue;
                } else
                {
                    Gizmos.color = Color.green;
                }
                Vector3 pos = new Vector3(x, 0, y);
                Gizmos.DrawCube(pos, Vector3.one);
            }
        }
    }
}
