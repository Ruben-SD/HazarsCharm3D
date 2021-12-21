using UnityEngine;
using System.Collections;

public class MazeLoader : MonoBehaviour
{
    public GameObject[] floorDecorators;
    public GameObject[] wallDecorators;
    public int mazeRows, mazeColumns;
    public GameObject wall;
    public float size = 1f;

    private MazeCell[,] mazeCells;

    // Use this for initialization
    void Start()
    {
        InitializeMaze();

        MazeAlgorithm ma = new HuntAndKillMazeAlgorithm(mazeCells);
        ma.CreateMaze();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void InitializeMaze()
    {

        mazeCells = new MazeCell[mazeRows, mazeColumns];

        for (int r = 0; r < mazeRows; r++)
        {
            for (int c = 0; c < mazeColumns; c++)
            {
                mazeCells[r, c] = new MazeCell();

                // For now, use the same wall object for the floor!
                mazeCells[r, c].floor = Instantiate(wall, new Vector3(r * size, -(size / 2f), c * size), Quaternion.identity) as GameObject;
                mazeCells[r, c].floor.name = "Floor " + r + "," + c;
                mazeCells[r, c].floor.transform.Rotate(Vector3.right, 90f);
                
                if (c == 0)
                {
                    mazeCells[r, c].westWall = Instantiate(wall, new Vector3(r * size, 0, (c * size) - (size / 2f)), Quaternion.identity) as GameObject;
                    mazeCells[r, c].westWall.name = "West Wall " + r + "," + c;
                }

                mazeCells[r, c].eastWall = Instantiate(wall, new Vector3(r * size, 0, (c * size) + (size / 2f)), Quaternion.identity) as GameObject;
                mazeCells[r, c].eastWall.name = "East Wall " + r + "," + c;

                int random = Random.Range(0, 99);
                if (random < 20)
                {
                    var temp = Instantiate(floorDecorators[Random.Range(0, floorDecorators.Length)], new Vector3(r * size, -(size / 2f), (c * size) + size / 2.0f), Quaternion.identity);
                    Debug.Log(floorDecorators[Random.Range(0, floorDecorators.Length)].transform.localScale);
                    temp.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                }
                random = Random.Range(0, 99);

                if (random < 20)
                {
                    var temp = Instantiate(wallDecorators[Random.Range(0, wallDecorators.Length)], new Vector3(r * size + Random.Range(-(size / 2f), (size/2.0f)), Random.Range(-(size / 2f), (size / 2.0f)), (c * size) + Random.Range(0.0f, 1.0f)), Quaternion.identity);
                    temp.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                }

                if (r == 0)
                {
                    mazeCells[r, c].northWall = Instantiate(wall, new Vector3((r * size) - (size / 2f), 0, c * size), Quaternion.identity) as GameObject;
                    mazeCells[r, c].northWall.name = "North Wall " + r + "," + c;
                    mazeCells[r, c].northWall.transform.Rotate(Vector3.up * 90f);
                }

                mazeCells[r, c].southWall = Instantiate(wall, new Vector3((r * size) + (size / 2f), 0, c * size), Quaternion.identity) as GameObject;
                mazeCells[r, c].southWall.name = "South Wall " + r + "," + c;
                mazeCells[r, c].southWall.transform.Rotate(Vector3.up * 90f);
            }
        }
    }
}
